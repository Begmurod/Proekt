using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using SensorSet.Model.SensorSet;

namespace SensorSet.UI.Equipment
{
    public partial class equipmentUC : DevExpress.XtraEditors.XtraUserControl
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
        public equipmentUC()
        {
            InitializeComponent();
        }

        public equipmentUC(Control _parent)
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
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
               SELECT  [GUID]
      ,[EquipmentTypeGUID]
      ,[EquipmentCategoryGUID]
      ,[InventoryNumber]
      ,[SerialNumber]
      ,[ManufacturingDate]
      ,[StartUseDate]
      ,[IpAddress]
      ,[Port]
      ,[BalanceCost]
      ,[UseMonths]
      ,[RemainingBalance]
      ,[GarantyPeriod]
      ,[DateModify]
      ,[DateCreate]
      ,[DeletedDate]
      ,[EquipmentKindGUID]
      ,[ParentGUID]
  FROM [dbo].[EquipmentView]
  WHERE [DeletedDate] is null"
                ));
                equipmentDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }
        private void loadequipmentCharacter()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
                SELECT [GUID]
      ,[CharacterName]
      ,[FieldName]
      ,[ParamType]
      ,[IsSystem]
      ,[DimensionGUID]
  FROM [dbo].[EquipmentCharacterView] Where DeletedDate is null"
                ));
                equipmentCharacterDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentForm addForm = new EquipmentForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EquipmentForm viewForm = new EquipmentForm();
            viewForm.currentEquipmentGuid = (Guid)equipmentGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentForm editForm = new EquipmentForm())
            {
                editForm.currentEquipmentGuid = (Guid)equipmentGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_Equipment currentEquipment = u.GetObjectByKey<device_Equipment>((Guid)equipmentGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить экземпляр оборудования {0} ({1}) ({2}) ({3}) ({4}) ({5}) ({6}) ({7}) ({8}) ({9}) ({10}) ({11}) ({12}) ?", currentEquipment.EquipmentCategoryGUID, currentEquipment.EquipmentTypeGUID,
                 currentEquipment.ParentGUID, currentEquipment.InventoryNumber, currentEquipment.SerialNumber,
                 currentEquipment.ManufacturingDate, currentEquipment.StartUseDate, currentEquipment.IpAddress,
                 currentEquipment.Port, currentEquipment.BalanceCost,
                 currentEquipment.UseMonths, currentEquipment.RemainingBalance, currentEquipment.GarantyPeriod), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipment.DeletedDate = DateTime.Now;
                    currentEquipment.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void equipmentGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

        private void equipmentUC_Load(object sender, EventArgs e)
        {
            loadData();
            loadequipmentCharacter();
        }

        private void ButtonItemAdd_Click(object sender, EventArgs e)
        {
            using (EquipmentCharacterForm addForm = new EquipmentCharacterForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void ButtonItemView_Click(object sender, EventArgs e)
        {
            EquipmentCharacterForm viewForm = new EquipmentCharacterForm();
            viewForm.currentEquipmentCharacterGuid = (Guid)equipmentCharacterGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void ButtonItemEdit_Click(object sender, EventArgs e)
        {
            using (EquipmentCharacterForm editForm = new EquipmentCharacterForm())
            {
                editForm.currentEquipmentCharacterGuid = (Guid)equipmentCharacterGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void ButtonItemDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_EquipmentCharacter currentEquipmentCharacter = u.GetObjectByKey<device_EquipmentCharacter>((Guid)equipmentCharacterGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалитьхрактеристики оборудования {0} ({1})", currentEquipmentCharacter.CharacterName, currentEquipmentCharacter.FieldName), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentEquipmentCharacter.DeletedDate = DateTime.Now;
                    currentEquipmentCharacter.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }
    }
}
