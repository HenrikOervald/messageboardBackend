using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/UserAcces")]
    public class UserAccesController : Controller
    {
        DataStorage.UserAccesControl UserAccesControl = new DataStorage.UserAccesControl();
        // POST: api/UserAcces
        [HttpPost]
        public IActionResult Post([FromBody]string userName, string password)
        {
            try
            {
                return Ok(UserAccesControl.LogIn(userName, password));
            }
            catch (Exceptions.BadLogInException e) {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.User user) {
            try
            {
                return Ok(UserAccesControl.LogOut(user));
            }
            catch (Exceptions.BadLogInException e) {
                return BadRequest();
            }
        }
    }
}
