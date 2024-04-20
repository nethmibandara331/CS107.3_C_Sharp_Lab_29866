using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet4
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0;
        bool is_Operation_Performed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                switch(operation)
                {
                    case"+": textBox1.Text = (result_value + double.Parse(textBox1.Text)).ToString(); break;
                    case"-": textBox1.Text = (result_value - double.Parse(textBox1.Text)).ToString(); break;
                    case"*": textBox1.Text = (result_value * double.Parse(textBox1.Text)).ToString(); break;
                    case"/": textBox1.Text = (result_value / double.Parse(textBox1.Text)).ToString(); break;
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Enter valid number", "Error");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void Operation_Performed(object sender, EventArgs e)
        {
            try
            {
                if (result_value != 0)
                {
                    button15.PerformClick();
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(textBox1.Text);
                    label1.Text = result_value + operation;
                    is_Operation_Performed = true;
                }

                else
                {
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(textBox1.Text);
                    label1.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Enter valid number", "Error");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "0"|| is_Operation_Performed)
            {
                textBox1.Clear();
            }
            Button btn=(Button)sender;

            if(btn.Text.Contains("."))
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text=textBox1.Text+btn.Text;
                }
            }

            else
            {
                textBox1.Text= textBox1.Text + btn.Text;
            }

            is_Operation_Performed= false;
        }
    }
}
