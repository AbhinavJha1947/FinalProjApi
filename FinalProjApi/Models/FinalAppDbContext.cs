using Microsoft.EntityFrameworkCore;

namespace FinalProjApi.Models
{
    public class FinalAppDbContext : DbContext
    {
        public FinalAppDbContext(DbContextOptions<FinalAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
