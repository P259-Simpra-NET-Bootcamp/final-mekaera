using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.Coupon;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(Coupon)")]
    public class CouponController : Controller
    {
        private readonly ICouponService CouponService;
        private IMapper mapper;

        public CouponController(ICouponService CouponService, IMapper mapper)
        {
            this.CouponService = CouponService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<CouponResponse> GetAll()
        {
            var list = CouponService.TGetAll;
            var mapped = mapper.Map<List<CouponResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public CouponResponse GetById(int id)
        {
            var row = CouponService.TGetById;
            var mapped = mapper.Map<CouponResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] CouponRequest request)
        {
            var entity = mapper.Map<Coupon>(request);
            CouponService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CouponResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<Coupon>(request);
            CouponService.TUpdate(entity);

        }
    }
}
