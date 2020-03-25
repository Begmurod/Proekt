using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SensorSet.Model.SensorSet
{

    public partial class device_EquipmentState
    {
        public device_EquipmentState(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
