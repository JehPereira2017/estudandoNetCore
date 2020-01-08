using Microsoft.EntityFrameworkCore;
using Change4Life.Models;

namespace Change4Life.Models
{
    public class Change4LifeContext : DbContext
    {
        public Change4LifeContext(DbContextOptions<Change4LifeContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Change4Life.Models.Medidas> Medidas { get; set; }
    }
}