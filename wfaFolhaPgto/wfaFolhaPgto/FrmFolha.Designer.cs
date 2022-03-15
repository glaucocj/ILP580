
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
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(393, 133);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblHorTra
            // 
            this.lblHorTra.AutoSize = true;
            this.lblHorTra.Location = new System.Drawing.Point(393, 185);
            this.lblHorTra.Name = "lblHorTra";
            this.lblHorTra.Size = new System.Drawing.Size(97, 13);
            this.lblHorTra.TabIndex = 1;
            this.lblHorTra.Text = "Horas Trabalhadas";
            // 
            // lblVlrHor
            // 
            this.lblVlrHor.AutoSize = true;
            this.lblVlrHor.Location = new System.Drawing.Point(393, 237);
            this.lblVlrHor.Name = "lblVlrHor";
            this.lblVlrHor.Size = new System.Drawing.Size(72, 13);
            this.lblVlrHor.TabIndex = 2;
            this.lblVlrHor.Text = "Valor da Hora";
            // 
            // lblNumDep
            // 
            this.lblNumDep.AutoSize = true;
            this.lblNumDep.Location = new System.Drawing.Point(393, 300);
            this.lblNumDep.Name = "lblNumDep";
            this.lblNumDep.Size = new System.Drawing.Size(106, 13);
            this.lblNumDep.TabIndex = 3;
            this.lblNumDep.Text = "Nro de Dependentes";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(364, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtHorTra
            // 
            this.txtHorTra.Location = new System.Drawing.Point(512, 55);
            this.txtHorTra.Name = "txtHorTra";
            this.txtHorTra.Size = new System.Drawing.Size(100, 20);
            this.txtHorTra.TabIndex = 5;
            // 
            // txtVlrHor
            // 
            this.txtVlrHor.Location = new System.Drawing.Point(656, 55);
            this.txtVlrHor.Name = "txtVlrHor";
            this.txtVlrHor.Size = new System.Drawing.Size(100, 20);
            this.txtVlrHor.TabIndex = 6;
            // 
            // txtNumDep
            // 
            this.txtNumDep.Location = new System.Drawing.Point(656, 133);
            this.txtNumDep.Name = "txtNumDep";
            this.txtNumDep.Size = new System.Drawing.Size(100, 20);
            this.txtNumDep.TabIndex = 7;
            // 
            // pctImagem
            // 
            this.pctImagem.Location = new System.Drawing.Point(656, 263);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(100, 50);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 8;
            this.pctImagem.TabStop = false;
            // 
            // FrmFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.txtNumDep);
            this.Controls.Add(this.txtVlrHor);
            this.Controls.Add(this.txtHorTra);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumDep);
            this.Controls.Add(this.lblVlrHor);
            this.Controls.Add(this.lblHorTra);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFolha";
            this.Text = "Folha de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
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
    }
}

