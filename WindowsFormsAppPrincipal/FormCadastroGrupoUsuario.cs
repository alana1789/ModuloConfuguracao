using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroGrupoUsuario : Form
    {
        private int id;

        public FormCadastroGrupoUsuario()
        {
            InitializeComponent();
        }

        public FormCadastroGrupoUsuario(int id)
        {
            this.id = id;
        }

        public int Id { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuariosBindingSource.EndEdit();

                if (Id == 0)
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuariosBindingSource.Current);
                else
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuariosBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
