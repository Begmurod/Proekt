using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace SensorSet
{
    /// <summary>
    /// Класс для хранения настроек подключения  
    /// </summary> 
    /// 
    [Serializable]
    public class Configs
    {
        /// <summary>
        /// Имя пользователя
        /// </summary> 
        private string _NameUser;
        public string NameUser
        {
            get { return _NameUser; }
            set { _NameUser = value; }
        }

        /// <summary>
        /// Пароль пользователя
        /// </summary> 
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        /// <summary>
        /// Имя сервера баз данных
        /// </summary> 
        private string _NameServer;
        public string NameServer
        {
            get { return _NameServer; }
            set { _NameServer = value; }
        }

        /// <summary>
        /// Имя базы данных
        /// </summary> 
        private string _NameDB;
        public string NameDB
        {
            get { return _NameDB; }
            set { _NameDB = value; }
        }

        /// <summary>
        /// Время проверки подключения
        /// </summary> 
        private int _numTimedOut;
        public int numTimedOut
        {
            get { return _numTimedOut; }
            set { _numTimedOut = value; }
        }
        #region -- методы сериализации объектов

        /// <summary>
        /// Загрузить исходные данные в экземпляр объекта расчета 
        /// </summary>  
        /// <param name="NameFile">Имя файла для извлечения данных</param>
        public Configs LoadData(string FileName)
        {
            //string path = Application.UserAppDataPath.ToString() + @"\"; // путь, где будем искать конфигурационный файл .xml

            // Восстановить данные путем десериализации из XML-файла            
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            Configs _cf = (Configs)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _cf;
        }

        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="cf">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(Configs cf, string NameFile)
        {
            //string path = Application.UserAppDataPath.ToString() + @"\"; // путь, куда будем писать конфигурационный файл .xml

            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, cf);
            myStream.Close();
        }

        #endregion -- методы сериализации объектов
    }
}