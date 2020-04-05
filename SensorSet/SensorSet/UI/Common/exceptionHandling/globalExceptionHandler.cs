using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;

namespace SensorSet.UI.Common.exceptionHandling
{
    public class globalExceptionHandler
    {
        public void OnThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = this.ShowThreadExceptionDialog(t.Exception);
            }
            catch
            {
                try
                {
                    XtraMessageBox.Show("Произошла критическая ошибка. \n Приложение будет закрыто.", "Произошла критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Application.Exit();
                }
            }

            //WebRequest request = WebRequest.Create("http://127.0.0.1/redmine/issues.xml");
            //// Set the Method property of the request to POST.
            //request.Method = "POST";
            //// Create POST data and convert it to a byte array.
            //string postData = string.Format(
            //    "<issue>" +
            //    "<subject>Ошибка: {0}</subject>" +
            //    "<description>Версия: {4}\r\nПользователь:{1}\r\nИсточник:{2}\r\nТрейс:\r\n{3}</description>" +
            //    "<project_id>asrk</project_id>" +
            //    "<priority_id>6</priority_id>" +
            //    "<tracker_id>1</tracker_id>" +
            //    "</issue>", t.Exception.Message, workSession.sessionSecurity.currentHost, t.Exception.Source, t.Exception.StackTrace.Substring(1,300)+"...", Properties.Settings.Default.currentVersion);

            //byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //// Set the ContentType property of the WebRequest.
            //request.ContentType = "application/xml";
            //// Set the ContentLength property of the WebRequest.
            //request.ContentLength = byteArray.Length;
            //// Get the request stream.
            //Stream dataStream = request.GetRequestStream();
            //// Write the data to the request stream.
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //// Close the Stream object.
            //dataStream.Close();

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        // Creates the error message and displays it.
        private DialogResult ShowThreadExceptionDialog(Exception e)
        {
            //log.databaseLog.initAndConfigLoggers();
            //log.databaseLog.applicationLog.ErrorException(e.Message, e);

            errorDialogForm eF = new errorDialogForm(e.Message, e.StackTrace);

            return eF.ShowDialog();
        }
    }
}
