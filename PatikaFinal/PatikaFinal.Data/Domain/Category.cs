using PatikaFinal.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Domain
{
    public class Category : BaseModel
    {
        //Kategori (adi. url, tags vs,) 
        public string Name { get; set; }
        public ICollection<MMProductCategory> MMProductCategories { get; set; }
    }
}
