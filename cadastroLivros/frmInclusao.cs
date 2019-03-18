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
    public partial class frmInclusao : Form
    {
        public frmInclusao()
        {
            InitializeComponent();
        }

        private void btnCapa_Click(object sender, EventArgs e)
        {
            // CLASSE PARA SELECIONAR IMAGEM NO DIRETÓRIO 
            OpenFileDialog arquivo = new OpenFileDialog();

            // CHAMA O MÉTODO QUE ABRE A JANELA
            arquivo.ShowDialog();

            // ASSOCIA A IMAGEM AO PICTUREBOX
            picCapa.ImageLocation = arquivo.FileName;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Os dados estão corretos?","Confirmar Cadastro", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                dataSetLivrosTableAdapters.tb_livrosTableAdapter taLivro = new dataSetLivrosTableAdapters.tb_livrosTableAdapter();
                taLivro.inserir_livro(
                    Convert.ToInt16 (mskCodigo.Text),
                    txtNome.Text,
                    cboGenero.Text,
                    dtpData.Text,
                    rtbSInopse.Text,
                    Convert.ToInt16 (nudNota.Value),
                    picCapa.ImageLocation
                    );
                MessageBox.Show("Dados Salvos com sucesso!", "Exito!");
            }
            else
            {
                MessageBox.Show("Então escreve direito porra!");
            }

        }

    }
}
