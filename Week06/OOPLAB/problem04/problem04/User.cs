using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem04
{
    internal class User
    {
       public string UserName { get; set; }
        public List<Posts> Posts { get; set; }
        public List<Follower> Followers { get; set; }
        public List<Likes> Likes { get; set; }
        public User(string userName)
        {
            UserName = userName;
            Posts = new List<Posts>();
            Followers = new List<Follower>();
            Likes = new List<Likes>();
        }
        public void AddPost(Posts post)
        {
            Posts.Add(post);
        }
        public void AddFollower(Follower follower)
        {
            Followers.Add(follower);
        }
        public void AddLike(Likes like)
        {
            Likes.Add(like);
        }

    }
}
