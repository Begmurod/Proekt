namespace SensorSet.UI.Equipment
{
    partial class equipmentCharacterEquipmentTypeUC
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
            DevExpress.Xpo.DataViewProperty dataViewProperty9 = new DevExpress.Xpo.DataViewProperty();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentCharacterEquipmentTypeUC));
            this.equipmentCharacterEquipmentTypeDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.equipmentCharacterEquipmentTypeRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentCharacterEquipmentTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentCharacterEquipmentTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentCharacterGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentTypeGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStrParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoolParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumericParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumericParam2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentCharacterEquipmentTypeDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "EquipmentCharacterGUID";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "EquipmentTypeGUID";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "IntParam";
            dataViewProperty4.ValueType = typeof(long);
            dataViewProperty5.Name = "StrParam";
            dataViewProperty5.ValueType = typeof(string);
            dataViewProperty6.Name = "DataParam";
            dataViewProperty6.ValueType = typeof(System.DateTime);
            dataViewProperty7.Name = "BoolParam";
            dataViewProperty7.ValueType = typeof(bool);
            dataViewProperty8.Name = "NumericParam";
            dataViewProperty8.ValueType = typeof(long);
            dataViewProperty9.Name = "NumericParam2";
            dataViewProperty9.ValueType = typeof(double);
            this.equipmentCharacterEquipmentTypeDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6,
            dataViewProperty7,
            dataViewProperty8,
            dataViewProperty9});
            // 
            // equipmentCharacterEquipmentTypeRibbonControl
            // 
            this.equipmentCharacterEquipmentTypeRibbonControl.ExpandCollapseItem.Id = 0;
            this.equipmentCharacterEquipmentTypeRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.equipmentCharacterEquipmentTypeRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.equipmentCharacterEquipmentTypeRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.equipmentCharacterEquipmentTypeRibbonControl.MaxItemId = 7;
            this.equipmentCharacterEquipmentTypeRibbonControl.Name = "equipmentCharacterEquipmentTypeRibbonControl";
            this.equipmentCharacterEquipmentTypeRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.equipmentCharacterEquipmentTypeRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            // equipmentCharacterEquipmentTypeGridControl
            // 
            this.equipmentCharacterEquipmentTypeGridControl.DataSource = this.equipmentCharacterEquipmentTypeDataView;
            this.equipmentCharacterEquipmentTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentCharacterEquipmentTypeGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentCharacterEquipmentTypeGridControl.MainView = this.equipmentCharacterEquipmentTypeGridView;
            this.equipmentCharacterEquipmentTypeGridControl.MenuManager = this.equipmentCharacterEquipmentTypeRibbonControl;
            this.equipmentCharacterEquipmentTypeGridControl.Name = "equipmentCharacterEquipmentTypeGridControl";
            this.equipmentCharacterEquipmentTypeGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentCharacterEquipmentTypeGridControl.TabIndex = 1;
            this.equipmentCharacterEquipmentTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentCharacterEquipmentTypeGridView});
            // 
            // equipmentCharacterEquipmentTypeGridView
            // 
            this.equipmentCharacterEquipmentTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colEquipmentCharacterGUID,
            this.colEquipmentTypeGUID,
            this.colIntParam,
            this.colStrParam,
            this.colDataParam,
            this.colBoolParam,
            this.colNumericParam,
            this.colNumericParam2});
            this.equipmentCharacterEquipmentTypeGridView.GridControl = this.equipmentCharacterEquipmentTypeGridControl;
            this.equipmentCharacterEquipmentTypeGridView.Name = "equipmentCharacterEquipmentTypeGridView";
            this.equipmentCharacterEquipmentTypeGridView.OptionsView.ShowFooter = true;
            this.equipmentCharacterEquipmentTypeGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.equipmentCharacterEquipmentTypeGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colEquipmentCharacterGUID
            // 
            this.colEquipmentCharacterGUID.Caption = "Идентификатор характеристики";
            this.colEquipmentCharacterGUID.FieldName = "EquipmentCharacterGUID";
            this.colEquipmentCharacterGUID.Name = "colEquipmentCharacterGUID";
            this.colEquipmentCharacterGUID.Visible = true;
            this.colEquipmentCharacterGUID.VisibleIndex = 0;
            this.colEquipmentCharacterGUID.Width = 169;
            // 
            // colEquipmentTypeGUID
            // 
            this.colEquipmentTypeGUID.Caption = "Идентификатор типа оборудования";
            this.colEquipmentTypeGUID.FieldName = "EquipmentTypeGUID";
            this.colEquipmentTypeGUID.Name = "colEquipmentTypeGUID";
            this.colEquipmentTypeGUID.Visible = true;
            this.colEquipmentTypeGUID.VisibleIndex = 1;
            this.colEquipmentTypeGUID.Width = 119;
            // 
            // colIntParam
            // 
            this.colIntParam.Caption = "Целочисленное значение характеристики по умолчнию";
            this.colIntParam.FieldName = "IntParam";
            this.colIntParam.Name = "colIntParam";
            this.colIntParam.Visible = true;
            this.colIntParam.VisibleIndex = 2;
            this.colIntParam.Width = 107;
            // 
            // colStrParam
            // 
            this.colStrParam.Caption = "Строковое значение характеристики по умолчнию";
            this.colStrParam.FieldName = "StrParam";
            this.colStrParam.Name = "colStrParam";
            this.colStrParam.Visible = true;
            this.colStrParam.VisibleIndex = 3;
            this.colStrParam.Width = 90;
            // 
            // colDataParam
            // 
            this.colDataParam.Caption = "Датированное значение характеристики по умолчнию";
            this.colDataParam.FieldName = "DataParam";
            this.colDataParam.Name = "colDataParam";
            this.colDataParam.Visible = true;
            this.colDataParam.VisibleIndex = 7;
            this.colDataParam.Width = 99;
            // 
            // colBoolParam
            // 
            this.colBoolParam.Caption = "Логическое значение характеристики по умолчнию";
            this.colBoolParam.FieldName = "BoolParam";
            this.colBoolParam.Name = "colBoolParam";
            this.colBoolParam.Visible = true;
            this.colBoolParam.VisibleIndex = 4;
            this.colBoolParam.Width = 116;
            // 
            // colNumericParam
            // 
            this.colNumericParam.Caption = "Нумерованное значение характеристики по умолчнию";
            this.colNumericParam.FieldName = "NumericParam";
            this.colNumericParam.Name = "colNumericParam";
            this.colNumericParam.Visible = true;
            this.colNumericParam.VisibleIndex = 5;
            this.colNumericParam.Width = 138;
            // 
            // colNumericParam2
            // 
            this.colNumericParam2.Caption = "Дробное значение характеристики по умолчнию";
            this.colNumericParam2.FieldName = "NumericParam2";
            this.colNumericParam2.Name = "colNumericParam2";
            this.colNumericParam2.Visible = true;
            this.colNumericParam2.VisibleIndex = 6;
            this.colNumericParam2.Width = 163;
            // 
            // equipmentCharacterEquipmentTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentCharacterEquipmentTypeGridControl);
            this.Controls.Add(this.equipmentCharacterEquipmentTypeRibbonControl);
            this.Name = "equipmentCharacterEquipmentTypeUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.equipmentCharacterEquipmentTypeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterEquipmentTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentCharacterEquipmentTypeDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentCharacterEquipmentTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentCharacterEquipmentTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentTypeGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colIntParam;
        private DevExpress.XtraGrid.Columns.GridColumn colStrParam;
        private DevExpress.XtraGrid.Columns.GridColumn colDataParam;
        private DevExpress.XtraGrid.Columns.GridColumn colBoolParam;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl equipmentCharacterEquipmentTypeRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentCharacterGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumericParam;
        private DevExpress.XtraGrid.Columns.GridColumn colNumericParam2;
    }
}
