using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    public class SubPost : Post
    {
        public int ParentID { get; set; }
    }
}
