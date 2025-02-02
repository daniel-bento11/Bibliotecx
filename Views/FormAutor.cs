using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Objetos;
using Views.Resources;

namespace Views
{
    public partial class FormAutor : Form
    {
        objAutor autor = new objAutor();
        clsNegocio negocio = new clsNegocio();
        private void carregar_dados()
        {
            try
            {
                dgvAutores.DataSource = negocio.Captar_autor();
                autor.Nome_autor = "";
                autor.Nacionalidade = "";
                autor.Id_autor = 0;
                btnDel.Cursor = Cursors.No;
                btnEditar.Cursor = Cursors.No;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Carregar Autores: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FormAutor()
        {
            InitializeComponent();
            carregar_dados();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {

        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            autor.Nome_autor = dgvAutores.CurrentRow.Cells[1].Value.ToString();
            autor.Id_autor = (int)dgvAutores.CurrentRow.Cells[0].Value;
            autor.Nacionalidade = dgvAutores.CurrentRow.Cells[2].Value.ToString();
            btnDel.Cursor = Cursors.Hand;
            btnEditar.Cursor = Cursors.Hand;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (btnDel.Cursor == Cursors.Hand)
            {
                try
                {
                    DialogResult resposta = MessageBox.Show("Deseja relamente excluir o autor " + autor.Nome_autor, "Exluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        negocio.Del_Autor(autor);
                        MessageBox.Show("Autor " + autor.Nome_autor + " Removido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregar_dados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir o Autor: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Autor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddAutor frmAutor = new FormAddAutor("Adicionar", autor);
            frmAutor.ShowDialog();
            carregar_dados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Cursor == Cursors.Hand)
            {
                FormAddAutor frmAutor = new FormAddAutor("Alterar", autor);
                frmAutor.ShowDialog();
                carregar_dados();
            }
            else
            {
                MessageBox.Show("Selecione um Autor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
