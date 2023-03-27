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
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuariosBindingSource.DataSource = new GrupoUsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (grupoUsuariosBindingSource.Count <= 0)
            {
                MessageBox.Show("Nenhum usuário selecionado.");
                return;
            }

            int id = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
        private void buttonAdicionarGrupoUsuario_Click_1(object sender, EventArgs e)
        {
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
        private void buttonExcuirUsuario_Click(object sender, EventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            new GrupoUsuarioBLL().Excluir(id);
            grupoUsuariosBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluído com sucesso!");
        }
        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaPermissao frm = new FormConsultaPermissao())
                {
                    frm.ShowDialog();

                    if (frm.Id != 0)
                    {
                        int idUsuario = ((Permissao)permissoesBindingSource.Current).Id;
                        new PermissaoBLL().AdicionarPermissao(idUsuario, frm.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
