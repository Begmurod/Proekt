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
    public partial class EquipmentTypeErrorForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentTypeErrorGuid;

        private device_EquipmentTypeError currentEquipmentTypeError;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public EquipmentTypeErrorForm()
        {
            InitializeComponent();
        }
        public EquipmentTypeErrorForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void EquipmentTypeErrorForm_Load(object sender, EventArgs e)
        {
            initForm();
        }
        void initForm()
        {
            if (edit)
            {
                currentEquipmentTypeError = uow.GetObjectByKey<device_EquipmentTypeError>(currentEquipmentTypeErrorGuid);
            }
            else
            {
                currentEquipmentTypeError = new device_EquipmentTypeError(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование погрешности типа оборудования {0}", currentEquipmentTypeError.MeasurandGUID, currentEquipmentTypeError.EquipmentTypeGUID, currentEquipmentTypeError.DiapasonBegin, currentEquipmentTypeError.DiapasonEnd, currentEquipmentTypeError.DeltaType, currentEquipmentTypeError.DeltaValue);
                addButton.Text = "Сохранить";
            }
            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData EquipmentTypeGUID = u.ExecuteQuery(@"SELECT GUID, FullName   FROM  device.EquipmentType WHERE[DeletedDate] is null");
                EquipmentTypeGUIDDataView.LoadData(EquipmentTypeGUID);

                SelectedData MeasurandGUID = u.ExecuteQuery(@"SELECT GUID, ValueName    FROM  device.Measurand WHERE[DeletedDate] is null");
                MeasurandGUIDDataView.LoadData(MeasurandGUID);

            }
            #endregion

            if (view)
            {
                Text = string.Format("Просмотр погрешности типа оборудования {0}", currentEquipmentTypeError.MeasurandGUID, currentEquipmentTypeError.EquipmentTypeGUID, currentEquipmentTypeError.DiapasonBegin, currentEquipmentTypeError.DiapasonEnd, currentEquipmentTypeError.DeltaType, currentEquipmentTypeError.DeltaValue);
                equipmentTypeGUIDLookUpEdit.ReadOnly = true;
                measurandGUIDlookUpEdit.Properties.ReadOnly = true;
                diapasonBegintextEdit.ReadOnly = true;
                diapasonEndTextEdit.ReadOnly = true;
                deltaValuetextEdit.ReadOnly = true;
                deltaTypeTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                measurandGUIDlookUpEdit.EditValue = currentEquipmentTypeError.MeasurandGUID;
                equipmentTypeGUIDLookUpEdit.EditValue = currentEquipmentTypeError.EquipmentTypeGUID;
                diapasonBegintextEdit.Text = currentEquipmentTypeError.DiapasonBegin.ToString();
                diapasonEndTextEdit.Text = currentEquipmentTypeError.DiapasonEnd.ToString();
                deltaTypeTextEdit.Text = currentEquipmentTypeError.DeltaType.ToString();
                deltaValuetextEdit.Text = currentEquipmentTypeError.DeltaValue.ToString();
            }
        }
      
        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveEquipmentTypeError();
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
        void SaveEquipmentTypeError()
        {
            if (formValid)
            {
                currentEquipmentTypeError.MeasurandGUID= uow.GetObjectByKey<device_Measurand>(measurandGUIDlookUpEdit.EditValue);
                currentEquipmentTypeError.EquipmentTypeGUID = uow.GetObjectByKey<device_EquipmentType>(equipmentTypeGUIDLookUpEdit.EditValue);
                currentEquipmentTypeError.DiapasonBegin = Convert.ToDecimal(diapasonBegintextEdit.Text);
                currentEquipmentTypeError.DiapasonEnd = Convert.ToDecimal(diapasonEndTextEdit.Text);
                currentEquipmentTypeError.DeltaType = Convert.ToInt16(deltaTypeTextEdit.Text);
                currentEquipmentTypeError.DeltaValue = Convert.ToDecimal(deltaValuetextEdit.Text);
                
                if (edit)
                {
                    currentEquipmentTypeError.DateOfChange = DateTime.Now;
                    currentEquipmentTypeError.Save();
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
