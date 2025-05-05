using Microsoft.EntityFrameworkCore;
using MeuProjetoAPI.Models; // Substitua com o namespace correto

namespace MeuProjetoAPI.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } // exemplo de entidade
    }
}
