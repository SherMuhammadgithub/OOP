using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem04
{
    internal class Likes
    {
        public string Like { get; set; }
        public User  User { get; set; }
        public DateTime LikeDate { get; set; }
        public Likes(string like, User user, DateTime likeDate)
        {
            Like = like;
            User = user;
            LikeDate = likeDate;
        }
    }
}
