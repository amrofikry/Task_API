using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PP.HiringSystem.Core.@interface.Infastructure;
using RepostaryPattren.Api.Dtos;
using RepostaryPattren.Core.Identity;
using RepostaryPattren.Data.Appcontext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepostaryPattren.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBaseRepository<User> UserRepository;
        private readonly IMapper _mapper;
        private ApplicationDBcontext applicationDBcontext;

        public UserController(IMapper mapper, ApplicationDBcontext applicationDBcontext, IBaseRepository<User> userRepository)
        {
            this.applicationDBcontext = applicationDBcontext;
            UserRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllUser()
        {
            var users = await UserRepository.GetAllUserAsync();

            var result = _mapper.Map<List<GetUserDto>>(users);

            return Ok(result);
        }


        [HttpPost]

        public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
        {

            var user = new User
            {

                Id = userDto.Id.ToString(),
                UserName = userDto.UserName,
                PhoneNumber = userDto.PhoneNumber,
                Email = userDto.Email,
                certificates=userDto.certificates.Select(e=>new Core.Entities.certificate { name=e.name}).ToList()

            };

           


            await applicationDBcontext.AddAsync(user);
            await  applicationDBcontext.SaveChangesAsync();
            var result = _mapper.Map<UserDto>(user);

            return Ok(result);

        }


    }
}
