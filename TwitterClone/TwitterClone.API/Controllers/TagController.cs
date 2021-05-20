using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.MODEL.Repositories;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TagController : BaseController
    {
        private readonly ITagRepository tagRepository;
        public TagController(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
