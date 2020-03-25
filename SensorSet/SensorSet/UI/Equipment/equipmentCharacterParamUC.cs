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
    public partial class equipmentCharacterParamUC : UserControl
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
        public equipmentCharacterParamUC(Control _parent)
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
        public equipmentCharacterParamUC()
        {
            InitializeComponent();
        }

        private void equipmentCharacterParamUC_Load(object sender, EventArgs e)
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
      ,[EquipmentCharacterGUID]
      ,[EquipmentGUID]
      ,[IntParam]
      ,[StrParam]
      ,[BoolParam]
      ,[NumericParam]
      ,[NumericParam2]
  FROM [dbo].[EquipmentCharacterParamView] Where DeletedDate is null"
                ));
                equipmentCharacterParamDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentCharacterParamForm addForm = new EquipmentCharacterParamForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EquipmentCharacterParamForm viewForm = new EquipmentCharacterParamForm();
            viewForm.currentEquipmentCharacterParamGuid = (Guid)equipmentCharacterParamGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentCharacterParamForm editForm = new EquipmentCharacterParamForm())
            {
                editForm.currentEquipmentCharacterParamGuid = (Guid)equipmentCharacterParamGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentCharacterParam currentEquipmentCharacterParam = u.GetObjectByKey<device_EquipmentCharacterParam>((Guid)equipmentCharacterParamGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить параметры(значения) характеристик {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6})?", currentEquipmentCharacterParam.EquipmentCharacterGUID, currentEquipmentCharacterParam.EquipmentGUID,
                   currentEquipmentCharacterParam.IntParam, currentEquipmentCharacterParam.StrParam, currentEquipmentCharacterParam.BoolParam, currentEquipmentCharacterParam.NumericParam, currentEquipmentCharacterParam.NumericParam2), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentCharacterParam.DeletedDate = DateTime.Now;
                    currentEquipmentCharacterParam.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void equipmentCharacterParamGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
