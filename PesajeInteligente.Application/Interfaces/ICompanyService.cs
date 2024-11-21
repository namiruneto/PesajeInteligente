using PesajeInteligente.Entities.Dtos;

namespace PesajeInteligente.Application.Interfaces
{
    /// <summary>
    /// Interface that defines methods for managing companies.
    /// </summary>
    public interface ICompanyService
    {
        /// <summary>
        /// Retrieves all companies.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="CompanyDto"/> objects representing all companies.
        /// </returns>
        IEnumerable<CompanyDto> GetAllCompanies();

        /// <summary>
        /// Retrieves a company by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the company.</param>
        /// <returns>
        /// A <see cref="CompanyDto"/> object representing the company with the specified ID.
        /// </returns>
        CompanyDto GetCompanyById(int id);

        /// <summary>
        /// Adds a new company.
        /// </summary>
        /// <param name="empresaDto">The <see cref="CompanyDto"/> object containing the company data.</param>
        void AddCompany(CompanyDto empresaDto);

        /// <summary>
        /// Updates the data of an existing company.
        /// </summary>
        /// <param name="empresaDto">The <see cref="CompanyDto"/> object containing the updated company data.</param>
        void UpdateCompany(CompanyDto empresaDto);

        /// <summary>
        /// Deletes a company by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the company to be deleted.</param>
        void DeleteCompany(int id);
    }
}
