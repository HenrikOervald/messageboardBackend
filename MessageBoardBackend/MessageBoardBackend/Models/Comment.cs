using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    public class Comment : Post
    {
        public UInt32 ParentID { get; set; }
        public UInt32 PostID { get; set; }
    }
}
