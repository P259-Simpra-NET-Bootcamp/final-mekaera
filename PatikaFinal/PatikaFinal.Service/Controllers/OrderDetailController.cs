using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.OrderDetail;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(OrderDetail)")]
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService OrderDetailService;
        private IMapper mapper;

        public OrderDetailController(IOrderDetailService OrderDetailService, IMapper mapper)
        {
            this.OrderDetailService = OrderDetailService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<OrderDetailResponse> GetAll()
        {
            var list = OrderDetailService.TGetAll;
            var mapped = mapper.Map<List<OrderDetailResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public OrderDetailResponse GetById(int id)
        {
            var row = OrderDetailService.TGetById;
            var mapped = mapper.Map<OrderDetailResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] OrderDetailRequest request)
        {
            var entity = mapper.Map<OrderDetail>(request);
            OrderDetailService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderDetailResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<OrderDetail>(request);
            OrderDetailService.TUpdate(entity);

        }
    }
}
