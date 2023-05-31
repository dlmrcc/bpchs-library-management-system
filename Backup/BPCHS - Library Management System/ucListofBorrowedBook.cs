using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class ucListOfBorrowedBooks : UserControl
    {
        public ucListOfBorrowedBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcAuthor_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT concat(bw.fname,' ',bw.mname,' ',bw.lname) Borrower,"
                + " b.Title,"
                + " b.Copy,"
                + " b.Edition,"
                + " Class `Remarks`,bb.dateborrow FROM borrowbook bb left join"
                + " (book b, borrower bw) on (bb.accno = b.accno and bb.borrowerid = bw.id) where bb.remarks = 'Borrowed'";
            wfLogIn.v();
            dataGridView1.DataSource = wfLogIn.table;
            dataGridView1.Columns[0].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
        }
    }
}