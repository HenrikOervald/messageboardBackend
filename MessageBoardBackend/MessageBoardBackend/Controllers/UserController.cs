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

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] Models.User user)
        {
            for (int i = 0; i < users.Count; i++) {

                if (users.Any(p => p.UserName == user.UserName))
                {
                    
                    System.Diagnostics.Debug.WriteLine("User already exists");
                }
                else
                {
                    if (user.UserID == null)
                    {
                            UserCount++;
                            user.UserID = UserCount;
                            users.Add(user);
                    }
                    else
                    {
                        Console.Error.WriteLine("User not added");
                    }
                }
            }
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
    }


}
