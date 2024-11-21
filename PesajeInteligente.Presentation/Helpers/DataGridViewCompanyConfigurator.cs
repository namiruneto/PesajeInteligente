// --------------------------------------------------------------------------------------------------------------------
// <summary>
// Clase para configurar las columnas del DataGridView utilizado en la lista de empresas.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PesajeInteligentes.Helpers
{
    /// <summary>
    /// Proporciona configuración para las columnas de un <see cref="DataGridView"/> en la vista de empresas.
    /// </summary>
    public class DataGridViewCompanyConfigurator
    {
        /// <summary>
        /// Configura las columnas del <see cref="DataGridView"/> para mostrar información de las empresas.
        /// </summary>
        /// <param name="dataGridView">El <see cref="DataGridView"/> que se configurará.</param>
        public static void Configure(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmpresaID",
                HeaderText = "ID de la Empresa",
                DataPropertyName = "EmpresaID",
                Visible = false
            });

            dataGridView.Columns["EmpresaID"].Visible = false;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre de la Empresa",
                DataPropertyName = "Nombre"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código de la Empresa",
                DataPropertyName = "Codigo"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Direccion",
                HeaderText = "Dirección",
                DataPropertyName = "Direccion"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telefono",
                HeaderText = "Teléfono",
                DataPropertyName = "Telefono"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ciudad",
                HeaderText = "Ciudad",
                DataPropertyName = "Ciudad"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Departamento",
                HeaderText = "Departamento",
                DataPropertyName = "Departamento"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Pais",
                HeaderText = "País",
                DataPropertyName = "Pais"
            });
        }
    }

}
