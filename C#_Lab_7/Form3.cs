using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\University\Y1Sem3\C #\Tutorial\Lab sheet 6\L6\Database1.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Employee;";
            string query1 = "SELECT * FROM Contact;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connection);

            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "Employee");
            adapter1.Fill(dataset, "Contact");
            dataGridView1.DataSource = dataset.Tables["Employee"];
            dataGridView2.DataSource = dataset.Tables["Contact"];
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
