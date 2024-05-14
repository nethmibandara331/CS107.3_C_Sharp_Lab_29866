using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace L6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\University\Y1Sem3\C #\Tutorial\Lab sheet 6\L6\Database1.mdf"";Integrated Security=True");
            try
            {


               

                string name = textBox1.Text;
                DateTime dob = dateTimePicker1.Value;
                string email = textBox2.Text;
                int num = int.Parse(textBox3.Text);
                string address = textBox4.Text;
                string uname = textBox5.Text;
                string pass = textBox6.Text;

                string query = $"INSERT into Employee(Username, Name, DoB, Password) VALUES('{uname}', '{name}', '{dob}', '{pass}')";
                string query2 = $"INSERT into Contact(Username, Contact_Number, Email, Address) VALUES('{uname}', '{num}', '{email}', '{address}')";

                SqlCommand cmd1 = new SqlCommand(query, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);

                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();   
            }

        }
    }
}
