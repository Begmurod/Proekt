using DevExpress.Xpo;
using System;
using SensorSet.Model.SensorSet;
using DevExpress.Xpo.DB;

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

        //private void addButton_Click(object sender, EventArgs e)
        //{
        //    validForm();
        //    SaveDimension();
        //    uow.CommitChanges();//Сохранение объекта в БД       
        //    Close();
        //}

        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
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
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            validForm();
            SaveDimension();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
