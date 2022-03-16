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
        #region Variaveis
        char ultimo_caractere = (char)32;
        #endregion
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ClsValidacao.ConsisteLetras(e.KeyChar,ultimo_caractere) == false)
            {
                MessageBox.Show("Entrada inválida","informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.KeyChar = (char)0;
            }

            else
            {
                ultimo_caractere = e.KeyChar;
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
