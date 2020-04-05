using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.XtraSplashScreen;

namespace SensorSet.UI.Common.exceptionHandling
{
    public partial class errorDialogForm : DevExpress.XtraEditors.XtraForm
    {
        public errorDialogForm(string ErrorMessage, string StackTrace, string header = null)
        {
            InitializeComponent();

            labelControl1.Text = ErrorMessage;
            memoEdit1.Text = ErrorMessage + "\r\n" + StackTrace;

            if (header != null)
            {
                Text = header;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string mailto = string.Format("mailto:isrk.support@urfc.ru?subject=\"{0} {1}\"", "Ошибка приложения", labelControl1.Text);
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = mailto;
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.RedirectStandardOutput = false;
            myProcess.Start();
        }

        private void errorDialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SplashScreenManager.CloseForm();
            }
            catch (Exception e1)
            {

            }
        }
    }
}
