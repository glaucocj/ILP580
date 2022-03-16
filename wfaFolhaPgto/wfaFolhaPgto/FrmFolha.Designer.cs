
namespace wfaFolhaPgto
{
    partial class FrmFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFolha));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblHorTra = new System.Windows.Forms.Label();
            this.lblVlrHor = new System.Windows.Forms.Label();
            this.lblNumDep = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtHorTra = new System.Windows.Forms.TextBox();
            this.txtVlrHor = new System.Windows.Forms.TextBox();
            this.txtNumDep = new System.Windows.Forms.TextBox();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlSaida = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.pnlSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblHorTra
            // 
            this.lblHorTra.AutoSize = true;
            this.lblHorTra.Location = new System.Drawing.Point(34, 88);
            this.lblHorTra.Name = "lblHorTra";
            this.lblHorTra.Size = new System.Drawing.Size(97, 13);
            this.lblHorTra.TabIndex = 1;
            this.lblHorTra.Text = "Horas Trabalhadas";
            // 
            // lblVlrHor
            // 
            this.lblVlrHor.AutoSize = true;
            this.lblVlrHor.Location = new System.Drawing.Point(34, 133);
            this.lblVlrHor.Name = "lblVlrHor";
            this.lblVlrHor.Size = new System.Drawing.Size(72, 13);
            this.lblVlrHor.TabIndex = 2;
            this.lblVlrHor.Text = "Valor da Hora";
            // 
            // lblNumDep
            // 
            this.lblNumDep.AutoSize = true;
            this.lblNumDep.Location = new System.Drawing.Point(34, 173);
            this.lblNumDep.Name = "lblNumDep";
            this.lblNumDep.Size = new System.Drawing.Size(106, 13);
            this.lblNumDep.TabIndex = 3;
            this.lblNumDep.Text = "Nro de Dependentes";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(477, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // txtHorTra
            // 
            this.txtHorTra.Location = new System.Drawing.Point(173, 81);
            this.txtHorTra.Name = "txtHorTra";
            this.txtHorTra.Size = new System.Drawing.Size(100, 20);
            this.txtHorTra.TabIndex = 2;
            this.txtHorTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorTra_KeyPress);
            this.txtHorTra.Validating += new System.ComponentModel.CancelEventHandler(this.txtHorTra_Validating);
            // 
            // txtVlrHor
            // 
            this.txtVlrHor.Location = new System.Drawing.Point(173, 133);
            this.txtVlrHor.Name = "txtVlrHor";
            this.txtVlrHor.Size = new System.Drawing.Size(100, 20);
            this.txtVlrHor.TabIndex = 3;
            this.txtVlrHor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrHor_KeyPress);
            this.txtVlrHor.Validating += new System.ComponentModel.CancelEventHandler(this.txtVlrHor_Validating);
            // 
            // txtNumDep
            // 
            this.txtNumDep.Location = new System.Drawing.Point(173, 174);
            this.txtNumDep.Name = "txtNumDep";
            this.txtNumDep.Size = new System.Drawing.Size(100, 20);
            this.txtNumDep.TabIndex = 4;
            this.txtNumDep.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumDep_Validating);
            // 
            // pctImagem
            // 
            this.pctImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctImagem.Image")));
            this.pctImagem.Location = new System.Drawing.Point(322, 81);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(167, 113);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 8;
            this.pctImagem.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(127, 214);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(237, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(347, 214);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // pnlSaida
            // 
            this.pnlSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSaida.Controls.Add(this.label1);
            this.pnlSaida.Controls.Add(this.label4);
            this.pnlSaida.Controls.Add(this.label2);
            this.pnlSaida.Controls.Add(this.label3);
            this.pnlSaida.Location = new System.Drawing.Point(12, 256);
            this.pnlSaida.Name = "pnlSaida";
            this.pnlSaida.Size = new System.Drawing.Size(776, 173);
            this.pnlSaida.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Salário Líquido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salário Bruto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Imposto Renda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "INSS";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalBruto.Location = new System.Drawing.Point(155, 287);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(108, 13);
            this.lblSalBruto.TabIndex = 13;
            // 
            // lblInss
            // 
            this.lblInss.BackColor = System.Drawing.SystemColors.Control;
            this.lblInss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInss.Location = new System.Drawing.Point(155, 322);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(108, 13);
            this.lblInss.TabIndex = 14;
            // 
            // lblIR
            // 
            this.lblIR.BackColor = System.Drawing.SystemColors.Control;
            this.lblIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIR.Location = new System.Drawing.Point(155, 360);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(108, 13);
            this.lblIR.TabIndex = 15;
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalLiq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalLiq.Location = new System.Drawing.Point(155, 392);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(108, 13);
            this.lblSalLiq.TabIndex = 16;
            // 
            // FrmFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.txtNumDep);
            this.Controls.Add(this.txtVlrHor);
            this.Controls.Add(this.txtHorTra);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumDep);
            this.Controls.Add(this.lblVlrHor);
            this.Controls.Add(this.lblHorTra);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFolha";
            this.Text = "Folha de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.pnlSaida.ResumeLayout(false);
            this.pnlSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblHorTra;
        private System.Windows.Forms.Label lblVlrHor;
        private System.Windows.Forms.Label lblNumDep;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtHorTra;
        private System.Windows.Forms.TextBox txtVlrHor;
        private System.Windows.Forms.TextBox txtNumDep;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlSaida;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

