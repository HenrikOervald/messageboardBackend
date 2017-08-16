using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend
{
    interface DataControlInterface
    {
        //Actions for Posts
        public IActionResult GetAllPosts();
        public IActionResult CreateNewPost(Models.Post post);
        public IActionResult EditAnExistingPost(Models.Post post);

        //Actions for SubPosts
        public IActionResult GetSubPostForPost(int id);
        public IActionResult CreateNewSupPostForPost(int id, Models.Post post);
        public IActionResult EditAnExistingSupPost(int id);

        //Shared actions between Posts and SubPosts
        public IActionResult DeleteSinglePostWithSubPosts(int idForPost);

    }
}
