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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void table2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet5);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet5.Table2' table. You can move, or remove it, as needed.
            this.table2TableAdapter.Fill(this.database1DataSet5.Table2);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //to exit the program
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            //to enable search and filter in data base
            try
            {
                this.table2TableAdapter.Search(this.database1DataSet5.Table2, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
