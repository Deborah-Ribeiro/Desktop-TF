
namespace Desktop_TF
{
    partial class FCadTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadTarefa));
            System.Windows.Forms.Label idTarefaLabel;
            System.Windows.Forms.Label descricaoTarefaLabel;
            System.Windows.Forms.Label fKStatusLabel;
            System.Windows.Forms.Label fKResponsavelLabel;
            System.Windows.Forms.Label obsLabel;
            this.tFdesktopDataSet = new Desktop_TF.TFdesktopDataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new Desktop_TF.TFdesktopDataSetTableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new Desktop_TF.TFdesktopDataSetTableAdapters.TableAdapterManager();
            this.tarefaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tarefaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTarefaLabel1 = new System.Windows.Forms.Label();
            this.descricaoTarefaTextBox = new System.Windows.Forms.TextBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new Desktop_TF.TFdesktopDataSetTableAdapters.ResponsavelTableAdapter();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Desktop_TF.TFdesktopDataSetTableAdapters.StatusTableAdapter();
            idTarefaLabel = new System.Windows.Forms.Label();
            descricaoTarefaLabel = new System.Windows.Forms.Label();
            fKStatusLabel = new System.Windows.Forms.Label();
            fKResponsavelLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tFdesktopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingNavigator)).BeginInit();
            this.tarefaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tFdesktopDataSet
            // 
            this.tFdesktopDataSet.DataSetName = "TFdesktopDataSet";
            this.tFdesktopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.tFdesktopDataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ResponsavelTableAdapter = this.responsavelTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Desktop_TF.TFdesktopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tarefaBindingNavigator
            // 
            this.tarefaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tarefaBindingNavigator.BindingSource = this.tarefaBindingSource;
            this.tarefaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tarefaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tarefaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tarefaBindingNavigatorSaveItem});
            this.tarefaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tarefaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tarefaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tarefaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tarefaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tarefaBindingNavigator.Name = "tarefaBindingNavigator";
            this.tarefaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tarefaBindingNavigator.Size = new System.Drawing.Size(608, 25);
            this.tarefaBindingNavigator.TabIndex = 0;
            this.tarefaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tarefaBindingNavigatorSaveItem
            // 
            this.tarefaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tarefaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tarefaBindingNavigatorSaveItem.Image")));
            this.tarefaBindingNavigatorSaveItem.Name = "tarefaBindingNavigatorSaveItem";
            this.tarefaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tarefaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tarefaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tarefaBindingNavigatorSaveItem_Click);
            // 
            // idTarefaLabel
            // 
            idTarefaLabel.AutoSize = true;
            idTarefaLabel.BackColor = System.Drawing.Color.Indigo;
            idTarefaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTarefaLabel.ForeColor = System.Drawing.Color.White;
            idTarefaLabel.Location = new System.Drawing.Point(193, 87);
            idTarefaLabel.Name = "idTarefaLabel";
            idTarefaLabel.Size = new System.Drawing.Size(78, 16);
            idTarefaLabel.TabIndex = 1;
            idTarefaLabel.Text = "Id Tarefa:";
            // 
            // idTarefaLabel1
            // 
            this.idTarefaLabel1.BackColor = System.Drawing.Color.Indigo;
            this.idTarefaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "IdTarefa", true));
            this.idTarefaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTarefaLabel1.ForeColor = System.Drawing.Color.White;
            this.idTarefaLabel1.Location = new System.Drawing.Point(291, 87);
            this.idTarefaLabel1.Name = "idTarefaLabel1";
            this.idTarefaLabel1.Size = new System.Drawing.Size(121, 23);
            this.idTarefaLabel1.TabIndex = 2;
            this.idTarefaLabel1.Text = "label1";
            // 
            // descricaoTarefaLabel
            // 
            descricaoTarefaLabel.AutoSize = true;
            descricaoTarefaLabel.BackColor = System.Drawing.Color.Indigo;
            descricaoTarefaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoTarefaLabel.ForeColor = System.Drawing.Color.White;
            descricaoTarefaLabel.Location = new System.Drawing.Point(135, 116);
            descricaoTarefaLabel.Name = "descricaoTarefaLabel";
            descricaoTarefaLabel.Size = new System.Drawing.Size(136, 16);
            descricaoTarefaLabel.TabIndex = 3;
            descricaoTarefaLabel.Text = "Descricao Tarefa:";
            // 
            // descricaoTarefaTextBox
            // 
            this.descricaoTarefaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "DescricaoTarefa", true));
            this.descricaoTarefaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTarefaTextBox.Location = new System.Drawing.Point(291, 113);
            this.descricaoTarefaTextBox.Name = "descricaoTarefaTextBox";
            this.descricaoTarefaTextBox.Size = new System.Drawing.Size(121, 22);
            this.descricaoTarefaTextBox.TabIndex = 4;
            // 
            // fKStatusLabel
            // 
            fKStatusLabel.AutoSize = true;
            fKStatusLabel.BackColor = System.Drawing.Color.Indigo;
            fKStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fKStatusLabel.ForeColor = System.Drawing.Color.White;
            fKStatusLabel.Location = new System.Drawing.Point(193, 142);
            fKStatusLabel.Name = "fKStatusLabel";
            fKStatusLabel.Size = new System.Drawing.Size(78, 16);
            fKStatusLabel.TabIndex = 5;
            fKStatusLabel.Text = "FKStatus:";
            // 
            // fKResponsavelLabel
            // 
            fKResponsavelLabel.AutoSize = true;
            fKResponsavelLabel.BackColor = System.Drawing.Color.Indigo;
            fKResponsavelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fKResponsavelLabel.ForeColor = System.Drawing.Color.White;
            fKResponsavelLabel.Location = new System.Drawing.Point(144, 169);
            fKResponsavelLabel.Name = "fKResponsavelLabel";
            fKResponsavelLabel.Size = new System.Drawing.Size(127, 16);
            fKResponsavelLabel.TabIndex = 7;
            fKResponsavelLabel.Text = "FKResponsavel:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.BackColor = System.Drawing.Color.Indigo;
            obsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obsLabel.ForeColor = System.Drawing.Color.White;
            obsLabel.Location = new System.Drawing.Point(229, 196);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(42, 16);
            obsLabel.TabIndex = 9;
            obsLabel.Text = "Obs:";
            // 
            // obsTextBox
            // 
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Obs", true));
            this.obsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obsTextBox.Location = new System.Drawing.Point(291, 193);
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(121, 22);
            this.obsTextBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKStatus", true));
            this.comboBox1.DataSource = this.statusBindingSource;
            this.comboBox1.DisplayMember = "Descricao";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "IdStatus";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKResponsavel", true));
            this.comboBox2.DataSource = this.responsavelBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(291, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "IdResponsavel";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "Responsavel";
            this.responsavelBindingSource.DataSource = this.tFdesktopDataSet;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.tFdesktopDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // FCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 408);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idTarefaLabel);
            this.Controls.Add(this.idTarefaLabel1);
            this.Controls.Add(descricaoTarefaLabel);
            this.Controls.Add(this.descricaoTarefaTextBox);
            this.Controls.Add(fKStatusLabel);
            this.Controls.Add(fKResponsavelLabel);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.obsTextBox);
            this.Controls.Add(this.tarefaBindingNavigator);
            this.Name = "FCadTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Tarefa";
            this.Load += new System.EventHandler(this.FCadTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tFdesktopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingNavigator)).EndInit();
            this.tarefaBindingNavigator.ResumeLayout(false);
            this.tarefaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TFdesktopDataSet tFdesktopDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private TFdesktopDataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private TFdesktopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tarefaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tarefaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idTarefaLabel1;
        private System.Windows.Forms.TextBox descricaoTarefaTextBox;
        private System.Windows.Forms.TextBox obsTextBox;
        private TFdesktopDataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private TFdesktopDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
    }
}