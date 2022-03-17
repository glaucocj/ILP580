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
        Conta mConta = new Conta();

        public void Atualizar()
        {
            lblExtrato.Text += "Saldo = " + mConta.Conta_Saldo + "\n";
            lblExtrato.Text += "Limite = " + mConta.Conta_Limite + "\n";
        }
        public FrmConta()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            mConta.Conta_Nro = int.Parse(txtNroConta.Text);
            mConta.Conta_Titular = txtTitular.Text;
            mConta.Conta_Tipo = int.Parse(txtTipoDaConta.Text);
            if (int.Parse(txtTipoDaConta.Text) == 1)
            {
                mConta.Conta_Limite = 0;
            }
            else
            {
                mConta.Conta_Limite = double.Parse(txtLimiteDaConta.Text);
            }

            Atualizar();
            //lblExtrato.Text += "Saldo = " + mConta.Conta_Saldo + "\n";
            //lblExtrato.Text += "Limite = " + mConta.Conta_Limite + "\n";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            mConta.Depositar(double.Parse(txtValor.Text));

            Atualizar();
            //lblExtrato.Text += "Saldo = " + mConta.Conta_Saldo + "\n";
            //lblExtrato.Text += "Limite = " + mConta.Conta_Limite + "\n";
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                mConta.Sacar(double.Parse(txtValor.Text));
                Atualizar();
            }
            catch (System.ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
