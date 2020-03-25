using DevExpress.Xpo;
using SensorSet.Model.SensorSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorSet.UI.Equipment
{
    public partial class DeviceEquipmentCategoryForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentDeviceEquipmentCategoryGuid;

        private device_EquipmentCategory currentDeviceEquipmentCategory;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public DeviceEquipmentCategoryForm()
        {
            InitializeComponent();
        }
        private void DeviceEquipmentCategoryForm_Load(object sender, EventArgs e)
        {
            initForm();
        }
        /// <summary>
        /// Здесь пока все в куче: поднятие/создание объекта, загрузка справочников для списков, настройка внешнего вида...
        /// </summary>
        void initForm()
        {
            if (edit)
            {
                currentDeviceEquipmentCategory = uow.GetObjectByKey<device_EquipmentCategory>(currentDeviceEquipmentCategoryGuid);
            }
            else
            {
                currentDeviceEquipmentCategory = new device_EquipmentCategory(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование категории оборудования {0}", currentDeviceEquipmentCategory.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр категории оборудования {0}", currentDeviceEquipmentCategory.Name);
                nameTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                nameTextEdit.Text = currentDeviceEquipmentCategory.Name;
            }
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SavetDeviceEquipmentCategory();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        void SavetDeviceEquipmentCategory()
        {
            if (formValid)
            {
                currentDeviceEquipmentCategory.Name = nameTextEdit.Text;

                if (edit)
                {
                    currentDeviceEquipmentCategory.DateOfChange = DateTime.Now;
                    currentDeviceEquipmentCategory.Save();
                }
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
        }
        void SaveDimension()
        {
            if (formValid)
            {
                currentDeviceEquipmentCategory.Name = nameTextEdit.Text;

                if (edit)
                {
                    currentDeviceEquipmentCategory.DateOfChange = DateTime.Now;
                    currentDeviceEquipmentCategory.Save();
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
