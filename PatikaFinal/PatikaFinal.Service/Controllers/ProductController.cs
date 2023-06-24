using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.Product;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(Product)")]
    public class ProductController : Controller
    {
        private readonly IProductService ProductService;
        private IMapper mapper;

        public ProductController(IProductService ProductService, IMapper mapper)
        {
            this.ProductService = ProductService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<ProductResponse> GetAll()
        {
            var list = ProductService.TGetAll;
            var mapped = mapper.Map<List<ProductResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public ProductResponse GetById(int id)
        {
            var row = ProductService.TGetById;
            var mapped = mapper.Map<ProductResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] ProductRequest request)
        {
            var entity = mapper.Map<Product>(request);
            ProductService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<Product>(request);
            ProductService.TUpdate(entity);

        }
    }
}
