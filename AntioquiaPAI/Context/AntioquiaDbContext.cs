using Microsoft.EntityFrameworkCore;

namespace AntioquiaPAI.Context
{
    public class AntioquiaDbContext : DbContext
    {
        public AntioquiaDbContext(DbContextOptions<AntioquiaDbContext> options) : base(options)
        {

        }

        //public DbSet<User> User { get; set; }
    }
}
