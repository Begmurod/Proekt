namespace SensorSet.UI.Equipment
{
    partial class dimensionUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dimensionUC));
            this.deimensionDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.dimensionRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dimensionGridControl = new DevExpress.XtraGrid.GridControl();
            this.dimensionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameEn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKoef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShowInInterface = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDigits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.deimensionDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // deimensionDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "Name";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "NameEn";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "ParentName";
            dataViewProperty4.ValueType = typeof(string);
            dataViewProperty5.Name = "Koef";
            dataViewProperty5.ValueType = typeof(decimal);
            dataViewProperty6.Name = "ShowInInterface";
            dataViewProperty6.ValueType = typeof(bool);
            dataViewProperty7.Name = "Digits";
            dataViewProperty7.ValueType = typeof(short);
            this.deimensionDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6,
            dataViewProperty7});
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
            this.dimensionRibbonControl.MaxItemId = 8;
            this.dimensionRibbonControl.Name = "dimensionRibbonControl";
            this.dimensionRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.dimensionRibbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
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
            // dimensionGridControl
            // 
            this.dimensionGridControl.DataSource = this.deimensionDataView;
            this.dimensionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionGridControl.Location = new System.Drawing.Point(0, 141);
            this.dimensionGridControl.MainView = this.dimensionGridView;
            this.dimensionGridControl.MenuManager = this.dimensionRibbonControl;
            this.dimensionGridControl.Name = "dimensionGridControl";
            this.dimensionGridControl.Size = new System.Drawing.Size(1019, 474);
            this.dimensionGridControl.TabIndex = 1;
            this.dimensionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dimensionGridView});
            // 
            // dimensionGridView
            // 
            this.dimensionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colName,
            this.colNameEn,
            this.colParentGUID,
            this.colKoef,
            this.colShowInInterface,
            this.colDigits});
            this.dimensionGridView.GridControl = this.dimensionGridControl;
            this.dimensionGridView.Name = "dimensionGridView";
            this.dimensionGridView.OptionsView.ShowFooter = true;
            this.dimensionGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dimensionGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colName
            // 
            this.colName.Caption = "Обозначение";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "{0}")});
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colNameEn
            // 
            this.colNameEn.Caption = "Международное обозначение";
            this.colNameEn.FieldName = "NameEn";
            this.colNameEn.Name = "colNameEn";
            this.colNameEn.Visible = true;
            this.colNameEn.VisibleIndex = 1;
            // 
            // colParentGUID
            // 
            this.colParentGUID.Caption = "Базовая единица";
            this.colParentGUID.FieldName = "ParentName";
            this.colParentGUID.Name = "colParentGUID";
            this.colParentGUID.Visible = true;
            this.colParentGUID.VisibleIndex = 2;
            // 
            // colKoef
            // 
            this.colKoef.Caption = "Коэффициент перевода в базовую единицу";
            this.colKoef.FieldName = "Koef";
            this.colKoef.Name = "colKoef";
            this.colKoef.Visible = true;
            this.colKoef.VisibleIndex = 3;
            // 
            // colShowInInterface
            // 
            this.colShowInInterface.Caption = "Отображать в интерфейсе по-умолчанию";
            this.colShowInInterface.FieldName = "Digits";
            this.colShowInInterface.Name = "colShowInInterface";
            // 
            // colDigits
            // 
            this.colDigits.Caption = "Кол-во знаков после запятой";
            this.colDigits.FieldName = "Digits";
            this.colDigits.Name = "colDigits";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // dimensionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dimensionGridControl);
            this.Controls.Add(this.dimensionRibbonControl);
            this.Name = "dimensionUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.dimensionUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deimensionDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView deimensionDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl dimensionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dimensionGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNameEn;
        private DevExpress.XtraGrid.Columns.GridColumn colParentGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colKoef;
        private DevExpress.XtraGrid.Columns.GridColumn colShowInInterface;
        private DevExpress.XtraGrid.Columns.GridColumn colDigits;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl dimensionRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}
