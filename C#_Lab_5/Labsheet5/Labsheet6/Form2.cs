using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet6
{
    public partial class Form2 : Form
    {
        public Form2(string fullname,string username,string email)
        {
            InitializeComponent();
            lblName.Text = $"Name: {fullname}";
            lblUsername.Text = $"User Name: {username}";
            lblEmail.Text=$"Email: {email}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
