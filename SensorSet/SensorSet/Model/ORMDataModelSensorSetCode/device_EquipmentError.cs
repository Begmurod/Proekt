﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SensorSet.Model.SensorSet
{

    public partial class device_EquipmentError
    {
        public device_EquipmentError(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
