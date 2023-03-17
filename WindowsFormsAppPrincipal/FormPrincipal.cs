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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.Nome = "Erisvaldo";
            usuario.NomeUsuario = "Teste";
            usuario.Ativo = true;
            usuario.CPF = "532.523.912-44";
            usuario.Senha = "183674";
            usuario.Email = "teste@gmail.com";
            new UsuarioBLL().Inserir(usuario);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
