using Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class InstagramDBContext : DbContext
{
    public InstagramDBContext(DbContextOptions<InstagramDBContext> opt) : base(opt)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Follow> Follows { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<UserType> UserType { get; set; }
    public DbSet<PostType> PostTypes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Follow>()
          .HasOne(f => f.User)
          .WithMany(u => u.Followings)
          .HasForeignKey(f => f.UserId)
          .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Follow>()
            .HasOne(f => f.FollowedUser)
            .WithMany(u => u.Followers)
            .HasForeignKey(f => f.FollowedUserId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }

}
