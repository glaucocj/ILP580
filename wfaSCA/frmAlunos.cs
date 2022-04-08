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
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'scaAlunosDataSet.alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter1.Fill(this.scaAlunosDataSet.alunos);
            // TODO: esta linha de código carrega dados na tabela 'alunosDataSet.alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.alunosDataSet.alunos);
            if (txtSexo.Text == "F") { rdbFeminino.Checked = true; }
            else if (txtSexo.Text == "M") { rdbMasculino.Checked = true; }
            else { rdbOutro.Checked = true; }
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alunosDataSet);
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            txtSexo.Text = "F";
        }
        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            txtSexo.Text = "M";
        }
        private void rdbOutro_CheckedChanged(object sender, EventArgs e)
        {
            txtSexo.Text = "O";
        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            //if (txtSexo.Text == "F") { rdbFeminino.Checked = true; }
            //else if (txtSexo.Text == "M") { rdbMasculino.Checked = true; }
            //else { rdbOutro.Checked = true; }
        }


    }
}
