namespace SensorSet.UI.Equipment
{
    partial class equipmentUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            DevExpress.Xpo.DataViewProperty dataViewProperty11 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty12 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty13 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty14 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty15 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty16 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty17 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty18 = new DevExpress.Xpo.DataViewProperty();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentUC));
            this.equipmentDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.equipmentRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equipmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentTypeGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentCategoryGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartUseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIpAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceCosta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseMonths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantyPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateModify = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventoryNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentKindGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "EquipmentTypeGUID";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "EquipmentCategoryGUID";
            dataViewProperty3.ValueType = typeof(string);
            dataViewProperty4.Name = "ParentGUID";
            dataViewProperty4.ValueType = typeof(string);
            dataViewProperty5.Name = "InventoryNumber";
            dataViewProperty5.ValueType = typeof(string);
            dataViewProperty6.Name = "SerialNumber";
            dataViewProperty6.ValueType = typeof(string);
            dataViewProperty7.Name = "ManufacturingDate";
            dataViewProperty7.ValueType = typeof(System.DateTime);
            dataViewProperty8.Name = "StartUseDate";
            dataViewProperty8.ValueType = typeof(System.DateTime);
            dataViewProperty9.Name = "IpAddress";
            dataViewProperty9.ValueType = typeof(string);
            dataViewProperty10.Name = "Port";
            dataViewProperty10.ValueType = typeof(string);
            dataViewProperty11.Name = "BalanceCosta";
            dataViewProperty11.ValueType = typeof(decimal);
            dataViewProperty12.Name = "UseMonths";
            dataViewProperty12.ValueType = typeof(int);
            dataViewProperty13.Name = "RemainingBalance";
            dataViewProperty13.ValueType = typeof(decimal);
            dataViewProperty14.Name = "GarantyPeriod";
            dataViewProperty14.ValueType = typeof(System.DateTime);
            dataViewProperty15.Name = "DateCreate";
            dataViewProperty15.ValueType = typeof(System.DateTime);
            dataViewProperty16.Name = "DateModify";
            dataViewProperty16.ValueType = typeof(System.DateTime);
            dataViewProperty17.Name = "EquipmentKindGUID";
            dataViewProperty17.ValueType = typeof(string);
            dataViewProperty18.Name = "DeletedData";
            dataViewProperty18.ValueType = typeof(System.DateTime);
            this.equipmentDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3,
            dataViewProperty4,
            dataViewProperty5,
            dataViewProperty6,
            dataViewProperty7,
            dataViewProperty8,
            dataViewProperty9,
            dataViewProperty10,
            dataViewProperty11,
            dataViewProperty12,
            dataViewProperty13,
            dataViewProperty14,
            dataViewProperty15,
            dataViewProperty16,
            dataViewProperty17,
            dataViewProperty18});
            // 
            // equipmentRibbonControl
            // 
            this.equipmentRibbonControl.ExpandCollapseItem.Id = 0;
            this.equipmentRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.equipmentRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.equipmentRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.equipmentRibbonControl.MaxItemId = 7;
            this.equipmentRibbonControl.Name = "equipmentRibbonControl";
            this.equipmentRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.equipmentRibbonControl.Size = new System.Drawing.Size(1019, 141);
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
            // equipmentGridControl
            // 
            this.equipmentGridControl.DataSource = this.equipmentDataView;
            this.equipmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentGridControl.Location = new System.Drawing.Point(0, 141);
            this.equipmentGridControl.MainView = this.equipmentGridView;
            this.equipmentGridControl.MenuManager = this.equipmentRibbonControl;
            this.equipmentGridControl.Name = "equipmentGridControl";
            this.equipmentGridControl.Size = new System.Drawing.Size(1019, 474);
            this.equipmentGridControl.TabIndex = 1;
            this.equipmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentGridView});
            // 
            // equipmentGridView
            // 
            this.equipmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colEquipmentTypeGUID,
            this.colEquipmentCategoryGUID,
            this.colParentGUID,
            this.colManufacturingDate,
            this.colSerialNumber,
            this.colStartUseDate,
            this.colIpAddress,
            this.colPort,
            this.colBalanceCosta,
            this.colUseMonths,
            this.colRemainingBalance,
            this.colGarantyPeriod,
            this.colDateModify,
            this.colInventoryNumber,
            this.colDateCreate,
            this.colDeletedDate,
            this.colEquipmentKindGUID});
            this.equipmentGridView.GridControl = this.equipmentGridControl;
            this.equipmentGridView.Name = "equipmentGridView";
            this.equipmentGridView.OptionsView.ShowFooter = true;
            this.equipmentGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.equipmentGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colEquipmentTypeGUID
            // 
            this.colEquipmentTypeGUID.Caption = "Тип оборудования";
            this.colEquipmentTypeGUID.FieldName = "EquipmentTypeGUID";
            this.colEquipmentTypeGUID.Name = "colEquipmentTypeGUID";
            this.colEquipmentTypeGUID.Visible = true;
            this.colEquipmentTypeGUID.VisibleIndex = 1;
            this.colEquipmentTypeGUID.Width = 71;
            // 
            // colEquipmentCategoryGUID
            // 
            this.colEquipmentCategoryGUID.Caption = "Характеристика";
            this.colEquipmentCategoryGUID.FieldName = "EquipmentCategoryGUID";
            this.colEquipmentCategoryGUID.Name = "colEquipmentCategoryGUID";
            this.colEquipmentCategoryGUID.Visible = true;
            this.colEquipmentCategoryGUID.VisibleIndex = 0;
            this.colEquipmentCategoryGUID.Width = 100;
            // 
            // colParentGUID
            // 
            this.colParentGUID.Caption = "Наименование вида оборудования";
            this.colParentGUID.FieldName = "ParentGUID";
            this.colParentGUID.Name = "colParentGUID";
            this.colParentGUID.Visible = true;
            this.colParentGUID.VisibleIndex = 2;
            this.colParentGUID.Width = 63;
            // 
            // colManufacturingDate
            // 
            this.colManufacturingDate.Caption = "Дата выпуска";
            this.colManufacturingDate.FieldName = "ManufacturingDate";
            this.colManufacturingDate.Name = "colManufacturingDate";
            this.colManufacturingDate.Visible = true;
            this.colManufacturingDate.VisibleIndex = 4;
            this.colManufacturingDate.Width = 69;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Заводской/серийный номер";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 7;
            this.colSerialNumber.Width = 60;
            // 
            // colStartUseDate
            // 
            this.colStartUseDate.Caption = "Дата ввода в эксплуатацию";
            this.colStartUseDate.FieldName = "StartUseDate";
            this.colStartUseDate.Name = "colStartUseDate";
            this.colStartUseDate.Visible = true;
            this.colStartUseDate.VisibleIndex = 5;
            this.colStartUseDate.Width = 82;
            // 
            // colIpAddress
            // 
            this.colIpAddress.Caption = "IP-адрес оборудования";
            this.colIpAddress.FieldName = "IpAddress";
            this.colIpAddress.Name = "colIpAddress";
            this.colIpAddress.Visible = true;
            this.colIpAddress.VisibleIndex = 6;
            this.colIpAddress.Width = 87;
            // 
            // colPort
            // 
            this.colPort.Caption = "Порт";
            this.colPort.FieldName = "Port";
            this.colPort.Name = "colPort";
            this.colPort.Visible = true;
            this.colPort.VisibleIndex = 8;
            this.colPort.Width = 44;
            // 
            // colBalanceCosta
            // 
            this.colBalanceCosta.Caption = "Балансовая стоимость";
            this.colBalanceCosta.FieldName = "BalanceCosta";
            this.colBalanceCosta.Name = "colBalanceCosta";
            this.colBalanceCosta.Visible = true;
            this.colBalanceCosta.VisibleIndex = 9;
            this.colBalanceCosta.Width = 44;
            // 
            // colUseMonths
            // 
            this.colUseMonths.Caption = "Срок полезного использования";
            this.colUseMonths.FieldName = "UseMonths";
            this.colUseMonths.Name = "colUseMonths";
            this.colUseMonths.Visible = true;
            this.colUseMonths.VisibleIndex = 10;
            this.colUseMonths.Width = 44;
            // 
            // colRemainingBalance
            // 
            this.colRemainingBalance.Caption = "Остаточная стоимость";
            this.colRemainingBalance.FieldName = "RemainingBalance";
            this.colRemainingBalance.Name = "colRemainingBalance";
            this.colRemainingBalance.Visible = true;
            this.colRemainingBalance.VisibleIndex = 11;
            this.colRemainingBalance.Width = 44;
            // 
            // colGarantyPeriod
            // 
            this.colGarantyPeriod.Caption = "Срок гарантии";
            this.colGarantyPeriod.FieldName = "GarantyPeriod";
            this.colGarantyPeriod.Name = "colGarantyPeriod";
            this.colGarantyPeriod.Visible = true;
            this.colGarantyPeriod.VisibleIndex = 12;
            this.colGarantyPeriod.Width = 44;
            // 
            // colDateModify
            // 
            this.colDateModify.Caption = "Дата последнего изменения записи";
            this.colDateModify.FieldName = "DateModify";
            this.colDateModify.Name = "colDateModify";
            this.colDateModify.Visible = true;
            this.colDateModify.VisibleIndex = 14;
            this.colDateModify.Width = 48;
            // 
            // colInventoryNumber
            // 
            this.colInventoryNumber.Caption = "Инвентарный номер";
            this.colInventoryNumber.FieldName = "InventoryNumber";
            this.colInventoryNumber.Name = "colInventoryNumber";
            this.colInventoryNumber.Visible = true;
            this.colInventoryNumber.VisibleIndex = 3;
            this.colInventoryNumber.Width = 53;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Дата внесения записи";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 13;
            this.colDateCreate.Width = 72;
            // 
            // colDeletedDate
            // 
            this.colDeletedDate.Caption = "Дата удаления (флаг)";
            this.colDeletedDate.FieldName = "DeletedDate";
            this.colDeletedDate.Name = "colDeletedDate";
            this.colDeletedDate.Width = 32;
            // 
            // colEquipmentKindGUID
            // 
            this.colEquipmentKindGUID.Caption = "gridColumn1";
            this.colEquipmentKindGUID.FieldName = "EquipmentKindGUID";
            this.colEquipmentKindGUID.Name = "colEquipmentKindGUID";
            // 
            // equipmentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentGridControl);
            this.Controls.Add(this.equipmentRibbonControl);
            this.Name = "equipmentUC";
            this.Size = new System.Drawing.Size(1019, 615);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView equipmentDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl equipmentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentTypeGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colParentGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturingDate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl equipmentRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentCategoryGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colStartUseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIpAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPort;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceCosta;
        private DevExpress.XtraGrid.Columns.GridColumn colUseMonths;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantyPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateModify;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentKindGUID;
    }
}
