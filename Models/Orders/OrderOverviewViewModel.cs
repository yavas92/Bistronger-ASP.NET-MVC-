﻿using Bistronger.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bistronger.Models.Orders
{
    public class OrderOverviewViewModel
    {
        public DataSet<Order> Orders { get; set; }
    }
}
