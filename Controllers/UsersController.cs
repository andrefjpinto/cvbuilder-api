using AutoMapper;
using cvbuilder_api.Models;
using cvbuilder_api.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cvbuilder_api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            return Ok();
            
/*            try 
            {
                // save 
                _userService.Create(user, userDto.Password);
                return Ok();
            } 
            catch(AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }*/
        }
    }
}