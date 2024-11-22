using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PesajeInteligente.Infrastructure.Data;
using System.IO;

namespace PesajeInteligente.Infrastructure.Abstracts
{
    /// <summary>
    /// Abstract base class for handling database connection configuration.
    /// This class provides methods to configure and create a DbContext for the Company database.
    /// </summary>
    public abstract class DatabaseConnectionBase
    {
        private readonly string _connectionString;
        private DbContextOptions<CompanyDbContext>? _options;

        /// <summary>
        /// Initializes the DatabaseConnectionBase class and loads the connection string from appsettings.json.
        /// </summary>
        protected DatabaseConnectionBase()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json")              
                .Build();

            _connectionString = configuration.GetConnectionString("PesajeInteligenteConnection") ??
                                throw new InvalidOperationException("Connection string not found.");
        }

        /// <summary>
        /// Configures the DbContext options using the SQL Server connection string.
        /// </summary>
        protected void ConfigureDbContext()
        {
            if (_options == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<CompanyDbContext>();
                optionsBuilder.UseSqlServer(_connectionString);
                _options = optionsBuilder.Options;  
            }
        }

        /// <summary>
        /// Creates a new instance of CompanyDbContext using the configured options.
        /// This method ensures that the DbContext is properly configured before instantiation.
        /// </summary>
        /// <returns>An instance of CompanyDbContext</returns>
        protected CompanyDbContext CreateDbContext()
        {
            if (_options == null)
            {
                ConfigureDbContext();
            }

            return new CompanyDbContext(_options!);
        }
    }
}
