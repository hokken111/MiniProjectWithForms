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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Department : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        public Department()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void depId_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into Department values(@Dep_Name)";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Dep_Name", depName.Text);

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
                string qry = "update Department set Dep_Name=@Dep_Name where Dep_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Dep_Name", depName.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(depId.Text));
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
                string qry = "delete from Department where Dep_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(depId.Text));
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
                string qry = "select * from Department";
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
