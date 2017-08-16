using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MessageBoardBackend.DataStorage
{
    public class DataStorage : DataControlInterface
    {
        private static DataStorage instance;
        public List<Models.Post> Posts;
        public List<Models.SubPost> SupPosts;

        public int PostIDCounter = 0;

        private DataStorage()
        {
            Posts = new List<Models.Post>();
            SupPosts = new List<Models.SubPost>();
        }

        //Singleton class
        public static DataStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;

            }
        }

        public List<Post> CreateNewPost(Post post)
        {
            if (post.PostID == null)
            {
                PostIDCounter++;
                post.PostID = PostIDCounter;
                Posts.Add(post);
                return Posts;
            }
            else if (!Posts.Any(p => p.PostID == post.PostID))
            {
                Posts.Add(post);
                return Posts;
            }
            else {
                throw new Exceptions.MessageAlreadyExistsException("A Post with that ID already exists");
            }
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
