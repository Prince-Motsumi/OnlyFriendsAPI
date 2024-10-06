using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; } // Primary Key
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }

        // Foreign Keys and Relationships
        public int PostId { get; set; } // Foreign Key to Post
        public Post Post { get; set; } // Navigation Property: A comment belongs to a post
        public int UserId { get; set; } // Foreign Key to User
        public User User { get; set; } // Navigation Property: A comment is made by a user
    }
}
