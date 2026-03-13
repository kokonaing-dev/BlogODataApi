using BlogODataApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogODataApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    public DbSet<Author> Authors { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}