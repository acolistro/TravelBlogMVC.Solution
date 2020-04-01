using Microsoft.EntityFrameworkCore;

namespace TravelBlogMVC.Models
{
  public class TravelBlogMVCContext : DbContext
  {
    public TravelBlogMVCContext(DbContextOptions<TravelBlogMVCContext> options)
      : base(options)
    {
    }
    
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, Author = "Michelle", Destination = "Louvre", Rating = 3, Description = "too crowded, some cool art", City = "Paris", Country = "France" },
          new Review { ReviewId = 2, Author = "Joe", Destination = "Irazu volcano national park", Rating = 4, Description = "it's a volcano", City = "Cartago", Country = "Costa Rica" },
          new Review { ReviewId = 3, Author = "Cletus", Destination = "The sticks", Rating = 5, Description = "real nice", City = "Cedar Creek", Country = "Canada" },
          new Review { ReviewId = 4, Author = "James", Destination = "Da Club", Rating = 3, Description = "It was aight", City = "Sydney", Country = "Australia" }
        );
      
      builder.Entity<User>()
        .HasData(
          new User { Id = 1, FirstName = "Michelle", LastName = "Nolastname", Username = "michelle", Password = "hello" },
          new User { Id = 2, FirstName = "Joe", LastName = "Yolo", Username = "joe", Password = "world" },
          new User { Id = 3, FirstName = "James", LastName = "Aight", Username = "james", Password = "password" }
        );
    }
  }
}