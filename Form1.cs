using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please Enter 1st Number");



            else if (textBox2.Text == "")
                MessageBox.Show("Please Enter 2nd Number");


            else
            {
                int m = Convert.ToInt16(textBox1.Text);
                int a = Convert.ToInt16(textBox2.Text);
                

                listBox1.Items.Clear();

                int F = m * a;
                listBox1.Items.Add("by using Newton's formula" );
                listBox1.Items.Add("");
                listBox1.Items.Add("Formula:   F = ma" );
                listBox1.Items.Add("");
                listBox1.Items.Add("Answer :   " + F + "N");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();  
        }
    }
}