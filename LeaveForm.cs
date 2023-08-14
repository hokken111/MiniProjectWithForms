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
    public partial class LeaveForm : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        int empid;
        public LeaveForm()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from Status", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Show_Status";
            comboBox1.ValueMember = "Status_Id";
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into LeaveForm values(@Emp_Id, @FromDate, @ToDate, @LeaveType, @Reason,@Status_Id)";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Emp_Id", Form1.EmpId);
                cmd.Parameters.AddWithValue("@FromDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ToDate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@LeaveType", leaveType.Text);
                cmd.Parameters.AddWithValue("@Reason", reason.Text);
                cmd.Parameters.AddWithValue("@Status_Id", comboBox1.SelectedValue);
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
                string qry = "update LeaveForm set FromDate=@FromDate,ToDate=@ToDate,LeaveType=@LeaveType,Reason=@Reason,Status_Id=@Status_Id where Leave_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Emp_Id",Form1.EmpId);
                cmd.Parameters.AddWithValue("@FromDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ToDate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@LeaveType", (leaveType.Text));
                cmd.Parameters.AddWithValue("@Reason", (reason.Text));
                cmd.Parameters.AddWithValue("@Status_Id", (comboBox1.SelectedValue));

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(leaveId.Text));
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select l.Leave_Id, e.Emp_Name, l.FromDate, l.ToDate, l.LeaveType, l.Reason, s.Show_Status from LeaveForm l join Employee e on e.Emp_Id=l.Emp_Id join Status s on s.Status_Id=l.Status_Id where Emp_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@id", empid);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void LeaveForm_Load(object sender, EventArgs e)
        {
             empid = Form1.EmpId;
            lblId.Text = Form1.EmpId.ToString();
            try
            {
                string qry = "select * from Balancesheet where Emp_Id=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@id", empid);
                connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if(dr.Read())
                    {
                        label11.Text = dr["Total_Leaves"].ToString();
                        label12.Text= dr["Leaves_Taken"].ToString();
                        label13.Text = dr["BalanceLeaves"].ToString();
                    }


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

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
