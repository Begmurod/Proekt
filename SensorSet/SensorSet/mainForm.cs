using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;

namespace SensorSet
{
    public partial class mainForm : RibbonForm
    {
        private Lazy<UI.Equipment.equipmentUC> equipmentUC;
        private Lazy<UI.Equipment.dimensionUC> dimensionUC;
        private Lazy<UI.Equipment.vendorUC> vendorUC;
        private Lazy<UI.Equipment.deviceEquipmentCategoryUC> deviceEquipmentCategoryUC;
        private Lazy<UI.Equipment.deviceEquipmentKindUC> deviceEquipmentKindUC;
        private Lazy<UI.Equipment.equipmentStateUC> equipmentStateUC;
        private Lazy<UI.Equipment.equipmentTypeUC> equipmentTypeUC;
        private Lazy<UI.Equipment.equipmentTypeErrorUC> equipmentTypeErrorUC;
        private Lazy<UI.Equipment.equipmentErrorUC> equipmentErrorUC;
        private Lazy<UI.Equipment.equipmentCharacterParamUC> equipmentCharacterParamUC;
        private Lazy<UI.Equipment.equipmentCharacterUC> equipmentCharacterUC;
        private Lazy<UI.Equipment.deviceMeasurandUC> deviceMeasurandUC;
        private Lazy<UI.Equipment.equipmentCharacterEquipmentTypeUC> equipmentCharacterEquipmentTypeUC;

        private void hideAllContainerControls(Control container)
        {
            foreach (Control child in container.Controls)
                child.Hide();
        }

        void initEquipmentUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentUC == null)
            {
                equipmentUC = new Lazy<UI.Equipment.equipmentUC>(() => new UI.Equipment.equipmentUC(mainContainer));
                equipmentUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Реестр устройств";
            equipmentUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentUC.Value.equipmentRibbonControl);
            ribbonControl.SelectedPage = equipmentUC.Value.equipmentRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }

        void initdimensionUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (dimensionUC == null)
            {
                dimensionUC = new Lazy<UI.Equipment.dimensionUC>(() => new UI.Equipment.dimensionUC(mainContainer));
                dimensionUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Единицы измерения";
            dimensionUC.Value.Show();
            ribbonControl.MergeRibbon(dimensionUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = dimensionUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initVendorUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (vendorUC == null)
            {
                vendorUC = new Lazy<UI.Equipment.vendorUC>(() => new UI.Equipment.vendorUC(mainContainer));
                vendorUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Производители устройств";
            vendorUC.Value.Show();
            ribbonControl.MergeRibbon(vendorUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = vendorUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }

        void initdeviceEquipmentCategoryUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (deviceEquipmentCategoryUC == null)
            {
                deviceEquipmentCategoryUC = new Lazy<UI.Equipment.deviceEquipmentCategoryUC>(() => new UI.Equipment.deviceEquipmentCategoryUC(mainContainer));
                deviceEquipmentCategoryUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Категорий оборудования";
            deviceEquipmentCategoryUC.Value.Show();
            ribbonControl.MergeRibbon(deviceEquipmentCategoryUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = deviceEquipmentCategoryUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initdeviceEquipmentKindUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (deviceEquipmentKindUC == null)
            {
                deviceEquipmentKindUC = new Lazy<UI.Equipment.deviceEquipmentKindUC>(() => new UI.Equipment.deviceEquipmentKindUC(mainContainer));
                deviceEquipmentKindUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Вид устройства";
            deviceEquipmentKindUC.Value.Show();
            ribbonControl.MergeRibbon(deviceEquipmentKindUC.Value.deviceEquipmentKindRibbonControl);
            ribbonControl.SelectedPage = deviceEquipmentKindUC.Value.deviceEquipmentKindRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initequipmentStateUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentStateUC == null)
            {
                equipmentStateUC = new Lazy<UI.Equipment.equipmentStateUC>(() => new UI.Equipment.equipmentStateUC(mainContainer));
                equipmentStateUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Состояние оборудования";
            equipmentStateUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentStateUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = equipmentStateUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initequipmentTypeUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentTypeUC == null)
            {
                equipmentTypeUC = new Lazy<UI.Equipment.equipmentTypeUC>(() => new UI.Equipment.equipmentTypeUC(mainContainer));
                equipmentTypeUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Типы обородования";
            equipmentTypeUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentTypeUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = equipmentTypeUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initequipmentTypeErrorUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentTypeErrorUC == null)
            {
                equipmentTypeErrorUC = new Lazy<UI.Equipment.equipmentTypeErrorUC>(() => new UI.Equipment.equipmentTypeErrorUC(mainContainer));
                equipmentTypeErrorUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Погрешность типа оборудования";
            equipmentTypeErrorUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentTypeErrorUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = equipmentTypeErrorUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initequipmentCharacterParamUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentCharacterParamUC == null)
            {
                equipmentCharacterParamUC = new Lazy<UI.Equipment.equipmentCharacterParamUC>(() => new UI.Equipment.equipmentCharacterParamUC(mainContainer));
                equipmentCharacterParamUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Параметры(значения) характеристик";
            equipmentCharacterParamUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentCharacterParamUC.Value.equipmentCharacterParamRibbonControl);
            ribbonControl.SelectedPage = equipmentCharacterParamUC.Value.equipmentCharacterParamRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initequipmentCharacterUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentCharacterUC == null)
            {
                equipmentCharacterUC = new Lazy<UI.Equipment.equipmentCharacterUC>(() => new UI.Equipment.equipmentCharacterUC(mainContainer));
                equipmentCharacterUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Характеристики оборудования";
            equipmentCharacterUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentCharacterUC.Value.equipmentCharacterRibbonControl);
            ribbonControl.SelectedPage = equipmentCharacterUC.Value.equipmentCharacterRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }

        void initequipmentErrorUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentErrorUC == null)
            {
                equipmentErrorUC = new Lazy<UI.Equipment.equipmentErrorUC>(() => new UI.Equipment.equipmentErrorUC(mainContainer));
                equipmentErrorUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Погрешность оборудования";
            equipmentErrorUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentErrorUC.Value.equipmentErrorRibbonControl);
            ribbonControl.SelectedPage = equipmentErrorUC.Value.equipmentErrorRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initdeviceMeasurandUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentErrorUC == null)
            {
                equipmentErrorUC = new Lazy<UI.Equipment.equipmentErrorUC>(() => new UI.Equipment.equipmentErrorUC(mainContainer));
                equipmentErrorUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Измеряемые величины";
            equipmentErrorUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentErrorUC.Value.equipmentErrorRibbonControl);
            ribbonControl.SelectedPage = equipmentErrorUC.Value.equipmentErrorRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initequipmentCharacterEquipmentTypeUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (equipmentCharacterEquipmentTypeUC == null)
            {
                equipmentCharacterEquipmentTypeUC = new Lazy<UI.Equipment.equipmentCharacterEquipmentTypeUC>(() => new UI.Equipment.equipmentCharacterEquipmentTypeUC(mainContainer));
                equipmentCharacterEquipmentTypeUC.Value.Dock = DockStyle.Fill;
            }
            Text = "SensorSet - Измеряемые величины";
            equipmentCharacterEquipmentTypeUC.Value.Show();
            ribbonControl.MergeRibbon(equipmentCharacterEquipmentTypeUC.Value.equipmentCharacterEquipmentTypeRibbonControl);
            ribbonControl.SelectedPage = equipmentCharacterEquipmentTypeUC.Value.equipmentCharacterEquipmentTypeRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }

        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            //identityInfo.Caption = Security.Session.CurrentWindowsPrincipal.Identity.Name;
            //databaseInfo.Caption = string.Format("{0}\\{1}", Database.Session.currentDatabaseServer, Database.Session.currentDatabase);

            initEquipmentUC();
        }

        private void equipmentItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initEquipmentUC();
        }

        private void dimensionItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initdimensionUC();
        }

        private void vendorItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initVendorUC();
        }

        private void equipmentCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initdeviceEquipmentCategoryUC();
        }

        private void equipmentKindeItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initdeviceEquipmentKindUC();
        }

        private void equipmentState_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentStateUC();
        }

        private void equipmentTypeItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentTypeUC();
        }

        private void EquipmentTypeError_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentTypeErrorUC();
        }

        private void equipmentCharacterParam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentCharacterParamUC();
        }


        private void characterItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentCharacterUC();
        }

        private void equipmentError_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentErrorUC();
        }

        private void measurandItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initdeviceMeasurandUC();
        }

        private void equipmentCharacterEquipmentType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initequipmentCharacterEquipmentTypeUC();
        }
    }
}
