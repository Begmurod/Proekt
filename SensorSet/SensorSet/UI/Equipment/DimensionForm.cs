using DevExpress.Xpo;
using System;
using SensorSet.Model.SensorSet;
using DevExpress.Xpo.DB;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;

namespace SensorSet.UI.Equipment
{
    public partial class DimensionForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentDimensionGuid;

        private list_Dimension currentDimension;       
       
        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public DimensionForm()
        {
            InitializeComponent();
        }
        public DimensionForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void DimensionForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        /// <summary>
        /// Здесь пока все в куче: поднятие/создание объекта, загрузка справочников для списков, настройка внешнего вида...
        /// </summary>
        void initForm()
        {
            if (edit)
            {
                currentDimension = uow.GetObjectByKey<list_Dimension>(currentDimensionGuid);
            }
            else
            {
                currentDimension = new list_Dimension(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование единицы {0} ({1})", currentDimension.Name, currentDimension.NameEn);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр единицы {0} ({1})", currentDimension.Name, currentDimension.NameEn);
                nameTextEdit.ReadOnly = true;
                nameEngTextEdit.ReadOnly = true;
                baseNameLookUpEdit.ReadOnly = true;
                koefTextEdit.ReadOnly = true;
                checkEdit.ReadOnly = true;
                digitTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData dimensionParentData = u.ExecuteQuery(@"SELECT GUID, Name, NameEn FROM [list].[Dimension] WHERE[DeletedDate] is null");
                dimensionDataView.LoadData(dimensionParentData);
                
            }
            #endregion

            if (edit)
            {
                nameTextEdit.Text = currentDimension.Name;
                nameEngTextEdit.Text = currentDimension.Name;
                baseNameLookUpEdit.EditValue = currentDimension.ParentGUID;
                koefTextEdit.Text = currentDimension.Koef.ToString();
                if(currentDimension.ShowInInterface)
                   checkEdit.Checked = true;
                digitTextEdit.Text = currentDimension.Digits.ToString();                              
            }
            

        }

        

        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
            formValid = false;

            List<string> notExistData = new List<string>();

            formValid = dxValidationProvider.Validate();
            foreach (System.Windows.Forms.Control c in dxValidationProvider.GetInvalidControls())
            {
                notExistData.Add(dxValidationProvider.GetValidationRule(c).ErrorText);
            }
            if (!formValid && notExistData.Count != 0)
            {
                int i = 1;
                string str = string.Empty;
                foreach (string s in notExistData)
                {
                    if (i == 1)
                        str = string.Format("\n{0}. {1}", i, s);
                    else
                        str = string.Format("{0}\n{1}. {2}", str, i, s);
                    i++;
                }
                str = string.Format("Для сохранения записи не хватает данных: {0}", str);
                XtraMessageBox.Show(str, "Ввод недостающих данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        /// <summary>
        /// Заполнение текущей единицы данными с формы
        /// </summary>
        void SaveDimension()
        {
            if (formValid)
            {
                currentDimension.Name = nameTextEdit.Text;
                currentDimension.NameEn = nameEngTextEdit.Text;
                currentDimension.ParentGUID = uow.GetObjectByKey<list_Dimension>(baseNameLookUpEdit.EditValue);
                currentDimension.Koef = Convert.ToDecimal(koefTextEdit.Text);
                currentDimension.ShowInInterface = checkEdit.Checked;
                currentDimension.Digits = Convert.ToInt16(digitTextEdit.Text);

                if (edit)
                {
                    currentDimension.DateOfChange = DateTime.Now;
                    currentDimension.Save();
                }
                uow.CommitChanges();//Сохранение объекта в БД  
                Close();
            }

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveDimension();                            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
