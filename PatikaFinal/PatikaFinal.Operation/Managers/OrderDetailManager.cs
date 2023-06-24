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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailRepository orderDetailRepository;
        private readonly IUnitOfWork unitOfWork;

        public OrderDetailManager(IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork)
        {
            this.orderDetailRepository = orderDetailRepository;
            this.unitOfWork = unitOfWork;
        }
   
        public void TDelete(OrderDetail t)
        {
            orderDetailRepository.Delete(t);
            unitOfWork.Complete();
        }

        public OrderDetail TGetById(int id)
        {
            return orderDetailRepository.GetById(id);
        }

        public List<OrderDetail> TGetAll()
        {
            return orderDetailRepository.GetAll();
        }

        public void TInsert(OrderDetail t)
        {
            orderDetailRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(OrderDetail t)
        {
            orderDetailRepository.Update(t);   
            unitOfWork.Complete();
        }
    }
}
