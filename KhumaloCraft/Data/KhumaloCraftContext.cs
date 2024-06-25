using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Models;

namespace KhumaloCraft.Data
{
    public class KhumaloCraftContext : DbContext
    {
        public KhumaloCraftContext (DbContextOptions<KhumaloCraftContext> options)
            : base(options)
        {
        }

        public DbSet<KhumaloCraft.Models.User> User { get; set; } = default!;
        public DbSet<KhumaloCraft.Models.Product> Product { get; set; } = default!;
        public DbSet<KhumaloCraft.Models.Order> Order { get; set; } = default!;
        public DbSet<KhumaloCraft.Models.Order_Product> Order_Product { get; set; } = default!;
        public DbSet<KhumaloCraft.Models.Order1> Order1 { get; set; } = default!;

       

        
    }
}
