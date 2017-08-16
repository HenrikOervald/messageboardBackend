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
        
        




        //Returns the messages list containing all messages
        public IEnumerable<Models.Post> Get() {
       
            return DataStorage.DataStorage.Instance.Posts;
        }

        //Returns all messages for a single owner
        [HttpGet("{owner}")]
        public IActionResult Get(string owner)
        {
            var messages = DataStorage.DataStorage.Instance.Posts;
            List<Models.Post> mes = new List<Models.Post>();
            for(int i=0; i<messages.Count; i++)
            {
                if (messages[i].Owner == owner) {
                    mes.Add(messages[i]);
                        
                    }
            }
            return Ok(mes);
        }

        //Adds a message to the messages List
        [HttpPost]
        public IActionResult Post([FromBody] Models.Post message) {
            if (message.PostID == null) {
                DataStorage.DataStorage.Instance.PostIDCounter++;
                message.PostID = DataStorage.DataStorage.Instance.PostIDCounter;
            }
            DataStorage.DataStorage.Instance.Posts.Add(message);
            return Ok(message);
        }
    }
}