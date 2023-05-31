namespace WindowsFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            this.table3BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.table3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet7 = new WindowsFormsApp1.Database1DataSet7();
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
            this.table3BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.table3TableAdapter = new WindowsFormsApp1.Database1DataSet7TableAdapters.Table3TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSet7TableAdapters.TableAdapterManager();
            this.table4DataGridView = new System.Windows.Forms.DataGridView();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet8 = new WindowsFormsApp1.Database1DataSet8();
            this.table4TableAdapter = new WindowsFormsApp1.Database1DataSet8TableAdapters.Table4TableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.Database1DataSet8TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingNavigator)).BeginInit();
            this.table3BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table4DataGridView)).BeginInit();
            this.searchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // table3BindingNavigator
            // 
            this.table3BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table3BindingNavigator.BindingSource = this.table3BindingSource;
            this.table3BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table3BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table3BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.table3BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table3BindingNavigatorSaveItem});
            this.table3BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table3BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table3BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table3BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table3BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table3BindingNavigator.Name = "table3BindingNavigator";
            this.table3BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table3BindingNavigator.Size = new System.Drawing.Size(825, 33);
            this.table3BindingNavigator.TabIndex = 0;
            this.table3BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // table3BindingSource
            // 
            this.table3BindingSource.DataMember = "Table3";
            this.table3BindingSource.DataSource = this.database1DataSet7;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // table3BindingNavigatorSaveItem
            // 
            this.table3BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table3BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table3BindingNavigatorSaveItem.Image")));
            this.table3BindingNavigatorSaveItem.Name = "table3BindingNavigatorSaveItem";
            this.table3BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.table3BindingNavigatorSaveItem.Text = "Save Data";
            this.table3BindingNavigatorSaveItem.Click += new System.EventHandler(this.table3BindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Location = new System.Drawing.Point(549, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "book data";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(354, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table3TableAdapter
            // 
            this.table3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table3TableAdapter = this.table3TableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table4DataGridView
            // 
            this.table4DataGridView.AutoGenerateColumns = false;
            this.table4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table4DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.table4DataGridView.DataSource = this.table4BindingSource;
            this.table4DataGridView.Location = new System.Drawing.Point(0, 79);
            this.table4DataGridView.Name = "table4DataGridView";
            this.table4DataGridView.RowHeadersWidth = 62;
            this.table4DataGridView.RowTemplate.Height = 29;
            this.table4DataGridView.Size = new System.Drawing.Size(514, 291);
            this.table4DataGridView.TabIndex = 5;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(0, 33);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(825, 34);
            this.searchToolStrip.TabIndex = 6;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(63, 29);
            this.nameToolStripLabel.Text = "Name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(66, 29);
            this.searchToolStripButton.Text = "search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // table4BindingSource
            // 
            this.table4BindingSource.DataMember = "Table4";
            this.table4BindingSource.DataSource = this.database1DataSet8;
            // 
            // database1DataSet8
            // 
            this.database1DataSet8.DataSetName = "Database1DataSet8";
            this.database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table4TableAdapter
            // 
            this.table4TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Table4TableAdapter = this.table4TableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.Database1DataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 19);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table4BindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(86, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 27);
            this.idTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(26, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table4BindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(86, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(26, 116);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 19);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table4BindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(86, 113);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 27);
            this.priceTextBox.TabIndex = 5;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.table4DataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table3BindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingNavigator)).EndInit();
            this.table3BindingNavigator.ResumeLayout(false);
            this.table3BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table4DataGridView)).EndInit();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource table3BindingSource;
        private Database1DataSet7TableAdapters.Table3TableAdapter table3TableAdapter;
        private Database1DataSet7TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table3BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table3BindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private Database1DataSet8 database1DataSet8;
        private System.Windows.Forms.BindingSource table4BindingSource;
        private Database1DataSet8TableAdapters.Table4TableAdapter table4TableAdapter;
        private Database1DataSet8TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView table4DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}