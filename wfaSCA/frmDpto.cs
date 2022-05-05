using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class frmDpto : Form
    {
        public frmDpto()
        {
            InitializeComponent();
        }

        private BindingManagerBase bmbDpto;

        private void frmDpto_Load(object sender, EventArgs e)
        {
            try
            {
                this.bmbDpto = this.BindingContext[dataSetDpto, "departamentos"];
                this.txtSigla.DataBindings.Add("Text", this.dataSetDpto, "departamentos.dep_sgl");
                this.txtNome.DataBindings.Add("Text", this.dataSetDpto, "departamentos.dep_nom");
                this.dataAdapterDpto.Fill(dataSetDpto, "departamentos");
            }
            catch (Exception erroAplicacao)
            {
                MessageBox.Show(this, erroAplicacao.Message,"Erro...");
            }
            finally
            {
                if ( cnnDpto.State == ConnectionState.Open) cnnDpto.Close();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.bmbDpto.Position--;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.bmbDpto.Position++;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bmbDpto.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.bmbDpto.EndCurrentEdit();
            this.dataAdapterDpto.Update(this.dataSetDpto);
            this.dataSetDpto.AcceptChanges();
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            this.bmbDpto.RemoveAt(bmbDpto.Position);
        }
    }
}
