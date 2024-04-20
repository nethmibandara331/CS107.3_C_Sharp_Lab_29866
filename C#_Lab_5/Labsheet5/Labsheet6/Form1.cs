using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            fnTextBox.Text = "";
            lnTextBox.Text = "";
            DBtextBox.Text = "";
            emailTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text!=confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password doesn't match","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(String.IsNullOrEmpty(fnTextBox.Text) || String.IsNullOrEmpty(lnTextBox.Text) || String.IsNullOrEmpty(DBtextBox.Text) || String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(usernameTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text) || String.IsNullOrEmpty(confirmPasswordTextBox.Text)) 
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form2 form2 = new Form2($"{fnTextBox.Text}{lnTextBox.Text}",usernameTextBox.Text , emailTextBox.Text);

            form2.Show();
            this.Hide();

     
        
        }

        private bool IsString(string text)
        {
            //check if all characters in the text are letters
            return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
        }
    }
}
