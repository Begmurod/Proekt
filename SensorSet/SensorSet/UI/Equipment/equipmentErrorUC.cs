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
    public partial class equipmentErrorUC : UserControl
    {
        public event EventHandler lockButtons;
        public event EventHandler unlockButtons;

        public virtual void fireLockButtons(EventArgs e)
        {
            if (lockButtons != null)
                lockButtons(this, e);
        }
        public equipmentErrorUC()
        {
            InitializeComponent();
        }
        public virtual void fireUnlockButtons(EventArgs e)
        {
            if (unlockButtons != null)
                unlockButtons(this, e);
        }
        public equipmentErrorUC(Control _parent)
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

        private void equipmentErrorUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
             SELECT   [GUID]
      ,[MeasurandGUID]
      ,[EquipmentGUID]
      ,[EquipmentTypeGUID]
      ,[DiapasonBegin]
      ,[DiapasonEnd]
      ,[DeltaType]
      ,[DeltaValue]
      ,[DateOfChange]
      ,[DeletedDate]
      ,[EquipmentID]
  FROM [dbo].[EquipmentErrorView]
  WHERE [DeletedDate] is null"
                ));
                equipmentErrorDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentErrorForm addForm = new EquipmentErrorForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EquipmentErrorForm viewForm = new EquipmentErrorForm();
            viewForm.currentEquipmentErrorGuid = (Guid)equipmentErrorGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentErrorForm editForm = new EquipmentErrorForm())
            {
                editForm.currentEquipmentErrorGuid = (Guid)equipmentErrorGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentError currentEquipmentError = u.GetObjectByKey<device_EquipmentError>((Guid)equipmentErrorGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить  погрешность оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})?", currentEquipmentError.MeasurandGUID, currentEquipmentError.EquipmentGUID, currentEquipmentError.DiapasonBegin, currentEquipmentError.DiapasonEnd, currentEquipmentError.DeltaType, currentEquipmentError.DeltaValue), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentError.DeletedDate = DateTime.Now;
                    currentEquipmentError.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void equipmentErrorGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
