namespace wfaSCA
{
    partial class frmCursos
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
            System.Windows.Forms.Label cur_sglLabel;
            System.Windows.Forms.Label cur_nomLabel;
            System.Windows.Forms.Label cur_dep_sglLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursos));
            this.cursosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cursosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cur_sglTextBox = new System.Windows.Forms.TextBox();
            this.cur_nomTextBox = new System.Windows.Forms.TextBox();
            this.cur_dep_sglTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EPCursos = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByCursoNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.cur_nomToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cur_nomToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCursoNomeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cursglDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curdepsglDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scaDataSet = new wfaSCA.scaDataSet();
            this.cursosTableAdapter = new wfaSCA.scaDataSetTableAdapters.cursosTableAdapter();
            this.tableAdapterManager = new wfaSCA.scaDataSetTableAdapters.TableAdapterManager();
            cur_sglLabel = new System.Windows.Forms.Label();
            cur_nomLabel = new System.Windows.Forms.Label();
            cur_dep_sglLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).BeginInit();
            this.cursosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByCursoNomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cur_sglLabel
            // 
            cur_sglLabel.AutoSize = true;
            cur_sglLabel.Location = new System.Drawing.Point(98, 86);
            cur_sglLabel.Name = "cur_sglLabel";
            cur_sglLabel.Size = new System.Drawing.Size(38, 16);
            cur_sglLabel.TabIndex = 1;
            cur_sglLabel.Text = "Sigla";
            // 
            // cur_nomLabel
            // 
            cur_nomLabel.AutoSize = true;
            cur_nomLabel.Location = new System.Drawing.Point(98, 114);
            cur_nomLabel.Name = "cur_nomLabel";
            cur_nomLabel.Size = new System.Drawing.Size(47, 16);
            cur_nomLabel.TabIndex = 3;
            cur_nomLabel.Text = "Nome:";
            // 
            // cur_dep_sglLabel
            // 
            cur_dep_sglLabel.AutoSize = true;
            cur_dep_sglLabel.Location = new System.Drawing.Point(98, 142);
            cur_dep_sglLabel.Name = "cur_dep_sglLabel";
            cur_dep_sglLabel.Size = new System.Drawing.Size(127, 16);
            cur_dep_sglLabel.TabIndex = 5;
            cur_dep_sglLabel.Text = "Sigla Departamento";
            // 
            // cursosBindingNavigator
            // 
            this.cursosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursosBindingNavigator.BindingSource = this.cursosBindingSource;
            this.cursosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cursosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cursosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cursosBindingNavigatorSaveItem});
            this.cursosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursosBindingNavigator.Name = "cursosBindingNavigator";
            this.cursosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursosBindingNavigator.Size = new System.Drawing.Size(1207, 27);
            this.cursosBindingNavigator.TabIndex = 0;
            this.cursosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cursosBindingNavigatorSaveItem
            // 
            this.cursosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursosBindingNavigatorSaveItem.Image")));
            this.cursosBindingNavigatorSaveItem.Name = "cursosBindingNavigatorSaveItem";
            this.cursosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cursosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cursosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursosBindingNavigatorSaveItem_Click);
            // 
            // cur_sglTextBox
            // 
            this.cur_sglTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cur_sglTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "cur_sgl", true));
            this.cur_sglTextBox.Location = new System.Drawing.Point(231, 83);
            this.cur_sglTextBox.MaxLength = 10;
            this.cur_sglTextBox.Name = "cur_sglTextBox";
            this.cur_sglTextBox.Size = new System.Drawing.Size(100, 22);
            this.cur_sglTextBox.TabIndex = 2;
            this.cur_sglTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cur_sglTextBox_Validating);
            // 
            // cur_nomTextBox
            // 
            this.cur_nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "cur_nom", true));
            this.cur_nomTextBox.Location = new System.Drawing.Point(231, 111);
            this.cur_nomTextBox.MaxLength = 70;
            this.cur_nomTextBox.Name = "cur_nomTextBox";
            this.cur_nomTextBox.Size = new System.Drawing.Size(100, 22);
            this.cur_nomTextBox.TabIndex = 4;
            this.cur_nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cur_nomTextBox_Validating);
            // 
            // cur_dep_sglTextBox
            // 
            this.cur_dep_sglTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cur_dep_sglTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "cur_dep_sgl", true));
            this.cur_dep_sglTextBox.Location = new System.Drawing.Point(231, 139);
            this.cur_dep_sglTextBox.MaxLength = 10;
            this.cur_dep_sglTextBox.Name = "cur_dep_sglTextBox";
            this.cur_dep_sglTextBox.Size = new System.Drawing.Size(100, 22);
            this.cur_dep_sglTextBox.TabIndex = 6;
            this.cur_dep_sglTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cur_dep_sglTextBox_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(45, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 121);
            this.panel1.TabIndex = 7;
            // 
            // EPCursos
            // 
            this.EPCursos.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cursglDataGridViewTextBoxColumn,
            this.curnomDataGridViewTextBoxColumn,
            this.curdepsglDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cursosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(428, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 310);
            this.dataGridView1.TabIndex = 8;
            // 
            // fillByCursoNomeToolStrip
            // 
            this.fillByCursoNomeToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByCursoNomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cur_nomToolStripLabel,
            this.cur_nomToolStripTextBox,
            this.fillByCursoNomeToolStripButton});
            this.fillByCursoNomeToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByCursoNomeToolStrip.Name = "fillByCursoNomeToolStrip";
            this.fillByCursoNomeToolStrip.Size = new System.Drawing.Size(1207, 27);
            this.fillByCursoNomeToolStrip.TabIndex = 9;
            this.fillByCursoNomeToolStrip.Text = "fillByCursoNomeToolStrip";
            // 
            // cur_nomToolStripLabel
            // 
            this.cur_nomToolStripLabel.Name = "cur_nomToolStripLabel";
            this.cur_nomToolStripLabel.Size = new System.Drawing.Size(113, 24);
            this.cur_nomToolStripLabel.Text = "Nome do Curso";
            this.cur_nomToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cur_nomToolStripTextBox
            // 
            this.cur_nomToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cur_nomToolStripTextBox.Name = "cur_nomToolStripTextBox";
            this.cur_nomToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByCursoNomeToolStripButton
            // 
            this.fillByCursoNomeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCursoNomeToolStripButton.Name = "fillByCursoNomeToolStripButton";
            this.fillByCursoNomeToolStripButton.Size = new System.Drawing.Size(74, 24);
            this.fillByCursoNomeToolStripButton.Text = "Pesquisar";
            this.fillByCursoNomeToolStripButton.Click += new System.EventHandler(this.fillByCursoNomeToolStripButton_Click);
            // 
            // cursglDataGridViewTextBoxColumn
            // 
            this.cursglDataGridViewTextBoxColumn.DataPropertyName = "cur_sgl";
            this.cursglDataGridViewTextBoxColumn.HeaderText = "Sigla";
            this.cursglDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.cursglDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cursglDataGridViewTextBoxColumn.Name = "cursglDataGridViewTextBoxColumn";
            this.cursglDataGridViewTextBoxColumn.Width = 125;
            // 
            // curnomDataGridViewTextBoxColumn
            // 
            this.curnomDataGridViewTextBoxColumn.DataPropertyName = "cur_nom";
            this.curnomDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.curnomDataGridViewTextBoxColumn.MaxInputLength = 70;
            this.curnomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.curnomDataGridViewTextBoxColumn.Name = "curnomDataGridViewTextBoxColumn";
            this.curnomDataGridViewTextBoxColumn.Width = 125;
            // 
            // curdepsglDataGridViewTextBoxColumn
            // 
            this.curdepsglDataGridViewTextBoxColumn.DataPropertyName = "cur_dep_sgl";
            this.curdepsglDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.curdepsglDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.curdepsglDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.curdepsglDataGridViewTextBoxColumn.Name = "curdepsglDataGridViewTextBoxColumn";
            this.curdepsglDataGridViewTextBoxColumn.Width = 125;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.scaDataSet;
            // 
            // scaDataSet
            // 
            this.scaDataSet.DataSetName = "scaDataSet";
            this.scaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cursosTableAdapter = this.cursosTableAdapter;
            this.tableAdapterManager.departamentosTableAdapter = null;
            this.tableAdapterManager.disciplinasTableAdapter = null;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.matriculasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = wfaSCA.scaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 516);
            this.Controls.Add(this.fillByCursoNomeToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(cur_sglLabel);
            this.Controls.Add(this.cur_sglTextBox);
            this.Controls.Add(cur_nomLabel);
            this.Controls.Add(this.cur_nomTextBox);
            this.Controls.Add(cur_dep_sglLabel);
            this.Controls.Add(this.cur_dep_sglTextBox);
            this.Controls.Add(this.cursosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).EndInit();
            this.cursosBindingNavigator.ResumeLayout(false);
            this.cursosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByCursoNomeToolStrip.ResumeLayout(false);
            this.fillByCursoNomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private scaDataSet scaDataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private scaDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private scaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cursosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cursosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cur_sglTextBox;
        private System.Windows.Forms.TextBox cur_nomTextBox;
        private System.Windows.Forms.TextBox cur_dep_sglTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider EPCursos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursglDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curdepsglDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByCursoNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel cur_nomToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cur_nomToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCursoNomeToolStripButton;
    }
}