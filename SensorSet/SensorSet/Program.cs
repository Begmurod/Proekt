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

namespace SensorSet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = new CultureInfo("ru-RU");

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            try
            {
                XpoDefault.Session = null;
                XpoDefault.DataLayer = new SimpleDataLayer(new DataCacheNode(new DataCacheRoot(XpoDefault.GetConnectionProvider(@"XpoProvider=MSSqlServer;data source=DESKTOP-4RTHTBS\SQLEXPRESS;
                    integrated security=false;initial catalog=SensorSet;User Id=begmurod;Password=1", AutoCreateOption.None))));
                //XpoDefault.DataLayer = new SimpleDataLayer(new DataCacheNode(new DataCacheRoot(XpoDefault.GetConnectionProvider(@"XpoProvider=MSSqlServer;data source=.\SQLEXPRESS;user id=begmurod;password=1;
                //    integrated security=true;initial catalog=SensorSet", AutoCreateOption.None))));
            }
            catch(Exception e)
            {
                throw (e);
            }

            Application.Run(new mainForm());            
        }
    }
}
