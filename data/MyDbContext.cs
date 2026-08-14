using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    public DbSet<UsrAdmin> USR_ADMIN { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasQueryFilter(p => p.Name == "Test");
    }

}