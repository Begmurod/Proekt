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

    [Persistent(@"list.Dimension")]
    public partial class list_Dimension : XPLiteObject
    {
        Guid fGUID;
        [Key(true)]
        public Guid GUID
        {
            get { return fGUID; }
            set { SetPropertyValue<Guid>("GUID", ref fGUID, value); }
        }
        string fName;
        [Size(200)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fNameEn;
        [Size(200)]
        public string NameEn
        {
            get { return fNameEn; }
            set { SetPropertyValue<string>("NameEn", ref fNameEn, value); }
        }
        list_Dimension fParentGUID;
        [Association(@"list_DimensionReferenceslist_Dimension")]
        public list_Dimension ParentGUID
        {
            get { return fParentGUID; }
            set { SetPropertyValue<list_Dimension>("ParentGUID", ref fParentGUID, value); }
        }
        decimal fKoef;
        public decimal Koef
        {
            get { return fKoef; }
            set { SetPropertyValue<decimal>("Koef", ref fKoef, value); }
        }
        bool fShowInInterface;
        public bool ShowInInterface
        {
            get { return fShowInInterface; }
            set { SetPropertyValue<bool>("ShowInInterface", ref fShowInInterface, value); }
        }
        DateTime fDateOfChange;
        public DateTime DateOfChange
        {
            get { return fDateOfChange; }
            set { SetPropertyValue<DateTime>("DateOfChange", ref fDateOfChange, value); }
        }
        short fDigits;
        public short Digits
        {
            get { return fDigits; }
            set { SetPropertyValue<short>("Digits", ref fDigits, value); }
        }
        DateTime fDeletedDate;
        public DateTime DeletedDate
        {
            get { return fDeletedDate; }
            set { SetPropertyValue<DateTime>("DeletedDate", ref fDeletedDate, value); }
        }
        [Association(@"device_EquipmentCharacterReferenceslist_Dimension")]
        public XPCollection<device_EquipmentCharacter> device_EquipmentCharacters { get { return GetCollection<device_EquipmentCharacter>("device_EquipmentCharacters"); } }
        [Association(@"device_MeasurandReferenceslist_Dimension")]
        public XPCollection<device_Measurand> device_Measurands { get { return GetCollection<device_Measurand>("device_Measurands"); } }
        [Association(@"list_DimensionReferenceslist_Dimension")]
        public XPCollection<list_Dimension> list_DimensionCollection { get { return GetCollection<list_Dimension>("list_DimensionCollection"); } }
    }

}
