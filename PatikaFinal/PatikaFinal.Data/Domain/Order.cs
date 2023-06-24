using PatikaFinal.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Domain
{
    public class Order : BaseModel
    {
        //Sipariş (sepet tutarı, kupon tutarı, kupon kodu, puan tutarı, vs.) 
        public int BasketCost { get; set; }
        public int CouponCode { get; set; }
        public int CouponDiscount { get; set; }
        public int UsedScore { get; set; }
        public int EarnedScore { get; set; }
        public int PaymentCost { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
