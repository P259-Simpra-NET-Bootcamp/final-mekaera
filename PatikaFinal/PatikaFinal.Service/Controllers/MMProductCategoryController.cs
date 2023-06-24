using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.MMProductCategory;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(MMProductCategory)")]
    public class MMProductCategoryController : Controller
    {
        private readonly IMMProductCategoryService MMProductCategoryService;
        private IMapper mapper;

        public MMProductCategoryController(IMMProductCategoryService MMProductCategoryService, IMapper mapper)
        {
            this.MMProductCategoryService = MMProductCategoryService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<MMProductCategoryResponse> GetAll()
        {
            var list = MMProductCategoryService.TGetAll;
            var mapped = mapper.Map<List<MMProductCategoryResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public MMProductCategoryResponse GetById(int id)
        {
            var row = MMProductCategoryService.TGetById;
            var mapped = mapper.Map<MMProductCategoryResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] MMProductCategoryRequest request)
        {
            var entity = mapper.Map<MMProductCategory>(request);
            MMProductCategoryService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MMProductCategoryResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<MMProductCategory>(request);
            MMProductCategoryService.TUpdate(entity);

        }
    }
}
