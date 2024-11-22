using PesajeInteligente.Entities.Domain;
using Microsoft.EntityFrameworkCore;

namespace PesajeInteligente.Infrastructure.Data
{
    /// <summary>
    /// Contexto de base de datos para la gestión de entidades relacionadas con las empresas.
    /// </summary>
    public class CompanyDbContext : DbContext
    {
        // Constructor que recibe las opciones de configuración para el contexto
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// DbSet que representa las empresas en la base de datos.
        /// </summary>
        public DbSet<Company> Company { get; set; }

        /// <summary>
        /// Configuración del modelo de la base de datos.
        /// Aquí puedes definir configuraciones adicionales, como claves primarias, índices, etc.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Company>()
                .HasKey(c => c.EmpresaID); 

        }
    }
}
