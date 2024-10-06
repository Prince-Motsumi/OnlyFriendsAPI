using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Domain.Entities
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string ProfileImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }

        // Relationships
        public ICollection<Post> Posts { get; set; } // A user can have multiple posts
        public ICollection<Comment> Comments { get; set; } // A user can make multiple comments
    }
}
