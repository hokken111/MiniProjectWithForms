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
    public partial class TimeSheet : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;

        public TimeSheet()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            /*SqlDataAdapter da = new SqlDataAdapter("Select * from Employee", connection);
            DataTable table = new DataTable();
            da.Fill(table);
            textBox1.Text = "@Emp_Id";*/
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into TimeSheet values(@Emp_Id, @InTime, @OutTime, @ReasonIfAny)";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Emp_Id", textBox1.Text);
                cmd.Parameters.AddWithValue("@InTime", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@OutTime", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@ReasonIfAny", reasonIf.Text);
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
                string qry = "update TimeSheet set InTime=@InTime,OutTime=@OutTime,ReasonIfAny=@ReasonIfAny where TimeS_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Emp_Id", (textBox1.Text));
                cmd.Parameters.AddWithValue("@InTime", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@OutTime", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@ReasonIfAny", reasonIf.Text);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(timeSid.Text));
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from TimeSheet";
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
