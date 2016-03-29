using System.Data.Entity;

namespace GitMvcWebApplication.Models
{
    public class KrunalContext : DbContext
    {
        public KrunalContext() : base("KrunalDbContext")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}