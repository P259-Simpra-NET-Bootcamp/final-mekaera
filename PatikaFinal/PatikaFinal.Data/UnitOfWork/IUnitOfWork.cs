using PatikaFinal.Data.Domain;
using PatikaFinal.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
    }
}
