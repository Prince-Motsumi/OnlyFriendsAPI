using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; } // Primary Key
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DatePosted { get; set; }

        // Foreign Keys and Relationships
        public int UserId { get; set; } // Foreign Key to User
        public User User { get; set; } // Navigation Property: A post is made by a user
        public ICollection<Comment> Comments { get; set; } // A post can have multiple comments
    }
}
