namespace wfaSCA
{
    partial class frmDpto
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
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.cnnDpto = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataAdapterDpto = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSetDpto = new wfaSCA.dtsDpto();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDpto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(72, 117);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 22);
            this.txtSigla.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(241, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(72, 218);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(317, 218);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(196, 218);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 6;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(446, 218);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(575, 218);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(75, 23);
            this.Remover.TabIndex = 8;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // cnnDpto
            // 
            this.cnnDpto.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\GitHub\\ILP580\\BD\\sca.accdb";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT departamentos.*\r\nFROM     departamentos";
            this.oleDbSelectCommand1.Connection = this.cnnDpto;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `departamentos` (`dep_sgl`, `dep_nom`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.cnnDpto;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("dep_sgl", System.Data.OleDb.OleDbType.VarWChar, 0, "dep_sgl"),
            new System.Data.OleDb.OleDbParameter("dep_nom", System.Data.OleDb.OleDbType.VarWChar, 0, "dep_nom")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `departamentos` SET `dep_sgl` = ?, `dep_nom` = ? WHERE ((`dep_sgl` = ?) AN" +
    "D ((? = 1 AND `dep_nom` IS NULL) OR (`dep_nom` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.cnnDpto;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("dep_sgl", System.Data.OleDb.OleDbType.VarWChar, 0, "dep_sgl"),
            new System.Data.OleDb.OleDbParameter("dep_nom", System.Data.OleDb.OleDbType.VarWChar, 0, "dep_nom"),
            new System.Data.OleDb.OleDbParameter("Original_dep_sgl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dep_sgl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_dep_nom", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dep_nom", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_dep_nom", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dep_nom", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `departamentos` WHERE ((`dep_sgl` = ?) AND ((? = 1 AND `dep_nom` IS N" +
    "ULL) OR (`dep_nom` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.cnnDpto;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_dep_sgl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dep_sgl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_dep_nom", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dep_nom", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_dep_nom", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dep_nom", System.Data.DataRowVersion.Original, null)});
            // 
            // dataAdapterDpto
            // 
            this.dataAdapterDpto.DeleteCommand = this.oleDbDeleteCommand1;
            this.dataAdapterDpto.InsertCommand = this.oleDbInsertCommand1;
            this.dataAdapterDpto.SelectCommand = this.oleDbSelectCommand1;
            this.dataAdapterDpto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "departamentos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("dep_sgl", "dep_sgl"),
                        new System.Data.Common.DataColumnMapping("dep_nom", "dep_nom")})});
            this.dataAdapterDpto.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataSetDpto
            // 
            this.dataSetDpto.DataSetName = "dtsDpto";
            this.dataSetDpto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDpto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSigla);
            this.Name = "frmDpto";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.frmDpto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDpto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button Remover;
        private System.Data.OleDb.OleDbConnection cnnDpto;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter dataAdapterDpto;
        private dtsDpto dataSetDpto;
    }
}