using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }

        private void ucUser_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT"
               + " StaffID as `STAFF ID`,"//0
               + " GName,"//1
               + " Password,"//2
               + " MName,"//3
               + " LName,"//4
               + " concat(gname, ' ',lname) as FULLNAME,"//5
               + " SType as `STAFF TYPE`,"//6
               + " SStatus as `STAFF STATUS`,"//7
               + " SecurityQuestion,"//8
               + " SecurityAnswer,"//9
               + " `Contact no` as `CONTACT #`,"//10
               + " DateRegister as `DATE REGISTER`,"//11
               + " USERNAME FROM `staff` where (concat(gname, ' ',lname) like '%" + textBox1.Text
               + "%' or UserName like '" + textBox1.Text
               + "%' or SType like '" + textBox1.Text
               + "%' or SStatus like '" + textBox1.Text + "%') and staffid != ''";//12
            wfLogIn.v();
            dataGridView1.DataSource = wfLogIn.table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sUserID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                cbUserType.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                cbUserStatus.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wfLogIn.q = "update staff set stype = '" + cbUserType.Text
               + "',sstatus = '" + cbUserStatus.Text
               + "' where staffid = '" + sUserID + "'";
            wfLogIn.v();
            MessageBox.Show("User security was been change!");
            ucUser_Load(sender, e);
        }
        string sUserID;
        public static String sSave;
        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            User_Setting s = new User_Setting();
            s.ShowDialog();
            ucUser_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucUser_Load(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}