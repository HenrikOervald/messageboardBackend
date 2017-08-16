using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.DataStorage
{
    public class DataStorageController : DataControlInterface
    {
        public IActionResult CreateNewPost(Post post)
        {
            throw new NotImplementedException();
        }

        public IActionResult CreateNewSupPostForPost(int id, Post post)
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteSinglePostWithSubPosts(int idForPost)
        {
            throw new NotImplementedException();
        }

        public IActionResult EditAnExistingPost(Post post)
        {
            throw new NotImplementedException();
        }

        public IActionResult EditAnExistingSupPost(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetSubPostForPost(int id)
        {
            throw new NotImplementedException();
        }
    }
}
