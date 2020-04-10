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
    public partial class equipmentCharacterEquipmentTypeUC : UserControl
    {
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
        public equipmentCharacterEquipmentTypeUC(Control _parent)
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

        public equipmentCharacterEquipmentTypeUC()
        {
            InitializeComponent();
        }

        private void equipmentCharacterEquipmentTypeUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _equipmentCharacterEquipmentTypeData = u.ExecuteQuery(string.Format(@"
               SELECT  [GUID]
      ,[EquipmentCharacterGUID]
      ,[EquipmentTypeGUID]
      ,[IntParam]
      ,[StrParam]
      ,[DataParam]
      ,[BoolParam]
      ,[NumericParam]
      ,[NumericParam2]
      ,[DeletedDate]
      ,[DateOfChange]
  FROM [dbo].[EquipmentCharacterEquipmentTypeView] Where DeletedDate is null"
                ));
                equipmentCharacterEquipmentTypeDataView.LoadData(_equipmentCharacterEquipmentTypeData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentCharacterEquipmentTypeForm addForm = new EquipmentCharacterEquipmentTypeForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EquipmentCharacterEquipmentTypeForm viewForm = new EquipmentCharacterEquipmentTypeForm();
            viewForm.currentEquipmentCharacterEquipmentTypeGuid = (Guid)equipmentCharacterEquipmentTypeGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentCharacterEquipmentTypeForm editForm = new EquipmentCharacterEquipmentTypeForm())
            {
                editForm.currentEquipmentCharacterEquipmentTypeGuid = (Guid)equipmentCharacterEquipmentTypeGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentCharacterEquipmentType currentEquipmentCharacterEquipmentType = u.GetObjectByKey<device_EquipmentCharacterEquipmentType>((Guid)equipmentCharacterEquipmentTypeGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить параметры(значения) характеристик {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})?", currentEquipmentCharacterEquipmentType.EquipmentCharacterGUID, currentEquipmentCharacterEquipmentType.EquipmentTypeGUID,
                   currentEquipmentCharacterEquipmentType.IntParam, currentEquipmentCharacterEquipmentType.StrParam, currentEquipmentCharacterEquipmentType.DataParam, currentEquipmentCharacterEquipmentType.BoolParam,
                   currentEquipmentCharacterEquipmentType.NumericParam, currentEquipmentCharacterEquipmentType.NumericParam2), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentCharacterEquipmentType.DeletedDate = DateTime.Now;
                    currentEquipmentCharacterEquipmentType.Save();
                    u.CommitChanges();
                }
            }

        }

        private void equipmentCharacterEquipmentTypeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

