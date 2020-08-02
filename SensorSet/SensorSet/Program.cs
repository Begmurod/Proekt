using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Globalization;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using SensorSet.UI.Common.exceptionHandling;
using System.Threading;

namespace SensorSet
{
    static class Program
    {
        public static string ExampleDBConnectionString = "Data Source=localhost;Initial Catalog=SensorSet;Integrated Security=False";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            globalExceptionHandler eh = new globalExceptionHandler();
            // Adds the event handler to to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(eh.OnThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = new CultureInfo("ru-RU");

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            try
            {
                XpoDefault.Session = null;
                XpoDefault.DataLayer = new SimpleDataLayer(new DataCacheNode(new DataCacheRoot(XpoDefault.GetConnectionProvider(Properties.Settings.Default.ConnectionString, AutoCreateOption.None))));
            }
            catch(Exception e)
            {
                throw (e);
            }

            Application.Run(new mainForm());   
            
        }
    }
}
