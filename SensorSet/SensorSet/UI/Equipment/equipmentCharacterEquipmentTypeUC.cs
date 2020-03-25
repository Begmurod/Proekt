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
                DevExpress.Xpo.DB.SelectedData _measuresData = u.ExecuteQuery(string.Format(@"
               SELECT  [GUID]
      ,[CharacterName]
      ,[FullName]
      ,[IntParam]
      ,[StrParam]
      ,[DataParam]
      ,[BoolParam]
      ,[NumericParam]
      ,[NumericParam2]
  FROM [dbo].[EquipmentCharacterEquipmentTypeView] Where DeletedDate is null"
                ));
                equipmentCharacterEquipmentTypeDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

    }
}
