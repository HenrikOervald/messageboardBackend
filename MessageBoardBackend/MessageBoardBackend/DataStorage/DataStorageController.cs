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
            throw new NotImplementedException();
        }

        public List<Post> GetAllTopLevelPosts()
        {
            throw new NotImplementedException();
        }

        public List<Post> GetSupPostsForTopLevelPost(Models.Post post)
        {
            throw new NotImplementedException();
        }
    }
}
