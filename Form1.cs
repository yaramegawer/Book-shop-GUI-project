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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                int pass;

                user = textBox1.Text;
                pass = Convert.ToInt32(textBox2.Text);
                //a code to confirm if the user enter the user name and password
                if (user == "username" && pass == 1234)
                {
                    MessageBox.Show("Succecful login");
                    //a code to transport you to form 3
                Form3 f2 = new Form3();
                f2.Show();
                Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("username or password is incorrect");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid input");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string user;
            int pass;

            user = textBox1.Text;
            pass=Convert.ToInt32(textBox2.Text);
                //a code to confirm if the user enter the user name and password
                if (user=="username" && pass == 1234)
            {
                    MessageBox.Show("Succecful login");
                    //a code to transport you to form 2
                    Form2 f2 = new Form2();
                    f2.Show();
                    Visible = false;
                    
            }
                else
                {
                    MessageBox.Show("username or password is incorrect");
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid input");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                int pass;

                user = textBox1.Text;
                pass = Convert.ToInt32(textBox2.Text);

                //a code to confirm if the user enter the user name and password
                if (user == "username" && pass == 1234)
                {
                    MessageBox.Show("Succecful login");
                    //a code to transport you to form 6
                Form6 f2 = new Form6();
                f2.Show();
                Visible = false;
                }
                
                 else
                {
                    MessageBox.Show("username or password is incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid input");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                int pass;

                user = textBox1.Text;
                pass = Convert.ToInt32(textBox2.Text);

                //a code to confirm if the user enter the user name and password
                if (user == "username" && pass == 1234)
                {
                    MessageBox.Show("Succecful login");
                    //a code to transport you to form 4
                Form4 f2 = new Form4();
                f2.Show();
                Visible = false;
                }
                else
                {
                    MessageBox.Show("username or password is incorrect");
                }

            }
            //if user enter invalid input an error message will show
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid input");
            }
          

        }
    }
}
