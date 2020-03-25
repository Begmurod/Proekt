using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SensorSet.Model.SensorSet
{

    public partial class device_EquipmentCharacter
    {
        public device_EquipmentCharacter(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
