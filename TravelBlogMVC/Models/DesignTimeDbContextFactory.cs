using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TravelBlogMVC.Models
{
  public class TravelBlogMVCContextFactory : IDesignTimeDbContextFactory<TravelBlogMVCContext>
  {

    TravelBlogMVCContext IDesignTimeDbContextFactory<TravelBlogMVCContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<TravelBlogMVCContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new TravelBlogMVCContext(builder.Options);
    }
  }
}