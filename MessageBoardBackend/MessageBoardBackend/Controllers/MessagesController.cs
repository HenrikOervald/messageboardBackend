using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

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
                    Owner = "Henrik",
                    Text = "Hello all!",
                    Date = DateTime.Now
                },
                new Models.Post
                {
                    Owner = "Signe",
                    Text = "Hello John",
                    Date = DateTime.Now
                }
            };

        public IEnumerable<Models.Post> Get() {
            return messages; 
        }

        [HttpGet("{owner}")]
        public List<Models.Post> Get(string owner)
        {
            List<Models.Post> mes = new List<Models.Post> { };
            for(int i=0; i<messages.Count; i++)
            {
                if (messages[i].Owner == owner) {
                    mes.Add(messages[i]);
                        
                    }
            }
            return mes;
        }

        [HttpPost]
        public Models.Post Post([FromBody] Models.Post message) {
            messages.Add(message);
            return message;
        }
    }
}