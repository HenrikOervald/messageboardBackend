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
        static int UserCount = 2;

        public static List<Models.User> users = new List<Models.User> {
            new Models.User{
                UserName = "Henrik",
                Password = "you2arem3",
                UserID = 1
            },
            new Models.User{
                UserName = "Signe",
                Password = "p3dersen",
                UserID = 2
            }
        };

        // GET: api/User
        [HttpGet]
        public IEnumerable<Models.User> Get()
        {
            return users;
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] Models.User user)
        {
                if (users.Any(p => p.UserName == user.UserName))
                {
                 return BadRequest();
                }
                else
                {
                    if (user.UserID == null)
                    {
                        UserCount++;
                        user.UserID = UserCount;
                        users.Add(user);
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
        }
    
        // DELETE : api/User/{id} 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var i = users.SingleOrDefault(u => u.UserID == id);
            if (i != null)
            {
                users.Remove(i);
                return Ok(users);
            }
            else {
                return NotFound();
            }
        }
    }
}
