using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        public static int EmpId { get; set; }
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Employee where Emp_Id=@e and Password=@p", connection);
            cmd.Parameters.AddWithValue("@e", empid_pass.Text);
            cmd.Parameters.AddWithValue("@p", password.Text);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    Form1.EmpId =Convert.ToInt32( dr["Emp_Id"]);

                    if (Convert.ToInt32(dr["Role_Id"]) == 1)
                    {
                        Form3 emp = new Form3();
                        emp.Show();

                    }
                    else if (Convert.ToInt32(dr["Role_Id"]) == 2)
                    {
                        Form2 e2 = new Form2();
                        e2.Show();

                    }
                    this.Hide();
                }
                
            }

            else
            {
                MessageBox.Show("User does not exist");
            }
            connection.Close();
            dr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
 }

