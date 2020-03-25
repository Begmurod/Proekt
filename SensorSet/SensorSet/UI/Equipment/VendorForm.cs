using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using SensorSet.Model.SensorSet;

namespace SensorSet.UI.Equipment
{
    public partial class VendorForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentVendorGuid;

        private list_Vendor currentVendor;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public VendorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Здесь пока все в куче: поднятие/создание объекта, загрузка справочников для списков, настройка внешнего вида...
        /// </summary>
        void initForm()
        {
            if (edit)
            {
                currentVendor = uow.GetObjectByKey<list_Vendor>(currentVendorGuid);
            }
            else
            {
                currentVendor = new list_Vendor(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование производителя {0}", currentVendor.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр производителя {0}", currentVendor.Name);
                nameTextEdit.ReadOnly = true;
                countryTextEdit.ReadOnly = true;               
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion
            

            if (edit)
            {
                nameTextEdit.Text = currentVendor.Name;
                countryTextEdit.Text = currentVendor.CountryName;               
            }
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveVendor();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }

        void SaveVendor()
        {
            if (formValid)
            {
                currentVendor.Name = nameTextEdit.Text;
                currentVendor.CountryName = countryTextEdit.Text;
                
                if (edit)
                {
                    currentVendor.DateOfChange = DateTime.Now;
                    currentVendor.Save();
                }
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
        }
        /// <summary>
        /// Заполнение текущей единицы данными с формы
        /// </summary>
        void SaveDimension()
        {
            if (formValid)
            {
                currentVendor.Name = nameTextEdit.Text;
                currentVendor.CountryName = countryTextEdit.Text;
                
                if (edit)
                {
                    currentVendor.DateOfChange = DateTime.Now;
                    currentVendor.Save();
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
