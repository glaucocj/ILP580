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

        private void txtUfeSgl_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtUfeSgl.Text == "")
                {
                    MessageBox.Show("Entre com uma silga válida", "Cadastro de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sSQl = "SELECT * from Estados where ufe_sig = '" + txtUfeSgl.Text.ToUpper() + "'";
                    oDA = new OleDbDataAdapter(sSQl, oCn);
                    oDs = new DataSet();
                    odt = new DataTable();
                    oDA.Fill(oDs,"Estados"); 
                    odt = oDs.Tables["Estados"];
                    if (odt.Rows.Count > 0)
                    {
                        oDr = odt.Rows[0];
                        txtUfeSgl.Text = oDr["ufe_sig"].ToString();
                        txtUfeNom.Text = oDr["ufe_nom"].ToString();
                    }
                    else
                    {
                        oDr = odt.NewRow();
                        oDr["ufe_sig"] = txtUfeSgl.Text.ToUpper();
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
            txtUfeSgl.Text = "";
            txtUfeNom.Text = "";
            EPUFE.SetError(txtUfeSgl, "");
            EPUFE.SetError(txtUfeNom, "");
            txtUfeSgl.Focus();
        }

        private void TSBSalvar_Click(object sender, EventArgs e)
        {
            if (Valida()==false)
            {
                MessageBox.Show("Corrija os campos com erro", "Cadastro de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                oDr["ufe_nom"] = txtUfeNom.Text.ToUpper();
                OleDbCommandBuilder oCB = new OleDbCommandBuilder(oDA);

                oDA.Update(oDs, "Estados");
                TSBNovo.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na confirmação" + ex.Message, "Cadastro de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TBSDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Confirme a exclusão do estados " + txtUfeSgl.Text, "Exclusão de Estados",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    oDs.Tables["Estados"].Rows[0].Delete();

                    OleDbCommandBuilder oCB = new OleDbCommandBuilder(oDA);

                    oDA.Update(oDs, "Estados");
                    TSBNovo.PerformClick();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro na exclusão" + ex.Message,"Exclusão de Estados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Valida()
        {
            bStatus = true;
            if (txtUfeSgl.Text == "")
            {
                EPUFE.SetError(txtUfeSgl, "Entre com a sigla do estado");
                bStatus = false;
            }
            else
                EPUFE.SetError(txtUfeSgl, "");

            if (txtUfeNom.Text == "")
            {
                EPUFE.SetError(txtUfeNom, "Entre com a sigla do estado");
                bStatus = false;
            }
            else
                EPUFE.SetError(txtUfeNom, "");

            return bStatus;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string sSQL = "Select * from estados where ufe_nom = '" + txtNome.Text.ToUpper() + "'";
                OleDbDataAdapter oDA_Con = new OleDbDataAdapter(sSQL, oCn);
                DataSet oDS_Con = new DataSet();
                DataTable oDT_Con = new DataTable();
                oDA_Con.Fill(oDS_Con, "estados");
                oDT_Con = oDS_Con.Tables["estados"];
                dgvUfe.DataSource = oDT_Con;

                dgvUfe.Columns["ufe_sig"].HeaderText = "Sigla";
                dgvUfe.Columns["Ufe_nom"].HeaderText = "Nome";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro na Consulta: " + ex.Message, "Cadastro de Estados",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dgvUfe_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtUfeSgl.Text = dgvUfe.CurrentRow.Cells["Ufe_sig"].Value.ToString();
            txtUfeSgl_Validated(this, new EventArgs());
        }
    }
}
