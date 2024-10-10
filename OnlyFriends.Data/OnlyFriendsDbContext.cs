using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlyFriends.Domain.Entities;

namespace OnlyFriends.Data
{
    public class OnlyFriendsDbContext : IdentityDbContext<User>
    {
        public OnlyFriendsDbContext(DbContextOptions<OnlyFriendsDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can configure entity relationships and rules here if needed
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(c => c.Posts)
                .HasForeignKey(c => c.UserId);
        }
    }
}
