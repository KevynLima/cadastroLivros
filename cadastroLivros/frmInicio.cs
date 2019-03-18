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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        
        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInclusao inclusao = new frmInclusao();
            inclusao.Show();
        }

        private void manutençãoConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.Show();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Resp = MessageBox.Show("Tem certeza que deseja sair?", "Mensagem",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Resp == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
    }
}
