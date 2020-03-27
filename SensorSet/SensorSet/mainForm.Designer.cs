namespace SensorSet
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.equipmentGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.equipmentItem = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentTypeItem = new DevExpress.XtraNavBar.NavBarItem();
            this.serviceItem = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentKindeItem = new DevExpress.XtraNavBar.NavBarItem();
            this.vendorItem = new DevExpress.XtraNavBar.NavBarItem();
            this.characterItem = new DevExpress.XtraNavBar.NavBarItem();
            this.measurandItem = new DevExpress.XtraNavBar.NavBarItem();
            this.dimensionItem = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentState = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentTypeError = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentCharacterParam = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentError = new DevExpress.XtraNavBar.NavBarItem();
            this.planGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.monthPlanNavItem = new DevExpress.XtraNavBar.NavBarItem();
            this.yearPlanItem = new DevExpress.XtraNavBar.NavBarItem();
            this.accountingGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.resItem = new DevExpress.XtraNavBar.NavBarItem();
            this.customerItem = new DevExpress.XtraNavBar.NavBarItem();
            this.eventsGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.eventsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.reportsGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.controlFrqItem = new DevExpress.XtraNavBar.NavBarItem();
            this.actsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.findRequestItem = new DevExpress.XtraNavBar.NavBarItem();
            this.mainContainer = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showHelpButton = new DevExpress.XtraBars.BarButtonItem();
            this.infoButton = new DevExpress.XtraBars.BarButtonItem();
            this.identityInfo = new DevExpress.XtraBars.BarStaticItem();
            this.databaseInfo = new DevExpress.XtraBars.BarStaticItem();
            this.mainHelpPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.infoAndOthers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentCharacterEquipmentType = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 143);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.mainContainer);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1244, 553);
            this.splitContainerControl.SplitterPosition = 235;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.equipmentGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.planGroup,
            this.accountingGroup,
            this.eventsGroup,
            this.reportsGroup,
            this.equipmentGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.monthPlanNavItem,
            this.yearPlanItem,
            this.resItem,
            this.customerItem,
            this.eventsItem,
            this.controlFrqItem,
            this.actsItem,
            this.equipmentItem,
            this.serviceItem,
            this.equipmentTypeItem,
            this.equipmentKindeItem,
            this.vendorItem,
            this.findRequestItem,
            this.characterItem,
            this.measurandItem,
            this.dimensionItem,
            this.equipmentCategory,
            this.equipmentState,
            this.equipmentTypeError,
            this.equipmentCharacterParam,
            this.equipmentError,
            this.equipmentCharacterEquipmentType});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 235;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(235, 541);
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // equipmentGroup
            // 
            this.equipmentGroup.Caption = "Устройства";
            this.equipmentGroup.Expanded = true;
            this.equipmentGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.equipmentGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentTypeItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.serviceItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentKindeItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.vendorItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.characterItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.measurandItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.dimensionItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentState),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentTypeError),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentCharacterParam),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentError),
            new DevExpress.XtraNavBar.NavBarItemLink(this.equipmentCharacterEquipmentType)});
            this.equipmentGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("equipmentGroup.LargeImage")));
            this.equipmentGroup.Name = "equipmentGroup";
            this.equipmentGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentGroup.SmallImage")));
            this.equipmentGroup.TopVisibleLinkIndex = 6;
            // 
            // equipmentItem
            // 
            this.equipmentItem.Caption = "Реестр устройств";
            this.equipmentItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("equipmentItem.LargeImage")));
            this.equipmentItem.Name = "equipmentItem";
            this.equipmentItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentItem.SmallImage")));
            this.equipmentItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentItem_LinkClicked);
            // 
            // equipmentTypeItem
            // 
            this.equipmentTypeItem.Caption = "Типы";
            this.equipmentTypeItem.Name = "equipmentTypeItem";
            this.equipmentTypeItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentTypeItem.SmallImage")));
            this.equipmentTypeItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentTypeItem_LinkClicked);
            // 
            // serviceItem
            // 
            this.serviceItem.Caption = "Обслуживание";
            this.serviceItem.Name = "serviceItem";
            this.serviceItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("serviceItem.SmallImage")));
            this.serviceItem.Visible = false;
            // 
            // equipmentKindeItem
            // 
            this.equipmentKindeItem.Caption = "Виды";
            this.equipmentKindeItem.Name = "equipmentKindeItem";
            this.equipmentKindeItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentKindeItem.SmallImage")));
            this.equipmentKindeItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentKindeItem_LinkClicked);
            // 
            // vendorItem
            // 
            this.vendorItem.Caption = "Производители";
            this.vendorItem.Name = "vendorItem";
            this.vendorItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("vendorItem.SmallImage")));
            this.vendorItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.vendorItem_LinkClicked);
            // 
            // characterItem
            // 
            this.characterItem.Caption = "Характеристики";
            this.characterItem.Name = "characterItem";
            this.characterItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("characterItem.SmallImage")));
            this.characterItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.characterItem_LinkClicked);
            // 
            // measurandItem
            // 
            this.measurandItem.Caption = "Показания";
            this.measurandItem.Name = "measurandItem";
            this.measurandItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("measurandItem.SmallImage")));
            this.measurandItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.measurandItem_LinkClicked);
            // 
            // dimensionItem
            // 
            this.dimensionItem.Caption = "Единицы";
            this.dimensionItem.Name = "dimensionItem";
            this.dimensionItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("dimensionItem.SmallImage")));
            this.dimensionItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.dimensionItem_LinkClicked);
            // 
            // equipmentCategory
            // 
            this.equipmentCategory.Caption = "Категория оборудования";
            this.equipmentCategory.Name = "equipmentCategory";
            this.equipmentCategory.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentCategory.SmallImage")));
            this.equipmentCategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentCategory_LinkClicked);
            // 
            // equipmentState
            // 
            this.equipmentState.Caption = "Состояние оборудования";
            this.equipmentState.Name = "equipmentState";
            this.equipmentState.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentState.SmallImage")));
            this.equipmentState.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentState_LinkClicked);
            // 
            // equipmentTypeError
            // 
            this.equipmentTypeError.Caption = "Погрешность типа оборудования";
            this.equipmentTypeError.Name = "equipmentTypeError";
            this.equipmentTypeError.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentTypeError.SmallImage")));
            this.equipmentTypeError.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.EquipmentTypeError_LinkClicked);
            // 
            // equipmentCharacterParam
            // 
            this.equipmentCharacterParam.Caption = "Параметры характеристик";
            this.equipmentCharacterParam.Name = "equipmentCharacterParam";
            this.equipmentCharacterParam.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentCharacterParam.SmallImage")));
            this.equipmentCharacterParam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentCharacterParam_LinkClicked);
            // 
            // equipmentError
            // 
            this.equipmentError.Caption = "Погрешность оборудования";
            this.equipmentError.Name = "equipmentError";
            this.equipmentError.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentError.SmallImage")));
            this.equipmentError.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentError_LinkClicked);
            // 
            // planGroup
            // 
            this.planGroup.Caption = "Экраны";
            this.planGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.planGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.planGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.monthPlanNavItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.yearPlanItem)});
            this.planGroup.Name = "planGroup";
            this.planGroup.Visible = false;
            // 
            // monthPlanNavItem
            // 
            this.monthPlanNavItem.Appearance.BackColor = System.Drawing.Color.White;
            this.monthPlanNavItem.Appearance.Options.UseBackColor = true;
            this.monthPlanNavItem.Caption = "План на месяц";
            this.monthPlanNavItem.Name = "monthPlanNavItem";
            // 
            // yearPlanItem
            // 
            this.yearPlanItem.Caption = "Годовой план";
            this.yearPlanItem.Name = "yearPlanItem";
            this.yearPlanItem.Visible = false;
            // 
            // accountingGroup
            // 
            this.accountingGroup.Caption = "Учетные данные";
            this.accountingGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.accountingGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.resItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.customerItem)});
            this.accountingGroup.Name = "accountingGroup";
            this.accountingGroup.Visible = false;
            // 
            // resItem
            // 
            this.resItem.Caption = "РЭС";
            this.resItem.Name = "resItem";
            // 
            // customerItem
            // 
            this.customerItem.Caption = "Клиенты";
            this.customerItem.Name = "customerItem";
            // 
            // eventsGroup
            // 
            this.eventsGroup.Caption = "Журналы";
            this.eventsGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.eventsGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.eventsItem)});
            this.eventsGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("eventsGroup.LargeImage")));
            this.eventsGroup.Name = "eventsGroup";
            this.eventsGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("eventsGroup.SmallImage")));
            // 
            // eventsItem
            // 
            this.eventsItem.Caption = "События";
            this.eventsItem.Name = "eventsItem";
            // 
            // reportsGroup
            // 
            this.reportsGroup.Caption = "Отчеты";
            this.reportsGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.reportsGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("reportsGroup.LargeImage")));
            this.reportsGroup.Name = "reportsGroup";
            this.reportsGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportsGroup.SmallImage")));
            // 
            // controlFrqItem
            // 
            this.controlFrqItem.Caption = "Контроль частот и РЭС";
            this.controlFrqItem.Name = "controlFrqItem";
            // 
            // actsItem
            // 
            this.actsItem.Caption = "Акты";
            this.actsItem.Name = "actsItem";
            this.actsItem.Visible = false;
            // 
            // findRequestItem
            // 
            this.findRequestItem.Caption = "Поиск помех";
            this.findRequestItem.Name = "findRequestItem";
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(992, 541);
            this.mainContainer.TabIndex = 0;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.showHelpButton,
            this.infoButton,
            this.identityInfo,
            this.databaseInfo});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 66;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainHelpPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1244, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // showHelpButton
            // 
            this.showHelpButton.Caption = "Помощь";
            this.showHelpButton.Glyph = ((System.Drawing.Image)(resources.GetObject("showHelpButton.Glyph")));
            this.showHelpButton.Id = 62;
            this.showHelpButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showHelpButton.LargeGlyph")));
            this.showHelpButton.Name = "showHelpButton";
            // 
            // infoButton
            // 
            this.infoButton.Caption = "О программе...";
            this.infoButton.Glyph = ((System.Drawing.Image)(resources.GetObject("infoButton.Glyph")));
            this.infoButton.Id = 63;
            this.infoButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("infoButton.LargeGlyph")));
            this.infoButton.Name = "infoButton";
            // 
            // identityInfo
            // 
            this.identityInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.identityInfo.Caption = "Пользователь";
            this.identityInfo.Id = 64;
            this.identityInfo.Name = "identityInfo";
            this.identityInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // databaseInfo
            // 
            this.databaseInfo.Caption = "БазаДанных";
            this.databaseInfo.Id = 65;
            this.databaseInfo.Name = "databaseInfo";
            this.databaseInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // mainHelpPage
            // 
            this.mainHelpPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.infoAndOthers});
            this.mainHelpPage.MergeOrder = 999;
            this.mainHelpPage.Name = "mainHelpPage";
            this.mainHelpPage.Text = "Информация";
            // 
            // infoAndOthers
            // 
            this.infoAndOthers.ItemLinks.Add(this.showHelpButton);
            this.infoAndOthers.ItemLinks.Add(this.infoButton);
            this.infoAndOthers.MergeOrder = 999;
            this.infoAndOthers.Name = "infoAndOthers";
            this.infoAndOthers.Text = "Информация и помощь";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.identityInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.databaseInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 696);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1244, 31);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Единицы";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Единицы";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.SmallImage")));
            // 
            // equipmentCharacterEquipmentType
            // 
            this.equipmentCharacterEquipmentType.Caption = "Набор характеристик типового оборудования";
            this.equipmentCharacterEquipmentType.Name = "equipmentCharacterEquipmentType";
            this.equipmentCharacterEquipmentType.SmallImage = ((System.Drawing.Image)(resources.GetObject("equipmentCharacterEquipmentType.SmallImage")));
            this.equipmentCharacterEquipmentType.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.equipmentCharacterEquipmentType_LinkClicked);
            // 
            // mainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 727);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "SensorSet";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup planGroup;
        private DevExpress.XtraNavBar.NavBarItem monthPlanNavItem;
        private DevExpress.XtraEditors.PanelControl mainContainer;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainHelpPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup infoAndOthers;
        private DevExpress.XtraBars.BarButtonItem showHelpButton;
        private DevExpress.XtraBars.BarButtonItem infoButton;
        private DevExpress.XtraBars.BarStaticItem identityInfo;
        private DevExpress.XtraBars.BarStaticItem databaseInfo;
        private DevExpress.XtraNavBar.NavBarItem yearPlanItem;
        private DevExpress.XtraNavBar.NavBarGroup accountingGroup;
        private DevExpress.XtraNavBar.NavBarItem resItem;
        private DevExpress.XtraNavBar.NavBarItem customerItem;
        private DevExpress.XtraNavBar.NavBarGroup eventsGroup;
        private DevExpress.XtraNavBar.NavBarItem eventsItem;
        private DevExpress.XtraNavBar.NavBarItem controlFrqItem;
        private DevExpress.XtraNavBar.NavBarItem actsItem;
        private DevExpress.XtraNavBar.NavBarGroup reportsGroup;
        private DevExpress.XtraNavBar.NavBarGroup equipmentGroup;
        private DevExpress.XtraNavBar.NavBarItem equipmentItem;
        private DevExpress.XtraNavBar.NavBarItem serviceItem;
        private DevExpress.XtraNavBar.NavBarItem equipmentTypeItem;
        private DevExpress.XtraNavBar.NavBarItem equipmentKindeItem;
        private DevExpress.XtraNavBar.NavBarItem vendorItem;
        private DevExpress.XtraNavBar.NavBarItem findRequestItem;
        private DevExpress.XtraNavBar.NavBarItem characterItem;
        private DevExpress.XtraNavBar.NavBarItem measurandItem;
        private DevExpress.XtraNavBar.NavBarItem dimensionItem;
        private DevExpress.XtraNavBar.NavBarItem equipmentCategory;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem equipmentState;
        private DevExpress.XtraNavBar.NavBarItem equipmentTypeError;
        private DevExpress.XtraNavBar.NavBarItem equipmentCharacterParam;
        private DevExpress.XtraNavBar.NavBarItem equipmentError;
        private DevExpress.XtraNavBar.NavBarItem equipmentCharacterEquipmentType;
    }
}

