using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class ApplicationContext : DbContext

    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options) { }

        public DbSet<Application> Movies { get; set; }
    }
}
