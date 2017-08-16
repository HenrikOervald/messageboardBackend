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
        List<Models.Post> GetAllPosts();
        List<Models.Post> CreateNewPost(Models.Post post);
        List<Models.Post> EditAnExistingPost(Models.Post post);

        //Actions for SubPosts
        List<Models.SubPost> GetAllSupPosts();
        List<Models.SubPost> GetSubPostForPost(int id);
        List<Models.SubPost> CreateNewSupPostForPost(Models.SubPost post);
        List<Models.SubPost> EditAnExistingSupPost(int id);

        //Shared actions between Posts and SubPosts
        List<Models.Post> DeleteSinglePostWithSubPosts(int idForPost);

    }
}
