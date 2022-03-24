using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaPessoa
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        PessoaJuridica mPessoa = new PessoaJuridica();

        #region Click
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbFisica.Checked = false;
            rdbJuridica.Checked = false;
            mtbPessoa.Text = "";
            txtNome.Text = "";
        }

        #endregion

        #region Mudança de Pessoa
        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            mtbPessoa.Mask = "999,999,999-99";
            lblPessoa.Text = "CPF";
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            mtbPessoa.Mask = "99,999,999/9999-99";
            lblPessoa.Text = "CNPJ";
        }

        #endregion

        private void mtbPessoa_Validating(object sender, CancelEventArgs e)
        {
            if (rdbJuridica.Checked)
            {
                if (PessoaJuridica.ValidaCNPJ(mtbPessoa.Text) == false) { mtbPessoa.Text = ""; }
            }
            else
            {
                if (PessoaFisica.ValidaCPF(mtbPessoa.Text) == false) { mtbPessoa.Text = ""; }
            }
        }


    }
}
