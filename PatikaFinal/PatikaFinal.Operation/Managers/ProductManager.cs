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
    public class ProductManager : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductManager(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }
     
        public void TDelete(Product t)
        {
            productRepository.Delete(t);
            unitOfWork.Complete();
        }

        public Product TGetById(int id)
        {
            return productRepository.GetById(id);
        }

        public List<Product> TGetAll()
        {
            return productRepository.GetAll();
        }

        public void TInsert(Product t)
        {
            productRepository.Insert(t);
            unitOfWork.Complete();
        }

        public void TUpdate(Product t)
        {
            productRepository.Update(t);
            unitOfWork.Complete();
        }
    }
}
