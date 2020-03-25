namespace SensorSet.UI.Equipment
{
    partial class equipmentCharacterUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentCharacterUC));
            this.equipmentCharacterDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.equipmentCharacterRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentCharacterGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentCharacterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCharacterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParamType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensionGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSystem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentCharacterDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "CharacterName";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "FieldName";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "ParamType";
            dataViewProperty4.ValueType = typeof(short);
            dataViewProperty5.Name = "IsSystem";
            dataViewProperty5.ValueType = typeof(bool);
            dataViewProperty6.Name = "DimensionGUID";
            dataViewProperty6.ValueType = typeof(string);
            this.equipmentCharacterDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6});
            // 
            // equipmentCharacterRibbonControl
            // 
            this.equipmentCharacterRibbonControl.ExpandCollapseItem.Id = 0;
            this.equipmentCharacterRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.equipmentCharacterRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.equipmentCharacterRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.equipmentCharacterRibbonControl.MaxItemId = 7;
            this.equipmentCharacterRibbonControl.Name = "equipmentCharacterRibbonControl";
            this.equipmentCharacterRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.equipmentCharacterRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            // equipmentCharacterGridControl
            // 
            this.equipmentCharacterGridControl.DataSource = this.equipmentCharacterDataView;
            this.equipmentCharacterGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentCharacterGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentCharacterGridControl.MainView = this.equipmentCharacterGridView;
            this.equipmentCharacterGridControl.MenuManager = this.equipmentCharacterRibbonControl;
            this.equipmentCharacterGridControl.Name = "equipmentCharacterGridControl";
            this.equipmentCharacterGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentCharacterGridControl.TabIndex = 1;
            this.equipmentCharacterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentCharacterGridView});
            // 
            // equipmentCharacterGridView
            // 
            this.equipmentCharacterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colCharacterName,
            this.colFieldName,
            this.colParamType,
            this.colDimensionGUID,
            this.colIsSystem});
            this.equipmentCharacterGridView.GridControl = this.equipmentCharacterGridControl;
            this.equipmentCharacterGridView.Name = "equipmentCharacterGridView";
            this.equipmentCharacterGridView.OptionsView.ShowFooter = true;
            this.equipmentCharacterGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.equipmentCharacterGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colCharacterName
            // 
            this.colCharacterName.Caption = "Название характеристики";
            this.colCharacterName.FieldName = "CharacterName";
            this.colCharacterName.Name = "colCharacterName";
            this.colCharacterName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "{0}")});
            this.colCharacterName.Visible = true;
            this.colCharacterName.VisibleIndex = 0;
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "Имя поля";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 1;
            // 
            // colParamType
            // 
            this.colParamType.Caption = "Тип данных параметра";
            this.colParamType.FieldName = "ParamType";
            this.colParamType.Name = "colParamType";
            this.colParamType.Visible = true;
            this.colParamType.VisibleIndex = 2;
            // 
            // colDimensionGUID
            // 
            this.colDimensionGUID.Caption = "Идентификатор единицы измерения";
            this.colDimensionGUID.FieldName = "DimensionGUID";
            this.colDimensionGUID.Name = "colDimensionGUID";
            this.colDimensionGUID.Visible = true;
            this.colDimensionGUID.VisibleIndex = 3;
            // 
            // colIsSystem
            // 
            this.colIsSystem.Caption = "Системная характеристика?";
            this.colIsSystem.FieldName = "IsSystem";
            this.colIsSystem.Name = "colIsSystem";
            // 
            // equipmentCharacterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentCharacterGridControl);
            this.Controls.Add(this.equipmentCharacterRibbonControl);
            this.Name = "equipmentCharacterUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.equipmentCharacterUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentCharacterDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentCharacterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentCharacterGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colCharacterName;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colParamType;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensionGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSystem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl equipmentCharacterRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
    }
}
