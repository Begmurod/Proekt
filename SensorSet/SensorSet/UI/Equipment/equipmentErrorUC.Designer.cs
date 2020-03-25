namespace SensorSet.UI.Equipment
{
    partial class equipmentErrorUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Xpo.DataViewProperty dataViewProperty1 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty2 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty3 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty4 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty5 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty6 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty7 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty8 = new DevExpress.Xpo.DataViewProperty();
            this.equipmentErrorDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.equipmentErrorRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentErrorGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentErrorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeasurandGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiapasonBegin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiapasonEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeltaType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeltaValue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentErrorDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "MeasurandGUID";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "EquipmentID";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "EquipmentGUID";
            dataViewProperty4.ValueType = typeof(string);
            dataViewProperty5.Name = "DiapasonBegin";
            dataViewProperty5.ValueType = typeof(decimal);
            dataViewProperty6.Name = "DiapasonEnd";
            dataViewProperty6.ValueType = typeof(decimal);
            dataViewProperty7.Name = "DeltaType";
            dataViewProperty7.ValueType = typeof(short);
            dataViewProperty8.Name = "DeltaValue";
            dataViewProperty8.ValueType = typeof(decimal);
            this.equipmentErrorDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6,
            dataViewProperty7,
            dataViewProperty8});
            // 
            // equipmentErrorRibbonControl
            // 
            this.equipmentErrorRibbonControl.ExpandCollapseItem.Id = 0;
            this.equipmentErrorRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.equipmentErrorRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.equipmentErrorRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.equipmentErrorRibbonControl.MaxItemId = 7;
            this.equipmentErrorRibbonControl.Name = "equipmentErrorRibbonControl";
            this.equipmentErrorRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.equipmentErrorRibbonControl.Size = new System.Drawing.Size(1019, 141);
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Добавить";
            this.barButtonItemAdd.Id = 3;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Редактировать";
            this.barButtonItemEdit.Enabled = false;
            this.barButtonItemEdit.Id = 4;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Удалить";
            this.barButtonItemDelete.Enabled = false;
            this.barButtonItemDelete.Id = 5;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemView
            // 
            this.barButtonItemView.Caption = "Просмотр";
            this.barButtonItemView.Enabled = false;
            this.barButtonItemView.Id = 6;
            this.barButtonItemView.Name = "barButtonItemView";
            this.barButtonItemView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemView_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemView);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // equipmentErrorGridControl
            // 
            this.equipmentErrorGridControl.DataSource = this.equipmentErrorDataView;
            this.equipmentErrorGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentErrorGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentErrorGridControl.MainView = this.equipmentErrorGridView;
            this.equipmentErrorGridControl.MenuManager = this.equipmentErrorRibbonControl;
            this.equipmentErrorGridControl.Name = "equipmentErrorGridControl";
            this.equipmentErrorGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentErrorGridControl.TabIndex = 1;
            this.equipmentErrorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentErrorGridView});
            // 
            // equipmentErrorGridView
            // 
            this.equipmentErrorGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colMeasurandGUID,
            this.colEquipmentID,
            this.colEquipmentGUID,
            this.colDiapasonBegin,
            this.colDiapasonEnd,
            this.colDeltaType,
            this.colDeltaValue});
            this.equipmentErrorGridView.GridControl = this.equipmentErrorGridControl;
            this.equipmentErrorGridView.Name = "equipmentErrorGridView";
            this.equipmentErrorGridView.OptionsView.ShowFooter = true;
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colMeasurandGUID
            // 
            this.colMeasurandGUID.Caption = "Измеряемая величина";
            this.colMeasurandGUID.FieldName = "MeasurandGUID";
            this.colMeasurandGUID.Name = "colMeasurandGUID";
            this.colMeasurandGUID.Visible = true;
            this.colMeasurandGUID.VisibleIndex = 1;
            // 
            // colEquipmentID
            // 
            this.colEquipmentID.Caption = "Средства измерения в АСРК";
            this.colEquipmentID.FieldName = "EquipmentID";
            this.colEquipmentID.Name = "colEquipmentID";
            this.colEquipmentID.Visible = true;
            this.colEquipmentID.VisibleIndex = 0;
            // 
            // colEquipmentGUID
            // 
            this.colEquipmentGUID.Caption = "Средства измерения";
            this.colEquipmentGUID.FieldName = "EquipmentGUID";
            this.colEquipmentGUID.Name = "colEquipmentGUID";
            this.colEquipmentGUID.Visible = true;
            this.colEquipmentGUID.VisibleIndex = 2;
            // 
            // colDiapasonBegin
            // 
            this.colDiapasonBegin.Caption = "Начало диапазона измерения";
            this.colDiapasonBegin.FieldName = "DiapasonBegin";
            this.colDiapasonBegin.Name = "colDiapasonBegin";
            this.colDiapasonBegin.Visible = true;
            this.colDiapasonBegin.VisibleIndex = 5;
            // 
            // colDiapasonEnd
            // 
            this.colDiapasonEnd.Caption = "Конец диапазона измерения";
            this.colDiapasonEnd.FieldName = "DiapasonEnd";
            this.colDiapasonEnd.Name = "colDiapasonEnd";
            this.colDiapasonEnd.Visible = true;
            this.colDiapasonEnd.VisibleIndex = 3;
            // 
            // colDeltaType
            // 
            this.colDeltaType.Caption = "Тип погрешности: 1-абсолютная, 0-относительная";
            this.colDeltaType.FieldName = "DeltaType";
            this.colDeltaType.Name = "colDeltaType";
            // 
            // colDeltaValue
            // 
            this.colDeltaValue.Caption = "Величина погрешности";
            this.colDeltaValue.FieldName = "DeltaValue";
            this.colDeltaValue.Name = "colDeltaValue";
            this.colDeltaValue.Visible = true;
            this.colDeltaValue.VisibleIndex = 4;
            // 
            // equipmentErrorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentErrorGridControl);
            this.Controls.Add(this.equipmentErrorRibbonControl);
            this.Name = "equipmentErrorUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.equipmentErrorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentErrorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentErrorDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentErrorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentErrorGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colMeasurandGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colDiapasonEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colDeltaType;
        private DevExpress.XtraGrid.Columns.GridColumn colDeltaValue;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl equipmentErrorRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colDiapasonBegin;
    }
}
