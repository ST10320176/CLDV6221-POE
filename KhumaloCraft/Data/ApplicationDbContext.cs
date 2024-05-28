using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace KhumaloCraft.Data
{
        public class ApplicationDbContext : IdentityDbContext

        {
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<LoginUserEntity> LoginUser { get; set; }

        }
    
}
