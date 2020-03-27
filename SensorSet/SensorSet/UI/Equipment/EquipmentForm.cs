using DevExpress.Xpf.Editors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors.Controls;
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
    public partial class EquipmentForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentGuid;

        private device_Equipment currentEquipment;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public EquipmentForm()
        {
            InitializeComponent();
        }
        public EquipmentForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
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
                currentEquipment = uow.GetObjectByKey<device_Equipment>(currentEquipmentGuid);
            }
            else
            {
                currentEquipment = new device_Equipment(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование экземпляра оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6}) ({7}) ({8}) ({9}) ({10}) ({11}) ({12})", currentEquipment.EquipmentCategoryGUID, currentEquipment.EquipmentTypeGUID,
                 currentEquipment.ParentGUID, currentEquipment.InventoryNumber, currentEquipment.SerialNumber,
                 currentEquipment.ManufacturingDate, currentEquipment.StartUseDate, currentEquipment.IpAddress,
                 currentEquipment.Port, currentEquipment.BalanceCost, currentEquipment.ChangedUserID,
                 currentEquipment.UseMonths, currentEquipment.RemainingBalance, currentEquipment.GarantyPeriod);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр экземпляра оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6}) ({7}) ({8}) ({9}) ({10}) ({11}) ({12})", currentEquipment.EquipmentCategoryGUID, currentEquipment.EquipmentTypeGUID,
                 currentEquipment.ParentGUID, currentEquipment.InventoryNumber, currentEquipment.SerialNumber,
                 currentEquipment.ManufacturingDate, currentEquipment.StartUseDate, currentEquipment.IpAddress,
                 currentEquipment.Port, currentEquipment.BalanceCost,
                 currentEquipment.UseMonths, currentEquipment.RemainingBalance, currentEquipment.GarantyPeriod);
                EquipmentCategoryGUIDlookUpEdit.ReadOnly = true;
                EquipmentTypeGUIDLookUpEdit.ReadOnly = true;
                ParentGUIDlookUpEdit.ReadOnly = true;
                inventoryNumberTextEdit.ReadOnly = true;
                ipAddresstextEdit.ReadOnly = true;
                serialNumberTextEdit.ReadOnly = true;
                porttextEdit.ReadOnly = true;
                balanceCostatextEdit.ReadOnly = true;
                useMonthstextEdit.ReadOnly = true;
                remainingBalancetextEdit.ReadOnly = true;
                garantyPerioddateEdit.ReadOnly = true;
                manufacturingDatedateEdit.ReadOnly = true;
                startUseDatedateEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                //EquipmentGUID
                SelectedData EquipmentTypeGUID = u.ExecuteQuery(@"SELECT GUID, FullName FROM device.EquipmentType WHERE[DeletedDate] is null");
                EquipmentTypeGUIDDataView.LoadData(EquipmentTypeGUID);

                //EquipmentCategoryGUID
                SelectedData EquipmentCategoryGUID = u.ExecuteQuery(@"SELECT GUID, Name  FROM device.EquipmentCategory WHERE[DeletedDate] is null");
                EquipmentCategoryGUIDDataView.LoadData(EquipmentCategoryGUID);

                //ParentGUID
                SelectedData ParentGUID = u.ExecuteQuery(@"SELECT GUID, Name  FROM device.EquipmentKind WHERE[DeletedDate] is null");
                ParentGUIDDataView.LoadData(ParentGUID);

            }
            #endregion

            if (edit)
            {
                EquipmentCategoryGUIDlookUpEdit.EditValue = currentEquipment.EquipmentCategoryGUID;
                EquipmentTypeGUIDLookUpEdit.EditValue = currentEquipment.EquipmentTypeGUID;
                ParentGUIDlookUpEdit.EditValue = currentEquipment.ParentGUID;
                inventoryNumberTextEdit.Text = currentEquipment.InventoryNumber;
                ipAddresstextEdit.Text = currentEquipment.IpAddress;
                serialNumberTextEdit.Text = currentEquipment.SerialNumber;
                porttextEdit.Text = currentEquipment.Port;
                balanceCostatextEdit.Text= currentEquipment.BalanceCost.ToString();
                useMonthstextEdit.Text = currentEquipment.UseMonths.ToString();
                remainingBalancetextEdit.Text = currentEquipment.RemainingBalance.ToString();
                garantyPerioddateEdit.DateTime = currentEquipment.GarantyPeriod;
                manufacturingDatedateEdit.DateTime = currentEquipment.ManufacturingDate;
                startUseDatedateEdit.DateTime = currentEquipment.StartUseDate;
               
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
            //formValid = false;
            //decimal balanceCost = 1;
            //int useMonth = -1;
            //decimal remainingBalance = -1;
            //string inventoryNumber = null;
            //try
            //{
            //    balanceCost = Convert.ToDecimal(balanceCostatextEdit.Text);
            //    useMonth = Convert.ToInt32(useMonthstextEdit.Text);
            //    remainingBalance = Convert.ToDecimal(remainingBalancetextEdit.Text);
            //    inventoryNumber = ipAddresstextEdit.Text;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("ошибка");
            //}
            //finally
            //{
            //    if (balanceCost > -1 && useMonth > -1 && remainingBalance >= 1 && inventoryNumber!= null)
            //    { formValid = true; }
            //}
        }
        /// <summary>
        /// Заполнение текущей единицы данными с формы
        /// </summary>
        void SaveDimension()
        {
            if (formValid)
            {
                currentEquipment.EquipmentCategoryGUID= uow.GetObjectByKey<device_EquipmentCategory>(EquipmentCategoryGUIDlookUpEdit.EditValue);
                currentEquipment.EquipmentTypeGUID = uow.GetObjectByKey<device_EquipmentType>(EquipmentTypeGUIDLookUpEdit.EditValue);
                currentEquipment.ParentGUID = uow.GetObjectByKey<device_Equipment>(ParentGUIDlookUpEdit.EditValue);
                currentEquipment.InventoryNumber = inventoryNumberTextEdit.Text;
                currentEquipment.IpAddress= ipAddresstextEdit.Text;
                currentEquipment.SerialNumber = serialNumberTextEdit.Text;
                currentEquipment.Port = porttextEdit.Text;
                currentEquipment.BalanceCost = Convert.ToDecimal(balanceCostatextEdit.Text);
                currentEquipment.UseMonths = Convert.ToInt32(useMonthstextEdit.Text);
                currentEquipment.RemainingBalance = Convert.ToDecimal(remainingBalancetextEdit.Text);
                currentEquipment.GarantyPeriod = garantyPerioddateEdit.DateTime;
                currentEquipment.ManufacturingDate = manufacturingDatedateEdit.DateTime;
                currentEquipment.StartUseDate = startUseDatedateEdit.DateTime;

                if (edit)
                {
                    currentEquipment.DateOfChange = DateTime.Now;
                    currentEquipment.Save();
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
