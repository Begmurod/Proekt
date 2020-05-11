using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorSet
{
    public partial class RegForm : Form
    {// Переменные уровня модуля для подключения к источнику данных
        private SqlConnectionStringBuilder scBuild = new SqlConnectionStringBuilder();

        // Объект для хранения конфигурационных настроек пожкдючения к серверу БД
        public Configs cf = new Configs();
        public RegForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            Configs cff = new Configs();

            //где будем искать конфигурационный файл .xml
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\configs.xml");

            if (fileDefaultUserAppDataPath.Exists)
            {
                this.cf = cff.LoadData(fileDefaultUserAppDataPath.ToString());
            }
            else
            {
                // Начальные настройки при первоначальной загрузке окна регистрации
                cf.NameUser = "SensorUser";
                cf.Password = "1";
                cf.NameServer = @".\";
                cf.NameDB = "SensorSet";
                cf.numTimedOut = 20;

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                cf.SaveData(cf, fileDefaultUserAppDataPath.ToString());
            }

            // Начальные настройки при первоначальной загрузке окна регистрации
            this.txtNameUser.Text = cf.NameUser.ToString();
            this.txtPassword.Text = cf.Password.ToString();
            this.txtNameServer.Text = cf.NameServer.ToString();
            this.txtNameDB.Text = cf.NameDB.ToString();
            this.numTimedOut.Value = cf.numTimedOut;
        }
        // Проверка наименования провайдера:
        //  если полученная строка ссылается на microsoft.jet.oledb, то метод возвращает объект OleDbConnection,
        //  в противном случае возвращает ссылку на объект MS SQL Server (SqlConnection) 
        IDbConnection CreateConnection(string connString)
        {
            if (connString.ToLower().IndexOf("microsoft.jet.oledb") > -1)
            {
                return new OleDbConnection(connString);     // MS Access
            }
            else
            {
                return new SqlConnection(connString);       // MS SQL Server
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Apply();

            this.statusStrip1.Visible = true;
            this.tsStatusLabel.Text = "Попытка подключения к источнику данных... Подождите!";
            this.statusStrip1.Refresh();

            // Проверить тест на подключение к источнику данных: 
            //      если тест успешный, то показать главную форму и скрыть форму регистрации,
            //      если тест неудачный, то показать ошибку
            if (TestConnect())
            {
                cf.NameUser = this.txtNameUser.Text.ToString().Trim();
                cf.Password = this.txtPassword.Text.ToString().Trim();
                cf.NameServer = this.txtNameServer.Text.ToString().Trim();
                cf.NameDB = this.txtNameDB.Text.ToString().Trim();
                cf.numTimedOut = (int)this.numTimedOut.Value;

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                cf.SaveData(cf, Application.UserAppDataPath.ToString() + @"\\configs.xml");
                mainForm Af = new mainForm();
                Af.ShowDialog();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string strMsgMessage = "Внимание!" + "\n" + "Ошибка при подключении к источнику данных!";
                MessageBox.Show(strMsgMessage, "Ошибка", buttons, MessageBoxIcon.Error);
            }
        }
        // Нажатие кнопки "Отмена" в окне регистрации - выход из программы
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Apply();

            tsStatusLabel.Visible = true;

            if (TestConnect())
            {
                tsStatusLabel.Text = "Успешно проверено!";
                tsStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                tsStatusLabel.Text = "Ошибка";
                tsStatusLabel.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// Применить введеные настройки
        /// </summary>
        private void Apply()
        {
            scBuild.UserID = this.txtNameUser.Text.Trim();
            scBuild.Password = this.txtPassword.Text.Trim();
            scBuild.DataSource = this.txtNameServer.Text.Trim();
            scBuild.InitialCatalog = this.txtNameDB.Text.Trim();
            scBuild.ConnectTimeout = (int)numTimedOut.Value;

            scBuild.IntegratedSecurity = false;
        }

        /// <summary>
        /// Проверка возможности подключения к базе данных
        /// </summary>
        /// <returns>есть или нет соединение</returns>
        private bool TestConnect()
        {
            IDbConnection cn = CreateConnection(scBuild.ConnectionString);
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception exc)
            {
                //System.Diagnostics.Debug.Print(exc.Message);
                MessageBox.Show(exc.Message, "Ошибка");
                return false;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Возвращается строка соединения
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return scBuild.ConnectionString;
            }
        }

        /// <summary>
        /// Логин подключенного пользователя
        /// </summary>
        public string UserID
        {
            get
            {
                return scBuild.UserID;
            }
        }
    }
}
