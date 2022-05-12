namespace wfaSCA
{
    partial class frmEstados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBNovo = new System.Windows.Forms.ToolStripButton();
            this.TSBSalvar = new System.Windows.Forms.ToolStripButton();
            this.TBSDeletar = new System.Windows.Forms.ToolStripButton();
            this.txtUfeSgl = new System.Windows.Forms.TextBox();
            this.txtUfeNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EPUFE = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvUfe = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPUFE)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUfe)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBNovo,
            this.TSBSalvar,
            this.TBSDeletar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBNovo
            // 
            this.TSBNovo.Image = ((System.Drawing.Image)(resources.GetObject("TSBNovo.Image")));
            this.TSBNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNovo.Name = "TSBNovo";
            this.TSBNovo.Size = new System.Drawing.Size(69, 28);
            this.TSBNovo.Text = "&Novo";
            this.TSBNovo.Click += new System.EventHandler(this.TSBNovo_Click);
            // 
            // TSBSalvar
            // 
            this.TSBSalvar.Image = global::wfaSCA.Properties.Resources.icone;
            this.TSBSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSalvar.Name = "TSBSalvar";
            this.TSBSalvar.Size = new System.Drawing.Size(73, 28);
            this.TSBSalvar.Text = "&Salvar";
            this.TSBSalvar.Click += new System.EventHandler(this.TSBSalvar_Click);
            // 
            // TBSDeletar
            // 
            this.TBSDeletar.Image = global::wfaSCA.Properties.Resources.icone;
            this.TBSDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBSDeletar.Name = "TBSDeletar";
            this.TBSDeletar.Size = new System.Drawing.Size(76, 28);
            this.TBSDeletar.Text = "&Excluir";
            this.TBSDeletar.Click += new System.EventHandler(this.TBSDeletar_Click);
            // 
            // txtUfeSgl
            // 
            this.txtUfeSgl.Location = new System.Drawing.Point(31, 70);
            this.txtUfeSgl.Name = "txtUfeSgl";
            this.txtUfeSgl.Size = new System.Drawing.Size(100, 22);
            this.txtUfeSgl.TabIndex = 1;
            this.txtUfeSgl.Validated += new System.EventHandler(this.txtUfeSgl_Validated);
            // 
            // txtUfeNom
            // 
            this.txtUfeNom.Location = new System.Drawing.Point(175, 70);
            this.txtUfeNom.Name = "txtUfeNom";
            this.txtUfeNom.Size = new System.Drawing.Size(100, 22);
            this.txtUfeNom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // EPUFE
            // 
            this.EPUFE.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(24, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 367);
            this.tabControl1.TabIndex = 5;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.txtUfeSgl);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.txtUfeNom);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(743, 338);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Cadastro";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.dgvUfe);
            this.tab2.Controls.Add(this.btnPesquisar);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Controls.Add(this.txtNome);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(743, 338);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Consulta";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 22);
            this.txtNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Location = new System.Drawing.Point(296, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 26);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvUfe
            // 
            this.dgvUfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUfe.Location = new System.Drawing.Point(27, 102);
            this.dgvUfe.Name = "dgvUfe";
            this.dgvUfe.ReadOnly = true;
            this.dgvUfe.RowHeadersWidth = 51;
            this.dgvUfe.RowTemplate.Height = 24;
            this.dgvUfe.Size = new System.Drawing.Size(691, 214);
            this.dgvUfe.TabIndex = 3;
            this.dgvUfe.DoubleClick += new System.EventHandler(this.dgvUfe_DoubleClick);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEstados";
            this.Text = "Estados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEstados_FormClosing);
            this.Load += new System.EventHandler(this.frmEstados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPUFE)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBNovo;
        private System.Windows.Forms.ToolStripButton TSBSalvar;
        private System.Windows.Forms.ToolStripButton TBSDeletar;
        private System.Windows.Forms.TextBox txtUfeSgl;
        private System.Windows.Forms.TextBox txtUfeNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider EPUFE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvUfe;
    }
}