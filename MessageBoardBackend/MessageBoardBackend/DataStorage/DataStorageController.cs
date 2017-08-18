using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.DataStorage
{
    public class DataStorageController : IDataControlInterface
    {
        DataStorage data = DataStorage.Instance;

        public List<Post> CreateNewPost(Post post)
        {
            return data.CreateNewPost(post);
        }

        public List<Post> CreateNewSupPostForPost(Post post)
        {
            return CreateNewSupPostForPost(post);
        }

        public List<Post> EditAnExistingPost(Post post)
        {
            return data.EditAnExistingPost(post);
        }

        public List<Post> GetAllTopLevelPosts()
        {
            return GetAllTopLevelPosts();
        }

        public List<Post> GetSupPostsForUpperLevelPost(Models.Post post)
        {
            return GetSupPostsForUpperLevelPost(post);
        }
    }
}
