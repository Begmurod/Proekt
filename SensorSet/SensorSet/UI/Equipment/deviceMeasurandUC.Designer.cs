namespace SensorSet.UI.Equipment
{
    partial class deviceMeasurandUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deviceMeasurandUC));
            this.measurandDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.deviceMeasurandRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.dimensionGridControl = new DevExpress.XtraGrid.GridControl();
            this.measurandGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolueName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensionGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.measurandDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceMeasurandRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurandGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // measurandDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "ValueName";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "DimensionGUID";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "DimensionID";
            dataViewProperty4.ValueType = typeof(long);
            dataViewProperty5.Name = "DateOfChange";
            dataViewProperty5.ValueType = typeof(System.DateTime);
            dataViewProperty6.Name = "DeletedDate";
            dataViewProperty6.ValueType = typeof(System.DateTime);
            this.measurandDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6});
            // 
            // deviceMeasurandRibbonControl
            // 
            this.deviceMeasurandRibbonControl.ExpandCollapseItem.Id = 0;
            this.deviceMeasurandRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.deviceMeasurandRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.deviceMeasurandRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.deviceMeasurandRibbonControl.MaxItemId = 8;
            this.deviceMeasurandRibbonControl.Name = "deviceMeasurandRibbonControl";
            this.deviceMeasurandRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.deviceMeasurandRibbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.deviceMeasurandRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // dimensionGridControl
            // 
            this.dimensionGridControl.DataSource = this.measurandDataView;
            this.dimensionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionGridControl.Location = new System.Drawing.Point(0, 141);
            this.dimensionGridControl.MainView = this.measurandGridView;
            this.dimensionGridControl.MenuManager = this.deviceMeasurandRibbonControl;
            this.dimensionGridControl.Name = "dimensionGridControl";
            this.dimensionGridControl.Size = new System.Drawing.Size(1019, 474);
            this.dimensionGridControl.TabIndex = 1;
            this.dimensionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.measurandGridView});
            // 
            // measurandGridView
            // 
            this.measurandGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colVolueName,
            this.colDimensionGUID,
            this.colDimensionID,
            this.colDateOfChange,
            this.colDeletedDate});
            this.measurandGridView.GridControl = this.dimensionGridControl;
            this.measurandGridView.Name = "measurandGridView";
            this.measurandGridView.OptionsView.ShowFooter = true;
            this.measurandGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.measurandGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colDimensionID
            // 
            this.colDimensionID.Caption = "DimensionID";
            this.colDimensionID.FieldName = "DimensionID";
            this.colDimensionID.Name = "colDimensionID";
            // 
            // colVolueName
            // 
            this.colVolueName.Caption = "Наименование измеряемой величины";
            this.colVolueName.FieldName = "ValueName";
            this.colVolueName.Name = "colVolueName";
            this.colVolueName.Visible = true;
            this.colVolueName.VisibleIndex = 0;
            // 
            // colDimensionGUID
            // 
            this.colDimensionGUID.Caption = "Размерности";
            this.colDimensionGUID.FieldName = "DimensionGUID";
            this.colDimensionGUID.Name = "colDimensionGUID";
            this.colDimensionGUID.Visible = true;
            this.colDimensionGUID.VisibleIndex = 1;
            // 
            // colDateOfChange
            // 
            this.colDateOfChange.Caption = "Дата ввода";
            this.colDateOfChange.FieldName = "DateOfChange";
            this.colDateOfChange.Name = "colDateOfChange";
            // 
            // colDeletedDate
            // 
            this.colDeletedDate.Caption = "Дата удаление";
            this.colDeletedDate.FieldName = "DeletedDate";
            this.colDeletedDate.Name = "colDeletedDate";
            // 
            // deviceMeasurandUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dimensionGridControl);
            this.Controls.Add(this.deviceMeasurandRibbonControl);
            this.Name = "deviceMeasurandUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.deviceMeasurandUC_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.measurandDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceMeasurandRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurandGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView measurandDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl dimensionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView measurandGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colVolueName;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensionGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensionID;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfChange;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl deviceMeasurandRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}
