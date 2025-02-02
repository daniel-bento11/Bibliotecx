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
    public partial class FormAddAutor : Form
    {
        objAutor autor  = new objAutor();
        clsNegocio negocio = new clsNegocio();
        private string funcao;
        public FormAddAutor(string funcao, objAutor autor)
        {
            this.funcao = funcao;
            this.autor = autor;
            InitializeComponent();
            lblTitle.Text = this.funcao + " Gênero Literário";
            if (funcao == "Alterar")
            { 
                txtAutor.Text = autor.Nome_autor;
                txtNacionalidade.Text = autor.Nacionalidade;
                btnAdd.Image = Properties.Resources.salve_;
            }

        }

        private void limpar_campos()
        {
            txtAutor.Text = "";
            txtNacionalidade.Text = "";
        }

        private void fechar()
        {
            limpar_campos();
            Close();
        }
        private bool verificar_campos()
        {
            if (autor.Nome_autor == "")
            {
                MessageBox.Show("Nome Obrigatório!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAutor.Focus();
                imgErrAutor.Visible = true;
            }
            else
            {
                imgErrAutor.Visible = false;
                if(autor.Nacionalidade == "")
                {
                    MessageBox.Show("Nacionalidade Obrigatória!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNacionalidade.Focus();
                    imgErrNacionalidade.Visible = true;
                }
                else
                {
                    imgErrNacionalidade.Visible = false;
                    if (negocio.Verificar_Autor(autor))
                    {
                        MessageBox.Show("Autor já Cadastrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAutor.Focus();
                        imgErrAutor.Visible = true;
                    }
                    else
                    {
                        imgErrAutor.Visible = false;
                        return true;
                    }
                }
            }
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FormAddAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "Alterar" && txtAutor.Text.Trim() == autor.Nome_autor)
                {
                    fechar();
                }
                else
                {
                    autor.Nome_autor = txtAutor.Text;
                    autor.Nacionalidade = txtNacionalidade.Text;
                    if (verificar_campos())
                    {
                        try
                        {
                            if (funcao == "Adicionar")
                            {
                                negocio.Add_Autor(autor);
                                MessageBox.Show("Autor Adicionado com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fechar();
                            }
                            else
                            {
                                DialogResult resposta = MessageBox.Show("Deseja relamente alterar o autor?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (resposta == DialogResult.Yes)
                                {
                                    negocio.Alt_Autor(autor);
                                    MessageBox.Show("Autor Alterado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                fechar();
                            }
                        }catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Tentar" + funcao + ": " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Verificar Campos: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fechar();
        }
    }
}
