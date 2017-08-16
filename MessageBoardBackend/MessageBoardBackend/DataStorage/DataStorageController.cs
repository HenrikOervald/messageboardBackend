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
        DataStorage data = DataStorage.Instance;

        public List<Post> CreateNewPost(Post post)
        {
            return data.CreateNewPost(post);
        }

        public List<SubPost> CreateNewSupPostForPost(SubPost post)
        {
            throw new NotImplementedException();
        }

        public List<Post> DeleteSinglePostWithSubPosts(int idForPost)
        {
            throw new NotImplementedException();
        }

        public List<Post> EditAnExistingPost(Post post)
        {
            throw new NotImplementedException();
        }

        public List<SubPost> EditAnExistingSupPost(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public List<SubPost> GetAllSupPosts()
        {
            throw new NotImplementedException();
        }

        public List<SubPost> GetSubPostForPost(int id)
        {
            throw new NotImplementedException();
        }
    }
}
