
namespace WfaOO
{
    partial class FrmConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConta));
            this.lblNroConta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblTipoDaConta = new System.Windows.Forms.Label();
            this.lblLimiteDaConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.txtNroConta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtTipoDaConta = new System.Windows.Forms.TextBox();
            this.txtLimiteDaConta = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblExtrato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroConta
            // 
            this.lblNroConta.AutoSize = true;
            this.lblNroConta.Location = new System.Drawing.Point(78, 45);
            this.lblNroConta.Name = "lblNroConta";
            this.lblNroConta.Size = new System.Drawing.Size(72, 17);
            this.lblNroConta.TabIndex = 0;
            this.lblNroConta.Text = "Nro Conta";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(262, 45);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(48, 17);
            this.lblTitular.TabIndex = 1;
            this.lblTitular.Text = "Titular";
            // 
            // lblTipoDaConta
            // 
            this.lblTipoDaConta.AutoSize = true;
            this.lblTipoDaConta.Location = new System.Drawing.Point(426, 45);
            this.lblTipoDaConta.Name = "lblTipoDaConta";
            this.lblTipoDaConta.Size = new System.Drawing.Size(97, 17);
            this.lblTipoDaConta.TabIndex = 2;
            this.lblTipoDaConta.Text = "Tipo da Conta";
            // 
            // lblLimiteDaConta
            // 
            this.lblLimiteDaConta.AutoSize = true;
            this.lblLimiteDaConta.Location = new System.Drawing.Point(578, 45);
            this.lblLimiteDaConta.Name = "lblLimiteDaConta";
            this.lblLimiteDaConta.Size = new System.Drawing.Size(106, 17);
            this.lblLimiteDaConta.TabIndex = 3;
            this.lblLimiteDaConta.Text = "Limite da Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(347, 182);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Location = new System.Drawing.Point(56, 263);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(151, 17);
            this.lblDisponivel.TabIndex = 5;
            this.lblDisponivel.Text = "Disponível para Saque";
            // 
            // txtNroConta
            // 
            this.txtNroConta.Location = new System.Drawing.Point(81, 95);
            this.txtNroConta.Name = "txtNroConta";
            this.txtNroConta.Size = new System.Drawing.Size(100, 22);
            this.txtNroConta.TabIndex = 6;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(265, 95);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 22);
            this.txtTitular.TabIndex = 7;
            // 
            // txtTipoDaConta
            // 
            this.txtTipoDaConta.Location = new System.Drawing.Point(429, 95);
            this.txtTipoDaConta.Name = "txtTipoDaConta";
            this.txtTipoDaConta.Size = new System.Drawing.Size(100, 22);
            this.txtTipoDaConta.TabIndex = 8;
            // 
            // txtLimiteDaConta
            // 
            this.txtLimiteDaConta.Location = new System.Drawing.Point(581, 95);
            this.txtLimiteDaConta.Name = "txtLimiteDaConta";
            this.txtLimiteDaConta.Size = new System.Drawing.Size(100, 22);
            this.txtLimiteDaConta.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(350, 214);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 10;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.AutoSize = true;
            this.btnCriarConta.Location = new System.Drawing.Point(609, 152);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(89, 27);
            this.btnCriarConta.TabIndex = 12;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.AutoSize = true;
            this.btnDepositar.Location = new System.Drawing.Point(493, 209);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(89, 27);
            this.btnDepositar.TabIndex = 13;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.AutoSize = true;
            this.btnSacar.Location = new System.Drawing.Point(609, 209);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(89, 27);
            this.btnSacar.TabIndex = 14;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblExtrato
            // 
            this.lblExtrato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtrato.Location = new System.Drawing.Point(56, 294);
            this.lblExtrato.Name = "lblExtrato";
            this.lblExtrato.Size = new System.Drawing.Size(681, 139);
            this.lblExtrato.TabIndex = 15;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExtrato);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtLimiteDaConta);
            this.Controls.Add(this.txtTipoDaConta);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNroConta);
            this.Controls.Add(this.lblDisponivel);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblLimiteDaConta);
            this.Controls.Add(this.lblTipoDaConta);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lblNroConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConta";
            this.Text = "Cadastro de Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroConta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblTipoDaConta;
        private System.Windows.Forms.Label lblLimiteDaConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.TextBox txtNroConta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtTipoDaConta;
        private System.Windows.Forms.TextBox txtLimiteDaConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblExtrato;
    }
}

