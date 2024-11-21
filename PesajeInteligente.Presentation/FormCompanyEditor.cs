// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Pesaje Inteligente - Formulario para editar información de empresas
// </copyright>
// <summary>
// Formulario para editar o crear una empresa en el sistema.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using PesajeInteligente.Application.Interfaces;
using PesajeInteligente.Entities.Dtos;

namespace PesajeInteligentes
{
    /// <summary>
    /// Formulario para gestionar la creación y edición de empresas.
    /// </summary>
    public partial class FormCompanyEditor : Form
    {
        private readonly ICompanyService _companyService;
        private readonly CompanyDto _company;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormCompanyEditor"/> class.
        /// </summary>
        /// <param name="companyService">Interfaz para el manejo de empresas.</param>
        /// <param name="company">Datos de la empresa a editar (opcional).</param>
        public FormCompanyEditor(ICompanyService companyService, CompanyDto company = null)
        {
            InitializeComponent();
            _companyService = companyService;

            if (company != null)
            {
                _company = company;
                PopulateFields();
            }
            else
            {
                _company = new CompanyDto { FechaCreacion = DateTime.Now, FechaUltimaModificacion = DateTime.Now };
            }
        }

        /// <summary>
        /// Llena los campos del formulario con los datos de la empresa.
        /// </summary>
        private void PopulateFields()
        {
            txtNombre.Text = _company.Nombre;
            txtCodigo.Text = _company.Codigo.ToString();
            txtDireccion.Text = _company.Direccion;
            txtTelefono.Text = _company.Telefono;
            txtCiudad.Text = _company.Ciudad;
            txtDepartamento.Text = _company.Departamento;
            txtPais.Text = _company.Pais;
        }

        /// <summary>
        /// Guarda los datos de la empresa.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                _company.Nombre = txtNombre.Text;
                _company.Codigo = int.Parse(txtCodigo.Text);
                _company.Direccion = txtDireccion.Text;
                _company.Telefono = txtTelefono.Text;
                _company.Ciudad = txtCiudad.Text;
                _company.Departamento = txtDepartamento.Text;
                _company.Pais = txtPais.Text;
                _company.FechaCreacion = _company.FechaCreacion;
                _company.FechaUltimaModificacion = DateTime.Now;

                if (_company.EmpresaID == 0) 
                {
                    _companyService.AddCompany(_company); 
                }
                else 
                {
                    _companyService.UpdateCompany(_company); 
                }

                MessageBox.Show("Empresa guardada exitosamente.");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
        }

        /// <summary>
        /// Valida que todos los campos del formulario estén completos.
        /// </summary>
        /// <returns>Devuelve true si todos los campos son válidos; de lo contrario, false.</returns>
        private bool ValidateFields()
        {
            return !string.IsNullOrEmpty(txtNombre.Text) &&
                   !string.IsNullOrEmpty(txtCodigo.Text) &&
                   !string.IsNullOrEmpty(txtDireccion.Text) &&
                   !string.IsNullOrEmpty(txtTelefono.Text) &&
                   !string.IsNullOrEmpty(txtCiudad.Text) &&
                   !string.IsNullOrEmpty(txtDepartamento.Text) &&
                   !string.IsNullOrEmpty(txtPais.Text);
        }

        /// <summary>
        /// Cierra el formulario sin guardar cambios.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
