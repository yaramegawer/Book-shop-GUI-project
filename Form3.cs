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
    public partial class Form3 : Form
    {
        class Rent
        {

            public int quantity;
            
           


            public Rent()
            {
                //default constructor
                quantity = 0;
                
             


            }
            public Rent(int q)
            {
                //constructor to intialize quantity
                quantity = q;
                 
           


            }
            public double total_price(double price)
            {
                //function to calculate the total price
                return quantity *( price);
            }

        }

      



        private void get_data(Rent book)
        {
            //function to pass text box value to quantity
            book.quantity = int.Parse(textBox2.Text);

        }
       

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x=0;
            double price = 0;
            Rent obj = new Rent();

            get_data(obj);
            //setting prices to the list box items
            if (listBox1.SelectedItem.ToString() == "Harry Potter" && listBox2.SelectedItem.ToString()=="One week")
            {
                price = 10.5;
            }
            else if (listBox1.SelectedItem.ToString() == "Lord of the rings" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 20.3;
            }
            else if (listBox1.SelectedItem.ToString() == "Atomic habits" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 3.75;
            }
            else if (listBox1.SelectedItem.ToString() == "The hunger games" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 12.75;
            }
            else if (listBox1.SelectedItem.ToString() == "The little prince" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 15;
            }
            else if (listBox1.SelectedItem.ToString() == "Shadow and bone" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 22.3;
            }
            else if (listBox1.SelectedItem.ToString() == "The maze runner" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 16.75;
            }
            else if (listBox1.SelectedItem.ToString() == "Six of crows" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 16.5;
            }
            else if (listBox1.SelectedItem.ToString() == "If we were villans" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 27.5;
            }
            else if (listBox1.SelectedItem.ToString() == "The last of us" && listBox2.SelectedItem.ToString() == "One week")
            {
                price = 33.4;
            }

            else if (listBox1.SelectedItem.ToString() == "Harry Potter" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 20.5;
            }
            else if (listBox1.SelectedItem.ToString() == "Lord of the rings" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 30.3;
            }
            else if (listBox1.SelectedItem.ToString() == "Atomic habits" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 6.75;
            }
            else if (listBox1.SelectedItem.ToString() == "The hunger games" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 22.75;
            }
            else if (listBox1.SelectedItem.ToString() == "The little prince" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 30;
            }
            else if (listBox1.SelectedItem.ToString() == "Shadow and bone" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 33.3;
            }
            else if (listBox1.SelectedItem.ToString() == "The maze runner" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 26.75;
            }
            else if (listBox1.SelectedItem.ToString() == "Six of crows" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 40.5;
            }
            else if (listBox1.SelectedItem.ToString() == "If we were villans" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 37.5;
            }
            else if (listBox1.SelectedItem.ToString() == "The last of us" && listBox2.SelectedItem.ToString() == "More than one week")
            {
                price = 55.4;
            }
            else
            {
                MessageBox.Show("you have to choose  book and a duration");

            }




            //passing total price to the list box

            textBox3.Text = obj.total_price(price).ToString("c");
            

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //function to show you the time you rented the book
            DateTime date;
            date = dateTimePicker1.Value;

            MessageBox.Show("You rented the book at: " + date);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
