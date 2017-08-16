﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.DataStorage
{
    public class DataStorage : DataControlInterface
    {
        private static DataStorage instance;
        public List<Models.Post> Posts;
        public List<Models.SubPost> SupPosts;

        public int PostIDCounter = 0;

        private DataStorage() {
            Posts = new List<Models.Post>();
            SupPosts = new List<Models.SubPost>();
        }

        //Singleton class
        public static DataStorage Instance {
            get {
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;

            }
        }

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

        public IActionResult EditAnExistingPost(Models.Post post)
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
