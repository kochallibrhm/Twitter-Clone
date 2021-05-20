using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.API.Dto;
using TwitterClone.MODEL.Entities;
using TwitterClone.MODEL.Repositories;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var allUsers = userRepository.GetAll().ToList();
            if (allUsers.Count == 0)
            {
                return NoContent();
            }
            return Ok(base.CreateSuccessReturnType(allUsers, null, true));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                // Checking if this username and email has been registered before
                var availableUser = userRepository.GetByUserName(userDto.UserName);
                var availableUserforMail = userRepository.GetByEmail(userDto.Email);
                if (availableUser == null && availableUserforMail == null)
                {
                    // if they are not, do registration
                    var user = new User
                    {
                        Name = userDto.Name,
                        LastName = userDto.LastName,
                        Username = userDto.UserName,
                        Email = userDto.Email,
                        Password = userDto.Password,
                        Birthday = userDto.BirthDay,
                        ImageUrl = userDto.ImageUrl,
                        IsAdmin = false
                    };

                    await userRepository.Create(user);
                    return CreatedAtAction("CreateUser", 
                        base.CreateSuccessReturnType(user, "User Registration Successful", true));

                }
                // Checking wich one is used for return an error
                else if(availableUser != null)
                {
                    return BadRequest(
                        base.CreateErrorReturnType(
                            null, "Username has been used by another user", false));
                }
                else
                {
                    return BadRequest(
                        base.CreateErrorReturnType(
                            null, "Email has been used for another registration", false));
                }
                
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
