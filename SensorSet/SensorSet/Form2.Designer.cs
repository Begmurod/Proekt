namespace SensorSet
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SensorSetDataSet = new SensorSet.SensorSetDataSet();
            this.DimensionBindingSource = new System.Windows.Forms.BindingSource();
            this.DimensionTableAdapter = new SensorSet.SensorSetDataSetTableAdapters.DimensionTableAdapter();
            this.SensorSetDataSet1 = new SensorSet.SensorSetDataSet1();
            this.EquipmentBindingSource = new System.Windows.Forms.BindingSource();
            this.EquipmentTableAdapter = new SensorSet.SensorSetDataSet1TableAdapters.EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SensorSetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorSetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DimensionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SensorSet.ReportEq.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // SensorSetDataSet
            // 
            this.SensorSetDataSet.DataSetName = "SensorSetDataSet";
            this.SensorSetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DimensionBindingSource
            // 
            this.DimensionBindingSource.DataMember = "Dimension";
            this.DimensionBindingSource.DataSource = this.SensorSetDataSet;
            // 
            // DimensionTableAdapter
            // 
            this.DimensionTableAdapter.ClearBeforeFill = true;
            // 
            // SensorSetDataSet1
            // 
            this.SensorSetDataSet1.DataSetName = "SensorSetDataSet1";
            this.SensorSetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EquipmentBindingSource
            // 
            this.EquipmentBindingSource.DataMember = "Equipment";
            this.EquipmentBindingSource.DataSource = this.SensorSetDataSet1;
            // 
            // EquipmentTableAdapter
            // 
            this.EquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SensorSetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorSetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DimensionBindingSource;
        private SensorSetDataSet SensorSetDataSet;
        private SensorSetDataSetTableAdapters.DimensionTableAdapter DimensionTableAdapter;
        private System.Windows.Forms.BindingSource EquipmentBindingSource;
        private SensorSetDataSet1 SensorSetDataSet1;
        private SensorSetDataSet1TableAdapters.EquipmentTableAdapter EquipmentTableAdapter;
    }
}