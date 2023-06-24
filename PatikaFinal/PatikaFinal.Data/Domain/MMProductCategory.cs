using PatikaFinal.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Domain
{
    public class MMProductCategory : BaseModel
    {
        //Ürün Kategori Map (kategoriId,UrunId)
        //Many-To-Many ilişkili yapı kurulması 
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
