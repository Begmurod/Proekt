namespace SensorSet.UI.Equipment
{
    partial class equipmentCharacterParamUC
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
            DevExpress.Xpo.DataViewProperty dataViewProperty10 = new DevExpress.Xpo.DataViewProperty();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentCharacterParamUC));
            this.equipmentCharacterParamDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.equipmentCharacterParamRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentCharacterParamGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentCharacterParamGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentCharacterGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStrParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoolParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumericParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumericParam2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentCharacterParamDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "EquipmentCharacterGUID";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "EquipmentGUID";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "IntParam";
            dataViewProperty4.ValueType = typeof(long);
            dataViewProperty5.Name = "StrParam";
            dataViewProperty5.ValueType = typeof(string);
            dataViewProperty6.Name = "BoolParam";
            dataViewProperty6.ValueType = typeof(bool);
            dataViewProperty7.Name = "NumericParam";
            dataViewProperty7.ValueType = typeof(long);
            dataViewProperty8.Name = "NumericParam2";
            dataViewProperty8.ValueType = typeof(double);
            dataViewProperty9.Name = "DataParam";
            dataViewProperty9.ValueType = typeof(System.DateTime);
            dataViewProperty10.Name = "DeletedDate";
            dataViewProperty10.ValueType = typeof(System.DateTime);
            this.equipmentCharacterParamDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6,
            dataViewProperty7,
            dataViewProperty8,
            dataViewProperty9,
            dataViewProperty10});
            // 
            // equipmentCharacterParamRibbonControl
            // 
            this.equipmentCharacterParamRibbonControl.ExpandCollapseItem.Id = 0;
            this.equipmentCharacterParamRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.equipmentCharacterParamRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.equipmentCharacterParamRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.equipmentCharacterParamRibbonControl.MaxItemId = 7;
            this.equipmentCharacterParamRibbonControl.Name = "equipmentCharacterParamRibbonControl";
            this.equipmentCharacterParamRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.equipmentCharacterParamRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            // equipmentCharacterParamGridControl
            // 
            this.equipmentCharacterParamGridControl.DataSource = this.equipmentCharacterParamDataView;
            this.equipmentCharacterParamGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentCharacterParamGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentCharacterParamGridControl.MainView = this.equipmentCharacterParamGridView;
            this.equipmentCharacterParamGridControl.MenuManager = this.equipmentCharacterParamRibbonControl;
            this.equipmentCharacterParamGridControl.Name = "equipmentCharacterParamGridControl";
            this.equipmentCharacterParamGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentCharacterParamGridControl.TabIndex = 1;
            this.equipmentCharacterParamGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentCharacterParamGridView});
            // 
            // equipmentCharacterParamGridView
            // 
            this.equipmentCharacterParamGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colEquipmentCharacterGUID,
            this.colEquipmentGUID,
            this.colIntParam,
            this.colStrParam,
            this.colDataParam,
            this.colBoolParam,
            this.colNumericParam,
            this.colNumericParam2});
            this.equipmentCharacterParamGridView.GridControl = this.equipmentCharacterParamGridControl;
            this.equipmentCharacterParamGridView.Name = "equipmentCharacterParamGridView";
            this.equipmentCharacterParamGridView.OptionsView.ShowFooter = true;
            this.equipmentCharacterParamGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.equipmentCharacterParamGridView_FocusedRowChanged);
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
            // colEquipmentGUID
            // 
            this.colEquipmentGUID.Caption = "Идентификатор экземпляра оборудования";
            this.colEquipmentGUID.FieldName = "EquipmentGUID";
            this.colEquipmentGUID.Name = "colEquipmentGUID";
            this.colEquipmentGUID.Visible = true;
            this.colEquipmentGUID.VisibleIndex = 1;
            this.colEquipmentGUID.Width = 119;
            // 
            // colIntParam
            // 
            this.colIntParam.Caption = "Целочисленное значение характеристики";
            this.colIntParam.FieldName = "IntParam";
            this.colIntParam.Name = "colIntParam";
            this.colIntParam.Visible = true;
            this.colIntParam.VisibleIndex = 2;
            this.colIntParam.Width = 107;
            // 
            // colStrParam
            // 
            this.colStrParam.Caption = "Строковое значение характеристики";
            this.colStrParam.FieldName = "StrParam";
            this.colStrParam.Name = "colStrParam";
            this.colStrParam.Visible = true;
            this.colStrParam.VisibleIndex = 3;
            this.colStrParam.Width = 90;
            // 
            // colDataParam
            // 
            this.colDataParam.Caption = "Датированное значение характеристики";
            this.colDataParam.FieldName = "DataParam";
            this.colDataParam.Name = "colDataParam";
            this.colDataParam.Visible = true;
            this.colDataParam.VisibleIndex = 7;
            this.colDataParam.Width = 99;
            // 
            // colBoolParam
            // 
            this.colBoolParam.Caption = "Логическое значение характеристики";
            this.colBoolParam.FieldName = "BoolParam";
            this.colBoolParam.Name = "colBoolParam";
            this.colBoolParam.Visible = true;
            this.colBoolParam.VisibleIndex = 4;
            this.colBoolParam.Width = 116;
            // 
            // colNumericParam
            // 
            this.colNumericParam.Caption = "Нумерованное значение характеристики";
            this.colNumericParam.FieldName = "NumericParam";
            this.colNumericParam.Name = "colNumericParam";
            this.colNumericParam.Visible = true;
            this.colNumericParam.VisibleIndex = 5;
            this.colNumericParam.Width = 138;
            // 
            // colNumericParam2
            // 
            this.colNumericParam2.Caption = "Дробное значение характеристики";
            this.colNumericParam2.FieldName = "NumericParam2";
            this.colNumericParam2.Name = "colNumericParam2";
            this.colNumericParam2.Visible = true;
            this.colNumericParam2.VisibleIndex = 6;
            this.colNumericParam2.Width = 163;
            // 
            // equipmentCharacterParamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentCharacterParamGridControl);
            this.Controls.Add(this.equipmentCharacterParamRibbonControl);
            this.Name = "equipmentCharacterParamUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.equipmentCharacterParamUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCharacterParamGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentCharacterParamDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentCharacterParamGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentCharacterParamGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colIntParam;
        private DevExpress.XtraGrid.Columns.GridColumn colStrParam;
        private DevExpress.XtraGrid.Columns.GridColumn colDataParam;
        private DevExpress.XtraGrid.Columns.GridColumn colBoolParam;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl equipmentCharacterParamRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentCharacterGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumericParam;
        private DevExpress.XtraGrid.Columns.GridColumn colNumericParam2;
    }
}
