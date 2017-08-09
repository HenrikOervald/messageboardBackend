using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    public class Post
    {
        public UInt32 ID { get; set; }
        public int AuthorID { get; set; }
        public String Text { get; set; }



    }
}
