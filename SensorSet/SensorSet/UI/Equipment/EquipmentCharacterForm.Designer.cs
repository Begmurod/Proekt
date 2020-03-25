namespace SensorSet.UI.Equipment
{
    partial class EquipmentCharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentCharacterForm));
            DevExpress.Xpo.DataViewProperty dataViewProperty1 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty2 = new DevExpress.Xpo.DataViewProperty();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.dimensionGUIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dimensionGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.fieldNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.characterNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.paramTypeTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGUIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.checkEdit);
            this.layoutControl1.Controls.Add(this.dimensionGUIDLookUpEdit);
            this.layoutControl1.Controls.Add(this.fieldNameTextEdit);
            this.layoutControl1.Controls.Add(this.characterNameTextEdit);
            this.layoutControl1.Controls.Add(this.paramTypeTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 225, 358, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(449, 170);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(327, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(203, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Сохранить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // checkEdit
            // 
            this.checkEdit.Location = new System.Drawing.Point(12, 84);
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.Properties.Caption = "Системная характеристика?";
            this.checkEdit.Size = new System.Drawing.Size(425, 19);
            this.checkEdit.StyleController = this.layoutControl1;
            this.checkEdit.TabIndex = 8;
            // 
            // dimensionGUIDLookUpEdit
            // 
            this.dimensionGUIDLookUpEdit.Location = new System.Drawing.Point(201, 60);
            this.dimensionGUIDLookUpEdit.Name = "dimensionGUIDLookUpEdit";
            this.dimensionGUIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dimensionGUIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Обозначение"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameEng", "Международное обозначение")});
            this.dimensionGUIDLookUpEdit.Properties.DataSource = this.dimensionGUIDDataView;
            this.dimensionGUIDLookUpEdit.Properties.DisplayMember = "Name";
            this.dimensionGUIDLookUpEdit.Properties.ValueMember = "GUID";
            this.dimensionGUIDLookUpEdit.Size = new System.Drawing.Size(236, 20);
            this.dimensionGUIDLookUpEdit.StyleController = this.layoutControl1;
            this.dimensionGUIDLookUpEdit.TabIndex = 6;
            // 
            // dimensionGUIDDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "Name";
            dataViewProperty2.ValueType = typeof(string);
            this.dimensionGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2});
            // 
            // fieldNameTextEdit
            // 
            this.fieldNameTextEdit.Location = new System.Drawing.Point(201, 36);
            this.fieldNameTextEdit.Name = "fieldNameTextEdit";
            this.fieldNameTextEdit.Size = new System.Drawing.Size(236, 20);
            this.fieldNameTextEdit.StyleController = this.layoutControl1;
            this.fieldNameTextEdit.TabIndex = 5;
            // 
            // characterNameTextEdit
            // 
            this.characterNameTextEdit.Location = new System.Drawing.Point(201, 12);
            this.characterNameTextEdit.Name = "characterNameTextEdit";
            this.characterNameTextEdit.Size = new System.Drawing.Size(236, 20);
            this.characterNameTextEdit.StyleController = this.layoutControl1;
            this.characterNameTextEdit.TabIndex = 4;
            // 
            // paramTypeTextEdit
            // 
            this.paramTypeTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.paramTypeTextEdit.Location = new System.Drawing.Point(201, 107);
            this.paramTypeTextEdit.Name = "paramTypeTextEdit";
            this.paramTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paramTypeTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.paramTypeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.paramTypeTextEdit.Size = new System.Drawing.Size(236, 20);
            this.paramTypeTextEdit.StyleController = this.layoutControl1;
            this.paramTypeTextEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(449, 170);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.characterNameTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem1.Text = "Название характеристики";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(186, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.fieldNameTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem2.Text = "Имя поля";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(186, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dimensionGUIDLookUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem3.Text = "Идентификатор единицы измерения";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(186, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(429, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.paramTypeTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem6.Text = "Тип данных параметра";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(186, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(191, 119);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(124, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(315, 119);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(114, 31);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 119);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(191, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // EquipmentCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 170);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EquipmentCharacterForm";
            this.Text = "Характеристики оборудования";
            this.Load += new System.EventHandler(this.EquipmentCharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGUIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.CheckEdit checkEdit;
        private DevExpress.XtraEditors.LookUpEdit dimensionGUIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit fieldNameTextEdit;
        private DevExpress.XtraEditors.TextEdit characterNameTextEdit;
        private DevExpress.XtraEditors.SpinEdit paramTypeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPDataView dimensionGUIDDataView;
    }
}