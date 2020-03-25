namespace SensorSet.UI.Equipment
{
    partial class EquipmentTypeErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentTypeErrorForm));
            DevExpress.Xpo.DataViewProperty dataViewProperty1 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty2 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty3 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty4 = new DevExpress.Xpo.DataViewProperty();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.diapasonEndTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.equipmentTypeGUIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.EquipmentTypeGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.deltaTypeTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.deltaValuetextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diapasonBegintextEdit = new DevExpress.XtraEditors.TextEdit();
            this.measurandGUIDlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.MeasurandGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diapasonEndTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGUIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaValuetextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diapasonBegintextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurandGUIDlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurandGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.diapasonEndTextEdit);
            this.layoutControl1.Controls.Add(this.equipmentTypeGUIDLookUpEdit);
            this.layoutControl1.Controls.Add(this.deltaTypeTextEdit);
            this.layoutControl1.Controls.Add(this.deltaValuetextEdit);
            this.layoutControl1.Controls.Add(this.diapasonBegintextEdit);
            this.layoutControl1.Controls.Add(this.measurandGUIDlookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 225, 358, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(527, 195);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(401, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(276, 156);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Сохранить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // diapasonEndTextEdit
            // 
            this.diapasonEndTextEdit.Location = new System.Drawing.Point(275, 84);
            this.diapasonEndTextEdit.Name = "diapasonEndTextEdit";
            this.diapasonEndTextEdit.Size = new System.Drawing.Size(240, 20);
            this.diapasonEndTextEdit.StyleController = this.layoutControl1;
            this.diapasonEndTextEdit.TabIndex = 7;
            // 
            // equipmentTypeGUIDLookUpEdit
            // 
            this.equipmentTypeGUIDLookUpEdit.Location = new System.Drawing.Point(275, 12);
            this.equipmentTypeGUIDLookUpEdit.Name = "equipmentTypeGUIDLookUpEdit";
            this.equipmentTypeGUIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.equipmentTypeGUIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Обозначение"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameEng", "Международное обозначение")});
            this.equipmentTypeGUIDLookUpEdit.Properties.DataSource = this.EquipmentTypeGUIDDataView;
            this.equipmentTypeGUIDLookUpEdit.Properties.DisplayMember = "FullName";
            this.equipmentTypeGUIDLookUpEdit.Properties.ValueMember = "GUID";
            this.equipmentTypeGUIDLookUpEdit.Size = new System.Drawing.Size(240, 20);
            this.equipmentTypeGUIDLookUpEdit.StyleController = this.layoutControl1;
            this.equipmentTypeGUIDLookUpEdit.TabIndex = 6;
            // 
            // EquipmentTypeGUIDDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "FullName";
            dataViewProperty2.ValueType = typeof(string);
            this.EquipmentTypeGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2});
            // 
            // deltaTypeTextEdit
            // 
            this.deltaTypeTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.deltaTypeTextEdit.Location = new System.Drawing.Point(275, 132);
            this.deltaTypeTextEdit.Name = "deltaTypeTextEdit";
            this.deltaTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deltaTypeTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.deltaTypeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deltaTypeTextEdit.Size = new System.Drawing.Size(240, 20);
            this.deltaTypeTextEdit.StyleController = this.layoutControl1;
            this.deltaTypeTextEdit.TabIndex = 9;
            // 
            // deltaValuetextEdit
            // 
            this.deltaValuetextEdit.Location = new System.Drawing.Point(275, 108);
            this.deltaValuetextEdit.Name = "deltaValuetextEdit";
            this.deltaValuetextEdit.Size = new System.Drawing.Size(240, 20);
            this.deltaValuetextEdit.StyleController = this.layoutControl1;
            this.deltaValuetextEdit.TabIndex = 7;
            // 
            // diapasonBegintextEdit
            // 
            this.diapasonBegintextEdit.Location = new System.Drawing.Point(275, 60);
            this.diapasonBegintextEdit.Name = "diapasonBegintextEdit";
            this.diapasonBegintextEdit.Size = new System.Drawing.Size(240, 20);
            this.diapasonBegintextEdit.StyleController = this.layoutControl1;
            this.diapasonBegintextEdit.TabIndex = 7;
            // 
            // measurandGUIDlookUpEdit
            // 
            this.measurandGUIDlookUpEdit.Location = new System.Drawing.Point(275, 36);
            this.measurandGUIDlookUpEdit.Name = "measurandGUIDlookUpEdit";
            this.measurandGUIDlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.measurandGUIDlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Обозначение"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameEng", "Международное обозначение")});
            this.measurandGUIDlookUpEdit.Properties.DataSource = this.MeasurandGUIDDataView;
            this.measurandGUIDlookUpEdit.Properties.DisplayMember = "ValueName";
            this.measurandGUIDlookUpEdit.Properties.ValueMember = "GUID";
            this.measurandGUIDlookUpEdit.Size = new System.Drawing.Size(240, 20);
            this.measurandGUIDlookUpEdit.StyleController = this.layoutControl1;
            this.measurandGUIDlookUpEdit.TabIndex = 6;
            // 
            // MeasurandGUIDDataView
            // 
            dataViewProperty3.Name = "GUID";
            dataViewProperty3.ValueType = typeof(object);
            dataViewProperty4.Name = "ValueName";
            dataViewProperty4.ValueType = typeof(string);
            this.MeasurandGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty3,
            dataViewProperty4});
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem9,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(527, 195);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.equipmentTypeGUIDLookUpEdit;
            this.layoutControlItem3.CustomizationFormText = "Идентификатор типа оборудования";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem3.Text = "Идентификатор типа оборудования";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(260, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.diapasonEndTextEdit;
            this.layoutControlItem4.CustomizationFormText = "Конец диапазона измерения";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem4.Text = "Конец диапазона измерения";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(260, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.deltaTypeTextEdit;
            this.layoutControlItem6.CustomizationFormText = "Тип погрешности: 1-абсолютная, 0-относительная";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem6.Text = "Тип погрешности: 1-абсолютная, 0-относительная";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(260, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(264, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(125, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(389, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(118, 31);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(264, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.deltaValuetextEdit;
            this.layoutControlItem5.CustomizationFormText = "Величина погрешности";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem5.Text = "Величина погрешности";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(260, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.diapasonBegintextEdit;
            this.layoutControlItem9.CustomizationFormText = "Начало диапазона измерения";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem9.Text = "Начало диапазона измерения";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(260, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.measurandGUIDlookUpEdit;
            this.layoutControlItem1.CustomizationFormText = "Идентификатор измеряемой величины";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem1.Text = "Идентификатор измеряемой величины";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(260, 13);
            // 
            // EquipmentTypeErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 195);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EquipmentTypeErrorForm";
            this.Text = "Погрешность типа оборудования";
            this.Load += new System.EventHandler(this.EquipmentTypeErrorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diapasonEndTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGUIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaValuetextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diapasonBegintextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurandGUIDlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurandGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.TextEdit diapasonEndTextEdit;
        private DevExpress.XtraEditors.LookUpEdit equipmentTypeGUIDLookUpEdit;
        private DevExpress.XtraEditors.SpinEdit deltaTypeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPDataView EquipmentTypeGUIDDataView;
        private DevExpress.XtraEditors.TextEdit deltaValuetextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit diapasonBegintextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit measurandGUIDlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPDataView MeasurandGUIDDataView;
    }
}