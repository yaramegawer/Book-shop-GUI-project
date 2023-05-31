using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void table3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet7);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet8.Table4' table. You can move, or remove it, as needed.
            this.table4TableAdapter.Fill(this.database1DataSet8.Table4);
            // TODO: This line of code loads data into the 'database1DataSet7.Table3' table. You can move, or remove it, as needed.
            this.table3TableAdapter.Fill(this.database1DataSet7.Table3);

        }

        private void table3DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            //to exit the program
            this.Close();
        }

        private void search3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table3TableAdapter.search3(this.database1DataSet7.Table3, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            //to enable search and filter in data base
            try
            {
                this.table4TableAdapter.search(this.database1DataSet8.Table4, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
