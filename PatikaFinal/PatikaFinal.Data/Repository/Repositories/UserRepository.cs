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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PatikaDbContext context) : base(context)
        {
        }
    }
}
