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
            this.bmbDpto = this.BindingContext[dtsDpto1, "departamentos"];
            this.textBox1.DataBindings.Add("Text", this.dtsDpto1, "departamentos.dep_sgl");
            this.textBox2.DataBindings.Add("Text", this.dtsDpto1, "departamentos.dep_nom");
            this.dtsDpto.Fill(dtsDpto1, "departamentos");
        }
    }
}
