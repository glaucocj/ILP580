
namespace WfaCalculos
{
    partial class FrmCalculos
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
            this.tabCalculos = new System.Windows.Forms.TabControl();
            this.tabArea = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.grbOpcao = new System.Windows.Forms.GroupBox();
            this.rdbCubo = new System.Windows.Forms.RadioButton();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.rdbQuadrado = new System.Windows.Forms.RadioButton();
            this.tabClassificacao = new System.Windows.Forms.TabPage();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNrosPrimos = new System.Windows.Forms.TabPage();
            this.tabCalculos.SuspendLayout();
            this.tabArea.SuspendLayout();
            this.grbOpcao.SuspendLayout();
            this.tabClassificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCalculos
            // 
            this.tabCalculos.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabCalculos.Controls.Add(this.tabArea);
            this.tabCalculos.Controls.Add(this.tabClassificacao);
            this.tabCalculos.Controls.Add(this.tabNrosPrimos);
            this.tabCalculos.Location = new System.Drawing.Point(12, 12);
            this.tabCalculos.Name = "tabCalculos";
            this.tabCalculos.SelectedIndex = 0;
            this.tabCalculos.Size = new System.Drawing.Size(776, 426);
            this.tabCalculos.TabIndex = 0;
            // 
            // tabArea
            // 
            this.tabArea.Controls.Add(this.btnLimpar);
            this.tabArea.Controls.Add(this.btnCalcular);
            this.tabArea.Controls.Add(this.txtResultado);
            this.tabArea.Controls.Add(this.txtZ);
            this.tabArea.Controls.Add(this.txtY);
            this.tabArea.Controls.Add(this.txtX);
            this.tabArea.Controls.Add(this.lblArea);
            this.tabArea.Controls.Add(this.lblY);
            this.tabArea.Controls.Add(this.lblZ);
            this.tabArea.Controls.Add(this.lblX);
            this.tabArea.Controls.Add(this.grbOpcao);
            this.tabArea.Location = new System.Drawing.Point(4, 28);
            this.tabArea.Name = "tabArea";
            this.tabArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabArea.Size = new System.Drawing.Size(768, 394);
            this.tabArea.TabIndex = 0;
            this.tabArea.Text = "Cálculo de Área/Volume";
            this.tabArea.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(622, 312);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.Location = new System.Drawing.Point(494, 312);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 35);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtResultado.Location = new System.Drawing.Point(436, 158);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 30);
            this.txtResultado.TabIndex = 8;
            // 
            // txtZ
            // 
            this.txtZ.Enabled = false;
            this.txtZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtZ.Location = new System.Drawing.Point(563, 74);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 30);
            this.txtZ.TabIndex = 7;
            this.txtZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZ_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Enabled = false;
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtY.Location = new System.Drawing.Point(419, 74);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 30);
            this.txtY.TabIndex = 6;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtX.Location = new System.Drawing.Point(281, 71);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 30);
            this.txtX.TabIndex = 5;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblArea.Location = new System.Drawing.Point(276, 161);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(127, 25);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Área/Volume";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblY.Location = new System.Drawing.Point(457, 43);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 25);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblZ.Location = new System.Drawing.Point(601, 43);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(24, 25);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "Z";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblX.Location = new System.Drawing.Point(318, 43);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // grbOpcao
            // 
            this.grbOpcao.Controls.Add(this.rdbCubo);
            this.grbOpcao.Controls.Add(this.rdbRetangulo);
            this.grbOpcao.Controls.Add(this.rdbQuadrado);
            this.grbOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpcao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbOpcao.Location = new System.Drawing.Point(17, 21);
            this.grbOpcao.Name = "grbOpcao";
            this.grbOpcao.Size = new System.Drawing.Size(244, 165);
            this.grbOpcao.TabIndex = 0;
            this.grbOpcao.TabStop = false;
            this.grbOpcao.Text = "Figura";
            // 
            // rdbCubo
            // 
            this.rdbCubo.AutoSize = true;
            this.rdbCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCubo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbCubo.Location = new System.Drawing.Point(6, 123);
            this.rdbCubo.Name = "rdbCubo";
            this.rdbCubo.Size = new System.Drawing.Size(81, 29);
            this.rdbCubo.TabIndex = 3;
            this.rdbCubo.Text = "Cubo";
            this.rdbCubo.UseVisualStyleBackColor = true;
            this.rdbCubo.CheckedChanged += new System.EventHandler(this.rdbCubo_CheckedChanged);
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRetangulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbRetangulo.Location = new System.Drawing.Point(6, 88);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.Size = new System.Drawing.Size(121, 29);
            this.rdbRetangulo.TabIndex = 2;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            this.rdbRetangulo.CheckedChanged += new System.EventHandler(this.rdbRetangulo_CheckedChanged);
            // 
            // rdbQuadrado
            // 
            this.rdbQuadrado.AutoSize = true;
            this.rdbQuadrado.Checked = true;
            this.rdbQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuadrado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbQuadrado.Location = new System.Drawing.Point(6, 53);
            this.rdbQuadrado.Name = "rdbQuadrado";
            this.rdbQuadrado.Size = new System.Drawing.Size(121, 29);
            this.rdbQuadrado.TabIndex = 1;
            this.rdbQuadrado.TabStop = true;
            this.rdbQuadrado.Text = "Quadrado";
            this.rdbQuadrado.UseVisualStyleBackColor = true;
            this.rdbQuadrado.CheckedChanged += new System.EventHandler(this.rdbQuadrado_CheckedChanged);
            // 
            // tabClassificacao
            // 
            this.tabClassificacao.Controls.Add(this.btnLimpar2);
            this.tabClassificacao.Controls.Add(this.btnClassificar);
            this.tabClassificacao.Controls.Add(this.txtB);
            this.tabClassificacao.Controls.Add(this.txtC);
            this.tabClassificacao.Controls.Add(this.txt1);
            this.tabClassificacao.Controls.Add(this.txt2);
            this.tabClassificacao.Controls.Add(this.txt3);
            this.tabClassificacao.Controls.Add(this.txtA);
            this.tabClassificacao.Controls.Add(this.label2);
            this.tabClassificacao.Controls.Add(this.label1);
            this.tabClassificacao.Location = new System.Drawing.Point(4, 28);
            this.tabClassificacao.Name = "tabClassificacao";
            this.tabClassificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassificacao.Size = new System.Drawing.Size(768, 394);
            this.tabClassificacao.TabIndex = 1;
            this.tabClassificacao.Text = "Classificação";
            this.tabClassificacao.UseVisualStyleBackColor = true;
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.AutoSize = true;
            this.btnLimpar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar2.Location = new System.Drawing.Point(488, 177);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(94, 35);
            this.btnLimpar2.TabIndex = 18;
            this.btnLimpar2.Text = "&Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // btnClassificar
            // 
            this.btnClassificar.AutoSize = true;
            this.btnClassificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassificar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClassificar.Location = new System.Drawing.Point(488, 78);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(112, 35);
            this.btnClassificar.TabIndex = 11;
            this.btnClassificar.Text = "&Classificar";
            this.btnClassificar.UseVisualStyleBackColor = true;
            this.btnClassificar.Click += new System.EventHandler(this.btnClassificar_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtB.Location = new System.Drawing.Point(175, 78);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 30);
            this.txtB.TabIndex = 17;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtC.Location = new System.Drawing.Point(306, 78);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 30);
            this.txtC.TabIndex = 16;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Info;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt1.Location = new System.Drawing.Point(44, 182);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 30);
            this.txt1.TabIndex = 15;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Info;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt2.Location = new System.Drawing.Point(175, 182);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 30);
            this.txt2.TabIndex = 14;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.Info;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt3.Location = new System.Drawing.Point(306, 182);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 30);
            this.txt3.TabIndex = 13;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtA.Location = new System.Drawing.Point(44, 78);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 30);
            this.txtA.TabIndex = 6;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(39, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Números em Ordem Crescente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Entre com os números:";
            // 
            // tabNrosPrimos
            // 
            this.tabNrosPrimos.Location = new System.Drawing.Point(4, 28);
            this.tabNrosPrimos.Name = "tabNrosPrimos";
            this.tabNrosPrimos.Size = new System.Drawing.Size(768, 394);
            this.tabNrosPrimos.TabIndex = 2;
            this.tabNrosPrimos.Text = "Nº Primos";
            this.tabNrosPrimos.UseVisualStyleBackColor = true;
            // 
            // FrmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.tabCalculos);
            this.Name = "FrmCalculos";
            this.Text = "C Á L C U L O S";
            this.tabCalculos.ResumeLayout(false);
            this.tabArea.ResumeLayout(false);
            this.tabArea.PerformLayout();
            this.grbOpcao.ResumeLayout(false);
            this.grbOpcao.PerformLayout();
            this.tabClassificacao.ResumeLayout(false);
            this.tabClassificacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCalculos;
        private System.Windows.Forms.TabPage tabArea;
        private System.Windows.Forms.TabPage tabClassificacao;
        private System.Windows.Forms.TabPage tabNrosPrimos;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox grbOpcao;
        private System.Windows.Forms.RadioButton rdbCubo;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.RadioButton rdbQuadrado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.Button btnClassificar;
    }
}

