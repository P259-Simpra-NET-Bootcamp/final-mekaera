using PatikaFinal.Data.Context;
using PatikaFinal.Data.Domain;
using PatikaFinal.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly PatikaDbContext context;

        public UnitOfWork(PatikaDbContext patikaDbContext)
        {
            context = patikaDbContext;
        }

        public void Complete()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
