using PatikaFinal.Data.Domain;
using PatikaFinal.Data.Repository.Interfaces;
using PatikaFinal.Data.UnitOfWork;
using PatikaFinal.Operation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Operation.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserManager(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }
        public void TDelete(User t)
        {
            userRepository.Delete(t);
            unitOfWork.Complete();
        }

        public User TGetById(int id)
        {
            return userRepository.GetById(id);
            
        }

        public List<User> TGetAll()
        {
            return userRepository.GetAll();
        }

        public void TInsert(User t)
        {
            userRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(User t)
        {
            userRepository.Update(t);
            unitOfWork.Complete();
        }
    }
}
