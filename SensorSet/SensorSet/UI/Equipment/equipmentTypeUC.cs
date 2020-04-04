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
    public partial class equipmentTypeUC : UserControl
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
        public equipmentTypeUC()
        {
            InitializeComponent();
        }
        public equipmentTypeUC(Control _parent)
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

        private void equipmentTypeUC_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataCharacter();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
                      SELECT [GUID]
      ,[Name]
      ,[FullName]
      ,[EquipmentKindGUID]
      ,[EquipmentVendorGUID]
      ,[Description]
  FROM [dbo].[equipmentTypeView] Where DeletedDate is null"
                ));
                equipmentTypeDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void loadDataCharacter()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
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
  FROM [dbo].[EquipmentCharacterEquipmentTypeView] Where DeletedDate is null  and  EquipmentTypeGUID = '{0}'", equipmentTypeGridView.GetFocusedRowCellValue("GUID")
                ));
                equipmentCharacterEquipmentTypeDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentTypeForm addForm = new EquipmentTypeForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            EquipmentTypeForm viewForm = new EquipmentTypeForm();
            viewForm.currentEquipmentTypeGuid = (Guid)equipmentTypeGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentTypeForm editForm = new EquipmentTypeForm())
            {
                editForm.currentEquipmentTypeGuid = (Guid)equipmentTypeGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentType currentEquipmentType = u.GetObjectByKey<device_EquipmentType>((Guid)equipmentTypeGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить  погрешность оборудования {0} ({1}) ({2}) ({3}) ({4})?", currentEquipmentType.Name, currentEquipmentType.FullName, currentEquipmentType.Description, currentEquipmentType.EquipmentVendorGUID, currentEquipmentType.EquipmentKindGUID), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentType.DeletedDate = DateTime.Now;
                    currentEquipmentType.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void equipmentTypeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                fireLockButtons(new EventArgs());
            }
            else
            {
                fireUnlockButtons(new EventArgs());
            }
            loadDataCharacter();
        }

        private void ButtonItemAdd_Click(object sender, EventArgs e)
        {
            using (EquipmentCharacterEquipmentTypeForm addForm = new EquipmentCharacterEquipmentTypeForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void ButtonItemView_Click(object sender, EventArgs e)
        {
            EquipmentCharacterEquipmentTypeForm viewForm = new EquipmentCharacterEquipmentTypeForm();
            viewForm.currentEquipmentCharacterEquipmentTypeGuid = (Guid)equipmentCharacterEquipmentTypeGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void ButtonItemEdit_Click(object sender, EventArgs e)
        {
            using (EquipmentCharacterEquipmentTypeForm editForm = new EquipmentCharacterEquipmentTypeForm())
            {
                editForm.currentEquipmentCharacterEquipmentTypeGuid = (Guid)equipmentCharacterEquipmentTypeGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void ButtonItemDelete_Click(object sender, EventArgs e)
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
    }
}
