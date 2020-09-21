using Microsoft.AspNetCore.Mvc;
using SmoothService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]   
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            Staff staff = new Staff();

            return Ok("Test");
        }
    }
}
