using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;

namespace wfaEscola
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            camadaNegocios alunos = new camadaNegocios();

            DataSet alunosDataSet = new DataSet();
            alunosDataSet = alunos.obtemAlunos();
            dgvAlunos.DataSource = alunosDataSet.Tables[0];
        }
    }
}
