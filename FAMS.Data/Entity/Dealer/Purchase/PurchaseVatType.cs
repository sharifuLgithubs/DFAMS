﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FADMS.Data.Entity.Dealer.Purchase
{
    public class PurchaseVatType : Base
    {
        public string name { get; set; }
        public string nameBn { get; set; }
        public int? isActive { get; set; }
    }
}