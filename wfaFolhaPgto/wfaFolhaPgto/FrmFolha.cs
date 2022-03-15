using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFolhaPgto
{
    public partial class FrmFolha : Form
    {
        public FrmFolha()
        {
            InitializeComponent();
        }
        char a = (char)32;
        char b = (char)46;
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ClsValidacao.ConsisteLetras(e.KeyChar) == false ||
                e.KeyChar == a || e.KeyChar == b)
            {
                MessageBox.Show("Entrada inválida","informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.KeyChar = (char)0;
            }
            else
            {
                if (e.KeyChar != (char)8) {
                    a = e.KeyChar;
                    b = e.KeyChar;
                }
            }
        }

        private void txtHorTra_Validating(object sender, CancelEventArgs e)
        {
            if (ClsValidacao.ConsisteNumInteiro(txtHorTra.Text) == false)
            {
                MessageBox.Show("Entrada inválida", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                txtHorTra.SelectAll();
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (ClsValidacao.ConsisteNome(txtNome.Text) == false)
            {
                MessageBox.Show("Entrada inválida", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
        }
    }
}
