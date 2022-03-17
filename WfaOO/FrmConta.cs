using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaOO
{
    public partial class FrmConta : Form
    {
        Conta_Comum conta_Comum = new Conta_Comum();
        Conta_Especial conta_Especial = new Conta_Especial();

        public void Atualizar()
        {
            if (txtTipoDaConta.Text == "1")
            {
                lblExtrato.Text += "Conta Comum" + "\n";
                lblExtrato.Text += "Saldo = " + conta_Comum.Conta_Saldo + "\n";
                lblExtrato.Text += "Limite = " + conta_Comum.Conta_Limite + "\n";
            }
            else
            {
                lblExtrato.Text += "Conta Especial" + "\n";
                lblExtrato.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                lblExtrato.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";

            }
        }
        public FrmConta()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTipoDaConta.Text) == 1)
            {


                conta_Comum.Conta_Nro = int.Parse(txtNroConta.Text);
                conta_Comum.Conta_Titular = txtTitular.Text;
                conta_Comum.Conta_Tipo = int.Parse(txtTipoDaConta.Text);
                conta_Comum.Conta_Limite = 0;
                Atualizar();
            }
            else
            {
                conta_Especial.Conta_Nro = int.Parse(txtNroConta.Text);
                conta_Especial.Conta_Titular = txtTitular.Text;
                conta_Especial.Conta_Tipo = int.Parse(txtTipoDaConta.Text);
                conta_Especial.Conta_Limite = double.Parse(txtLimiteDaConta.Text);
                Atualizar();
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTipoDaConta.Text) == 1)
            {
                conta_Comum.Depositar(double.Parse(txtValor.Text));
                Atualizar();
            }
            else
            {
                conta_Especial.Depositar(double.Parse(txtValor.Text));
                Atualizar();
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtTipoDaConta.Text) == 1)
                {
                    conta_Comum.Sacar(double.Parse(txtValor.Text));
                    Atualizar();
                }

                else
                {
                    conta_Especial.Sacar(double.Parse(txtValor.Text));
                    Atualizar();
                }
            }
            catch (System.ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
