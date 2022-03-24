
namespace WfaPessoa
{
    partial class frmPessoa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPessoa = new System.Windows.Forms.GroupBox();
            this.rdbJuridica = new System.Windows.Forms.RadioButton();
            this.rdbFisica = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtbPessoa = new System.Windows.Forms.MaskedTextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.grbPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPessoa
            // 
            this.grbPessoa.Controls.Add(this.rdbJuridica);
            this.grbPessoa.Controls.Add(this.rdbFisica);
            this.grbPessoa.Location = new System.Drawing.Point(12, 12);
            this.grbPessoa.Name = "grbPessoa";
            this.grbPessoa.Size = new System.Drawing.Size(228, 134);
            this.grbPessoa.TabIndex = 0;
            this.grbPessoa.TabStop = false;
            this.grbPessoa.Text = "Pessoa";
            // 
            // rdbJuridica
            // 
            this.rdbJuridica.AutoSize = true;
            this.rdbJuridica.Location = new System.Drawing.Point(40, 77);
            this.rdbJuridica.Name = "rdbJuridica";
            this.rdbJuridica.Size = new System.Drawing.Size(129, 21);
            this.rdbJuridica.TabIndex = 2;
            this.rdbJuridica.TabStop = true;
            this.rdbJuridica.Text = "Pessoa Juridica";
            this.rdbJuridica.UseVisualStyleBackColor = true;
            this.rdbJuridica.CheckedChanged += new System.EventHandler(this.rdbJuridica_CheckedChanged);
            // 
            // rdbFisica
            // 
            this.rdbFisica.AutoSize = true;
            this.rdbFisica.Location = new System.Drawing.Point(40, 35);
            this.rdbFisica.Name = "rdbFisica";
            this.rdbFisica.Size = new System.Drawing.Size(116, 21);
            this.rdbFisica.TabIndex = 1;
            this.rdbFisica.TabStop = true;
            this.rdbFisica.Text = "Pessoa Física";
            this.rdbFisica.UseVisualStyleBackColor = true;
            this.rdbFisica.CheckedChanged += new System.EventHandler(this.rdbFisica_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(396, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(393, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSize = true;
            this.btnCadastrar.Location = new System.Drawing.Point(155, 265);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 27);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // mtbPessoa
            // 
            this.mtbPessoa.Location = new System.Drawing.Point(396, 180);
            this.mtbPessoa.Mask = "99,999,999/9999-99";
            this.mtbPessoa.Name = "mtbPessoa";
            this.mtbPessoa.Size = new System.Drawing.Size(161, 22);
            this.mtbPessoa.TabIndex = 5;
            this.mtbPessoa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPessoa.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPessoa_Validating);
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(393, 140);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(34, 17);
            this.lblPessoa.TabIndex = 6;
            this.lblPessoa.Text = "CPF";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Location = new System.Drawing.Point(532, 265);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 27);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Location = new System.Drawing.Point(396, 265);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 27);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.AutoSize = true;
            this.btnExibir.Location = new System.Drawing.Point(272, 265);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(80, 27);
            this.btnExibir.TabIndex = 9;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            // 
            // lblInfo1
            // 
            this.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo1.Location = new System.Drawing.Point(103, 333);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(200, 17);
            this.lblInfo1.TabIndex = 10;
            // 
            // lblInfo2
            // 
            this.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo2.Location = new System.Drawing.Point(103, 374);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(200, 17);
            this.lblInfo2.TabIndex = 11;
            // 
            // lblInfo3
            // 
            this.lblInfo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo3.Location = new System.Drawing.Point(103, 424);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(200, 17);
            this.lblInfo3.TabIndex = 12;
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.mtbPessoa);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.grbPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPessoa";
            this.Text = "Cadastro de Pessoa";
            this.grbPessoa.ResumeLayout(false);
            this.grbPessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPessoa;
        private System.Windows.Forms.RadioButton rdbJuridica;
        private System.Windows.Forms.RadioButton rdbFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbPessoa;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
    }
}

