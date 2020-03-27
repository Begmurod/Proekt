﻿using DevExpress.Xpo;
using System;
using SensorSet.Model.SensorSet;
using DevExpress.Xpo.DB;

namespace SensorSet.UI.Equipment
{
    public partial class MeasurandForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentMeasurandGuid;

        private device_Measurand currentMeasurand;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public MeasurandForm()
        {
            InitializeComponent();
        }
        public MeasurandForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void DimensionForm_Load(object sender, EventArgs e)
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
                currentMeasurand = uow.GetObjectByKey<device_Measurand>(currentMeasurandGuid);
            }
            else
            {
                currentMeasurand = new device_Measurand(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактировать измеряемые величины {0} ({1})", currentMeasurand.ValueName, currentMeasurand.DimensionGUID);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Посмотреть измеряемые величины {0} ({1})", currentMeasurand.ValueName, currentMeasurand.DimensionGUID);
                valueNameTextEdit.ReadOnly = true;
                DimensionGUIDLookUpEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion

            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData DimensionGUIDData = u.ExecuteQuery(@"SELECT GUID, Name, NameEn FROM [list].[Dimension] WHERE[DeletedDate] is null");
                dimensionGUIDDataView.LoadData(DimensionGUIDData);

            }
            #endregion

            if (edit)
            {
                valueNameTextEdit.Text = currentMeasurand.ValueName;
                DimensionGUIDLookUpEdit.EditValue = currentMeasurand.DimensionGUID;
              
            }

        }

        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
        }
        /// <summary>
        /// Заполнение текущей единицы данными с формы
        /// </summary>
        

        private void addButton_Click(object sender, EventArgs e)
        {

            validForm();
            SaveMeasurand();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        void SaveMeasurand()
        {
            if (formValid)
            {
                currentMeasurand.ValueName = valueNameTextEdit.Text;
                currentMeasurand.DimensionGUID = uow.GetObjectByKey<list_Dimension>(DimensionGUIDLookUpEdit.EditValue);
                if (edit)
                {
                    currentMeasurand.DateOfChange = DateTime.Now;
                    currentMeasurand.Save();
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
