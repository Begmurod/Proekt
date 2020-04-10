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
using DevExpress.XtraEditors;
using SensorSet.Model.SensorSet;

namespace SensorSet.UI.Equipment
{
    public partial class equipmentStateUC : UserControl
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

        public equipmentStateUC()
        {
            InitializeComponent();
        }
        public equipmentStateUC(Control _parent)
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

        private void equipmentStateUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _equipmentStateData = u.ExecuteQuery(string.Format(@"
                SELECT [GUID]
                ,StateName
                  FROM device.EquipmentState
                  WHERE [DeletedDate] is null"
                ));
                equipmentStateDataView.LoadData(_equipmentStateData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentStateForm addForm = new EquipmentStateForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EquipmentStateForm viewForm = new EquipmentStateForm();
            viewForm.currentEquipmentStateGuid = (Guid)equipmentStateGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentStateForm editForm = new EquipmentStateForm())
            {
                editForm.currentEquipmentStateGuid = (Guid)equipmentStateGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentState currentEquipmentState = u.GetObjectByKey<device_EquipmentState>((Guid)equipmentStateGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить состояние оборудования {0}?", currentEquipmentState.StateName), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentState.DeletedDate = DateTime.Now;
                    currentEquipmentState.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void equipmentStateGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
