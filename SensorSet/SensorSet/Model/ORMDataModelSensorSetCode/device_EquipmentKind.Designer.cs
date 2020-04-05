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

    [Persistent(@"device.EquipmentKind")]
    public partial class device_EquipmentKind : XPLiteObject
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
        device_EquipmentKind fParentGUID;
        [Association(@"device_EquipmentKindReferencesdevice_EquipmentKind")]
        public device_EquipmentKind ParentGUID
        {
            get { return fParentGUID; }
            set { SetPropertyValue<device_EquipmentKind>("ParentGUID", ref fParentGUID, value); }
        }
        DateTime fDateOfChange;
        public DateTime DateOfChange
        {
            get { return fDateOfChange; }
            set { SetPropertyValue<DateTime>("DateOfChange", ref fDateOfChange, value); }
        }
        [Association(@"device_EquipmentKindReferencesdevice_EquipmentKind")]
        public XPCollection<device_EquipmentKind> device_EquipmentKindCollection { get { return GetCollection<device_EquipmentKind>("device_EquipmentKindCollection"); } }
        [Association(@"device_EquipmentTypeReferencesdevice_EquipmentKind")]
        public XPCollection<device_EquipmentType> device_EquipmentTypes { get { return GetCollection<device_EquipmentType>("device_EquipmentTypes"); } }
    }

}
