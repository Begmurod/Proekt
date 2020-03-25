namespace SensorSet.UI.Equipment
{
    partial class deviceEquipmentKindUC
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
            DevExpress.Xpo.DataViewProperty dataViewProperty4 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty5 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty6 = new DevExpress.Xpo.DataViewProperty();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deviceEquipmentKindUC));
            this.deviceEquipmentKindDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.deviceEquipmentKindRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deviceEquipmentKindGridControl = new DevExpress.XtraGrid.GridControl();
            this.deviceEquipmentKindGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceEquipmentKindDataView
            // 
            dataViewProperty4.Name = "GUID";
            dataViewProperty4.ValueType = typeof(object);
            dataViewProperty5.Name = "Name";
            dataViewProperty5.ValueType = typeof(string);
            dataViewProperty6.Name = "ParentName";
            dataViewProperty6.ValueType = typeof(string);
            this.deviceEquipmentKindDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6});
            // 
            // deviceEquipmentKindRibbonControl
            // 
            this.deviceEquipmentKindRibbonControl.ExpandCollapseItem.Id = 0;
            this.deviceEquipmentKindRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.deviceEquipmentKindRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.deviceEquipmentKindRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.deviceEquipmentKindRibbonControl.MaxItemId = 7;
            this.deviceEquipmentKindRibbonControl.Name = "deviceEquipmentKindRibbonControl";
            this.deviceEquipmentKindRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.deviceEquipmentKindRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            // deviceEquipmentKindGridControl
            // 
            this.deviceEquipmentKindGridControl.DataSource = this.deviceEquipmentKindDataView;
            this.deviceEquipmentKindGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceEquipmentKindGridControl.Location = new System.Drawing.Point(0, 141);
            this.deviceEquipmentKindGridControl.MainView = this.deviceEquipmentKindGridView;
            this.deviceEquipmentKindGridControl.MenuManager = this.deviceEquipmentKindRibbonControl;
            this.deviceEquipmentKindGridControl.Name = "deviceEquipmentKindGridControl";
            this.deviceEquipmentKindGridControl.Size = new System.Drawing.Size(1019, 474);
            this.deviceEquipmentKindGridControl.TabIndex = 1;
            this.deviceEquipmentKindGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deviceEquipmentKindGridView});
            // 
            // deviceEquipmentKindGridView
            // 
            this.deviceEquipmentKindGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colName,
            this.colParentGUID});
            this.deviceEquipmentKindGridView.GridControl = this.deviceEquipmentKindGridControl;
            this.deviceEquipmentKindGridView.Name = "deviceEquipmentKindGridView";
            this.deviceEquipmentKindGridView.OptionsView.ShowFooter = true;
            this.deviceEquipmentKindGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.deviceEquipmentKindGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colName
            // 
            this.colName.Caption = "Наименование вида оборудования";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "{0}")});
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colParentGUID
            // 
            this.colParentGUID.Caption = "Идентификатор родительской записи";
            this.colParentGUID.FieldName = "ParentName";
            this.colParentGUID.Name = "colParentGUID";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Просмотр";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Просмотр";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // deviceEquipmentKindUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deviceEquipmentKindGridControl);
            this.Controls.Add(this.deviceEquipmentKindRibbonControl);
            this.Name = "deviceEquipmentKindUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.deviceEquipmentKindUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceEquipmentKindGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView deviceEquipmentKindDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl deviceEquipmentKindGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView deviceEquipmentKindGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colParentGUID;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl deviceEquipmentKindRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
