using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Schema.Category
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PatikaFinal.Data.Domain.MMProductCategory> MMProductCategories { get; set; }
    }
}
