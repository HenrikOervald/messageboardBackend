﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    public class User
    {
        public String UserName { get; set; }
        public int UserID { get; set; }
        public String Password { get; set; }
    }
}