using ExampleVerticalSliceArchteture.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace ExampleVerticalSliceArchteture.Api.Infrastructure
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
    }
}
