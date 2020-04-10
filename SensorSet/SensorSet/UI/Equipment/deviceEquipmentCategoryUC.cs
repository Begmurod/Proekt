using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using SensorSet.Model.SensorSet;
using DevExpress.XtraEditors;

namespace SensorSet.UI.Equipment
{
    public partial class deviceEquipmentCategoryUC : UserControl
    {
        #region Для блокировки кнопок. Нужно вынести в отдельный абстрактный класс
        public event EventHandler lockButtons;
        public event EventHandler unlockButtons;

        public virtual void fireLockButtons(EventArgs e)
        {
            if (lockButtons != null)
                lockButtons(this, e);
        }


        public virtual void fireUnlockButtons(EventArgs e)
        {
            if (unlockButtons != null)
                unlockButtons(this, e);
        }
        #endregion
        public deviceEquipmentCategoryUC(Control _parent)
        {
            InitializeComponent();
            Parent = _parent;

            lockButtons += new EventHandler(OnDimensionSetLockButtons);
            unlockButtons += new EventHandler(OnDimensionUnlockButtons);
        }
        public void OnDimensionSetLockButtons(object sender, EventArgs e)
        {
            barButtonItemView.Enabled = false;
            barButtonItemEdit.Enabled = false;
            barButtonItemDelete.Enabled = false;
        }

        public void OnDimensionUnlockButtons(object sender, EventArgs e)
        {
            barButtonItemView.Enabled = true;
            barButtonItemEdit.Enabled = true;
            barButtonItemDelete.Enabled = true;
        }

        public deviceEquipmentCategoryUC()
        {
            InitializeComponent();
        }
        
        private void deviceEquipmentCategoryUC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _equipmentCategoryData = u.ExecuteQuery(string.Format(@"
                SELECT [GUID]
      ,Name   
  FROM device.EquipmentCategory
  WHERE [DeletedDate] is null"
                ));
                deviceEquipmentCategoryDataView.LoadData(_equipmentCategoryData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DeviceEquipmentCategoryForm addForm = new DeviceEquipmentCategoryForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }
     
        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeviceEquipmentCategoryForm viewForm = new DeviceEquipmentCategoryForm();
            viewForm.currentDeviceEquipmentCategoryGuid = (Guid)deviceEquipmentCategoryGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DeviceEquipmentCategoryForm editForm = new DeviceEquipmentCategoryForm())
            {
                editForm.currentDeviceEquipmentCategoryGuid = (Guid)deviceEquipmentCategoryGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentCategory currentDeviceEquipmentCategory = u.GetObjectByKey<device_EquipmentCategory>((Guid)deviceEquipmentCategoryGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить категорию оборудования {0}", currentDeviceEquipmentCategory.Name), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentDeviceEquipmentCategory.DeletedDate = DateTime.Now;
                    currentDeviceEquipmentCategory.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void deviceEquipmentCategoryGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                fireLockButtons(new EventArgs());
            }
            else
            {
                fireUnlockButtons(new EventArgs());
            }
        }
    }
}
