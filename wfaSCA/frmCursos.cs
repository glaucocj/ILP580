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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void cursosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scaDataSet);

        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'scaDataSet.cursos'. Você pode movê-la ou removê-la conforme necessário.
            this.cursosTableAdapter.Fill(this.scaDataSet.cursos);

        }
        #region Validação de Campo Vazio
        private void cur_sglTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cur_sglTextBox.Text.Trim() == "")
            {
                EPCursos.SetError(cur_sglTextBox, "Entre com a silga do curso");
                
            }
                
        }

        private void cur_nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cur_nomTextBox.Text.Trim() == "")
            {
                EPCursos.SetError(cur_nomTextBox, "Entre com a silga do curso");
            }
        }

        private void cur_dep_sglTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cur_dep_sglTextBox.Text.Trim() == "")
            {
                EPCursos.SetError(cur_dep_sglTextBox, "Entre com a silga do curso");
            }
        }

        #endregion

        private void fillByCursoNomeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cursosTableAdapter.FillByCursoNome(this.scaDataSet.cursos, cur_nomToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
