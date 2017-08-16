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
        
        // GET: api/SubPost
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DataStorage.DataStorage.Instance.SupPosts);
        }

        // GET: api/SubPost/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            List<Models.SubPost> returnList = DataStorage.DataStorage.Instance.GetSupPosts(id);
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
            if (supPost.PostID == null) {
                DataStorage.DataStorage.Instance.PostIDCounter++;
                supPost.PostID =DataStorage.DataStorage.Instance.PostIDCounter ;
            }
            DataStorage.DataStorage.Instance.SupPosts.Add(supPost);
            return Ok(DataStorage.DataStorage.Instance.SupPosts);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Models.SubPost> Delete(int id)
        {
            return DataStorage.DataStorage.Instance.RemoveSupPost(id);
        }
    }
}
