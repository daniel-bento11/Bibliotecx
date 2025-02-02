using BD;
using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormLogin : Form
    {
        public string user;
        public string password;
        public int id_user;

        clsNegocio negocio = new clsNegocio();
        objUser usuario = new objUser();
        Conexao con = new Conexao();
        FormAddUser cadastrar = new FormAddUser();
        public FormLogin()
        {
            InitializeComponent();
        }


        private void preencher_obj_usuario(DataTable dt)
        {
            usuario.Nome_user = dt.Rows[0][1].ToString();
            usuario.Login_user = dt.Rows[0][2].ToString();
            usuario.Nome_tipo_user = dt.Rows[0][6].ToString();
            usuario.Id_tipo_user = (int)dt.Rows[0][5];
            usuario.Id_user = (int)dt.Rows[0][0];
            usuario.Password_user = "";
        }
        private void limpar_campos()
        {
            txtSenha.Text = "";
            txtUser.Text = "";
            txtUser.Focus();
            txtSenha.PasswordChar = '*';
            btnPassChar.Image = Properties.Resources.esconder_senha;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            usuario.Login_user = txtUser.Text;
            usuario.Password_user = txtSenha.Text;
            try
            {
                dt = negocio.Logar(usuario);
                

                if (dt.Rows.Count>0)
                {

                    preencher_obj_usuario(dt);
                    MessageBox.Show("Bem-Vindo " + usuario.Nome_user, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    limpar_campos();
                    FormMainMenu main_menu = new FormMainMenu(usuario);
                    main_menu.ShowDialog();
                    
                    

                }
                else
                {
                    limpar_campos();
                    MessageBox.Show("Usuário ou Senha incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show("Erro ao Tentar Logar: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
          

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            limpar_campos();
            cadastrar.ShowDialog();
        }

        private void btnPassChar_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                txtSenha.PasswordChar = '*';
                btnPassChar.Image = Properties.Resources.esconder_senha;
            }
            else
            {
                txtSenha.PasswordChar = '\0';
                btnPassChar.Image = Properties.Resources.ver_senha;
            }
        }
    }
}
