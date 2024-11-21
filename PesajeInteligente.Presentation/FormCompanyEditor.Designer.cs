namespace PesajeInteligentes
{
    partial class FormCompanyEditor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCiudad = new TextBox();
            txtDepartamento = new TextBox();
            txtPais = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCiudad = new Label();
            lblDepartamento = new Label();
            lblPais = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(155, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.LightGray;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(155, 59);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.LightGray;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(155, 89);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 27);
            txtDireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightGray;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(155, 119);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtCiudad
            // 
            txtCiudad.BackColor = Color.LightGray;
            txtCiudad.BorderStyle = BorderStyle.FixedSingle;
            txtCiudad.Location = new Point(155, 149);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(200, 27);
            txtCiudad.TabIndex = 5;
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = Color.LightGray;
            txtDepartamento.BorderStyle = BorderStyle.FixedSingle;
            txtDepartamento.Location = new Point(155, 179);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 27);
            txtDepartamento.TabIndex = 6;
            // 
            // txtPais
            // 
            txtPais.BackColor = Color.LightGray;
            txtPais.BorderStyle = BorderStyle.FixedSingle;
            txtPais.Location = new Point(155, 209);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(200, 27);
            txtPais.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(82, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(207, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Arial", 10F);
            lblNombre.Location = new Point(35, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.Font = new Font("Arial", 10F);
            lblCodigo.Location = new Point(35, 59);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 20);
            lblCodigo.TabIndex = 19;
            lblCodigo.Text = "Código:";
            // 
            // lblDireccion
            // 
            lblDireccion.Font = new Font("Arial", 10F);
            lblDireccion.Location = new Point(35, 89);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(100, 20);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            lblTelefono.Font = new Font("Arial", 10F);
            lblTelefono.Location = new Point(35, 119);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(100, 20);
            lblTelefono.TabIndex = 17;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCiudad
            // 
            lblCiudad.Font = new Font("Arial", 10F);
            lblCiudad.Location = new Point(35, 149);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(100, 20);
            lblCiudad.TabIndex = 16;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.Font = new Font("Arial", 10F);
            lblDepartamento.Location = new Point(35, 179);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(100, 20);
            lblDepartamento.TabIndex = 15;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblPais
            // 
            lblPais.Font = new Font("Arial", 10F);
            lblPais.Location = new Point(35, 209);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(100, 20);
            lblPais.TabIndex = 14;
            lblPais.Text = "País:";
            // 
            // FormCompanyEditor
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 329);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtPais);
            Controls.Add(lblPais);
            Controls.Add(txtDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(txtCiudad);
            Controls.Add(lblCiudad);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Font = new Font("Arial", 10F);
            Name = "FormCompanyEditor";
            Text = "Editor de Empresa";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCiudad;
        private TextBox txtDepartamento;
        private TextBox txtPais;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCiudad;
        private Label lblDepartamento;
        private Label lblPais;
    }
}
