﻿using BLL;
using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcuirUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }
            if (MessageBox.Show("deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);
            usuarioBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Nenhum usuário selecionado.");
                return;
            }

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            using (FormCadastroUsuario frm = new FormCadastroUsuario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            using (FormCadastrarGrupoUsuario frm = new FormCadastrarGrupoUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            if (grupoUsuariosBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }
            if (MessageBox.Show("deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idGrupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            new GrupoUsuarioBLL().Excluir(idGrupo);
            grupoUsuariosBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
