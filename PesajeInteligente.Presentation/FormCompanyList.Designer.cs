namespace PesajeInteligentes
{
    partial class FormCompanyList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel panelTop;

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
            dataGridViewCompanies = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtFilter = new TextBox();
            lblFilter = new Label();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompanies).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCompanies
            // 
            dataGridViewCompanies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompanies.Location = new Point(29, 66);
            dataGridViewCompanies.Name = "dataGridViewCompanies";
            dataGridViewCompanies.RowHeadersWidth = 51;
            dataGridViewCompanies.Size = new Size(934, 360);
            dataGridViewCompanies.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(667, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Orange;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(767, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 35);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(868, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(159, 20);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(466, 27);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(26, 24);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(133, 20);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filtrar por nombre:";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblFilter);
            panelTop.Controls.Add(txtFilter);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnEdit);
            panelTop.Controls.Add(btnDelete);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(990, 60);
            panelTop.TabIndex = 0;
            // 
            // FormCompanyList
            // 
            ClientSize = new Size(990, 450);
            Controls.Add(dataGridViewCompanies);
            Controls.Add(panelTop);
            Name = "FormCompanyList";
            Text = "Lista de Empresas";
            Load += FormCompanyList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompanies).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }
    }
}
