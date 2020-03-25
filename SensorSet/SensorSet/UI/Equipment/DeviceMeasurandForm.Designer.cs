namespace SensorSet.UI.Equipment
{
    partial class DeviceMeasurandForm
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
            DevExpress.Xpo.DataViewProperty dataViewProperty1 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty2 = new DevExpress.Xpo.DataViewProperty();
            DevExpress.Xpo.DataViewProperty dataViewProperty3 = new DevExpress.Xpo.DataViewProperty();
            this.DeviceMeasurandDataView = new DevExpress.Xpo.XPDataView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceMeasurandDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceMeasurandDataView
            // 
            dataViewProperty1.Name = "GUID";
            dataViewProperty1.ValueType = typeof(object);
            dataViewProperty2.Name = "Name";
            dataViewProperty2.ValueType = typeof(string);
            dataViewProperty3.Name = "NameEng";
            dataViewProperty3.ValueType = typeof(string);
            this.DeviceMeasurandDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            dataViewProperty1,
            dataViewProperty2,
            dataViewProperty3});
            // 
            // DeviceMeasurandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DeviceMeasurandForm";
            this.Text = "DeviceMeasurandForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeviceMeasurandDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPDataView DeviceMeasurandDataView;
    }
}