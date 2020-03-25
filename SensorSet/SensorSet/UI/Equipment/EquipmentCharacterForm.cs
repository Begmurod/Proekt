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
    public partial class EquipmentCharacterForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentEquipmentCharacterGuid;

        private device_EquipmentCharacter currentEquipmentCharacter;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public EquipmentCharacterForm()
        {
            InitializeComponent();
        }
        public EquipmentCharacterForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void EquipmentCharacterForm_Load(object sender, EventArgs e)
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
                currentEquipmentCharacter = uow.GetObjectByKey<device_EquipmentCharacter>(currentEquipmentCharacterGuid);
            }
            else
            {
                currentEquipmentCharacter = new device_EquipmentCharacter(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование храктеристики оборудования {0} ({1})", currentEquipmentCharacter.CharacterName, currentEquipmentCharacter.FieldName, currentEquipmentCharacter.ParamType, currentEquipmentCharacter.IsSystem, currentEquipmentCharacter.DimensionGUID);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр характеристики оборудования {0} ({1})", currentEquipmentCharacter.CharacterName, currentEquipmentCharacter.FieldName, currentEquipmentCharacter.ParamType, currentEquipmentCharacter.IsSystem, currentEquipmentCharacter.DimensionGUID);
                characterNameTextEdit.ReadOnly = true;
                fieldNameTextEdit.ReadOnly = true;
                dimensionGUIDLookUpEdit.ReadOnly = true;
                paramTypeTextEdit.ReadOnly = true;
                checkEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData DimensionGUID = u.ExecuteQuery(@"SELECT GUID, Name FROM [list].[Dimension] WHERE[DeletedDate] is null");
                dimensionGUIDDataView.LoadData(DimensionGUID);

            }
            #endregion

            if (edit)
            {
                characterNameTextEdit.Text = currentEquipmentCharacter.CharacterName;
                fieldNameTextEdit.Text = currentEquipmentCharacter.FieldName;
                dimensionGUIDLookUpEdit.EditValue = currentEquipmentCharacter.DimensionGUID;
                if (currentEquipmentCharacter.IsSystem)
                    checkEdit.Checked = true;
                paramTypeTextEdit.Text = currentEquipmentCharacter.ParamType.ToString();
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveEquipmentCharacter();
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
        void SaveEquipmentCharacter()
        {
            if (formValid)
            {
                currentEquipmentCharacter.CharacterName = characterNameTextEdit.Text;
                currentEquipmentCharacter.FieldName = fieldNameTextEdit.Text;
                currentEquipmentCharacter.DimensionGUID = uow.GetObjectByKey<list_Dimension>(dimensionGUIDLookUpEdit.EditValue);
                currentEquipmentCharacter.IsSystem = checkEdit.Checked;
                currentEquipmentCharacter.ParamType = Convert.ToInt16(paramTypeTextEdit.Text);

                if (edit)
                {
                    currentEquipmentCharacter.DateOfChange = DateTime.Now;
                    currentEquipmentCharacter.Save();
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
