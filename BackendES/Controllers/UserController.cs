using BackendES.Models;
using BackendES.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [EnableCors("AllowAll")]
        [HttpGet("/api/user/all")]
        public IActionResult GetAll()
        {
            List<User> users = userService.GetUsers();
            return Ok(users);
        }


        [EnableCors("AllowAll")]
        [HttpPost("/api/user/add")]
        [AllowAnonymous]
        public IActionResult AddUser([FromBody] User user)
        {

            userService.AddUser(user);
            return Ok(user);
        }

        [EnableCors("AllowAll")]
        [HttpPatch("/api/user/update")]
        [AllowAnonymous]
        public IActionResult UpdateUser([FromBody] User user)
        {

            userService.UpdateUser(user);
            return Ok(user);
        }


        [EnableCors("AllowAll")]
        [HttpDelete("/api/user/delete/{id}")]
        [AllowAnonymous]
        public ActionResult<bool> DeleteProduct(string id)
        {
            try
            {
                return userService.DeleteUser(int.Parse(id));
            }
            catch(Exception e)
            {
                return false;
            }
        }



    }
}
