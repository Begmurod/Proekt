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
    public partial class EquipmentTypeForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentTypeGuid;

        private device_EquipmentType currentEquipmentType;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public EquipmentTypeForm()
        {
            InitializeComponent();
        }
        public EquipmentTypeForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        

        /// <summary>
        /// Здесь пока все в куче: поднятие/создание объекта, загрузка справочников для списков, настройка внешнего вида...
        /// </summary>
        void initForm()
        {
            if (edit)
            {
                currentEquipmentType = uow.GetObjectByKey<device_EquipmentType>(currentEquipmentTypeGuid);
            }
            else
            {
                currentEquipmentType = new device_EquipmentType(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование типо обородования {0} ({1}) ({2}) ({3}) ({4}) ", currentEquipmentType.Name, currentEquipmentType.FullName, currentEquipmentType.Description,currentEquipmentType.EquipmentVendorGUID, currentEquipmentType.EquipmentKindGUID);
                addButton.Text = "Сохранить";
            }
            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData EquipmentTypeGUID = u.ExecuteQuery(@"SELECT GUID, Name FROM [device].[EquipmentKind] WHERE[DeletedDate] is null");
                EquipmentKindGUIDDataView.LoadData(EquipmentTypeGUID);

                SelectedData EquipmentVendorGUID = u.ExecuteQuery(@"SELECT GUID, Name FROM list.Vendor WHERE[DeletedDate] is null");
                EquipmentVendorGUIDDataView.LoadData(EquipmentVendorGUID);

            }
            #endregion

            if (view)
            {
                Text = string.Format("Просмотр типо обородования {0} ({1}) ({2}) ({3}) ({4})", currentEquipmentType.Name, currentEquipmentType.FullName, currentEquipmentType.Description, currentEquipmentType.EquipmentVendorGUID, currentEquipmentType.EquipmentKindGUID);
                nameTextEdit.ReadOnly = true;
                equipmentKindGUIDUpEdit.ReadOnly = true;
                equipmentVendorGUIDlookUpEdit.ReadOnly = true;
                fullNametextEdit.ReadOnly = true;
                changedUserIDtextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            //using (Session u = new Session())
            //{
            //    SelectedData dimensionParentData = u.ExecuteQuery(@"SELECT GUID, Name, NameEn FROM [list].[Dimension] WHERE[DeletedDate] is null");
            //    currentEquipmentTypeGuid.LoadData(dimensionParentData);

            //}
            #endregion

            if (edit)
            {
                nameTextEdit.Text = currentEquipmentType.Name;
                equipmentKindGUIDUpEdit.EditValue = currentEquipmentType.EquipmentKindGUID;
                equipmentVendorGUIDlookUpEdit.EditValue = currentEquipmentType.EquipmentVendorGUID;
                fullNametextEdit.Text = currentEquipmentType.FullName.ToString();
                changedUserIDtextEdit.Text = currentEquipmentType.Description.ToString();
                
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveEquipmentType();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
        }
        /// <summary>
        /// Заполнение текущей единицы данными с формы
        /// </summary>
        void SaveEquipmentType()
        {
            if (formValid)
            {
                currentEquipmentType.Name = nameTextEdit.Text;
                currentEquipmentType.FullName = fullNametextEdit.Text;
                currentEquipmentType.Description = changedUserIDtextEdit.Text;
                currentEquipmentType.EquipmentVendorGUID = uow.GetObjectByKey<list_Vendor>(equipmentVendorGUIDlookUpEdit.EditValue);
                currentEquipmentType.EquipmentKindGUID = uow.GetObjectByKey<device_EquipmentKind>(equipmentKindGUIDUpEdit.EditValue);
                

                if (edit)
                {
                    currentEquipmentType.DateOfChange = DateTime.Now;
                    currentEquipmentType.Save();
                }
            }

        }

        private void EquipmentTypeForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
