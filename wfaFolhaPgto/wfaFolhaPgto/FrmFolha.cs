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


            if (e.KeyChar == (char)13)
            {
                txtHorTra.Focus();
            }

            else if(ClsValidacao.ConsisteLetras(e.KeyChar,ultimo_caractere) == false)
            {
                MessageBox.Show("Entrada inválida","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.KeyChar = (char)0;
            }

            
            else
            {
                ultimo_caractere = e.KeyChar;
            }
        }

        private void txtHorTra_Validating(object sender, CancelEventArgs e)
        {
            if (ClsValidacao.ConsisteNumReal(txtHorTra.Text) == false)
            {
                MessageBox.Show("Entrada inválida", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                txtHorTra.SelectAll();
            }
        }


        private void txtVlrHor_Validating(object sender, CancelEventArgs e)
        {
            if (ClsValidacao.ConsisteNumReal(txtVlrHor.Text) == false)
            {
                MessageBox.Show("Entrada inválida", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                txtVlrHor.SelectAll();
            }
        }

        private void txtNumDep_Validating(object sender, CancelEventArgs e)
        {
            if (ClsValidacao.ConsisteNumInteiro(txtNumDep.Text) == false)
            {
                MessageBox.Show("Entrada inválida", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                txtNumDep.SelectAll();
            }
        }

        private void txtHorTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtVlrHor.Focus();
            }
        }

        private void txtVlrHor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtNumDep.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtHorTra.Text = "";
            txtNumDep.Text = "";
            txtVlrHor.Text = "";
            lblHorTra.Text = "";
            lblInss.Text = "";
            lblIR.Text = "";
            lblSalBruto.Text = "";
            lblSalLiq.Text = "";
            txtNome.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ClsValidacao.ConsisteNome(txtNome.Text) == false) //Valida o nome para não permitir nome vazio
            {
                MessageBox.Show("Entrada inválida", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }


            Double.TryParse(txtHorTra.Text, out double hora);
            Double.TryParse(txtVlrHor.Text, out double valor);
            int.TryParse(txtNumDep.Text, out int dependentes);
            double salBruto = hora * valor;
                        
            lblSalBruto.Text = salBruto.ToString("R$ ###,###,##0.00");
            lblInss.Text = (Taxas.CalculaINSS(salBruto)).ToString("R$ ###,###,##0.00");
            lblIR.Text = (Taxas.CalculaIR(salBruto, dependentes)).ToString("R$ ###,###,##0.00");
            lblSalLiq.Text = (salBruto-Taxas.CalculaINSS(salBruto)-Taxas.CalculaIR(salBruto,dependentes)).ToString("R$ ###,###,##0.00");
        }

        private void txtNumDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
               btnCalcular_Click(sender, e);
            }
        }

        private void FrmFolha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "P E R G U N T A",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
