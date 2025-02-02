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

namespace Views.Resources
{
    public partial class FormAddGenero : Form
    {

        objGenero genero = new objGenero();
        clsNegocio negocio = new clsNegocio();
        private string funcao;
        public FormAddGenero(string funcao, objGenero genero)
        {
            this.genero = genero;
            this.funcao = funcao;
            InitializeComponent();
            lblTitle.Text = this.funcao + " Gênero Literário";
            if (funcao == "Alterar")
            {
                txtGenero.Text = this.genero.Nome_genero;
                btnAdd.Image = Properties.Resources.salve_;
            }
        }

        private void limpar_campos()
        {
            txtGenero.Text = "";
        }

        private void fechar()
        {
            limpar_campos();
            Close();
        }
        private bool verificar_campos(objGenero genero)
        {
            if (txtGenero.Text == "")
            {
                MessageBox.Show("Campo Obrigatório!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenero.Focus();
                imgErrGen.Visible = true;
            }
            else
            {
                if (negocio.Verificar_Genero(genero))
                {
                    MessageBox.Show("Gênero já Cadastrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGenero.Focus();
                    imgErrGen.Visible = true;
                }
                else
                {
                    imgErrGen.Visible = false;
                    return true;
                }
            }
            return false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(funcao == "Alterar" && txtGenero.Text.Trim() == genero.Nome_genero)
                {
                    fechar();
                }
                else {
                    genero.Nome_genero = txtGenero.Text.Trim();
                    if (verificar_campos(genero))
                    {
                        try
                        {
                            if (funcao == "Adicionar") {
                            negocio.Add_Genero(genero);
                            MessageBox.Show("Gênero Adicionado com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fechar();
                            }
                            else
                            {
                                DialogResult resposta = MessageBox.Show("Deseja relamente alterar o gênero?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (resposta == DialogResult.Yes)
                                {
                                    negocio.Alt_Genero(genero);
                                    MessageBox.Show("Gênero Alterado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                fechar();
                            }
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Erro ao Tentar" +  funcao + ": " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Verificar Campos: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddGenero_Load(object sender, EventArgs e)
        {

        }
    }
}
