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
using Views.Resources;

namespace Views
{
    public partial class FormGenero : Form
    {

        clsNegocio negocio = new clsNegocio();
        objGenero genero = new objGenero();

        private void carregar_dados()
        {
            try
            {
                dgvGenero.DataSource = negocio.Captar_genero();
                genero.Nome_genero = "";
                genero.Id_genero = 0;
                btnDel.Cursor = Cursors.No;
                btnEditar.Cursor = Cursors.No;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Carregar Gêneros: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FormGenero()
        {
            InitializeComponent();
            carregar_dados();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGenero_Load(object sender, EventArgs e)
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddGenero frmAddGenero = new FormAddGenero("Adicionar", genero);
            frmAddGenero.ShowDialog();
            carregar_dados();
        }

        private void dgvGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            genero.Nome_genero = dgvGenero.CurrentRow.Cells[1].Value.ToString();
            genero.Id_genero = (int)dgvGenero.CurrentRow.Cells[0].Value;
            btnDel.Cursor = Cursors.Hand;
            btnEditar.Cursor = Cursors.Hand;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (btnDel.Cursor == Cursors.Hand)
            {
                try
                {
                    DialogResult resposta = MessageBox.Show("Deseja relamente excluir o gênero " + genero.Nome_genero, "Exluir" ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        negocio.Del_Genero(genero);
                        MessageBox.Show("Gênero " + genero.Nome_genero + " Removido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregar_dados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir o Gênero: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Gênero!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Cursor == Cursors.Hand)
            {
                FormAddGenero frmAltGenero = new FormAddGenero("Alterar", genero);
                frmAltGenero.ShowDialog();
                carregar_dados();
            }
            else
            {
                MessageBox.Show("Selecione um Gênero!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
