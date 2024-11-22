using PesajeInteligente.Entities.Domain;
using PesajeInteligente.Infrastructure.Abstracts;
using PesajeInteligente.Infrastructure.Interfaces;

namespace PesajeInteligente.Infrastructure.Repositories
{
    public class CompanyRepository : DatabaseConnectionBase, ICompanyRepository
    {     

        /// <summary>
        /// Retrieves all companies from the database.
        /// </summary>
        /// <returns>List of companies</returns>
        public List<Company> GetAllCompanies()
        {
            using var context = CreateDbContext();
            return context.Company.ToList();
        }

        /// <summary>
        /// Retrieves a company by its ID from the database.
        /// </summary>
        /// <param name="companyId">The ID of the company to retrieve</param>
        /// <returns>The company with the specified ID, or null if not found</returns>
        public Company GetCompanyById(int companyId)
        {
            using var context = CreateDbContext();
            return context.Company.Find(companyId);  // Finds a company by its primary key (ID)
        }

        /// <summary>
        /// Adds a new company to the database.
        /// </summary>
        /// <param name="company">The company to add</param>
        public void AddCompany(Company company)
        {
            using var context = CreateDbContext();
            context.Company.Add(company);
            context.SaveChanges();
        }

        /// <summary>
        /// Removes a company by ID.
        /// </summary>
        /// <param name="companyId">The ID of the company to remove</param>
        public void DeleteCompany(int companyId)
        {
            using var context = CreateDbContext();
            var company = context.Company.Find(companyId);
            if (company != null)
            {
                context.Company.Remove(company);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing company in the database.
        /// </summary>
        /// <param name="company">The updated company object</param>
        /// <returns>True if the update is successful, otherwise false</returns>
        public bool UpdateCompany(Company company)
        {
            using var context = CreateDbContext();
            var existingCompany = context.Company.Find(company.EmpresaID);

            if (existingCompany != null)
            {
                // Update the fields of the existing entity
                existingCompany.Nombre = company.Nombre;
                existingCompany.Codigo = company.Codigo;
                existingCompany.Direccion = company.Direccion;
                existingCompany.Telefono = company.Telefono;
                existingCompany.Ciudad = company.Ciudad;
                existingCompany.Departamento = company.Departamento;
                existingCompany.Pais = company.Pais;
                existingCompany.FechaUltimaModificacion = DateTime.Now; // Optional: track the last update

                context.SaveChanges();
                return true; // Update was successful
            }
            return false; // Company not found
        }

    }
}
