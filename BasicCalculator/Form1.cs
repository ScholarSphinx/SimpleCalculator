using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "SUM";
            double sum = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "DIFFERENCE";
            double diff = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            textBox3.Text = diff.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "PRODUCT";
            double prod = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            textBox3.Text = prod.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "QUOTIENT";
            double quot = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            // Display the quotient in textBox3, formatted to 2 decimal places
            textBox3.Text = quot.ToString("N2"); // "N2" formats the number as a decimal with 2 decimal places and includes commas for thousands separators if applicable.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            label3.Text = "---";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            label3.Text = "---";
        }
    }
}
