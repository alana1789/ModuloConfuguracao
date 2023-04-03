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
    public partial class FormCadastroDeGrupoU : Form
    {
        private int id;

        public FormCadastroDeGrupoU()
        {
            InitializeComponent();
        }

        public FormCadastroDeGrupoU(int id)
        {
            this.id = id;
        }

        public int Id { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.EndEdit();

                if (Id == 0)
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                else
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nomeGrupoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    


            
    
           
    
    

