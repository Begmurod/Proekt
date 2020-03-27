namespace SensorSet.UI.Equipment
{
    partial class DimensionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DimensionForm));
            DevExpress.Xpo.DataViewProperty dataViewProperty1 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty2 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty3 = new DevExpress.Xpo.DataViewProperty();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.koefTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.baseNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dimensionDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.nameEngTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.digitTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koefTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEngTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.koefTextEdit);
            this.layoutControl1.Controls.Add(this.baseNameLookUpEdit);
            this.layoutControl1.Controls.Add(this.nameEngTextEdit);
            this.layoutControl1.Controls.Add(this.nameTextEdit);
            this.layoutControl1.Controls.Add(this.digitTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 225, 358, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(465, 191);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(354, 155);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(244, 155);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Сохранить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // checkEdit
            // 
            this.checkEdit.Location = new System.Drawing.Point(12, 108);
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.Properties.Caption = "Отображать в интерфейсе по-умолчанию";
            this.checkEdit.Size = new System.Drawing.Size(441, 19);
            this.checkEdit.StyleController = this.layoutControl1;
            this.checkEdit.TabIndex = 8;
            // 
            // koefTextEdit
            // 
            this.koefTextEdit.Location = new System.Drawing.Point(239, 84);
            this.koefTextEdit.Name = "koefTextEdit";
            this.koefTextEdit.Size = new System.Drawing.Size(214, 20);
            this.koefTextEdit.StyleController = this.layoutControl1;
            this.koefTextEdit.TabIndex = 7;
            // 
            // baseNameLookUpEdit
            // 
            this.baseNameLookUpEdit.Location = new System.Drawing.Point(239, 60);
            this.baseNameLookUpEdit.Name = "baseNameLookUpEdit";
            this.baseNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baseNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Обозначение"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameEng", "Международное обозначение")});
            this.baseNameLookUpEdit.Properties.DataSource = this.dimensionDataView;
            this.baseNameLookUpEdit.Properties.DisplayMember = "Name";
            this.baseNameLookUpEdit.Properties.ValueMember = "GUID";
            this.baseNameLookUpEdit.Size = new System.Drawing.Size(214, 20);
            this.baseNameLookUpEdit.StyleController = this.layoutControl1;
            this.baseNameLookUpEdit.TabIndex = 6;
            // 
            // dimensionDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "Name";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "NameEng";
            dataViewProperty3.ValueType = typeof(string);
            this.dimensionDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3});
            // 
            // nameEngTextEdit
            // 
            this.nameEngTextEdit.Location = new System.Drawing.Point(239, 36);
            this.nameEngTextEdit.Name = "nameEngTextEdit";
            this.nameEngTextEdit.Size = new System.Drawing.Size(214, 20);
            this.nameEngTextEdit.StyleController = this.layoutControl1;
            this.nameEngTextEdit.TabIndex = 5;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(239, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(214, 20);
            this.nameTextEdit.StyleController = this.layoutControl1;
            this.nameTextEdit.TabIndex = 4;
            // 
            // digitTextEdit
            // 
            this.digitTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitTextEdit.Location = new System.Drawing.Point(239, 131);
            this.digitTextEdit.Name = "digitTextEdit";
            this.digitTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.digitTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.digitTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.digitTextEdit.Size = new System.Drawing.Size(214, 20);
            this.digitTextEdit.StyleController = this.layoutControl1;
            this.digitTextEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(465, 191);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nameTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem1.Text = "Обозначение";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(224, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.nameEngTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem2.Text = "Международное обозначение";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(224, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.baseNameLookUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem3.Text = "Базовая единица";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(224, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.koefTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem4.Text = "Коэффициент перевода в базовую единицу";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(224, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(445, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.digitTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem6.Text = "Кол-во знаков после запятой";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(224, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(232, 143);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(110, 28);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(342, 143);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(103, 28);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 143);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(232, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // DimensionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 191);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DimensionForm";
            this.Text = "Единица измерения";
            this.Load += new System.EventHandler(this.DimensionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koefTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEngTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit koefTextEdit;
        private DevExpress.XtraEditors.LookUpEdit baseNameLookUpEdit;
        private DevExpress.XtraEditors.TextEdit nameEngTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.SpinEdit digitTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPDataView dimensionDataView;
    }
}