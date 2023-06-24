using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.Order;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(Order)")]
    public class OrderController : Controller
    {
        private readonly IOrderService OrderService;
        private IMapper mapper;

        public OrderController(IOrderService OrderService, IMapper mapper)
        {
            this.OrderService = OrderService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<OrderResponse> GetAll()
        {
            var list = OrderService.TGetAll;
            var mapped = mapper.Map<List<OrderResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public OrderResponse GetById(int id)
        {
            var row = OrderService.TGetById;
            var mapped = mapper.Map<OrderResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] OrderRequest request)
        {
            var entity = mapper.Map<Order>(request);
            OrderService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<Order>(request);
            OrderService.TUpdate(entity);

        }
    }
}
