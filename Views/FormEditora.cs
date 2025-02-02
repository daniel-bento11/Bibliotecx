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

namespace Views
{
   
    public partial class FormEditora : Form
    {
        clsNegocio negocio = new clsNegocio();
        private void carregar_dados()
        {
            try
            {
                dgvEditoras.DataSource = negocio.Captar_editora();
                btnDel.Cursor = Cursors.No;
                btnEditar.Cursor = Cursors.No;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Carregar Autores: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormEditora()
        {
            InitializeComponent();
            carregar_dados();    
        }

        private void dgvEditoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEditora_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
