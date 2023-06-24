using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Data.UnitOfWork;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.Category;
using PatikaFinal.Schema.Product;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(Category)")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private IMapper mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<CategoryResponse> GetAll()
        {
            var list = categoryService.TGetAll;
            var mapped = mapper.Map<List<CategoryResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public CategoryResponse GetById(int id)
        {
            var row = categoryService.TGetById;
            var mapped = mapper.Map<CategoryResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] CategoryRequest request)
        {
            var entity = mapper.Map<Category>(request);
            categoryService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoryResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<Category>(request);
            categoryService.TUpdate(entity);

        }

    }
}
