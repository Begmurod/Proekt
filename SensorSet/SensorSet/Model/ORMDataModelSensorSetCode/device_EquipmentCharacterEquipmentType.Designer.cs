﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SensorSet.Model.SensorSet
{

    [Persistent(@"device.EquipmentCharacterEquipmentType")]
    public partial class device_EquipmentCharacterEquipmentType : XPLiteObject
    {
        Guid fGUID;
        [Key(true)]
        public Guid GUID
        {
            get { return fGUID; }
            set { SetPropertyValue<Guid>("GUID", ref fGUID, value); }
        }
        device_EquipmentType fEquipmentTypeGUID;
        [Association(@"device_EquipmentCharacterEquipmentTypeReferencesdevice_EquipmentType")]
        public device_EquipmentType EquipmentTypeGUID
        {
            get { return fEquipmentTypeGUID; }
            set { SetPropertyValue<device_EquipmentType>("EquipmentTypeGUID", ref fEquipmentTypeGUID, value); }
        }
        device_EquipmentCharacter fEquipmentCharacterGUID;
        [Association(@"device_EquipmentCharacterEquipmentTypeReferencesdevice_EquipmentCharacter")]
        public device_EquipmentCharacter EquipmentCharacterGUID
        {
            get { return fEquipmentCharacterGUID; }
            set { SetPropertyValue<device_EquipmentCharacter>("EquipmentCharacterGUID", ref fEquipmentCharacterGUID, value); }
        }
        long fIntParam;
        public long IntParam
        {
            get { return fIntParam; }
            set { SetPropertyValue<long>("IntParam", ref fIntParam, value); }
        }
        string fStrParam;
        [Size(SizeAttribute.Unlimited)]
        public string StrParam
        {
            get { return fStrParam; }
            set { SetPropertyValue<string>("StrParam", ref fStrParam, value); }
        }
        DateTime fDataParam;
        public DateTime DataParam
        {
            get { return fDataParam; }
            set { SetPropertyValue<DateTime>("DataParam", ref fDataParam, value); }
        }
        bool fBoolParam;
        public bool BoolParam
        {
            get { return fBoolParam; }
            set { SetPropertyValue<bool>("BoolParam", ref fBoolParam, value); }
        }
        long fNumericParam;
        public long NumericParam
        {
            get { return fNumericParam; }
            set { SetPropertyValue<long>("NumericParam", ref fNumericParam, value); }
        }
        double fNumericParam2;
        public double NumericParam2
        {
            get { return fNumericParam2; }
            set { SetPropertyValue<double>("NumericParam2", ref fNumericParam2, value); }
        }
    }

}
