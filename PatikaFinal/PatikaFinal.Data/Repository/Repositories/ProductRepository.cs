using PatikaFinal.Data.Context;
using PatikaFinal.Data.Domain;
using PatikaFinal.Data.Repository.Base;
using PatikaFinal.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(PatikaDbContext context) : base(context)
        {
        }
    }
}
