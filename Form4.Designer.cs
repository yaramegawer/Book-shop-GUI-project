namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label duration_of_rentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.database1DataSet5 = new WindowsFormsApp1.Database1DataSet5();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table2TableAdapter = new WindowsFormsApp1.Database1DataSet5TableAdapters.Table2TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSet5TableAdapters.TableAdapterManager();
            this.table2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.table2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.duration_of_rentTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            customer_idLabel = new System.Windows.Forms.Label();
            customer_nameLabel = new System.Windows.Forms.Label();
            duration_of_rentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingNavigator)).BeginInit();
            this.table2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(6, 50);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(98, 19);
            customer_idLabel.TabIndex = 0;
            customer_idLabel.Text = "customer id:";
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(2, 130);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(124, 19);
            customer_nameLabel.TabIndex = 2;
            customer_nameLabel.Text = "customer name:";
            // 
            // duration_of_rentLabel
            // 
            duration_of_rentLabel.AutoSize = true;
            duration_of_rentLabel.Location = new System.Drawing.Point(0, 204);
            duration_of_rentLabel.Name = "duration_of_rentLabel";
            duration_of_rentLabel.Size = new System.Drawing.Size(126, 19);
            duration_of_rentLabel.TabIndex = 4;
            duration_of_rentLabel.Text = "duration of rent:";
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table2";
            this.table2BindingSource.DataSource = this.database1DataSet5;
            // 
            // table2TableAdapter
            // 
            this.table2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table2TableAdapter = this.table2TableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table2BindingNavigator
            // 
            this.table2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table2BindingNavigator.BindingSource = this.table2BindingSource;
            this.table2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table2BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.table2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table2BindingNavigatorSaveItem});
            this.table2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table2BindingNavigator.Name = "table2BindingNavigator";
            this.table2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table2BindingNavigator.Size = new System.Drawing.Size(846, 38);
            this.table2BindingNavigator.TabIndex = 0;
            this.table2BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // table2BindingNavigatorSaveItem
            // 
            this.table2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table2BindingNavigatorSaveItem.Image")));
            this.table2BindingNavigatorSaveItem.Name = "table2BindingNavigatorSaveItem";
            this.table2BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.table2BindingNavigatorSaveItem.Text = "Save Data";
            this.table2BindingNavigatorSaveItem.Click += new System.EventHandler(this.table2BindingNavigatorSaveItem_Click);
            // 
            // table2DataGridView
            // 
            this.table2DataGridView.AutoGenerateColumns = false;
            this.table2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.table2DataGridView.DataSource = this.table2BindingSource;
            this.table2DataGridView.Location = new System.Drawing.Point(0, 70);
            this.table2DataGridView.Name = "table2DataGridView";
            this.table2DataGridView.RowHeadersWidth = 62;
            this.table2DataGridView.RowTemplate.Height = 29;
            this.table2DataGridView.Size = new System.Drawing.Size(515, 326);
            this.table2DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "customer_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customer_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "customer_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "duration_of_rent";
            this.dataGridViewTextBoxColumn3.HeaderText = "duration_of_rent";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(customer_idLabel);
            this.groupBox1.Controls.Add(this.customer_idTextBox);
            this.groupBox1.Controls.Add(customer_nameLabel);
            this.groupBox1.Controls.Add(this.customer_nameTextBox);
            this.groupBox1.Controls.Add(duration_of_rentLabel);
            this.groupBox1.Controls.Add(this.duration_of_rentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(521, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(168, 42);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 27);
            this.customer_idTextBox.TabIndex = 1;
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "customer_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(168, 122);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(100, 27);
            this.customer_nameTextBox.TabIndex = 3;
            // 
            // duration_of_rentTextBox
            // 
            this.duration_of_rentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "duration_of_rent", true));
            this.duration_of_rentTextBox.Location = new System.Drawing.Point(168, 196);
            this.duration_of_rentTextBox.Name = "duration_of_rentTextBox";
            this.duration_of_rentTextBox.Size = new System.Drawing.Size(100, 27);
            this.duration_of_rentTextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(383, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.searchToolStripButton,
            this.toolStripButton1});
            this.searchToolStrip.Location = new System.Drawing.Point(0, 38);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(846, 38);
            this.searchToolStrip.TabIndex = 5;
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
            this.searchToolStripButton.Size = new System.Drawing.Size(68, 29);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 514);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table2DataGridView);
            this.Controls.Add(this.table2BindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingNavigator)).EndInit();
            this.table2BindingNavigator.ResumeLayout(false);
            this.table2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private Database1DataSet5TableAdapters.Table2TableAdapter table2TableAdapter;
        private Database1DataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table2BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table2BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView table2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox duration_of_rentTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}