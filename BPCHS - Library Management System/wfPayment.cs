using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfPayment : Form
    {
        public wfPayment()
        {
            InitializeComponent();
        }
        string sUserID;
        String[] aUserID;
        void vUser()
        {
            wfLogIn.q = "SELECT concat(gname,' ',mname,' ',lname),"
                + " staffid FROM staff where staffid in"
                + " (select userid from borrowbook)";
            wfLogIn.v();
            cbUser.Items.Clear();
            cbUser.Items.Add("All");
            aUserID = new String[wfLogIn.table.Rows.Count];
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
            {
                cbUser.Items.Add(wfLogIn.table.Rows[a][0]);
                aUserID[a] = wfLogIn.table.Rows[a][1].ToString();
            }
        }
        string sBorrowerID;
        String[] aBorrowerID;
        void vBorrower()
        {
            wfLogIn.q = "SELECT concat(FName, ' ',MName, ' ',LName),"
                + " id FROM borrower where ID in"
                + " (select borrowerid from borrowbook)";
            wfLogIn.v();
            cbBorrower.Items.Clear();
            cbBorrower.Items.Add("All");
            aBorrowerID = new String[wfLogIn.table.Rows.Count];
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
            {
                cbBorrower.Items.Add(wfLogIn.table.Rows[a][0]);
                aBorrowerID[a] = wfLogIn.table.Rows[a][1].ToString();
            }
        }
        string sWhere;
        void vLoad()
        {
            wfLogIn.q = "SELECT concat(bk.title, ' copy ',copy, ' ', edition) Book,"
                + " Amount,"//1
                + " Cash,"//2
                + " paystat `Payment Status`,"//3
                + " datepaid `Payment Date`"//4
                + " FROM payment p left join (borrowbook bb, staff s, borrower b, book bk)"
                + " on (bb.borrowerid = b.id and p.bbid = bb.bbid and bb.userid = s.staffid"
                + " and bb.accno = bk.accno)" + sWhere;
            wfLogIn.v();
            dgBookReturn.DataSource = wfLogIn.table;
            dgBookReturn.Columns[0].Width = 400;
            dgBookReturn.Columns[1].DefaultCellStyle.Format = "c";
            dgBookReturn.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgBookReturn.Columns[2].DefaultCellStyle.Format = "c";
            dgBookReturn.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgBookReturn.Columns[3].Width = 140;
            dgBookReturn.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            dgBookReturn.Columns[4].Width = 150;
            dTotalAmount = 0;
            for (int a = 0; a < dgBookReturn.Rows.Count; a++)
                dTotalAmount += Convert.ToDouble(dgBookReturn.Rows[a].Cells[2].Value);
            lbTotalPayment.Text = "Total Payment: " + dTotalAmount.ToString("c");
        }
        double dTotalAmount;
        private void wfPayment_Load(object sender, EventArgs e)
        {
            vUser();
            vBorrower();
            vLoad();
            cbBorrower.SelectedIndex = 0;
            cbUser.SelectedIndex = 0;
            sWhere = " where s.staffid like '%" + sUserID
                + "%' and b.id like '%" + sBorrowerID + "%' and datepaid"
                + " between '" + dtFrom.Value.ToString("yyyy-MM-dd 00:00:00")
                + "' and '" + dtTo.Value.ToString("yyyy-MM-dd 23:59:59") + "'";
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            sUserID = "";
            if (cbUser.SelectedIndex > 0)
            {
                sUserID = aUserID[cbUser.SelectedIndex - 1];
            }
            vLoad();
        }

        private void cbBorrower_SelectedIndexChanged(object sender, EventArgs e)
        {
            sBorrowerID = "";
            if (cbBorrower.SelectedIndex > 0)
            {
                sBorrowerID = aBorrowerID[cbBorrower.SelectedIndex - 1];
            }
            vLoad();
        }

        private void dtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                vLoad();
        }

        private void dtTo_KeyDown(object sender, KeyEventArgs e)
        {
            dtFrom_KeyDown(sender, e);
        }

        private void bnLost_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool SetupThePrinting()
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            printDocument1.DocumentName = "Payment Report";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgBookReturn, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 12, FontStyle.Bold,
                    GraphicsUnit.Point), Color.Black, true);
            return true;
        }
        Printing print;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
                printDocument1.Print();
            }
        }
    }
}