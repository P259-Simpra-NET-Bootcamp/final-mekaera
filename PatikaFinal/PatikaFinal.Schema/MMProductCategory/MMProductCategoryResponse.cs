using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Schema.MMProductCategory
{
    public class MMProductCategoryResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public PatikaFinal.Data.Domain.Product Product { get; set; }
        public PatikaFinal.Data.Domain.Category Category { get; set; }
    }
}
