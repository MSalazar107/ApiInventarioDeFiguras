using ApiInventarioDeFiguras.Entidades;
using Microsoft.EntityFrameworkCore;
namespace ApiInventarioDeFiguras
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Figura> Figuras { get; set; }
        public DbSet<Wave> Waves { get; set; }
    }
    

}
