using IntTest.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace IntTest.Api.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Fruit> Fruits { get; set; }
    }
}
