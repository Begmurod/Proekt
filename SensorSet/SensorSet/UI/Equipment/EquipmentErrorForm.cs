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
    public partial class EquipmentErrorForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentErrorGuid;

        private device_EquipmentError currentEquipmentError;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public EquipmentErrorForm()
        {
            InitializeComponent();
        }
        public EquipmentErrorForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void EquipmentErrorForm_Load(object sender, EventArgs e)
        {
            initForm();
        }
        void initForm()
        {
            if (edit)
            {
                currentEquipmentError = uow.GetObjectByKey<device_EquipmentError>(currentEquipmentErrorGuid);
            }
            else
            {
                currentEquipmentError = new device_EquipmentError(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование погрешность оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ", currentEquipmentError.MeasurandGUID, currentEquipmentError.EquipmentGUID, currentEquipmentError.DiapasonBegin, currentEquipmentError.DiapasonEnd, currentEquipmentError.DeltaType, currentEquipmentError.DeltaValue);
                addButton.Text = "Сохранить";
            }
            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData EquipmentGUID = u.ExecuteQuery(@"SELECT GUID,SerialNumber,InventoryNumber FROM device.Equipment WHERE[DeletedDate] is null");
                EquipmentGUIDDataView.LoadData(EquipmentGUID);

                SelectedData MeasurandGUID = u.ExecuteQuery(@"SELECT GUID, ValueName FROM device.Measurand WHERE[DeletedDate] is null");
                MeasurandGUIDDataView.LoadData(MeasurandGUID);


            }
            #endregion

            if (view)
            {
                Text = string.Format("Просмотр погрешность оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ", currentEquipmentError.MeasurandGUID,  currentEquipmentError.EquipmentGUID, currentEquipmentError.DiapasonBegin, currentEquipmentError.DiapasonEnd, currentEquipmentError.DeltaType, currentEquipmentError.DeltaValue);
                measurandGUIDlookUpEdit.Properties.ReadOnly = true;
                equipmentGUIDlookUpEdit.Properties.ReadOnly = true;
                diapasonBegintextEdit.ReadOnly = true;
                diapasonEndTextEdit.ReadOnly = true;
                deltaValuetextEdit.ReadOnly = true;
                deltaTypeTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                measurandGUIDlookUpEdit.EditValue = currentEquipmentError.MeasurandGUID;
                equipmentGUIDlookUpEdit.EditValue = currentEquipmentError.EquipmentGUID;
                diapasonBegintextEdit.Text = currentEquipmentError.DiapasonBegin.ToString();
                diapasonEndTextEdit.Text = currentEquipmentError.DiapasonEnd.ToString();
                deltaTypeTextEdit.Text = currentEquipmentError.DeltaType.ToString();
                deltaValuetextEdit.Text = currentEquipmentError.DeltaValue.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveEquipmentError();
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
        void SaveEquipmentError()
        {
            if (formValid)
            {
                currentEquipmentError.MeasurandGUID = uow.GetObjectByKey<device_Measurand>(measurandGUIDlookUpEdit.EditValue);
                currentEquipmentError.EquipmentGUID = uow.GetObjectByKey<device_Equipment>(equipmentGUIDlookUpEdit.EditValue);
                currentEquipmentError.DiapasonBegin = Convert.ToDecimal(diapasonBegintextEdit.Text);
                currentEquipmentError.DiapasonEnd = Convert.ToDecimal(diapasonEndTextEdit.Text);
                currentEquipmentError.DeltaType = Convert.ToInt16(deltaTypeTextEdit.Text);
                currentEquipmentError.DeltaValue = Convert.ToDecimal(deltaValuetextEdit.Text);

                if (edit)
                {
                    currentEquipmentError.DateOfChange = DateTime.Now;
                    currentEquipmentError.Save();
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
