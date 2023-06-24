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
    public class CouponManager : ICouponService
    {
        private readonly ICouponRepository couponRepository;
        private readonly IUnitOfWork unitOfWork;

        public CouponManager(ICouponRepository couponRepository, IUnitOfWork unitOfWork)
        {
            this.couponRepository = couponRepository;
            this.unitOfWork = unitOfWork;
        }
       
        public void TDelete(Coupon t)
        {
            couponRepository.Delete(t);
            unitOfWork.Complete();
        }

        public Coupon TGetById(int id)
        {
           return couponRepository.GetById(id);
        }

        public List<Coupon> TGetAll()
        {
            return couponRepository.GetAll();
        }

        public void TInsert(Coupon t)
        {
            couponRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(Coupon t)
        {
            couponRepository.Update(t);
            unitOfWork.Complete();
        }
    }
}
