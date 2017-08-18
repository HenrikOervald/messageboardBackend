using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        DataStorage.UserStorageController userStorageControl = new DataStorage.UserStorageController();

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(userStorageControl.GetAllUsers());
        }
        
        
        [HttpGet ("{online}")]
        public IActionResult GetOnlineUsers(string online) {
            return Ok(userStorageControl.GetAllOnlineUsers());
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] Models.User user)
        {
            try {
                return Ok(userStorageControl.CreateNewUser(user));
            } catch (Exceptions.UserAlreadyExistsException) {
                return BadRequest();
            }
        }
    
    }
}
