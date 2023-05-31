using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class ucBorrowBook : UserControl
    {
        public ucBorrowBook()
        {
            InitializeComponent();
        }
        string where;
        void vBooks()
        {
            wfLogIn.q = "SELECT accno `BOOK ID`,"
                + " title `TITLE`,"
                + " copy `COPY`,"
                + " edition `EDITION`,"
                + " copyright `COPY RIGHT`,"
                + " publisher `PUBLISHER`,"
                + " class `BOOK CLASS`,"
                + " author `AUTHOR`,"
                + " duration FROM book"
                + " where accno not in"
                + " (SELECT accno FROM borrowbook where bookstat = 'No') and availability = 'Available'"
                + where;
            wfLogIn.v();
            dgAvail.DataSource = wfLogIn.table;
            dgAvail.Columns[0].Visible = false;
            dgAvail.Columns[8].Visible = false;
        }
        //book inventory
        //SELECT concat(br.fname,' ',br.mname,' ',br.lname) `Borrower`,
        //concat(title,' Copy ',copy,' ',edition,' Edition ', class) Book,
        //dateborrow `Date Borrow`, expecteddatereturn `Expected Return`,datereturn
        //`Date Return`, Remarks FROM borrowbook bb left join (borrower br, book b)
        //on (br.id = bb.borrowerid and b.accno = bb.accno)
        private void ucBorrowBook_Load(object sender, EventArgs e)
        {
            vBooks();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ucBorrower.sSave = "Add";
            wfBorrowersetting b = new wfBorrowersetting();
            b.ShowDialog();
        }
        void vBorrowedBook()
        {
            wfLogIn.q = "SELECT bbid,"//0
                + " b.title `TITLE`,"//1
                + " b.edition `EDITION`,"//2
                + " b.copy `COPY`,"//3
                + " b.publisher `PUBLISHER`,"//4
                + " b.class ` BOOK CLASS`,"//5
                + " b.author `AUTHOR`,"//6
                + " bb.dateborrow `DATE BORROWED`,"//7
                + " bb.accno,"//8
                + " bb.expecteddatereturn `Expected Return Date`"//9
                + " FROM borrowbook bb left join"
                + " (staff s, borrower br, book b)"
                + " on (s.staffid = bb.userid and"
                + " bb.accno = b.accno and br.id = bb.borrowerid) where bb.borrowerid = '"
                + sBorrowerID + "' and bb.remarks != 'Returned'";
            wfLogIn.v();
            dgBorrowedBooks.DataSource = wfLogIn.table;
            dgBorrowedBooks.Columns[0].Visible = false;
            dgBorrowedBooks.Columns[8].Visible = false;
            dgBorrowedBooks.Columns[7].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBorrowedBooks.Columns[9].DefaultCellStyle.Format = "MMM. dd, yyyy";
        }
        string sRate;
        int sBorrowLimit;
        private void bnBorrowBook_Click(object sender, EventArgs e)
        {
            if (pnBorrower.Visible == false)
            {
                MessageBox.Show("Please select borrower first.", "Unable to borrow");
                txtBorrower.Focus();
            }
            else
            {
                if (dgBorrowedBooks.Rows.Count == sBorrowLimit)
                {
                    MessageBox.Show("Borrower named " + lbBorrowerName.Text
                        + " has reached the maximum books to borrowed.", "Maximum ("
                        + sBorrowLimit.ToString() + ")");
                }
                else
                {
                    int WeekDays = 0;
                    int d = 1;
                    for (d = 1; d < 100; d++)
                    {
                        if (DateTime.Now.AddDays(d).ToString("ddd") == "Sat"
                            || DateTime.Now.AddDays(d).ToString("ddd") == "Sun")
                        {

                        }
                        else
                        {
                            wfLogIn.q = "SELECT dayid FROM hollidays where actdate = '"
                                + DateTime.Now.AddDays(d).ToString("yyyy-MM-dd") + "'";
                            wfLogIn.v();
                            if (wfLogIn.table.Rows.Count > 0) { }
                            else
                            {
                                WeekDays++;
                                if (WeekDays == iDuration)
                                    break;
                            }
                        }
                    }
                    int s = 0;
                    for (int a = 0; a < dgBorrowedBooks.Rows.Count; a++)
                    {
                        if (dgAvail.Rows[dgAvail.CurrentCell.RowIndex].Cells[1].Value.ToString()
                            == dgBorrowedBooks.Rows[a].Cells[1].Value.ToString())
                        {
                            s++;
                            break;
                        }
                    }
                    if (s == 0)
                    {
                        wfLogIn.q = "insert into borrowbook"
                            + " (BBID, BorrowerID, UserID, AccNo, DateBorrow,"
                            + " DateReturn, BillingFlag, Remarks, Rate, expecteddatereturn, bookstat, userid2)"
                            + " values (null,'" + sBorrowerID
                            + "','" + wfLogIn.StaffID
                            + "','" + dgAvail.Rows[dgAvail.CurrentCell.RowIndex].Cells[0].Value
                            + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            + "',null,'" + "No"
                            + "','" + "Borrowed"
                            + "','" + sRate
                            + "','" + DateTime.Now.AddDays(d).ToString("yyyy-MM-dd HH:mm:ss") + "','No','')";
                        wfLogIn.v();
                        vBooks();
                        vBorrowedBook();
                    }
                    else
                    {
                        MessageBox.Show("The borrower has already borrowed "
                            + dgAvail.Rows[dgAvail.CurrentCell.RowIndex].Cells[1].Value.ToString()
                            , "Unable to borrow");
                    }
                }
            }
        }
        private void bnAddBook_Click(object sender, EventArgs e)
        {
            ucBook.sSaveBook = "Add";
            wfAccessionBooks a = new wfAccessionBooks();
            a.ShowDialog();
            vBooks();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == 0)
            {
                where = " and title like '%" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 1)
            {
                where = " and publisher like '%" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 2)
            {
                where = " and source like '%" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 3)
            {
                where = " and class like '%" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 4)
            {
                where = " and author like '%" + txtSearch.Text + "%'";
            }
            vBooks();
        }
        string sBorrowerID;
        private void txtBorrower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBorrower.Text = txtBorrower.Text.ToUpper();
                wfLogIn.q = "SELECT Address,"
                    + " br.borrowertype,"
                    + " bday,"
                    + " concat(lName,', ', fName, ' ',mName), id"
                    + " FROM borrower b left join bookrate br"
                    + " on (br.bookrateid = b.bookrateid) where" + " (id = '" + txtBorrower.Text
                    + "' or concat(lName,', ', fName, ' ',mName) like '%" + txtBorrower.Text + "%')";
                wfLogIn.v();
                if (wfLogIn.table.Rows.Count > 0)
                {
                    dgBorrowedBooks.Visible = true;
                    pnBorrower.Visible = true;
                    dgBorrowedBooks.Visible = true;
                    rtAddress.Text = wfLogIn.table.Rows[0][0].ToString();
                    lbBorrowerType.Text = wfLogIn.table.Rows[0][1].ToString();
                    lbBDate.Text = Convert.ToDateTime(wfLogIn.table.Rows[0][2]).ToString("MMM. dd yyyy");
                    lbBorrowerName.Text = wfLogIn.table.Rows[0][3].ToString();
                    sBorrowerID = wfLogIn.table.Rows[0][4].ToString();
                    wfLogIn.q = "SELECT rate, maximum, initialfines FROM borrowertype where type = '"
                        + lbBorrowerType.Text + "'";
                    wfLogIn.v();
                    sRate = wfLogIn.table.Rows[0][0].ToString();
                    sBorrowLimit = Convert.ToInt32(wfLogIn.table.Rows[0][1]);
                    iniFines = Convert.ToInt32(wfLogIn.table.Rows[0][2]);
                    vBorrowedBook();
                }
                else
                {
                    lbBDate.Text = "Null";
                    lbBorrowerName.Text = "Null";
                    lbBorrowerType.Text = "Null";
                    rtAddress.Text = "Null";
                }
            }
        }
        int iniFines;
        int iDuration;
        private void dgAvail_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                iDuration = Convert.ToInt32(dgAvail.SelectedRows[0].Cells[8].Value);
            }
            catch { }
        }
    }
}