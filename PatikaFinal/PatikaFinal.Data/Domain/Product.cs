using PatikaFinal.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Domain
{
    public class Product : BaseModel
    {
        //Ürün (Kategori, adi, özellikleri, açıklama, aktiflik, puan kazandırma yüzdesi, max puan tutarı) 
        public ICollection<MMProductCategory> MMProductCategories { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Feature { get; set; }
        public int PercentageForScore { get; set; }
        public int MaxScoreLimit { get; set; }

    }
}
