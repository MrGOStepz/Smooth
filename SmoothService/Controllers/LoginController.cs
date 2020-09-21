using Microsoft.AspNetCore.Mvc;
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
            return Ok("Test");
        }
    }
}
