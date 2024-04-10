using Microsoft.EntityFrameworkCore;
using RESTfulAPIDemo.Models;
using System.Collections.Generic;

namespace RESTfulAPIDemo.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
  : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
