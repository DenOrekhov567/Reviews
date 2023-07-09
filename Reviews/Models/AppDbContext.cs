using Microsoft.EntityFrameworkCore;

namespace Reviews.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<ReviewModel> Reviews { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}