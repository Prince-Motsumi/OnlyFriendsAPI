using Microsoft.AspNetCore.Identity;

namespace OnlyFriends.Domain.Entities
{
    public class User : IdentityUser
    {
        public string Bio { get; set; }
        public string ProfileImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }

        // Relationships
        public ICollection<Post> Posts { get; set; } // A user can have multiple posts
        public ICollection<Comment> Comments { get; set; } // A user can make multiple comments
    }
}
