using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    public class Post
    {
        public int? PostID { get; set; }
        public int OwnerID { get; set; }
        public String Owner { get; set; }
        public String Text { get; set; }
        public DateTime Date = DateTime.Now;
        public int? ParentID { get; set; }
        public List<Post> childrensList = new List<Post>();



    }
}
