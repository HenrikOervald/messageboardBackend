﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    public class Post
    {
     public String Owner { get; set; }
     public String Text { get; set; }
    public DateTime Date { get; set; }

    }
}
