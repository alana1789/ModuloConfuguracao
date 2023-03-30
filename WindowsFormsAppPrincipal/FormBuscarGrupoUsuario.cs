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
                grupoUsuariosBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNomeGrupo(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuariosBindingSource.Count == 0)
                    throw new Exception("Não existe grupo a ser excluído");

                using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(((GrupoUsuario)grupoUsuariosBindingSource.Current).Id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionarGrupoUsuario_Click_1(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuariosBindingSource.Count == 0)
                    throw new Exception("Não existe um grupo selecionado para adicionar uma permissão.");

                using (FormConsultaPermissao frm = new FormConsultaPermissao())
                {
                    frm.ShowDialog();
                    int idGrupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                    new GrupoUsuarioBLL().AdicionarPermissao(idGrupo, frm.Id);
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirPermissao_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(permissoesBindingSource.Count == 0)
                    throw new Exception("Não existe grupo a ser excluído");

                int idGrupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                int idPermissao = ((Permissao)permissoesBindingSource.Current).Id;
                new GrupoUsuarioBLL().RemoverPermissao(idGrupo, idPermissao);
                permissoesBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormBuscarGrupoUsuario_Load(object sender, EventArgs e)
        {

        }
        private void buttonExcuirGrupoUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuariosBindingSource.Count == 0)
                    return;
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                new GrupoUsuarioBLL().Excluir(((GrupoUsuario)grupoUsuariosBindingSource.Current).Id);
                grupoUsuariosBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
