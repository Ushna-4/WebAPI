using Microsoft.EntityFrameworkCore;
using MyWebAPI.Models;
using System.Collections.Generic;

namespace MyWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
