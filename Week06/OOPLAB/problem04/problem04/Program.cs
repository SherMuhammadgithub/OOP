using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John");
            Posts post = new Posts("Post 1", DateTime.Now, "This is the first post");
            user.AddPost(post);
            Follower follower = new Follower("Follower 1");
            user.AddFollower(follower);
            Likes like = new Likes("Like 1", user, DateTime.Now);
            user.AddLike(like);
            Comments comment = new Comments("Comment 1", DateTime.Now, "This is the first comment");
            post.AddComment(comment);
        }
    }
}
