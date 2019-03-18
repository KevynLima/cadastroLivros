using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroLivros
{
    public partial class frmConsulta : Form
    {
        dataSetLivrosTableAdapters.tb_livrosTableAdapter taLivro =
            new dataSetLivrosTableAdapters.tb_livrosTableAdapter();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnTudo_Click(object sender, EventArgs e)
        {
            /* DATASOURCE - Origem dos dados do DATAGRID
             * JOGA O RESULTADO DO SELECT PARA O DATAGRID*/
            
            dgvLivros.DataSource = taLivro.consultarTodos();
            
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLivros.DataSource = taLivro.consultarGenero(cboGenero.Text);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            dgvLivros.DataSource = taLivro.consultaNome(txtNome.Text);
        }

        private void mskCodigo_TextChanged(object sender, EventArgs e)
        {
            if (mskCodigo.Text != "")
            {
                dgvLivros.DataSource = taLivro.consultarCodigo(Convert.ToInt32(mskCodigo.Text));
            }
        }
    }
}
