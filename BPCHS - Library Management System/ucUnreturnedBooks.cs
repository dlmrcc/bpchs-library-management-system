using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace BPCHS___Library_Management_System
{
    public partial class ucUnreturnedBooks : UserControl
    {
        public ucUnreturnedBooks()
        {
            InitializeComponent();
        }

        private void ucUnreturnedBooks_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            DateTime ngaun = DateTime.Now;
            wfLogIn.q = "SELECT bbid,"//0
                + " concat(bw.fname,' ',bw.lname) `BORROWER`,"//1
                + " bw.connum `Contact #`,"//2
                + " concat(b.TITLE,' copy ',b.copy,' ',b.edition,' Edition') `BOOK`,"//3
                + " b.AUTHOR,"//4
                + " br.REMARKS,"//5
                + " dateborrow `DATE BORROWED`,"//6
                + " expecteddatereturn `EXPECTED DATE RETURN` FROM borrowbook br left join"//7
                + " (book b, staff s, borrower bw) on"
                + " (br.userid = s.staffid and b.accno = br.accno and bw.id = br.borrowerid) where expecteddatereturn < '"// hindi pwd ang 3 lang, kc baka makasama ang sat and sun.
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and br.bookstat = 'No'";//   + " where DATEDIFF(day,dateborrow,ngaun) >= 3";
            wfLogIn.v();
            dataGridView1.DataSource = wfLogIn.table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[3].Width = ((dataGridView1.Width - (dataGridView1.Columns[1].Width
                + dataGridView1.Columns[2].Width + dataGridView1.Columns[5].Width
                + dataGridView1.Columns[6].Width + dataGridView1.Columns[7].Width)) / 2) - 10;
            dataGridView1.Columns[4].Width = dataGridView1.Columns[3].Width;
            lbUnreturned.Text = "List of Unreturned Books (" + dataGridView1.Rows.Count + ")";
        }
    }
}
