using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        class Book
        {

            public int quantity;
         


    public Book()
            {
                //default constructor
                quantity = 0;
          


    }
            public Book(int q)
            {
                //constructor to intialize quantity
               quantity=q;
             

            }
            public double total_price(double p)
            {
                //function to calculate the total price
                return quantity * p;
            }

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listbox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void get_data(Book book)
        {
            //function to pass text box value to quantity
            book.quantity =int.Parse(textBox1.Text);
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            double price=0;
            Book obj = new Book();

            get_data(obj);
            //setting prices to the list box items
            if(listBox1.SelectedItem.ToString()=="Harry Potter")
            {
                price=20.5;
            }
            else if(listBox1.SelectedItem.ToString() == "Lord of the rings")
            {
                price = 40.3;
            }
            else if (listBox1.SelectedItem.ToString() == "Atomic habits")
            {
                price = 15;
            }
            else if (listBox1.SelectedItem.ToString() == "The hunger games")
            {
                price = 25.5;
            }
            else if (listBox1.SelectedItem.ToString() == "The little prince")
            {
                price = 30;
            }
            else if (listBox1.SelectedItem.ToString() == "Shadow and bone")
            {
                price = 44.6;
            }
            else if (listBox1.SelectedItem.ToString() == "The maze runner")
            {
                price = 33.5;
            }
            else if (listBox1.SelectedItem.ToString() == "Six of crows")
            {
                price = 33;
            }
            else if (listBox1.SelectedItem.ToString() == "If we were villans")
            {
                price = 55;
            }
            else if (listBox1.SelectedItem.ToString() == "The last of us")
            {
                price = 66.8;
            }
            //passing total price to the list box
            textBox2.Text = obj.total_price(price).ToString("c");

            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //to show you the way you choose to pay with and exit the program
            Book obj2=new Book();   
            if (checkBox1.Checked)
            {
                MessageBox.Show("You chose to pay by Visa ");

            }
            else
            {
                MessageBox.Show("You chose to pay by Cash ");
            }
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
