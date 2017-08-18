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
            return Ok(DataStorageController.GetAllTopLevelPosts());
        }

        //Returns 3 levels of supPosts for a post
        [HttpGet("{post}")]
        public IActionResult GetSupPostsForUpperLevelPost(Models.Post post) {
            return Ok(DataStorageController.GetSupPostsForUpperLevelPost(post));
        }

        //Adds a message to the messages List
        [HttpPost]
        public IActionResult Post([FromBody] Models.Post message) {
            try{
                return Ok(DataStorageController.CreateNewPost(message));
            }
            catch(Exceptions.MessageAlreadyExistsException e){
                return NotFound() ;
            }
        }

        [HttpPut("{post}")]
        public IActionResult EditAnExistingPost(Models.Post post) {
            try{
                return Ok(DataStorageController.EditAnExistingPost(post));
            }
            catch(Exceptions.MessageDoesNotExistException e) {
                return NotFound();
            }
        }
    }
}