namespace SensorSet.UI.Equipment
{
    partial class EquipmentTypeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentTypeForm));
            DevExpress.Xpo.DataViewProperty dataViewProperty1 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty2 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty3 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty4 = new DevExpress.Xpo.DataViewProperty();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.equipmentKindGUIDUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.EquipmentKindGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.equipmentVendorGUIDlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.EquipmentVendorGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.fullNametextEdit = new DevExpress.XtraEditors.TextEdit();
            this.changedUserIDtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentKindGUIDUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentKindGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentVendorGUIDlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentVendorGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNametextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedUserIDtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.equipmentKindGUIDUpEdit);
            this.layoutControl1.Controls.Add(this.nameTextEdit);
            this.layoutControl1.Controls.Add(this.equipmentVendorGUIDlookUpEdit);
            this.layoutControl1.Controls.Add(this.fullNametextEdit);
            this.layoutControl1.Controls.Add(this.changedUserIDtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 225, 358, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(490, 170);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Appearance.Options.UseForeColor = true;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(373, 132);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(256, 132);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Сохранить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equipmentKindGUIDUpEdit
            // 
            this.equipmentKindGUIDUpEdit.Location = new System.Drawing.Point(254, 36);
            this.equipmentKindGUIDUpEdit.Name = "equipmentKindGUIDUpEdit";
            this.equipmentKindGUIDUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.equipmentKindGUIDUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование вида оборудования")});
            this.equipmentKindGUIDUpEdit.Properties.DataSource = this.EquipmentKindGUIDDataView;
            this.equipmentKindGUIDUpEdit.Properties.DisplayMember = "Name";
            this.equipmentKindGUIDUpEdit.Properties.ValueMember = "GUID";
            this.equipmentKindGUIDUpEdit.Size = new System.Drawing.Size(224, 20);
            this.equipmentKindGUIDUpEdit.StyleController = this.layoutControl1;
            this.equipmentKindGUIDUpEdit.TabIndex = 6;
            // 
            // EquipmentKindGUIDDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "Name";
            dataViewProperty2.ValueType = typeof(string);
            this.EquipmentKindGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2});
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(254, 60);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(224, 20);
            this.nameTextEdit.StyleController = this.layoutControl1;
            this.nameTextEdit.TabIndex = 4;
            // 
            // equipmentVendorGUIDlookUpEdit
            // 
            this.equipmentVendorGUIDlookUpEdit.Location = new System.Drawing.Point(254, 12);
            this.equipmentVendorGUIDlookUpEdit.Name = "equipmentVendorGUIDlookUpEdit";
            this.equipmentVendorGUIDlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.equipmentVendorGUIDlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название производителя")});
            this.equipmentVendorGUIDlookUpEdit.Properties.DataSource = this.EquipmentVendorGUIDDataView;
            this.equipmentVendorGUIDlookUpEdit.Properties.DisplayMember = "Name";
            this.equipmentVendorGUIDlookUpEdit.Properties.ValueMember = "GUID";
            this.equipmentVendorGUIDlookUpEdit.Size = new System.Drawing.Size(224, 20);
            this.equipmentVendorGUIDlookUpEdit.StyleController = this.layoutControl1;
            this.equipmentVendorGUIDlookUpEdit.TabIndex = 6;
            // 
            // EquipmentVendorGUIDDataView
            // 
            dataViewProperty3.Name = "GUID";
            dataViewProperty3.ValueType = typeof(object);
            dataViewProperty4.Name = "Name";
            dataViewProperty4.ValueType = typeof(string);
            this.EquipmentVendorGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty3,
            dataViewProperty4});
            // 
            // fullNametextEdit
            // 
            this.fullNametextEdit.Location = new System.Drawing.Point(254, 84);
            this.fullNametextEdit.Name = "fullNametextEdit";
            this.fullNametextEdit.Size = new System.Drawing.Size(224, 20);
            this.fullNametextEdit.StyleController = this.layoutControl1;
            this.fullNametextEdit.TabIndex = 7;
            // 
            // changedUserIDtextEdit
            // 
            this.changedUserIDtextEdit.Location = new System.Drawing.Point(254, 108);
            this.changedUserIDtextEdit.Name = "changedUserIDtextEdit";
            this.changedUserIDtextEdit.Size = new System.Drawing.Size(224, 20);
            this.changedUserIDtextEdit.StyleController = this.layoutControl1;
            this.changedUserIDtextEdit.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(490, 170);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(244, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(117, 30);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(361, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(109, 30);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(244, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.changedUserIDtextEdit;
            this.layoutControlItem6.CustomizationFormText = "Описание типа обородования";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItem6.Text = "Описание типа обородования";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(239, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.fullNametextEdit;
            this.layoutControlItem2.CustomizationFormText = "Полное наименование типа";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItem2.Text = "Полное наименование типа";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(239, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.equipmentVendorGUIDlookUpEdit;
            this.layoutControlItem5.CustomizationFormText = "Идентификатор производителя оборудования";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItem5.Text = "Идентификатор производителя оборудования";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(239, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.equipmentKindGUIDUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItem3.Text = "Идентификатор вида устройства";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(239, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nameTextEdit;
            this.layoutControlItem1.CustomizationFormText = "Краткое наименование типа";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItem1.Text = "Краткое наименование типа";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(239, 13);
            // 
            // EquipmentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 170);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EquipmentTypeForm";
            this.Text = "Тип Оборудования";
            this.Load += new System.EventHandler(this.EquipmentTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentKindGUIDUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentKindGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentVendorGUIDlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentVendorGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNametextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedUserIDtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.LookUpEdit equipmentKindGUIDUpEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit equipmentVendorGUIDlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit fullNametextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit changedUserIDtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.Xpo.XPDataView EquipmentVendorGUIDDataView;
        private DevExpress.Xpo.XPDataView EquipmentKindGUIDDataView;
    }
}