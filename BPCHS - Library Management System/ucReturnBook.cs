using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
namespace BPCHS___Library_Management_System
{
    public partial class ucReturnBook : UserControl
    {
        public ucReturnBook()
        {
            InitializeComponent();
        }
        void vBorrower()
        {
            wfLogIn.q = "SELECT id `BORROWER ID`,"
                + " concat(fname,' ', mname ,' ', lname) `BORROWER NAME`"
                + " FROM borrower where id in"
                + " (select borrowerid from borrowbook where bookstat = 'No') and (id = '" + txtSearch.Text
                + "' or concat(fname,' ', mname ,' ', lname) like '%" + txtSearch.Text + "%')";
            wfLogIn.v();
            dgBorrower.DataSource = wfLogIn.table;
        }
        private void ucReturnBook_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            vBorrower();
            txtCash.Text = "0";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vBorrower();
            }
        }
        string sBorrwerID;
        void vBorrowedBook()
        {
            wfLogIn.q = "SELECT bbid,"//0
                + " concat(b.title,' copy ',b.copy,' ',b.edition,' Edition') `Book`,"//1
                + " concat(s.gname,' ', s.mname,' ',s.lname) `Staff`,"//2
                + " bb.dateborrow `Date Borrowed`,"//3
                + " bb.`expecteddatereturn` `Expected Date Return`,"//4
                + " bb.`datereturn` `Return Date`,"//5
                + " bb.`lostdate` `Lost Date`,"//6
                + " bb.RATE `Fines Rate`,"//7
                + " b.accno,"//8
                + " b.Class"//9
                + " FROM borrowbook bb left join (book b, borrower br, staff s)"
                + " on (b.accno = bb.accno and br.id = bb.borrowerid and bb.userid = s.staffid)"
                + " where bb.borrowerid = '" + sBorrwerID + "' and bb.bookstat = 'No'";
            wfLogIn.v();
            dgBookReturn.DataSource = wfLogIn.table;
            dgBookReturn.Columns[0].Visible = false;
            dgBookReturn.Columns[8].Visible = false;
            dgBookReturn.Columns[3].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBookReturn.Columns[4].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBookReturn.Columns[5].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBookReturn.Columns[6].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBookReturn.Columns[5].DefaultCellStyle.NullValue = "Not Available";
            dgBookReturn.Columns[6].DefaultCellStyle.NullValue = "Not Available";
            dgBookReturn.Columns[2].Width = 190;
            dgBookReturn.Columns[7].Width = 80;
            dgBookReturn.Columns[7].DefaultCellStyle.Format = "c";
            dgBookReturn.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgBookReturn.Columns[9].Width = 80;
            dgBookReturn.Columns[1].Width = 315;
            if (dgBookReturn.Rows.Count == 0)
                vBorrower();
        }
        private void dgBorrower_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sBorrwerID = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[0].Value.ToString();
                vBorrowedBook();
                vFines();
            }
            catch { }
        }
        TimeSpan ts;
        string sDateBorrow;
        string sExpectedDateReturn;
        string sDateLost;
        string sDateReturn;
        int iWeekDays = 0;
        Double dPrice;
        double dTotalFines;
        double dTotalPayment;
        double dRemainingFines;
        void vFines()
        {           
            int iMultiWeeks = 0;
            dPrice = 0;
            iWeekDays = 0;
            sExpectedDateReturn = dgBookReturn.SelectedRows[0].Cells[4].Value.ToString();
            sDateReturn = dgBookReturn.SelectedRows[0].Cells[5].Value.ToString();
            sDateLost = dgBookReturn.SelectedRows[0].Cells[6].Value.ToString();
            sBBID = dgBookReturn.SelectedRows[0].Cells[0].Value.ToString();
            if (sDateReturn == "" && sDateLost == "")
            {
                ts = DateTime.Now - Convert.ToDateTime(sExpectedDateReturn);
            }
            else if (sDateReturn != "" && sDateLost == "")
            {
                ts = DateTime.Parse(sDateReturn) - Convert.ToDateTime(sExpectedDateReturn);
            }
            else if (sDateLost != "")
            {
                ts = DateTime.Parse(sDateLost) - Convert.ToDateTime(sExpectedDateReturn);
            }
            int iDays = (int)ts.TotalDays;
            for (int s = 1; s <= iDays; s++)
            {
                DateTime dExpectedDateReturn = Convert.ToDateTime(sExpectedDateReturn);
                if (dExpectedDateReturn.AddDays(s).ToString("ddd") == "Mon" ||
                    dExpectedDateReturn.AddDays(s).ToString("ddd") == "Tue" ||
                    dExpectedDateReturn.AddDays(s).ToString("ddd") == "Wed" ||
                    dExpectedDateReturn.AddDays(s).ToString("ddd") == "Thu" ||
                    dExpectedDateReturn.AddDays(s).ToString("ddd") == "Fri")
                {
                    wfLogIn.q = "SELECT dayid FROM hollidays where actdate = '" + Convert.ToDateTime(sExpectedDateReturn).AddDays(s).ToString("yyyy-MM-dd") + "'";
                    wfLogIn.v();
                    if(wfLogIn.table.Rows.Count==0)
                    iWeekDays++;
                }
            }
            dPrice = iWeekDays * Convert.ToDouble(dgBookReturn.SelectedRows[0].Cells[7].Value);
            wfLogIn.q = "SELECT sum(cash) FROM payment where bbid = '" + sBBID + "'";
            wfLogIn.v();
            try
            {
                dTotalPayment = Convert.ToDouble(wfLogIn.table.Rows[0][0]);
            }
            catch
            {
                dTotalPayment = 0;
            }
            wfLogIn.q = "SELECT amount FROM payment where paystat = 'Unsettled' and bbid = '" + sBBID + "'";
            wfLogIn.v();
            try
            {
                dTotalFines = Convert.ToDouble(wfLogIn.table.Rows[0][0]);
            }
            catch
            {
                dTotalFines = dPrice;
            }
            dRemainingFines = dTotalFines - dTotalPayment;
            lbTotalDaysBorrowed.Text = iWeekDays.ToString();
            lbTotalFines.Text = dTotalFines.ToString("c");
            lbTotalPayment.Text = dTotalPayment.ToString("c");
            lbRemainingFines.Text = dRemainingFines.ToString("c");
            if (dgBookReturn.Rows.Count == 0)
            {
                vBorrower();
                dTotalFines = 0;
                dTotalPayment = 0;
                dRemainingFines = 0;
                lbTotalFines.Text = dTotalFines.ToString("c");
                lbTotalPayment.Text = dTotalPayment.ToString("c");
                lbRemainingFines.Text = dRemainingFines.ToString("c");
            }
        }
        double dMoney;
        double dCash;
        double dBalance;
        double dChange;
        string sBBID;
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dCash = Convert.ToDouble(txtCash.Text);
            }
            catch { dCash = 0; }
            if (dCash >= dRemainingFines)
            {
                dBalance = 0;
                dChange = dCash - dRemainingFines;
                dMoney = dRemainingFines;
            }
            else
            {
                dBalance = dRemainingFines - dCash;
                dChange = 0;
                dMoney = dCash;
            }
            lbBalance.Text = dBalance.ToString("c");
            lbChange.Text = dChange.ToString("c");
        }

        private void dgBookReturn_SelectionChanged(object sender, EventArgs e)
        {
            try
            {              
                vFines();
                if (dgBookReturn.SelectedRows[0].Cells[6].Value.ToString() != "")
                {
                    bnLost.Text = "Replace th Lost Book";
                }
                else
                {
                    bnLost.Text = "Mark as Lost";
                }
            }
            catch { sBBID = ""; }
            if (sDateReturn != "" && sDateLost != "")
            {
                bnLost.Visible = false;
            }
        }
        string sBorrowID;
        string ssDateLost;
        string ssDateReturn;
        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sBorrowID = dgBookReturn.SelectedRows[0].Cells[0].Value.ToString();
                if (dCash > 0)
                {
                    string sPaystat = "Unsettled";
                    if (dBalance == 0)
                    {
                        sPaystat = "Settled";
                    }
                    wfLogIn.q = "insert into payment (PayID, bbid, Amount, Cash, Datepaid, paystat, staffid) values (null,'" + sBorrowID
                        + "','" + dRemainingFines
                        + "','" + dMoney
                        + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                        + "','" + sPaystat
                        + "','" + wfLogIn.StaffID + "')";
                    wfLogIn.v();
                }
                if (ssDateLost == "")
                {
                    wfLogIn.q = "update borrowbook set datereturn = '" + DateTime.Now.ToString("yyyy-MM-dd")
                        + "', remarks = 'Returned' where bbid = '" + sBorrowID + "'";
                    wfLogIn.v();
                }
                wfLogIn.q = "select datereturn from borrowbook where bbid = '" + sBorrowID + "'";
                wfLogIn.v(); try
                {
                    ssDateReturn = wfLogIn.table.Rows[0][0].ToString();
                }
                catch { }
                txtCash_TextChanged(sender, e);
                if (dBalance == 0 && ssDateReturn != "")
                {
                    wfLogIn.q = "update borrowbook set bookstat = 'Yes', billingflag = 'Yes' where bbid = '" + sBorrowID + "'";
                    wfLogIn.v();
                }
                vBorrowedBook();
                if (dgBookReturn.Rows.Count == 0)
                {
                    vBorrower();
                } txtCash.Text = "0";
            }
        }
        private void bnLost_Click(object sender, EventArgs e)
        {
            sBorrowID = dgBookReturn.SelectedRows[0].Cells[0].Value.ToString();
            if (bnLost.Text == "Mark as Lost")
            {
                wfLogIn.q = "update borrowbook set Remarks = 'Lost"
                       + "', lostdate = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                       + "' where bbid = '" + sBorrowID + "'";
                wfLogIn.v();
            }
            else
            {
                wfLogIn.q = "update borrowbook set Remarks = 'Returned"
                      + "', dateReturn = '" + DateTime.Now.ToString("yyyy-MM-dd")
                      + "', userid2 = '" + wfLogIn.StaffID
                      + "' where bbid = '" + sBorrowID
                      + "'";
                wfLogIn.v();
                wfLogIn.q = "update book set class = 'Replaced' where accno in (select accno from borrowbook where bbid = '" + sBorrowID + "')";
                wfLogIn.v();
                wfLogIn.q = "select datereturn from borrowbook where bbid = '" + sBorrowID + "' ";
                wfLogIn.v();
                ssDateReturn = wfLogIn.table.Rows[0][0].ToString();
                if (dBalance == 0)
                {
                    wfLogIn.q = "update borrowbook set bookstat = 'Yes', billingflag = 'Yes' where bbid = '" + sBorrowID + "'";
                    wfLogIn.v();
                }
                vBorrowedBook();
                if (dgBookReturn.Rows.Count == 0)
                {
                    vBorrower();
                }
            }
            vBorrowedBook();
            if (dgBookReturn.Rows.Count == 0)
            {
                vBorrower();
                dTotalFines = 0;
                dTotalPayment = 0;
                dRemainingFines = 0;
                lbTotalFines.Text = dTotalFines.ToString("c");
                lbTotalPayment.Text = dTotalPayment.ToString("c");
                lbRemainingFines.Text = dRemainingFines.ToString("c");
            }

            txtCash.Text = "0";
        }
        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 48 && e.KeyChar <= 57)
                || e.KeyChar == 8) || (e.KeyChar == 46) && (txtCash.Text.IndexOf('.') == -1))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}