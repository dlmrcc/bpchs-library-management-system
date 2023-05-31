using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BPCHS___Library_Management_System
{
    public partial class wfHome : Form
    {
        public wfHome()
        {
            InitializeComponent();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.SType == "Admin")
            {
                ucUser u = new ucUser();
                pnCon.Controls.Clear();
                pnCon.Controls.Add(u);
                u.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Unable to access this form.", "Prohibited Action");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbUser.Text = wfLogIn.sGName + " " + wfLogIn.sMName + " " + wfLogIn.sLName;
            lbDate.Text = DateTime.Now.ToString("MMM. dd, yyyy hh:mm:ss tt");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            ucUnreturnedBooks b = new ucUnreturnedBooks();
            pnCon.Controls.Clear();
            pnCon.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void ni_DoubleClick(object sender, EventArgs e)
        {
            Show();
            ni.Visible = false;
            WindowState = FormWindowState.Maximized;
        }

        private void logHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.SType == "Admin")
            {
                ucLogHist l = new ucLogHist();
                pnCon.Controls.Clear();
                pnCon.Controls.Add(l);
                l.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Unable to access this form.", "Prohibited Action");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Log - Out?"
                , "Confirm Log - Out"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void bnBorrower_Click(object sender, EventArgs e)
        {
            ucBorrower b = new ucBorrower();
            pnCon.Controls.Clear();
            pnCon.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void changeUserSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucUser.sSave = "Edit";
            User_Setting s = new User_Setting();
            s.ShowDialog();
            timer1_Tick(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ucBook b = new ucBook();
            pnCon.Controls.Clear();
            pnCon.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void borrowerTypeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.SType == "Admin")
            {
                Hide();
                wfBorrowerTypeSettings s = new wfBorrowerTypeSettings();
                s.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Unable to access this form.", "Prohibited Action");
            }
        }

        private void bnBorrowBooks_Click(object sender, EventArgs e)
        {
            pnCon.Controls.Clear();
            ucBorrowBook c = new ucBorrowBook();
            pnCon.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }
        private void deweyDecimalSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfBookClassification b = new wfBookClassification();
            b.ShowDialog();
        }

        private void bnReturnBooks_Click(object sender, EventArgs e)
        {
            pnCon.Controls.Clear();
            ucReturnBook c = new ucReturnBook();
            pnCon.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }
        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            wfBookReport b = new wfBookReport();
            b.ShowDialog();
            Show();
        }

        private void listOfBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucListOfBorrowedBooks l = new ucListOfBorrowedBooks();
            pnCon.Controls.Clear();
            pnCon.Controls.Add(l);
            l.Dock = DockStyle.Fill;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucUnreturnedBooks b = new ucUnreturnedBooks();
            pnCon.Controls.Clear();
            pnCon.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void holidaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.SType == "Admin")
            {
                Hide();
                wfHollidays h = new wfHollidays();
                h.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Unable to access this form.", "Prohibited Action");
            }
        }

        private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.SType == "Admin")
            {
                Hide();
                wfPayment h = new wfPayment();
                h.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Unable to access this form.", "Prohibited Action");
            }
        }
    }
}