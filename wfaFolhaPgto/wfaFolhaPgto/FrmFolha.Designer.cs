
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
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(45, 30);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(240, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblHorTra
            // 
            this.lblHorTra.AutoSize = true;
            this.lblHorTra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorTra.Location = new System.Drawing.Point(45, 91);
            this.lblHorTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorTra.Name = "lblHorTra";
            this.lblHorTra.Size = new System.Drawing.Size(214, 29);
            this.lblHorTra.TabIndex = 1;
            this.lblHorTra.Text = "Horas Trabalhadas";
            // 
            // lblVlrHor
            // 
            this.lblVlrHor.AutoSize = true;
            this.lblVlrHor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrHor.Location = new System.Drawing.Point(45, 152);
            this.lblVlrHor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVlrHor.Name = "lblVlrHor";
            this.lblVlrHor.Size = new System.Drawing.Size(159, 29);
            this.lblVlrHor.TabIndex = 2;
            this.lblVlrHor.Text = "Valor da Hora";
            // 
            // lblNumDep
            // 
            this.lblNumDep.AutoSize = true;
            this.lblNumDep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDep.Location = new System.Drawing.Point(45, 213);
            this.lblNumDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDep.Name = "lblNumDep";
            this.lblNumDep.Size = new System.Drawing.Size(231, 29);
            this.lblNumDep.TabIndex = 3;
            this.lblNumDep.Text = "Nro de Dependentes";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(310, 27);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(635, 36);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtHorTra
            // 
            this.txtHorTra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorTra.Location = new System.Drawing.Point(310, 84);
            this.txtHorTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorTra.Name = "txtHorTra";
            this.txtHorTra.Size = new System.Drawing.Size(132, 36);
            this.txtHorTra.TabIndex = 2;
            this.txtHorTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorTra_KeyPress);
            this.txtHorTra.Validating += new System.ComponentModel.CancelEventHandler(this.txtHorTra_Validating);
            // 
            // txtVlrHor
            // 
            this.txtVlrHor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrHor.Location = new System.Drawing.Point(310, 145);
            this.txtVlrHor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrHor.Name = "txtVlrHor";
            this.txtVlrHor.Size = new System.Drawing.Size(132, 36);
            this.txtVlrHor.TabIndex = 3;
            this.txtVlrHor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrHor_KeyPress);
            this.txtVlrHor.Validating += new System.ComponentModel.CancelEventHandler(this.txtVlrHor_Validating);
            // 
            // txtNumDep
            // 
            this.txtNumDep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDep.Location = new System.Drawing.Point(310, 206);
            this.txtNumDep.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDep.Name = "txtNumDep";
            this.txtNumDep.Size = new System.Drawing.Size(132, 36);
            this.txtNumDep.TabIndex = 4;
            this.txtNumDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDep_KeyPress);
            this.txtNumDep.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumDep_Validating);
            // 
            // pctImagem
            // 
            this.pctImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctImagem.Image")));
            this.pctImagem.Location = new System.Drawing.Point(667, 71);
            this.pctImagem.Margin = new System.Windows.Forms.Padding(4);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(261, 171);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 8;
            this.pctImagem.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(241, 257);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 50);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(450, 257);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(677, 257);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 50);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlSaida
            // 
            this.pnlSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSaida.Controls.Add(this.lblSalLiq);
            this.pnlSaida.Controls.Add(this.label1);
            this.pnlSaida.Controls.Add(this.lblIR);
            this.pnlSaida.Controls.Add(this.label4);
            this.pnlSaida.Controls.Add(this.lblInss);
            this.pnlSaida.Controls.Add(this.label2);
            this.pnlSaida.Controls.Add(this.lblSalBruto);
            this.pnlSaida.Controls.Add(this.label3);
            this.pnlSaida.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSaida.Location = new System.Drawing.Point(16, 331);
            this.pnlSaida.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSaida.Name = "pnlSaida";
            this.pnlSaida.Size = new System.Drawing.Size(1033, 196);
            this.pnlSaida.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Salário Líquido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salário Bruto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Imposto Renda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "INSS";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalBruto.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(226, 22);
            this.lblSalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(150, 28);
            this.lblSalBruto.TabIndex = 13;
            // 
            // lblInss
            // 
            this.lblInss.BackColor = System.Drawing.SystemColors.Control;
            this.lblInss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInss.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInss.Location = new System.Drawing.Point(226, 66);
            this.lblInss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(150, 28);
            this.lblInss.TabIndex = 14;
            // 
            // lblIR
            // 
            this.lblIR.BackColor = System.Drawing.SystemColors.Control;
            this.lblIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIR.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(226, 112);
            this.lblIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(150, 28);
            this.lblIR.TabIndex = 15;
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalLiq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalLiq.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(226, 152);
            this.lblSalLiq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(150, 28);
            this.lblSalLiq.TabIndex = 16;
            // 
            // FrmFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmFolha";
            this.Text = "Folha de Pagamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFolha_FormClosing);
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

