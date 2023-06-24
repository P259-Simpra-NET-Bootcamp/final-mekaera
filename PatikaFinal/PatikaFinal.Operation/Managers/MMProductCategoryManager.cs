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
    public class MMProductCategoryManager : IMMProductCategoryService
    {
        private readonly IMMProductCategoryRepository mMProductCategoryRepository;
        private readonly IUnitOfWork unitOfWork;
        public MMProductCategoryManager(IMMProductCategoryRepository mMProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            this.mMProductCategoryRepository = mMProductCategoryRepository;
            this.unitOfWork = unitOfWork;
        }
      
        public void TDelete(MMProductCategory t)
        {
            mMProductCategoryRepository.Delete(t);
            unitOfWork.Complete();
        }

        public MMProductCategory TGetById(int id)
        {
            return mMProductCategoryRepository.GetById(id);
        }

        public List<MMProductCategory> TGetAll()
        {
            return mMProductCategoryRepository.GetAll();
        }

        public void TInsert(MMProductCategory t)
        {
            mMProductCategoryRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(MMProductCategory t)
        {
            mMProductCategoryRepository.Update(t);
            unitOfWork.Complete();
        }
    }
}
