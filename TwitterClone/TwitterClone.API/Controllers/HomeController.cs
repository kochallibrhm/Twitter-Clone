using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : BaseController
    {
        [HttpGet]
        public string Get()
        {
            return "TwitterClone.api";
        }
    }
}
