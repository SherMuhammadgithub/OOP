using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem04
{
    internal class Comments
    {
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }

      public Comments(string comment, DateTime commentDate, string commentText)
        {
            Comment = comment;
            CommentDate = commentDate;
            CommentText = commentText;
        }

    }
}
