using PesajeInteligente.Entities.Domain;

namespace PesajeInteligente.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface that defines the operations for handling company data in the repository.
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Retrieves all companies from the database.
        /// </summary>
        /// <returns>A list of companies</returns>
        List<Company> GetAllCompanies();

        /// <summary>
        /// Retrieves a company by its ID.
        /// </summary>
        /// <param name="companyId">The ID of the company to retrieve</param>
        /// <returns>The company with the specified ID</returns>
        Company GetCompanyById(int companyId);

        /// <summary>
        /// Adds a new company to the database.
        /// </summary>
        /// <param name="company">The company to add</param>
        void AddCompany(Company company);

        /// <summary>
        /// Removes a company by its ID.
        /// </summary>
        /// <param name="companyId">The ID of the company to remove</param>
        void DeleteCompany(int companyId);

        /// <summary>
        /// Updates an existing company in the database.
        /// </summary>
        /// <param name="company">The company with updated information</param>
        /// <returns>True if the update was successful; otherwise, false</returns>
        bool UpdateCompany(Company company);
    }
}
