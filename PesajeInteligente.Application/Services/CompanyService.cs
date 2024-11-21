using PesajeInteligente.Application.Interfaces;
using PesajeInteligente.Entities.Domain;
using PesajeInteligente.Entities.Dtos;
using PesajeInteligente.Infrastructure.Interfaces;
using PesajeInteligente.Infrastructure.Repositories;

namespace PesajeInteligente.Application.Services
{
    /// <summary>
    /// Service that implements the <see cref="ICompanyService"/> interface and provides methods for managing company data.
    /// </summary>
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        /// <summary>
        /// Constructor that initializes the company repository.
        /// </summary>
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }

        /// <summary>
        /// Retrieves all companies and maps them to <see cref="CompanyDto"/>.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="CompanyDto"/> objects representing all companies.
        /// </returns>
        public IEnumerable<CompanyDto> GetAllCompanies()
        {
            return _companyRepository.GetAllCompanies().Select(e => new CompanyDto
            {
                EmpresaID = e.EmpresaID,
                Nombre = e.Nombre,
                Codigo = e.Codigo,
                Direccion = e.Direccion,
                Telefono = e.Telefono,
                Ciudad = e.Ciudad,
                Departamento = e.Departamento,
                Pais = e.Pais
            });
        }

        /// <summary>
        /// Retrieves a company by its unique ID and maps it to a <see cref="CompanyDto"/>.
        /// </summary>
        /// <param name="id">The ID of the company to retrieve.</param>
        /// <returns>
        /// A <see cref="CompanyDto"/> representing the company with the specified ID.
        /// </returns>
        public CompanyDto GetCompanyById(int id)
        {
            var empresa = _companyRepository.GetCompanyById(id);
            if (empresa == null)
                throw new KeyNotFoundException($"Company with ID {id} not found.");

            return new CompanyDto
            {
                EmpresaID = empresa.EmpresaID,
                Nombre = empresa.Nombre,
                Codigo = empresa.Codigo,
                Direccion = empresa.Direccion,
                Telefono = empresa.Telefono,
                Ciudad = empresa.Ciudad,
                Departamento = empresa.Departamento,
                Pais = empresa.Pais,
                FechaCreacion = empresa.FechaCreacion,
                FechaUltimaModificacion = empresa.FechaUltimaModificacion,
            };
        }

        /// <summary>
        /// Adds a new company based on the provided <see cref="CompanyDto"/>.
        /// </summary>
        /// <param name="empresaDto">The company data to add.</param>
        public void AddCompany(CompanyDto empresaDto)
        {
            var empresa = new Company
            {
                Nombre = empresaDto.Nombre,
                Codigo = empresaDto.Codigo,
                Direccion = empresaDto.Direccion,
                Telefono = empresaDto.Telefono,
                Ciudad = empresaDto.Ciudad,
                Departamento = empresaDto.Departamento,
                Pais = empresaDto.Pais,
                FechaCreacion = DateTime.Now,
                FechaUltimaModificacion = DateTime.Now,
            };
            _companyRepository.AddCompany(empresa);
        }

        /// <summary>
        /// Updates an existing company based on the provided <see cref="CompanyDto"/>.
        /// </summary>
        /// <param name="empresaDto">The company data to update.</param>
        public void UpdateCompany(CompanyDto empresaDto)
        {
            var empresa = new Company
            {
                EmpresaID = empresaDto.EmpresaID,
                Nombre = empresaDto.Nombre,
                Codigo = empresaDto.Codigo,
                Direccion = empresaDto.Direccion,
                Telefono = empresaDto.Telefono,
                Ciudad = empresaDto.Ciudad,
                Departamento = empresaDto.Departamento,
                Pais = empresaDto.Pais,
                FechaUltimaModificacion = DateTime.Now,
            };
            _companyRepository.UpdateCompany(empresa);
        }

        /// <summary>
        /// Deletes a company by its unique ID.
        /// </summary>
        /// <param name="id">The ID of the company to delete.</param>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the company with the specified ID is not found.
        /// </exception>
        public void DeleteCompany(int id)
        {
            var company = _companyRepository.GetCompanyById(id);

            if (company == null)
                throw new KeyNotFoundException($"Company with ID {id} not found.");

            _companyRepository.DeleteCompany(id);
        }
    }
}
