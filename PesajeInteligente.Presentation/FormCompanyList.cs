// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Pesaje Inteligente - Listado de empresas
// </copyright>
// <summary>
// Formulario para mostrar, agregar, editar y eliminar empresas en el sistema.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using PesajeInteligente.Application.Interfaces;
using PesajeInteligente.Application.Services;
using PesajeInteligente.Entities.Dtos;
using PesajeInteligentes.Helpers;
using System.ComponentModel;

namespace PesajeInteligentes
{
    /// <summary>
    /// Formulario para la gestión de empresas.
    /// </summary>
    public partial class FormCompanyList : Form
    {
        private readonly ICompanyService _companyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormCompanyList"/> class.
        /// </summary>
        public FormCompanyList()
        {
            InitializeComponent();
            _companyRepository = new CompanyService();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void FormCompanyList_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        /// <summary>
        /// Carga la lista de empresas en el DataGridView.
        /// </summary>
        private void LoadCompanies()
        {
            dataGridViewCompanies.AutoGenerateColumns = false;
            DataGridViewCompanyConfigurator.Configure(dataGridViewCompanies);

            var companies = _companyRepository.GetAllCompanies();

            if (companies != null && companies.Any())
            {
                dataGridViewCompanies.DataSource = new BindingList<CompanyDto>(companies.ToList());
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para agregar una empresa.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var formEditor = new FormCompanyEditor(_companyRepository);
            formEditor.ShowDialog();
            LoadCompanies();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para editar una empresa seleccionada.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count == 1)
            {
                var companyId = (int)dataGridViewCompanies.SelectedRows[0].Cells["EmpresaID"].Value;
                var company = _companyRepository.GetCompanyById(companyId);
                var formEditor = new FormCompanyEditor(_companyRepository, company);
                formEditor.ShowDialog();
                LoadCompanies();
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para eliminar empresas seleccionadas.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCompanies.SelectedRows)
            {
                var companyId = (int)row.Cells["EmpresaID"].Value;
                _companyRepository.DeleteCompany(companyId);
            }

            LoadCompanies();
        }

        /// <summary>
        /// Maneja el evento de cambio de texto en el cuadro de filtro para buscar empresas.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            var filterText = txtFilter.Text.ToLower();
            var companies = _companyRepository.GetAllCompanies()
                .Where(c => c.Nombre.ToLower().Contains(filterText))
                .ToList();

            dataGridViewCompanies.DataSource = new BindingList<CompanyDto>(companies);
        }
    }
}
