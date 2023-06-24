using PatikaFinal.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Domain
{
    public class OrderDetail : BaseModel
    {
        //Sipariş Detay(sepetteki urun detay bilgileri vs.,)
        public string Detail { get; set; }
    }
}
