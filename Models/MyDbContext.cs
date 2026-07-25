using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    public DbSet<UsrAdmin> USR_ADMIN { get; set; }
}