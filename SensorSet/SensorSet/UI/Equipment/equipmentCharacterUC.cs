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
    public partial class equipmentCharacterUC : UserControl
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
        public equipmentCharacterUC()
        {
            InitializeComponent();
        }
        public equipmentCharacterUC(Control _parent)
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

        private void equipmentCharacterUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _equipmentCharacterData = u.ExecuteQuery(string.Format(@"
                SELECT [GUID]
      ,[CharacterName]
      ,[FieldName]
      ,[ParamType]
      ,[IsSystem]
      ,[DimensionGUID]
  FROM [dbo].[EquipmentCharacterView] Where DeletedDate is null"
                ));
                equipmentCharacterDataView.LoadData(_equipmentCharacterData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentCharacterForm addForm = new EquipmentCharacterForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EquipmentCharacterForm viewForm = new EquipmentCharacterForm();
            viewForm.currentEquipmentCharacterGuid = (Guid)equipmentCharacterGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EquipmentCharacterForm editForm = new EquipmentCharacterForm())
            {
                editForm.currentEquipmentCharacterGuid = (Guid)equipmentCharacterGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void equipmentCharacterGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
