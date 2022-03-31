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

        PessoaJuridica jurPessoa = new PessoaJuridica();
        PessoaFisica fisPessoa = new PessoaFisica();

        char ultimo_caractere = (char)32;

        #region Click
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obrigado por usar nosso sistema!\nDeseja sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbFisica.Checked = true;
            rdbJuridica.Checked = false;
            mtbPessoa.Text = "";
            txtNome.Text = "";
            lblInfo1.Text = "";
            lblInfo2.Text = "";
            lblInfo3.Text = "";
            btnCadastrar.Enabled = false;
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rdbFisica.Checked)
            {
                fisPessoa.CPF = mtbPessoa.Text;
                fisPessoa.Nome = txtNome.Text;
                MessageBox.Show("Cliente Cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPessoa.Text = "";
                txtNome.Text = "";
                btnExibir.Enabled = true;
            }
            else
            {
                jurPessoa.CNPJ = mtbPessoa.Text;
                jurPessoa.Nome = txtNome.Text;
                MessageBox.Show("Empresa Cadastrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPessoa.Text = "";
                txtNome.Text = "";
                btnExibir.Enabled = true;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (rdbFisica.Checked)
            {
                lblInfo1.Text = "Cliente Cadastrado";
                lblInfo3.Text = fisPessoa.CPF;
                lblInfo2.Text = fisPessoa.Nome;
            }
            else if(rdbJuridica.Checked)
            {
                lblInfo1.Text = "Cliente Cadastrado";
                lblInfo3.Text = jurPessoa.CNPJ;
                lblInfo2.Text = jurPessoa.Nome;
            }
            else
            {
                MessageBox.Show("Escolha um tipo de pessoa!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Mudança de Pessoa
        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            mtbPessoa.Mask = "999,999,999-99";
            lblPessoa.Text = "CPF";
            lblInfo1.Text = "";
            lblInfo2.Text = "";
            lblInfo3.Text = "";
            mtbPessoa.Text = "";
            btnCadastrar.Enabled = false;
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            mtbPessoa.Mask = "99,999,999/9999-99";
            lblPessoa.Text = "CNPJ";
            lblInfo1.Text = "";
            lblInfo2.Text = "";
            lblInfo3.Text = "";
            mtbPessoa.Text = "";
            btnCadastrar.Enabled = false;
        }

        #endregion

        #region Validação
        private void mtbPessoa_Validating(object sender, CancelEventArgs e)
        {
            if (rdbJuridica.Checked)
            {
                if (PessoaJuridica.ValidaCNPJ(mtbPessoa.Text) == false)
                {
                    mtbPessoa.Text = "";
                    btnCadastrar.Enabled = false;
                    MessageBox.Show("CNPJ inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { if (txtNome.Text != "" && mtbPessoa.Text != "") { btnCadastrar.Enabled = true; } }
            }
            else
            {
                if (PessoaFisica.ValidaCPF(mtbPessoa.Text) == false)
                {
                    mtbPessoa.Text = "";
                    btnCadastrar.Enabled = false;
                    MessageBox.Show("CPF inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { if (txtNome.Text != "" && mtbPessoa.Text != "") { btnCadastrar.Enabled = true; } }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ClsValidacao.ConsisteLetras(e.KeyChar, ultimo_caractere) == false)
            {
                MessageBox.Show("Entrada inválida", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.KeyChar = (char)0;
            }


            else
            {
                ultimo_caractere = e.KeyChar;
            }
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            ultimo_caractere = (char)32;
            if (txtNome.Text != "" && mtbPessoa.Text != "") { btnCadastrar.Enabled = true; }
        }

        private void mtbPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCadastrar.Enabled = true;
        }
    }

        #endregion
}

