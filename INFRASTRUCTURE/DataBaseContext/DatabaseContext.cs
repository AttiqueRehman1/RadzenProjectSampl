using Domains.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace INFRASTRUCTURE.DataBaseContext
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null;
        public DbSet<Product_IMAGE> ProductImages { get; set; } = null;
        public DbSet<Slide> Slides { get; set; } = null;
    }
}
