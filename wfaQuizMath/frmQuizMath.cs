using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace wfaQuizMath
{
    public partial class frmQuizMath : Form
    {
        Random randomizar = new Random();
        int valorSoma1, valorSoma2, valorSub1, valorSub2, valorMult1,valorMult2,valorDiv1,valorDiv2,tempoRestante;

        private void nudSubtracao_ValueChanged(object sender, EventArgs e)
        {
            if ((valorSub1 - valorSub2) == nudSubtracao.Value) { SystemSounds.Beep.Play(); }

        }

        private void nudMultiplicacao_ValueChanged(object sender, EventArgs e)
        {
            if ((valorMult1 * valorMult2) == nudMultiplicacao.Value) { SystemSounds.Beep.Play(); }

        }

        private void nudDivisao_ValueChanged(object sender, EventArgs e)
        {
            if ((valorDiv1 / valorDiv2) == nudDivisao.Value) { SystemSounds.Beep.Play(); }

        }

        private void nudSoma_ValueChanged(object sender, EventArgs e)
        {
            if ((valorSoma1 + valorSoma2) == nudSoma.Value) { SystemSounds.Beep.Play(); }
        }

        #region Métodos
        public void IniciarTeste()
        {
            valorSoma1 = randomizar.Next(51);
            valorSoma2 = randomizar.Next(51);
            valorSub1 = randomizar.Next(1,100);
            valorSub2 = randomizar.Next(1,valorSub1);
            valorMult1 = randomizar.Next(1, 11);
            valorMult2 = randomizar.Next(1, 11);
            valorDiv1 = randomizar.Next(1, 100);
            valorDiv2 = randomizar.Next(1, valorDiv1+1);

            while (valorDiv1 % valorDiv2 != 0) { valorDiv2 = randomizar.Next(1, 11); }

            lblSomaEsq.Text = valorSoma1.ToString();
            lblSomaDir.Text = valorSoma2.ToString();
            lblMenosEsq.Text = valorSub1.ToString();
            lblMenosDir.Text = valorSub2.ToString();
            lblDivideEsq.Text = valorDiv1.ToString();
            lblDivideDir.Text = valorDiv2.ToString();
            lblVezesEsq.Text = valorMult1.ToString();
            lblVezesDir.Text = valorMult2.ToString();

            nudSoma.Value = 0;
            nudDivisao.Value = 0;
            nudMultiplicacao.Value = 0;
            nudSubtracao.Value = 0;


            tempoRestante = 30;
            lblTempo.Text = "30 segundos";
            timer1.Start();
        }

        private bool ValidaResposta()
        {
            if(((valorSoma1 + valorSoma2) == nudSoma.Value) 
                && ((valorSub1 - valorSub2) == nudSubtracao.Value)
                && ((valorMult1 * valorMult2) == nudMultiplicacao.Value)
                && ((valorDiv1 / valorDiv2) == nudDivisao.Value))   { return true;}
            else { return false; }
        }
        #endregion

        public frmQuizMath()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ValidaResposta())
            {
                timer1.Stop();
                MessageBox.Show("Você respondeu tudo certo!", "Parabéns!");
                btnInicio.Enabled = true;
                lblTempo.ForeColor = Color.Black;
            }
            else if(tempoRestante > 0)
            {
                tempoRestante -= 1;
                lblTempo.Text = tempoRestante + " segundos";
                if(tempoRestante <= 5)
                {
                    lblTempo.ForeColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                lblTempo.Text = "Tempo Encerrado!";
                MessageBox.Show("Você não terminou no tempo.", "Desculpe!");
                nudSoma.Value = valorSoma1 + valorSoma2;
                nudSubtracao.Value = valorSub1 - valorSub2;
                nudMultiplicacao.Value = valorMult1 * valorMult2;
                nudDivisao.Value = valorDiv1 / valorDiv2;
                btnInicio.Enabled = true;
                lblTempo.ForeColor = Color.Black;
            }
        }

        private void resposta_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            IniciarTeste();
            btnInicio.Enabled = false;
        }

        private void frmQuizMath_Load(object sender, EventArgs e)
        {
            
        }
    }
}
