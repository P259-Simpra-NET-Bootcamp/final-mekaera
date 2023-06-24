using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Schema.Order
{
    public class OrderResponse
    {
        public int Id { get; set; }
        public int BasketCost { get; set; }
        public int CouponCode { get; set; }
        public int CouponDiscount { get; set; }
        public int UsedScore { get; set; }
        public int EarnedScore { get; set; }
        public int PaymentCost { get; set; }
        public PatikaFinal.Data.Domain.OrderDetail OrderDetail { get; set; }
    }
}
