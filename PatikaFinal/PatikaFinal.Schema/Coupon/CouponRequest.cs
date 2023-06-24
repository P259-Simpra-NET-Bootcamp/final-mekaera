﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Schema.Coupon
{
    public class CouponRequest
    {
        public int CouponCode { get; set; }
        public DateTime ExpireDate { get; set; }
        public int DiscountPercent { get; set; }
        public int MaxDiscountAmount { get; set; }
    }
}
