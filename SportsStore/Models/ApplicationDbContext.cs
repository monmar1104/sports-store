using System;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> 
                options) : base(options) { }

        public DbSet<ProductE> Products { get; set; }

    }
}
