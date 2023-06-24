using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Schema.Product
{
    public class ProductRequest
    {
        public ICollection<PatikaFinal.Data.Domain.MMProductCategory> MMProductCategories { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Feature { get; set; }
        public int PercentageForScore { get; set; }
        public int MaxScoreLimit { get; set; }

    }
}
