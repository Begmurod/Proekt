namespace SensorSet.UI.Equipment
{
    partial class equipmentTypeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentTypeUC));
            this.equipmentTypeDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.dimensionRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKindName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentTypeDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "Name";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "EquipmentKindGUID";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "EquipmentVendorGUID";
            dataViewProperty4.ValueType = typeof(string);
            dataViewProperty5.Name = "FullName";
            dataViewProperty5.ValueType = typeof(string);
            dataViewProperty6.Name = "Description";
            dataViewProperty6.ValueType = typeof(string);
            this.equipmentTypeDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6});
            // 
            // dimensionRibbonControl
            // 
            this.dimensionRibbonControl.ExpandCollapseItem.Id = 0;
            this.dimensionRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.dimensionRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.dimensionRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.dimensionRibbonControl.MaxItemId = 7;
            this.dimensionRibbonControl.Name = "dimensionRibbonControl";
            this.dimensionRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.dimensionRibbonControl.Size = new System.Drawing.Size(1019, 141);
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Добавить";
            this.barButtonItemAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.Glyph")));
            this.barButtonItemAdd.Id = 3;
            this.barButtonItemAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.LargeGlyph")));
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Редактировать";
            this.barButtonItemEdit.Enabled = false;
            this.barButtonItemEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemEdit.Glyph")));
            this.barButtonItemEdit.Id = 4;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Удалить";
            this.barButtonItemDelete.Enabled = false;
            this.barButtonItemDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.Glyph")));
            this.barButtonItemDelete.Id = 5;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemView
            // 
            this.barButtonItemView.Caption = "Просмотр";
            this.barButtonItemView.Enabled = false;
            this.barButtonItemView.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemView.Glyph")));
            this.barButtonItemView.Id = 6;
            this.barButtonItemView.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemView.LargeGlyph")));
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
            // equipmentTypeGridControl
            // 
            this.equipmentTypeGridControl.DataSource = this.equipmentTypeDataView;
            this.equipmentTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentTypeGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentTypeGridControl.MainView = this.equipmentTypeGridView;
            this.equipmentTypeGridControl.MenuManager = this.dimensionRibbonControl;
            this.equipmentTypeGridControl.Name = "equipmentTypeGridControl";
            this.equipmentTypeGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentTypeGridControl.TabIndex = 1;
            this.equipmentTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentTypeGridView});
            // 
            // equipmentTypeGridView
            // 
            this.equipmentTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colName,
            this.colKindName,
            this.colVendorName,
            this.colFullName,
            this.colDescription});
            this.equipmentTypeGridView.GridControl = this.equipmentTypeGridControl;
            this.equipmentTypeGridView.Name = "equipmentTypeGridView";
            this.equipmentTypeGridView.OptionsView.ShowFooter = true;
            this.equipmentTypeGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.equipmentTypeGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colName
            // 
            this.colName.Caption = "Краткое наименование типа";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colKindName
            // 
            this.colKindName.Caption = "Идентификатор вида устройства";
            this.colKindName.FieldName = "EquipmentKindGUID";
            this.colKindName.Name = "colKindName";
            this.colKindName.Visible = true;
            this.colKindName.VisibleIndex = 1;
            // 
            // colVendorName
            // 
            this.colVendorName.Caption = "Идентификатор производителя оборудования";
            this.colVendorName.FieldName = "EquipmentVendorGUID";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Visible = true;
            this.colVendorName.VisibleIndex = 2;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Полное наименование типа";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Описание";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // equipmentTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentTypeGridControl);
            this.Controls.Add(this.dimensionRibbonControl);
            this.Name = "equipmentTypeUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.equipmentTypeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentTypeDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentTypeGridView;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl dimensionRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colKindName;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
