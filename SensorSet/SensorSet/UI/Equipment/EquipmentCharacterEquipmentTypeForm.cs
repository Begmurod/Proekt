using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using SensorSet.Model.SensorSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorSet.UI.Equipment
{
    public partial class EquipmentCharacterEquipmentTypeForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentCharacterEquipmentTypeGuid;

        private device_EquipmentCharacterEquipmentType currentEquipmentCharacterEquipmentType;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public EquipmentCharacterEquipmentTypeForm()
        {
            InitializeComponent();
        }
        public EquipmentCharacterEquipmentTypeForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void EquipmentCharacterEquipmentTypeForm_Load(object sender, EventArgs e)
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
                currentEquipmentCharacterEquipmentType = uow.GetObjectByKey<device_EquipmentCharacterEquipmentType>(currentEquipmentCharacterEquipmentTypeGuid);
            }
            else
            {
                currentEquipmentCharacterEquipmentType = new device_EquipmentCharacterEquipmentType(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование Набор характеристик типового оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})", currentEquipmentCharacterEquipmentType.EquipmentCharacterGUID, currentEquipmentCharacterEquipmentType.EquipmentTypeGUID,
                   currentEquipmentCharacterEquipmentType.IntParam, currentEquipmentCharacterEquipmentType.StrParam, currentEquipmentCharacterEquipmentType.DataParam, currentEquipmentCharacterEquipmentType.BoolParam, 
                   currentEquipmentCharacterEquipmentType.NumericParam, currentEquipmentCharacterEquipmentType.NumericParam2);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр Набор характеристик типового оборудованияк {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})", currentEquipmentCharacterEquipmentType.EquipmentCharacterGUID, currentEquipmentCharacterEquipmentType.EquipmentTypeGUID,
                   currentEquipmentCharacterEquipmentType.IntParam, currentEquipmentCharacterEquipmentType.StrParam, currentEquipmentCharacterEquipmentType.DataParam, currentEquipmentCharacterEquipmentType.BoolParam,
                   currentEquipmentCharacterEquipmentType.NumericParam, currentEquipmentCharacterEquipmentType.NumericParam2);
               
                equipmentCharacterGUIDlookUpEdit.ReadOnly = true;
                equipmentTypeGUIDLookUpEdit.ReadOnly = true;
                intParamTextEdit.ReadOnly = true;
                strParamTextEdit.ReadOnly = true;
                dataParamdateEdit.ReadOnly = true;
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

                SelectedData EquipmentTypeGUID = u.ExecuteQuery(@"SELECT GUID, FullName FROM  [device].[EquipmentType] WHERE DeletedDate is null");
                EquipmentTypeGUIDDataView.LoadData(EquipmentTypeGUID);
            }
            #endregion

            if (edit)
            {
                equipmentCharacterGUIDlookUpEdit.EditValue = currentEquipmentCharacterEquipmentType.EquipmentCharacterGUID.GUID;
                equipmentTypeGUIDLookUpEdit.EditValue = currentEquipmentCharacterEquipmentType.EquipmentTypeGUID.GUID;
                intParamTextEdit.Text = currentEquipmentCharacterEquipmentType.IntParam.ToString();
                strParamTextEdit.Text = currentEquipmentCharacterEquipmentType.StrParam;
                dataParamdateEdit.DateTime = currentEquipmentCharacterEquipmentType.DataParam;
                if (currentEquipmentCharacterEquipmentType.BoolParam)
                    checkEdit.Checked = true;
                numericParamtextEdit.Text = currentEquipmentCharacterEquipmentType.NumericParam.ToString();
                numericParam2textEdit.Text = currentEquipmentCharacterEquipmentType.NumericParam2.ToString();
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
                currentEquipmentCharacterEquipmentType.EquipmentCharacterGUID = uow.GetObjectByKey<device_EquipmentCharacter>(equipmentCharacterGUIDlookUpEdit.EditValue);
                currentEquipmentCharacterEquipmentType.EquipmentTypeGUID = uow.GetObjectByKey<device_EquipmentType>(equipmentTypeGUIDLookUpEdit.EditValue);
                currentEquipmentCharacterEquipmentType.IntParam = Convert.ToInt64(intParamTextEdit.Text);
                currentEquipmentCharacterEquipmentType.StrParam = strParamTextEdit.Text;
                currentEquipmentCharacterEquipmentType.DataParam = dataParamdateEdit.DateTime;
                currentEquipmentCharacterEquipmentType.BoolParam = checkEdit.Checked;
                currentEquipmentCharacterEquipmentType.NumericParam = Convert.ToInt64(numericParamtextEdit.Text);
                currentEquipmentCharacterEquipmentType.NumericParam2 = Convert.ToDouble(numericParam2textEdit.Text);

                if (edit)
                {
                    currentEquipmentCharacterEquipmentType.DateOfChange = DateTime.Now;
                    currentEquipmentCharacterEquipmentType.Save();
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
