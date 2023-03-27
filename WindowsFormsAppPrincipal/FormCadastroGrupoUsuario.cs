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
        private int id1;

        public FormCadastroGrupoUsuario()
        {
            InitializeComponent();
        }

        public FormCadastroGrupoUsuario(int id)
        {
            this.id1 = id;
        }

        public int Id { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuariosBLL = new GrupoUsuarioBLL();
                grupoUsuariosBindingSource.EndEdit();

                if (Id == 0)
                    grupoUsuariosBLL.Inserir((GrupoUsuario)grupoUsuariosBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
