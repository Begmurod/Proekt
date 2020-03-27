using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SensorSet.Model.SensorSet;
using DevExpress.Xpo.DB;

namespace SensorSet.UI.Equipment
{
    public partial class EquipmentCharacterParamForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentCharacterParamGuid;

        private device_EquipmentCharacterParam currentEquipmentCharacterParam;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public EquipmentCharacterParamForm()
        {
            InitializeComponent();
        }
        public EquipmentCharacterParamForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void EquipmentCharacterParamForm_Load(object sender, EventArgs e)
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
                currentEquipmentCharacterParam = uow.GetObjectByKey<device_EquipmentCharacterParam>(currentEquipmentCharacterParamGuid);
            }
            else
            {
                currentEquipmentCharacterParam = new device_EquipmentCharacterParam(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование параметров и характеристик {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})", currentEquipmentCharacterParam.EquipmentCharacterGUID, currentEquipmentCharacterParam.EquipmentGUID,
                   currentEquipmentCharacterParam.IntParam, currentEquipmentCharacterParam.StrParam, currentEquipmentCharacterParam.BoolParam, currentEquipmentCharacterParam.NumericParam, currentEquipmentCharacterParam.NumericParam2);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр параметров и характеристик {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})", currentEquipmentCharacterParam.EquipmentCharacterGUID, currentEquipmentCharacterParam.EquipmentGUID,
                   currentEquipmentCharacterParam.IntParam, currentEquipmentCharacterParam.StrParam, currentEquipmentCharacterParam.BoolParam, currentEquipmentCharacterParam.NumericParam, currentEquipmentCharacterParam.NumericParam2);
                equipmentCharacterGUIDlookUpEdit.ReadOnly = true;
                equipmentGUIDLookUpEdit.ReadOnly = true;
                intParamTextEdit.ReadOnly = true;
                strParamTextEdit.ReadOnly = true;
                checkEdit.ReadOnly = true;
                numericParamtextEdit.ReadOnly = true;
                numericParam2textEdit.ReadOnly = true;
                
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData EquipmentCharacterGUID = u.ExecuteQuery(@"SELECT GUID, CharacterName FROM  device.EquipmentCharacter WHERE DeletedDate is null");
                EquipmentCharacterGUIDDataView.LoadData(EquipmentCharacterGUID);

                SelectedData EquipmentGUID = u.ExecuteQuery(@"SELECT GUID, SerialNumber FROM  [device].[Equipment] WHERE DeletedDate is null");
                EquipmentGUIDDataView.LoadData(EquipmentGUID);
            }
            #endregion

            if (edit)
            {
                equipmentCharacterGUIDlookUpEdit.EditValue = currentEquipmentCharacterParam.EquipmentCharacterGUID.GUID;
                equipmentGUIDLookUpEdit.EditValue = currentEquipmentCharacterParam.EquipmentGUID.GUID;
                intParamTextEdit.Text = currentEquipmentCharacterParam.IntParam.ToString();
                strParamTextEdit.Text = currentEquipmentCharacterParam.StrParam;
                if (currentEquipmentCharacterParam.BoolParam)
                    checkEdit.Checked = true;
                numericParamtextEdit.Text = currentEquipmentCharacterParam.NumericParam.ToString();
                numericParam2textEdit.Text = currentEquipmentCharacterParam.NumericParam2.ToString();
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveDimension();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
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
                currentEquipmentCharacterParam.EquipmentCharacterGUID = uow.GetObjectByKey<device_EquipmentCharacter>(equipmentCharacterGUIDlookUpEdit.EditValue);
                currentEquipmentCharacterParam.EquipmentGUID = uow.GetObjectByKey<device_Equipment>(equipmentGUIDLookUpEdit.EditValue);
                currentEquipmentCharacterParam.IntParam = Convert.ToInt64(intParamTextEdit.Text);
                currentEquipmentCharacterParam.StrParam = strParamTextEdit.Text;
                currentEquipmentCharacterParam.BoolParam = checkEdit.Checked;
                currentEquipmentCharacterParam.NumericParam = Convert.ToInt64(numericParamtextEdit.Text);
                currentEquipmentCharacterParam.NumericParam2 = Convert.ToDouble(numericParam2textEdit.Text);

                if (edit)
                {
                    currentEquipmentCharacterParam.DateOfChange = DateTime.Now;
                    currentEquipmentCharacterParam.Save();
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
