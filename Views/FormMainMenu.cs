using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormMainMenu : Form
    {
        objUser usuario = new objUser();
        public FormMainMenu(objUser usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUser.Text = this.usuario.Login_user;
            if (this.usuario.Id_tipo_user == 1)
            {
                btnAutor.Visible = true;
                btnGenero.Visible = true;
                btnLivro.Visible = true;
                btnEditora.Visible = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja relamente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            DialogResult resposta = MessageBox.Show("Deseja relamente fazer logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                this.Hide();
                login.ShowDialog();
            }
            
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            FormGenero formGenero = new FormGenero();
            formGenero.ShowDialog();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            FormAutor frmAutor = new FormAutor();
            frmAutor.ShowDialog();
        }

        private void btnEditora_Click(object sender, EventArgs e)
        {
            FormEditora frmEditora = new FormEditora();
            frmEditora.ShowDialog();
        }
    }
}
