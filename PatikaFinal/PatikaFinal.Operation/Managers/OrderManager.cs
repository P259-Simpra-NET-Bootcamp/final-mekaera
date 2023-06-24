using PatikaFinal.Data.Domain;
using PatikaFinal.Data.Repository.Interfaces;
using PatikaFinal.Data.Repository.Repositories;
using PatikaFinal.Data.UnitOfWork;
using PatikaFinal.Operation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Operation.Managers
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IUnitOfWork unitOfWork;

        public OrderManager(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            this.orderRepository = orderRepository;
            this.unitOfWork = unitOfWork;
        }
  
        public void TDelete(Order t)
        {
            orderRepository.Delete(t);
            unitOfWork.Complete();
        }

        public Order TGetById(int id)
        {
           return orderRepository.GetById(id);

        }

        public List<Order> TGetAll()
        {
            return orderRepository.GetAll();
        }

        public void TInsert(Order t)
        {
            orderRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(Order t)
        {
            orderRepository.Update(t); 
            unitOfWork.Complete();
        }
    }
}
