using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.MdiParent = this;
            leaveForm.Show();
        }

        private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSheet timeSheet = new TimeSheet();
            timeSheet.MdiParent = this;
            timeSheet.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
