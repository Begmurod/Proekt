using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorSet
{
    public partial class Form2 : Form
    {
        private Timer timer;
        private ToolStripProgressBar progress;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SensorSetDataSet1.Equipment". При необходимости она может быть перемещена или удалена.
            this.EquipmentTableAdapter.Fill(this.SensorSetDataSet1.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SensorSetDataSet.Dimension". При необходимости она может быть перемещена или удалена.
            this.DimensionTableAdapter.Fill(this.SensorSetDataSet.Dimension);

            this.reportViewer1.RefreshReport();
        }
        public Form2(Timer tmr, ToolStripProgressBar progr, List<ReportParameter> lstParam) //перегружаю конструктор
        {
            InitializeComponent();
            progress = progr;
            timer = tmr;
            try
            {
                reportViewer1.LocalReport.SetParameters(lstParam);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            //timer.Enabled = false;
            //progress.Value = progress.Maximum;
        }
    }
}
