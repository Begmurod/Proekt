﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SensorSet.Model.SensorSet
{

    public partial class measure_Metering
    {
        public measure_Metering(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
