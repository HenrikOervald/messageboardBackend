using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/SubPost")]
    public class SubPostController : Controller
    {
        DataStorage.DataStorageController DataStorageController = new DataStorage.DataStorageController();
        
        // GET: api/SubPost
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DataStorageController.GetAllPosts());
        }

        // GET: api/SubPost/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            List<Models.SubPost> returnList = DataStorageController.GetAllSupPosts();
            if (returnList != null)
            {
                return Ok(returnList);
            }
            else {
                return BadRequest();
            }
        }
        
        // POST: api/SubPost
        [HttpPost]
        public IActionResult Post([FromBody] Models.SubPost supPost)
        {
            try
            {
                return Ok(DataStorageController.CreateNewSupPostForPost(supPost));
            }
            catch (Exceptions.MessageAlreadyExistsException e) {
                return BadRequest(e);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Models.SubPost> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
