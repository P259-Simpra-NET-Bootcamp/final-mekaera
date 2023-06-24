using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaFinal.Data.Domain;
using PatikaFinal.Operation.Services;
using PatikaFinal.Schema.User;

namespace PatikaFinal.Service.Controllers
{
    [ApiController]
    [Route("(User)")]
    public class UserController : Controller
    {
        private readonly IUserService UserService;
        private IMapper mapper;

        public UserController(IUserService UserService, IMapper mapper)
        {
            this.UserService = UserService;
            this.mapper = mapper;
        }

        [HttpGet]
        public List<UserResponse> GetAll()
        {
            var list = UserService.TGetAll;
            var mapped = mapper.Map<List<UserResponse>>(list);
            return mapped;
        }
        [HttpGet("{id}")]
        public UserResponse GetById(int id)
        {
            var row = UserService.TGetById;
            var mapped = mapper.Map<UserResponse>(row);
            return mapped;
        }
        [HttpPost]
        public void Post([FromBody] UserRequest request)
        {
            var entity = mapper.Map<User>(request);
            UserService.TInsert(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserResponse request)
        {
            request.Id = id;
            var entity = mapper.Map<User>(request);
            UserService.TUpdate(entity);

        }
    }
}
