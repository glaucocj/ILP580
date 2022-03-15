
namespace wfaQuizMath
{
    partial class frmQuizMath
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
            this.components = new System.ComponentModel.Container();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.lblSomaEsq = new System.Windows.Forms.Label();
            this.lblMais = new System.Windows.Forms.Label();
            this.lblSomaDir = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.nudSoma = new System.Windows.Forms.NumericUpDown();
            this.nudSubtracao = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenosDir = new System.Windows.Forms.Label();
            this.lblMenos = new System.Windows.Forms.Label();
            this.lblMenosEsq = new System.Windows.Forms.Label();
            this.nudMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVezesDir = new System.Windows.Forms.Label();
            this.lblVezes = new System.Windows.Forms.Label();
            this.lblVezesEsq = new System.Windows.Forms.Label();
            this.nudDivisao = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDivideDir = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.lblDivideEsq = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(265, 19);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(200, 30);
            this.lblTempo.TabIndex = 0;
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.Location = new System.Drawing.Point(33, 18);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(217, 33);
            this.lblTempoRestante.TabIndex = 1;
            this.lblTempoRestante.Text = "Tempo Restante";
            // 
            // lblSomaEsq
            // 
            this.lblSomaEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSomaEsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaEsq.Location = new System.Drawing.Point(50, 75);
            this.lblSomaEsq.Name = "lblSomaEsq";
            this.lblSomaEsq.Size = new System.Drawing.Size(60, 50);
            this.lblSomaEsq.TabIndex = 2;
            this.lblSomaEsq.Text = "?";
            this.lblSomaEsq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMais
            // 
            this.lblMais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMais.Location = new System.Drawing.Point(125, 75);
            this.lblMais.Name = "lblMais";
            this.lblMais.Size = new System.Drawing.Size(60, 50);
            this.lblMais.TabIndex = 3;
            this.lblMais.Text = "+";
            this.lblMais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSomaDir
            // 
            this.lblSomaDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSomaDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaDir.Location = new System.Drawing.Point(200, 75);
            this.lblSomaDir.Name = "lblSomaDir";
            this.lblSomaDir.Size = new System.Drawing.Size(60, 50);
            this.lblSomaDir.TabIndex = 4;
            this.lblSomaDir.Text = "?";
            this.lblSomaDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIgual
            // 
            this.lblIgual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(275, 75);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(60, 50);
            this.lblIgual.TabIndex = 5;
            this.lblIgual.Text = "=";
            this.lblIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSoma
            // 
            this.nudSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoma.Location = new System.Drawing.Point(350, 80);
            this.nudSoma.Name = "nudSoma";
            this.nudSoma.Size = new System.Drawing.Size(100, 41);
            this.nudSoma.TabIndex = 1;
            this.nudSoma.ValueChanged += new System.EventHandler(this.nudSoma_ValueChanged);
            this.nudSoma.Enter += new System.EventHandler(this.resposta_Enter);
            // 
            // nudSubtracao
            // 
            this.nudSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSubtracao.Location = new System.Drawing.Point(350, 140);
            this.nudSubtracao.Name = "nudSubtracao";
            this.nudSubtracao.Size = new System.Drawing.Size(100, 41);
            this.nudSubtracao.TabIndex = 2;
            this.nudSubtracao.ValueChanged += new System.EventHandler(this.nudSubtracao_ValueChanged);
            this.nudSubtracao.Enter += new System.EventHandler(this.resposta_Enter);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenosDir
            // 
            this.lblMenosDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenosDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenosDir.Location = new System.Drawing.Point(200, 135);
            this.lblMenosDir.Name = "lblMenosDir";
            this.lblMenosDir.Size = new System.Drawing.Size(60, 50);
            this.lblMenosDir.TabIndex = 9;
            this.lblMenosDir.Text = "?";
            this.lblMenosDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenos
            // 
            this.lblMenos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenos.Location = new System.Drawing.Point(125, 135);
            this.lblMenos.Name = "lblMenos";
            this.lblMenos.Size = new System.Drawing.Size(60, 50);
            this.lblMenos.TabIndex = 8;
            this.lblMenos.Text = "-";
            this.lblMenos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenosEsq
            // 
            this.lblMenosEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenosEsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenosEsq.Location = new System.Drawing.Point(50, 135);
            this.lblMenosEsq.Name = "lblMenosEsq";
            this.lblMenosEsq.Size = new System.Drawing.Size(60, 50);
            this.lblMenosEsq.TabIndex = 7;
            this.lblMenosEsq.Text = "?";
            this.lblMenosEsq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMultiplicacao
            // 
            this.nudMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMultiplicacao.Location = new System.Drawing.Point(350, 200);
            this.nudMultiplicacao.Name = "nudMultiplicacao";
            this.nudMultiplicacao.Size = new System.Drawing.Size(100, 41);
            this.nudMultiplicacao.TabIndex = 3;
            this.nudMultiplicacao.ValueChanged += new System.EventHandler(this.nudMultiplicacao_ValueChanged);
            this.nudMultiplicacao.Enter += new System.EventHandler(this.resposta_Enter);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 15;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVezesDir
            // 
            this.lblVezesDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVezesDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezesDir.Location = new System.Drawing.Point(200, 195);
            this.lblVezesDir.Name = "lblVezesDir";
            this.lblVezesDir.Size = new System.Drawing.Size(60, 50);
            this.lblVezesDir.TabIndex = 14;
            this.lblVezesDir.Text = "?";
            this.lblVezesDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVezes
            // 
            this.lblVezes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezes.Location = new System.Drawing.Point(125, 195);
            this.lblVezes.Name = "lblVezes";
            this.lblVezes.Size = new System.Drawing.Size(60, 50);
            this.lblVezes.TabIndex = 13;
            this.lblVezes.Text = "X";
            this.lblVezes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVezesEsq
            // 
            this.lblVezesEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVezesEsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezesEsq.Location = new System.Drawing.Point(50, 195);
            this.lblVezesEsq.Name = "lblVezesEsq";
            this.lblVezesEsq.Size = new System.Drawing.Size(60, 50);
            this.lblVezesEsq.TabIndex = 12;
            this.lblVezesEsq.Text = "?";
            this.lblVezesEsq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDivisao
            // 
            this.nudDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDivisao.Location = new System.Drawing.Point(350, 266);
            this.nudDivisao.Name = "nudDivisao";
            this.nudDivisao.Size = new System.Drawing.Size(100, 41);
            this.nudDivisao.TabIndex = 4;
            this.nudDivisao.ValueChanged += new System.EventHandler(this.nudDivisao_ValueChanged);
            this.nudDivisao.Enter += new System.EventHandler(this.resposta_Enter);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 20;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivideDir
            // 
            this.lblDivideDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivideDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideDir.Location = new System.Drawing.Point(200, 261);
            this.lblDivideDir.Name = "lblDivideDir";
            this.lblDivideDir.Size = new System.Drawing.Size(60, 50);
            this.lblDivideDir.TabIndex = 19;
            this.lblDivideDir.Text = "?";
            this.lblDivideDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivide
            // 
            this.lblDivide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivide.Location = new System.Drawing.Point(125, 261);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(60, 50);
            this.lblDivide.TabIndex = 18;
            this.lblDivide.Text = "/";
            this.lblDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivideEsq
            // 
            this.lblDivideEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivideEsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideEsq.Location = new System.Drawing.Point(50, 261);
            this.lblDivideEsq.Name = "lblDivideEsq";
            this.lblDivideEsq.Size = new System.Drawing.Size(60, 50);
            this.lblDivideEsq.TabIndex = 17;
            this.lblDivideEsq.Text = "?";
            this.lblDivideEsq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = true;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(160, 314);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(175, 39);
            this.btnInicio.TabIndex = 22;
            this.btnInicio.Text = "Iniciar o Teste";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQuizMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.nudDivisao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDivideDir);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblDivideEsq);
            this.Controls.Add(this.nudMultiplicacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVezesDir);
            this.Controls.Add(this.lblVezes);
            this.Controls.Add(this.lblVezesEsq);
            this.Controls.Add(this.nudSubtracao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenosDir);
            this.Controls.Add(this.lblMenos);
            this.Controls.Add(this.lblMenosEsq);
            this.Controls.Add(this.nudSoma);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblSomaDir);
            this.Controls.Add(this.lblMais);
            this.Controls.Add(this.lblSomaEsq);
            this.Controls.Add(this.lblTempoRestante);
            this.Controls.Add(this.lblTempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmQuizMath";
            this.Text = "Teste de Matemática";
            this.Load += new System.EventHandler(this.frmQuizMath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Label lblSomaEsq;
        private System.Windows.Forms.Label lblMais;
        private System.Windows.Forms.Label lblSomaDir;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.NumericUpDown nudSoma;
        private System.Windows.Forms.NumericUpDown nudSubtracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenosDir;
        private System.Windows.Forms.Label lblMenos;
        private System.Windows.Forms.Label lblMenosEsq;
        private System.Windows.Forms.NumericUpDown nudMultiplicacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVezesDir;
        private System.Windows.Forms.Label lblVezes;
        private System.Windows.Forms.Label lblVezesEsq;
        private System.Windows.Forms.NumericUpDown nudDivisao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDivideDir;
        private System.Windows.Forms.Label lblDivide;
        private System.Windows.Forms.Label lblDivideEsq;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Timer timer1;
    }
}

