using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.API.Dto;
using TwitterClone.MODEL.Repositories;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TwitController : BaseController
    {
        private readonly ITwitRepository twitRepository;
        public TwitController(ITwitRepository twitRepository)
        {
            this.twitRepository = twitRepository;
        }

        [HttpGet]
        public IActionResult GetAllTwitsByUserName(string username)
        {
            var twits = twitRepository.GetAllTwitsByUsername(username);
            if (twits == null)
            {
                return NoContent();
            }
            return Ok(base.CreateSuccessReturnType(twits, null, true));
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateTwit(TwitDto twitDto)
        //{
        //    return null;
        //}
    }
}
