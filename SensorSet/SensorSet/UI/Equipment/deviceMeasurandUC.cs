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
    
    public partial class deviceMeasurandUC : UserControl
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
        public deviceMeasurandUC()
        {
            InitializeComponent();
        }
        public deviceMeasurandUC(Control _parent)
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
                SELECT [GUID]
      ,[ValueName]
      ,[DimensionGUID]
      ,[DimensionID]
      ,[DateOfChange]
      ,[DeletedDate]
  FROM [dbo].[MeasurandView] Where DeletedDate is null"
                ));
                measurandDataView.LoadData(_measuresData);
            }
            GC.Collect();
        }

        private void deviceMeasurandUC_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (MeasurandFormForm addForm = new MeasurandFormForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MeasurandFormForm viewForm = new MeasurandFormForm();
            viewForm.currentMeasurandGuid = (Guid)measurandGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (MeasurandFormForm editForm = new MeasurandFormForm())
            {
                editForm.currentMeasurandGuid = (Guid)measurandGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_Measurand currentMeasurand = u.GetObjectByKey<device_Measurand>((Guid)measurandGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить Измеряемые величины {0} ({1}) ?", currentMeasurand.ValueName, currentMeasurand.DimensionGUID), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentMeasurand.DeletedDate = DateTime.Now;
                    currentMeasurand.Save();
                    u.CommitChanges();
                }
            }
            loadData();
        }

        private void measurandGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

