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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryManager(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public void TDelete(Category t)
        {
            categoryRepository.Delete(t);
            unitOfWork.Complete();
        }

        public Category TGetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public List<Category> TGetAll()
        {
            return categoryRepository.GetAll();
        }

        public void TInsert(Category t)
        {
            categoryRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(Category t)
        {
            categoryRepository.Update(t);   
            unitOfWork.Complete();
        }
    }
}
