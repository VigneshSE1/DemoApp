using DemoApp.Models.ViewModels;
using DemoApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.API.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_userService.Get());
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserViewModel  userViewModel)
        {
            _userService.Add(userViewModel);
            return Ok();
        }



    }
}
