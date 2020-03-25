using DevExpress.Xpo;
using DevExpress.Xpo.DB;
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
    public partial class DeviceEquipmentKindForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentKindGuid;

        private device_EquipmentKind currentEquipmentKind;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public DeviceEquipmentKindForm()
        {
            InitializeComponent();
        }
        public DeviceEquipmentKindForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void DeviceEquipmentKindForm_Load(object sender, EventArgs e)
        {
            initForm();
        }
        void initForm()
        {
            if (edit)
            {
                currentEquipmentKind = uow.GetObjectByKey<device_EquipmentKind>(currentEquipmentKindGuid);
            }
            else
            {
                currentEquipmentKind = new device_EquipmentKind(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование вида устройств {0}", currentEquipmentKind.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр вида устройств {0} ", currentEquipmentKind.Name);
                nameTextEdit.ReadOnly = true;
               
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData deviceEquipmentKindParentData = u.ExecuteQuery(@"SELECT GUID, Name FROM [device].[EquipmentKind] WHERE[DeletedDate] is null");
                deviceEquipmentKindDataView.LoadData(deviceEquipmentKindParentData);

            }
            #endregion

            if (edit)
            {
                nameTextEdit.Text = currentEquipmentKind.Name;
                //if (currentEquipmentKind.ShowInInterface)
                //    checkEdit.Checked = true;
                //digitTextEdit.Text = currentEquipmentKind.Digits.ToString();
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveDeviceEquipmentKind();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        void SaveDeviceEquipmentKind()
        {
            if (formValid)
            {
                currentEquipmentKind.Name = nameTextEdit.Text;

                if (edit)
                {
                    currentEquipmentKind.DateOfChange = DateTime.Now;
                    currentEquipmentKind.Save();
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
                currentEquipmentKind.Name = nameTextEdit.Text;
                if (edit)
                {
                    currentEquipmentKind.DateOfChange = DateTime.Now;
                    currentEquipmentKind.Save();
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
