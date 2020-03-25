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
    public partial class deviceEquipmentKindUC : UserControl
    {
        private UnitOfWork uow = new UnitOfWork();

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
        public deviceEquipmentKindUC()
        {
            InitializeComponent();
        }
        public deviceEquipmentKindUC(Control _parent)
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

        private void deviceEquipmentKindUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
                SELECT [GUID]
      ,Name 
      ,(Select [Name] FROM [device].[EquipmentKind] where GUID = d.ParentGUID) as ParentName
         FROM  [device].[EquipmentKind]
         as d
        WHERE [DeletedDate] is null"
                ));
                deviceEquipmentKindDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DeviceEquipmentKindForm addForm = new DeviceEquipmentKindForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeviceEquipmentKindForm viewForm = new DeviceEquipmentKindForm();
            viewForm.currentEquipmentKindGuid = (Guid)deviceEquipmentKindGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DeviceEquipmentKindForm editForm = new DeviceEquipmentKindForm())
            {
                editForm.currentEquipmentKindGuid = (Guid)deviceEquipmentKindGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentKind currentEquipmentKind = u.GetObjectByKey<device_EquipmentKind>((Guid)deviceEquipmentKindGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить вид устройства {0}?", currentEquipmentKind.Name), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentKind.DeletedDate = DateTime.Now;
                    currentEquipmentKind.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void deviceEquipmentKindGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
