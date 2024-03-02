using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem04
{
    internal class Posts
    {
        public string Post { get; set; }
        public DateTime PostDate { get; set; }
        public string PostText { get; set; }
        public List<Comments> Comments;
        public List<Likes> Likes;
        public Posts(string post, DateTime postDate, string postText)
        {
            Post = post;
            PostDate = postDate;
            PostText = postText;
            Comments = new List<Comments>();
            Likes = new List<Likes>();
        }
        public void AddComment(Comments comment)
        {
            Comments.Add(comment);
        }

        public void AddLike(Likes like)
        {
            Likes.Add(like);
        }
    }
}
