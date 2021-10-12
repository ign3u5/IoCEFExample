using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1.Models
{
    public class CollabSoftContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public CollabSoftContext(DbContextOptions<CollabSoftContext> options) : base(options) { }
    }
}
