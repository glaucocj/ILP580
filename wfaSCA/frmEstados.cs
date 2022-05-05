using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace wfaSCA
{
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        string mstring = Properties.Settings.Default.scaConnectionStringV1;
        bool bStatus;
        OleDbConnection oCn = new OleDbConnection();
        OleDbDataAdapter oDA = new OleDbDataAdapter();
        DataSet oDs = new DataSet();
        DataTable odt = new DataTable();
        DataRow oDr;

        private void frmEstados_Load(object sender, EventArgs e)
        {
            try
            {
                oCn = new OleDbConnection(mstring);
                oCn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na abertura da conexão" + ex.Message,"Cadastro de Estados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmEstados_FormClosing(object sender, FormClosingEventArgs e)
        {
            oDA.Dispose();
            oDs.Dispose();
            odt.Dispose();
            oCn.Dispose();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Entre com uma silga válida", "Cadastro de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sSQl = "SELECT * from estado where ufe_sig = '" + textBox1.Text.ToUpper() + "'";
                    oDA = new OleDbDataAdapter(sSQl, oCn);
                    oDs = new DataSet();
                    odt = new DataTable();
                    oDA.Fill(oDs,"Estado"); 
                    odt = oDs.Tables["Estado"];
                    if (odt.Rows.Count > 0)
                    {
                        oDr = odt.Rows[0];
                        textBox1.Text = oDr["ufe_sig"].ToString();
                        textBox2.Text = oDr["ufe_nom"].ToString();
                    }
                    else
                    {
                        oDr = odt.NewRow();
                        oDr["ufe_sig"] = textBox1.Text.ToUpper();
                        odt.Rows.Add(oDr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na confirmação"+ex.Message,"Cadastro de Estados",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSBNovo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            EPUFE.SetError(textBox1, "");
            EPUFE.SetError(textBox2, "");
            textBox1.Focus();
        }

        private void TSBSalvar_Click(object sender, EventArgs e)
        {
            if (Valida()==false)
            {
                MessageBox.Show("Corrija os campos com erro", "Cadastro de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                oDr["ufe_nom"] = textBox2.Text.ToUpper();
                OleDbCommandBuilder oCB = new OleDbCommandBuilder(oDA);

                oDA.Update(oDs, "estado");
                TSBNovo.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na confirmação" + ex.Message, "Cadastro de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
