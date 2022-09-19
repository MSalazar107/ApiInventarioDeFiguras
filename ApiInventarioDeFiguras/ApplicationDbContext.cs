using ApiInventarioDeFiguras.Entidades;
using Microsoft.EntityFrameworkCore;
namespace ApiInventarioDeFiguras
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Figura> Figuras { get; set; }
    }
}
