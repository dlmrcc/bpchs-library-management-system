using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfBookClassification : Form
    {
        public wfBookClassification()
        {
            InitializeComponent();
        }

        ColorConverter c = new ColorConverter();
        public static String sID, sFrom, sTo, sClass;
        private void button2_Click(object sender, EventArgs e)
        {
            sID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            sFrom = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            sTo = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sClass = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            wfDeweySet d = new wfDeweySet();
            d.MinimizeBox = false;
            d.StartPosition = FormStartPosition.CenterScreen;
            d.MaximizeBox = false;
            d.ShowDialog();
            wfBookClassification_Load(sender, e);
        }
        private void wfBookClassification_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT id, start `FROM`, end `TO`, class `CLASS` FROM bookdivision";
            wfLogIn.v();
            dataGridView1.DataSource = wfLogIn.table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Width = dataGridView1.Width - 203;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wfBookClassification_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}