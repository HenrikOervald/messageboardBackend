using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        static List<Models.Post> messages = new 
            List<Models.Post>{
                new Models.Post
                {
                    Owner = "John",
                    Text = "Hello all!"
                },
                new Models.Post
                {
                    Owner = "Tim",
                    Text = "Hello John"
                }
            };

        public IEnumerable<Models.Post> Get() {
            return messages; 
        }

        [HttpPost]
        public Models.Post Post([FromBody] Models.Post message) {
            messages.Add(message);
            return message;
        }
    }
}