using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend
{
    interface IDataControlInterface
    {
        //Actions for Posts
        List<Models.Post> GetAllTopLevelPosts();
        List<Models.Post> CreateNewPost(Models.Post post);
        List<Models.Post> EditAnExistingPost(Models.Post post);
        List<Models.Post> GetSupPostsForUpperLevelPost(Models.Post post);
       


    }
}
