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
    public partial class equipmentTypeErrorUC : UserControl
    {
        public event EventHandler lockButtons;
        public event EventHandler unlockButtons;

        public virtual void fireLockButtons(EventArgs e)
        {
            if (lockButtons != null)
                lockButtons(this, e);
        }
        public equipmentTypeErrorUC()
        {
            InitializeComponent();
        }
        public virtual void fireUnlockButtons(EventArgs e)
        {
            if (unlockButtons != null)
                unlockButtons(this, e);
        }
        public equipmentTypeErrorUC(Control _parent)
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

        private void equipmentTypeErrorUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _equipmentTypeErrorData = u.ExecuteQuery(string.Format(@"
               SELECT [GUID]
      ,[EquipmentTypeGUID]
      ,[MeasurandGUID]
      ,[DiapasonBegin]
      ,[DiapasonEnd]
      ,[DeltaType]
      ,[DeltaValue]
  FROM [dbo].[EquipmentTypeErrorView] Where DeletedDate is null"
                ));
                equipmentTypeErrorDataView.LoadData(_equipmentTypeErrorData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentTypeErrorForm addForm = new EquipmentTypeErrorForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            EquipmentTypeErrorForm viewForm = new EquipmentTypeErrorForm();
            viewForm.currentEquipmentTypeErrorGuid = (Guid)equipmentTypeErrorGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentTypeErrorForm editForm = new EquipmentTypeErrorForm())
            {
                editForm.currentEquipmentTypeErrorGuid = (Guid)equipmentTypeErrorGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentTypeError currentEquipmentTypeError = u.GetObjectByKey<device_EquipmentTypeError>((Guid)equipmentTypeErrorGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить погрешности типа оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}?", currentEquipmentTypeError.MeasurandGUID, currentEquipmentTypeError.EquipmentTypeGUID, currentEquipmentTypeError.DiapasonBegin, currentEquipmentTypeError.DiapasonEnd, currentEquipmentTypeError.DeltaType, currentEquipmentTypeError.DeltaValue), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentTypeError.DeletedDate = DateTime.Now;
                    currentEquipmentTypeError.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void equipmentTypeErrorGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

        private void barButtonItemAd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentTypeErrorForm addForm = new EquipmentTypeErrorForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }
    }
}
