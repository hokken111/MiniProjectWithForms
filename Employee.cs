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
using System.Xml.Linq;
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class Employee : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        public Employee()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from Department", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SqlDataAdapter da2 = new SqlDataAdapter("select * from Role", connection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dep_Name";
            comboBox1.ValueMember = "Dep_Id";

            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Role_Name";
            comboBox2.ValueMember = "Role_Id";


        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into Employee values(@Dep_Id,@Role_Id, @Emp_Name, @Salary, @Gender, @Password)";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Dep_Id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@Role_Id", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@Emp_Name", emp_Name.Text);
                cmd.Parameters.AddWithValue("@Salary", salary.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Inserted");
                }
                else
                {
                    MessageBox.Show("Record not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Employee set Dep_Id=@Dep_Id,Role_Id=@Role_Id, Emp_Name=@Emp_Name,Salary=@Salary,Gender=@Gender,Password=@Password where Emp_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Dep_Id", (comboBox1.SelectedValue));
                cmd.Parameters.AddWithValue("@Role_Id", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@Emp_Name", emp_Name.Text);
                cmd.Parameters.AddWithValue("@Salary", salary.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(emp_Id.Text));
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Employee where Emp_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(emp_Id.Text));
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void getAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee";
                cmd = new SqlCommand(qry, connection);
                connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;


                }
                else
                {
                    MessageBox.Show("Records not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
