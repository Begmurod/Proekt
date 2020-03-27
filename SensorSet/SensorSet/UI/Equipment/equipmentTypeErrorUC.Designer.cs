namespace SensorSet.UI.Equipment
{
    partial class equipmentTypeErrorUC
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
            DevExpress.Xpo.DataViewProperty dataViewProperty15 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty16 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty17 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty18 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty19 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty20 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty21 = new DevExpress.Xpo.DataViewProperty();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentTypeErrorUC));
            this.equipmentTypeErrorDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.dimensionRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentTypeErrorUCGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentTypeErrorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeErrorGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentKindGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeasurandGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiapasonBegin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiapasonEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeltaType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeltaValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItemAd = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeErrorDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeErrorUCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeErrorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentTypeErrorDataView
            // 
            dataViewProperty15.Name = "GUID";
            dataViewProperty15.ValueType = typeof(object);
            dataViewProperty16.Name = "EquipmentTypeGUID";
            dataViewProperty16.ValueType = typeof(string);
            dataViewProperty17.Name = "MeasurandGUID";
            dataViewProperty17.ValueType = typeof(string);
            dataViewProperty18.Name = "DiapasonBegin";
            dataViewProperty18.ValueType = typeof(decimal);
            dataViewProperty19.Name = "DiapasonEnd";
            dataViewProperty19.ValueType = typeof(decimal);
            dataViewProperty20.Name = "DeltaType";
            dataViewProperty20.ValueType = typeof(short);
            dataViewProperty21.Name = "DeltaValue";
            dataViewProperty21.ValueType = typeof(decimal);
            this.equipmentTypeErrorDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty15,
            dataViewProperty16,
            dataViewProperty17,
            dataViewProperty18,
            dataViewProperty19,
            dataViewProperty20,
            dataViewProperty21});
            // 
            // dimensionRibbonControl
            // 
            this.dimensionRibbonControl.ExpandCollapseItem.Id = 0;
            this.dimensionRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.dimensionRibbonControl.ExpandCollapseItem,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView,
            this.ribbonGalleryBarItem1,
            this.barButtonItemAd});
            this.dimensionRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.dimensionRibbonControl.MaxItemId = 9;
            this.dimensionRibbonControl.Name = "dimensionRibbonControl";
            this.dimensionRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.dimensionRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemView);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // equipmentTypeErrorUCGridControl
            // 
            this.equipmentTypeErrorUCGridControl.DataSource = this.equipmentTypeErrorDataView;
            this.equipmentTypeErrorUCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentTypeErrorUCGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentTypeErrorUCGridControl.MainView = this.equipmentTypeErrorGridView;
            this.equipmentTypeErrorUCGridControl.MenuManager = this.dimensionRibbonControl;
            this.equipmentTypeErrorUCGridControl.Name = "equipmentTypeErrorUCGridControl";
            this.equipmentTypeErrorUCGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentTypeErrorUCGridControl.TabIndex = 1;
            this.equipmentTypeErrorUCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentTypeErrorGridView});
            // 
            // equipmentTypeErrorGridView
            // 
            this.equipmentTypeErrorGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeErrorGUID,
            this.colEquipmentKindGUID,
            this.colMeasurandGUID,
            this.colDiapasonBegin,
            this.colDiapasonEnd,
            this.colDeltaType,
            this.colDeltaValue});
            this.equipmentTypeErrorGridView.GridControl = this.equipmentTypeErrorUCGridControl;
            this.equipmentTypeErrorGridView.Name = "equipmentTypeErrorGridView";
            this.equipmentTypeErrorGridView.OptionsView.ShowFooter = true;
            this.equipmentTypeErrorGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.equipmentTypeErrorGridView_FocusedRowChanged);
            // 
            // colTypeErrorGUID
            // 
            this.colTypeErrorGUID.FieldName = "GUID";
            this.colTypeErrorGUID.Name = "colTypeErrorGUID";
            // 
            // colEquipmentKindGUID
            // 
            this.colEquipmentKindGUID.Caption = "Идентификатор типа оборудования";
            this.colEquipmentKindGUID.FieldName = "EquipmentTypeGUID";
            this.colEquipmentKindGUID.Name = "colEquipmentKindGUID";
            this.colEquipmentKindGUID.Visible = true;
            this.colEquipmentKindGUID.VisibleIndex = 0;
            // 
            // colMeasurandGUID
            // 
            this.colMeasurandGUID.Caption = "Идентификатор измеряемой величины";
            this.colMeasurandGUID.FieldName = "MeasurandGUID";
            this.colMeasurandGUID.Name = "colMeasurandGUID";
            this.colMeasurandGUID.Visible = true;
            this.colMeasurandGUID.VisibleIndex = 1;
            // 
            // colDiapasonBegin
            // 
            this.colDiapasonBegin.Caption = "Начало диапазона измерения";
            this.colDiapasonBegin.FieldName = "DiapasonBegin";
            this.colDiapasonBegin.Name = "colDiapasonBegin";
            this.colDiapasonBegin.Visible = true;
            this.colDiapasonBegin.VisibleIndex = 2;
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
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Добавить";
            this.barButtonItemAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.Glyph")));
            this.barButtonItemAdd.Id = 3;
            this.barButtonItemAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.LargeGlyph")));
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Добавить";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 7;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItemAd
            // 
            this.barButtonItemAd.Caption = "Добавить";
            this.barButtonItemAd.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAd.Glyph")));
            this.barButtonItemAd.Id = 8;
            this.barButtonItemAd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAd.LargeGlyph")));
            this.barButtonItemAd.Name = "barButtonItemAd";
            this.barButtonItemAd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAd_ItemClick);
            // 
            // equipmentTypeErrorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentTypeErrorUCGridControl);
            this.Controls.Add(this.dimensionRibbonControl);
            this.Name = "equipmentTypeErrorUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.equipmentTypeErrorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeErrorDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeErrorUCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeErrorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentTypeErrorDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentTypeErrorUCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentTypeErrorGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeErrorGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colMeasurandGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colDiapasonBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colDiapasonEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colDeltaType;
        private DevExpress.XtraGrid.Columns.GridColumn colDeltaValue;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl dimensionRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentKindGUID;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
