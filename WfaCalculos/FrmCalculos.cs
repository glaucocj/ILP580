using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCalculos
{
    public partial class FrmCalculos : Form
    {
        public FrmCalculos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Text = "";
            if (rdbQuadrado.Checked || rdbRetangulo.Checked || rdbCubo.Checked)
            {
                if (txtX.Text.Trim() != "")
                {
                    
                    txtResultado.Text = Area(float.Parse(txtX.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório - X", "Cálculo de Área", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtX.Focus();
                }
                
            }

            if (rdbRetangulo.Checked || rdbCubo.Checked)
            {
                if (txtY.Text.Trim() != "")
                {

                    txtResultado.Text = Area(float.Parse(txtY.Text),float.Parse(txtY.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Campos Obrigatórios - Y", "Cálculo de Área", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtY.Focus();
                }

            }

            if (rdbCubo.Checked)
            {
                if (txtZ.Text.Trim() != "")
                {

                    txtResultado.Text = Area(float.Parse(txtX.Text),float.Parse(txtY.Text),float.Parse(txtZ.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Campos Obrigatórios - Z", "Cálculo de Área", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtZ.Focus();
                }

            }

            //if (rdbRetangulo.Checked)
            //{
            //    float valorX,valorY;
            //    valorX = float.Parse(txtX.Text);
            //    valorY = float.Parse(txtY.Text);
            //    txtResultado.Text = (Area(valorX,valorY).ToString());
            //}

            //if (rdbCubo.Checked)
            //{
            //    float valorX,valorY,valorZ;
            //    valorX = float.Parse(txtX.Text);
            //    valorY = float.Parse(txtY.Text);
            //    valorZ = float.Parse(txtZ.Text);
            //    txtResultado.Text = (Area(valorX,valorY,valorZ).ToString());
            //}
        }
        #region Métodos
        private static float Area(float valorX)
        {
            return (valorX * valorX);
        }

        private static float Area(float valorX,float valorY)
        {
            return (valorX * valorY);
        }

        private static float Area(float valorX, float valorY,float valorZ)
        {
            return (valorX * valorY * valorZ);
        }

        #endregion

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ',')
            {
                e.KeyChar = ClsValida.SoUmaVirgula(txtX.Text);
            }
            else
            {
                e.KeyChar = ClsValida.ConsisteNum(e.KeyChar);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
        }

        private void rdbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtY.Enabled = true;
            txtZ.Enabled = false;
            txtZ.Text = "";
        }

        private void rdbCubo_CheckedChanged(object sender, EventArgs e)
        {
            txtY.Enabled = true;
            txtZ.Enabled = true;
        }

        private void rdbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            txtY.Enabled = false;
            txtZ.Enabled = false;
            txtY.Text = "";
            txtZ.Text = "";
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = ClsValida.SoUmaVirgula(txtY.Text);
            }
            else
            {
                e.KeyChar = ClsValida.ConsisteNum(e.KeyChar);
            }
        }

        private void txtZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = ClsValida.SoUmaVirgula(txtZ.Text);
            }
            else
            {
                e.KeyChar = ClsValida.ConsisteNum(e.KeyChar);
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = ClsValida.SoUmaVirgula(txtA.Text);
            }
            else
            {
                e.KeyChar = ClsValida.ConsisteNum(e.KeyChar);
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = ClsValida.SoUmaVirgula(txtB.Text);
            }
            else
            {
                e.KeyChar = ClsValida.ConsisteNum(e.KeyChar);
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = ClsValida.SoUmaVirgula(txtC.Text);
            }
            else
            {
                e.KeyChar = ClsValida.ConsisteNum(e.KeyChar);
            }
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txtA.Text = ""; 
            txtB.Text = ""; 
            txtC.Text = "";
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            float a, b, c;
            float.TryParse(txtA.Text, out a);
            float.TryParse(txtA.Text, out b);
            float.TryParse(txtA.Text, out c);


            if (a >= b && a >=c)
            {
                txt1.Text = a.ToString();
                txt
            }
            else
            {

            }
        }
    }
}
