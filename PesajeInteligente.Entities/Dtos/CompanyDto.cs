namespace PesajeInteligente.Entities.Dtos
{
    /// <summary>
    /// Data Transfer Object (DTO) that represents a company.
    /// </summary>
    public class CompanyDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the company.
        /// </summary>
        public int EmpresaID { get; set; }       

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        public string Nombre { get; set; }       

        /// <summary>
        /// Gets or sets the code associated with the company.
        /// </summary>
        public int Codigo { get; set; }         

        /// <summary>
        /// Gets or sets the address of the company.
        /// </summary>
        public string Direccion { get; set; }   

        /// <summary>
        /// Gets or sets the phone number of the company.
        /// </summary>
        public string Telefono { get; set; }    

        /// <summary>
        /// Gets or sets the city where the company is located.
        /// </summary>
        public string Ciudad { get; set; }  

        /// <summary>
        /// Gets or sets the department or state where the company is located.
        /// </summary>
        public string Departamento { get; set; } 

        /// <summary>
        /// Gets or sets the country where the company is located.
        /// </summary>
        public string Pais { get; set; }        

        /// <summary>
        /// Gets or sets the date and time when the company was created.
        /// </summary>
        public DateTime FechaCreacion { get; set; } 

        /// <summary>
        /// Gets or sets the date and time when the company record was last modified.
        /// </summary>
        public DateTime FechaUltimaModificacion { get; set; } 
    }
}
