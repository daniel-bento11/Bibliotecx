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
    public partial class FormAddUser : Form
    {
        clsNegocio negocio = new clsNegocio();
        objUser usuario = new objUser();

        public FormAddUser()
        {
            InitializeComponent();
        }


        private bool verificar_campos(objUser usuario)
        {
            if (usuario.Login_user == "")
            {
                MessageBox.Show("Usuário Obrigatório", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                imgErrUser.Visible = true;
            }
            else
            {
                imgErrUser.Visible = false;
                if (usuario.Nome_user == "")
                {
                    MessageBox.Show("Nome Obrigatório", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                    imgErrNome.Visible = true;
                }
                else
                {
                    imgErrNome.Visible = false;
                    if (usuario.Password_user == "")
                    {
                        MessageBox.Show("Senha Obrigatória", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Focus();
                        imgErrSenha.Visible = true;
                    }
                    else
                    {
                        imgErrSenha.Visible = false;
                        if (txtConfSenha.Text.Trim() == "")
                        {
                            MessageBox.Show("Confirmar Senha Obrigatório", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtConfSenha.Focus();
                            imgErrConfSenha.Visible = true;
                        }
                        else
                        {
                            imgErrConfSenha.Visible = false;
                            if (txtConfSenha.Text.Trim() != usuario.Password_user)
                            {
                                MessageBox.Show("As senhas devem ser iguais", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSenha.Focus();
                                imgErrConfSenha.Visible = true;
                                imgErrSenha.Visible = true;
                            }
                            else
                            {
                                imgErrConfSenha.Visible = false;
                                imgErrSenha.Visible = false;
                                if (negocio.Verificar_Usuario(usuario))
                                {
                                    MessageBox.Show("Usuário já cadastrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtUser.Focus();
                                    imgErrUser.Visible = true;
                                }
                                else
                                {
                                    imgErrUser.Visible = false;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        private void limpar_campos()
        {
            txtSenha.Text = "";
            txtConfSenha.Text = "";
            txtUser.Focus();
            txtNome.Text = "";
            txtUser.Text = "";
            txtSenha.PasswordChar = '*';
            btnPassChar.Image = Properties.Resources.esconder_senha;
        }

        private void fechar()
        {
            limpar_campos();
            this.Close();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechar();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usuario.Nome_user = txtNome.Text.Trim();
            usuario.Login_user = txtUser.Text.Trim();
            usuario.Password_user = txtSenha.Text.Trim();
            try { 
                if (verificar_campos(usuario))
                {
                    try
                    {
                        negocio.Cadastrar_usuario(usuario);
                        MessageBox.Show("Usuário Cadastrado com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fechar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Tentar Cadastrar: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Verificar Campos: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
