using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MessageBoardBackend.DataStorage
{
    public class DataStorage : IDataControlInterface
    {
        private static DataStorage instance;
        public List<Models.Post> Posts;

        public int PostIDCounter = 0;

        private DataStorage()
        {
            Posts = new List<Models.Post>();
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
                return Posts;
            }
            else if (!Posts.Any(p => p.PostID == post.PostID))
            {
                Posts.Add(post);
                return Posts;
            }
            else {
                throw new Exceptions.MessageAlreadyExistsException();
            }
        }

        public List<Post> EditAnExistingPost(Post post)
        {
            int index = Posts.FindIndex(item => item.PostID == post.PostID);
            if (index != -1)
            {
                Posts[index].Text = post.Text;
                return Posts;
            }
            else {
                throw new Exceptions.MessageDoesNotExistException();
            }
        }

        public List<Post> GetAllTopLevelPosts()
        {
            List<Post> returnList = new List<Post>();
            foreach (var post in Posts) {
                if (post.ParentID == null) {
                    returnList.Add(post);
                }
            }

            return returnList;
        }

        public List<Post> GetSupPostsForTopLevelPost(Post post)
        {
            populateChildrenList(post , 2);
            return post.childrensList;
        }

        private void populateChildrenList(Post post , int counter) {
            foreach (Post p in Posts)
            {
                if (p.ParentID == post.PostID)
                {
                    post.childrensList.Add(p);
                }
            }

            if (counter > 0)
            {
                foreach (Post x in post.childrensList)
                {
                    populateChildrenList(x, counter-1);
                }
            }
        }
    }
}
