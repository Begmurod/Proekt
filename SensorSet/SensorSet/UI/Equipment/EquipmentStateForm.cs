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
    public partial class EquipmentStateForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentStateGuid;

        private device_EquipmentState currentEquipmentState;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public EquipmentStateForm()
        {
            InitializeComponent();
        }
        void initForm()
        {
            if (edit)
            {
                currentEquipmentState = uow.GetObjectByKey<device_EquipmentState>(currentEquipmentStateGuid);
            }
            else
            {
                currentEquipmentState = new device_EquipmentState(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование состояние оборудования {0}", currentEquipmentState.StateName);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр состояние оборудования {0}", currentEquipmentState.StateName);
                nameTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                nameTextEdit.Text = currentEquipmentState.StateName;
            }
        }

        private void EquipmentStateForm_Load(object sender, EventArgs e)
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
                currentEquipmentState.StateName = nameTextEdit.Text;

                if (edit)
                {
                    currentEquipmentState.DateOfChange = DateTime.Now;
                    currentEquipmentState.Save();
                }
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
