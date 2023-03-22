namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionarUsuario = new System.Windows.Forms.Button();
            this.buttonExcuirUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupoUsuario = new System.Windows.Forms.Button();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(906, 89);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersWidth = 51;
            this.grupoUsuariosDataGridView.RowTemplate.Height = 24;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(279, 378);
            this.grupoUsuariosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupos do usuário";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.usuarioBindingSource;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(582, 50);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(663, 50);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 5;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonAdicionarUsuario
            // 
            this.buttonAdicionarUsuario.Location = new System.Drawing.Point(744, 50);
            this.buttonAdicionarUsuario.Name = "buttonAdicionarUsuario";
            this.buttonAdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarUsuario.TabIndex = 5;
            this.buttonAdicionarUsuario.Text = "Adicionar";
            this.buttonAdicionarUsuario.UseCompatibleTextRendering = true;
            this.buttonAdicionarUsuario.UseVisualStyleBackColor = true;
            this.buttonAdicionarUsuario.Click += new System.EventHandler(this.buttonAdicionarUsuario_Click);
            // 
            // buttonExcuirUsuario
            // 
            this.buttonExcuirUsuario.Location = new System.Drawing.Point(825, 51);
            this.buttonExcuirUsuario.Name = "buttonExcuirUsuario";
            this.buttonExcuirUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonExcuirUsuario.TabIndex = 5;
            this.buttonExcuirUsuario.Text = "Excuir";
            this.buttonExcuirUsuario.UseVisualStyleBackColor = true;
            this.buttonExcuirUsuario.Click += new System.EventHandler(this.buttonExcuirUsuario_Click);
            // 
            // buttonExcluirGrupoUsuario
            // 
            this.buttonExcluirGrupoUsuario.Location = new System.Drawing.Point(1110, 51);
            this.buttonExcluirGrupoUsuario.Name = "buttonExcluirGrupoUsuario";
            this.buttonExcluirGrupoUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirGrupoUsuario.TabIndex = 5;
            this.buttonExcluirGrupoUsuario.Text = "Excluir";
            this.buttonExcluirGrupoUsuario.UseVisualStyleBackColor = true;
            this.buttonExcluirGrupoUsuario.Click += new System.EventHandler(this.buttonExcluirGrupoUsuario_Click);
            // 
            // buttonAdicionarGrupoUsuario
            // 
            this.buttonAdicionarGrupoUsuario.Location = new System.Drawing.Point(1029, 51);
            this.buttonAdicionarGrupoUsuario.Name = "buttonAdicionarGrupoUsuario";
            this.buttonAdicionarGrupoUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarGrupoUsuario.TabIndex = 5;
            this.buttonAdicionarGrupoUsuario.Text = "Adicionar";
            this.buttonAdicionarGrupoUsuario.UseVisualStyleBackColor = true;
            this.buttonAdicionarGrupoUsuario.Click += new System.EventHandler(this.buttonAdicionarGrupoUsuario_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Nome,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 90);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.Size = new System.Drawing.Size(888, 378);
            this.usuarioDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NomeUsuario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome de usuário";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn10.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 47;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 521);
            this.Controls.Add(this.buttonExcluirGrupoUsuario);
            this.Controls.Add(this.buttonAdicionarGrupoUsuario);
            this.Controls.Add(this.buttonExcuirUsuario);
            this.Controls.Add(this.buttonAdicionarUsuario);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcuirUsuario;
        private System.Windows.Forms.Button buttonExcluirGrupoUsuario;
        private System.Windows.Forms.Button buttonAdicionarGrupoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        public System.Windows.Forms.Button buttonAdicionarUsuario;
    }
}