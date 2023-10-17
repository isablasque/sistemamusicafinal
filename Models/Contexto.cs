using Microsoft.EntityFrameworkCore;

namespace sistemamusicafinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Album>? Album { get; set; }
        public DbSet<Cantor>? Cantor { get; set; }
        public DbSet<Musica>? Musica { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }

    }
}

