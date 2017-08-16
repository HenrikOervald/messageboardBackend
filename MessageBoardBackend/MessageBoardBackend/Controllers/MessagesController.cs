using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;



namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {

        DataStorage.DataStorageController DataStorageController = new DataStorage.DataStorageController();




        //Returns the messages list containing all messages
        public IActionResult Get() {

            return Ok(DataStorageController.GetAllPosts());
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
            try
            {
                return Ok(DataStorageController.CreateNewPost(message));
            }
            catch(Exceptions.MessageAlreadyExistsException e)
            {
                
                
                return NotFound() ;
            }
        }
    }
}