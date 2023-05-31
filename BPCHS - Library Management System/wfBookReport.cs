using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfBookReport : Form
    {
        public wfBookReport()
        {
            InitializeComponent();
        }
        string sWhere;
        void vLoad()
        {
            wfLogIn.q = "SELECT concat(b.title,' Copy ',copy,' ',edition,' Edition ',class) Book,"//0
               + " concat(s.gname,' ',s.MName,' ', s.LName) `Issued By`,"//1
               + " concat(br.fname,' ',br.mname,' ',br.lname) Borrower,"//2
               + " concat(ss.gname,' ',ss.MName,' ', ss.LName) `Received By`,"//3
               + " bb.dateborrow `Borrow Date`,"//4
               + " expecteddatereturn `Expected Return`,"//5
               + " datereturn `Return Date`,"//6
               + " lostdate `Lost Date`,"//7
               + " bb.Remarks,"//8
               + " rate `Rate` FROM borrowbook bb left join (staff s, book b, borrower br, staff ss)"//8
               + " on (s.staffid = bb.userid and ss.staffid = bb.userid and b.accno = bb.accno and bb.borrowerid = br.id)"
               + sWhere;
            wfLogIn.v();
            dgBorrowerType.DataSource = wfLogIn.table;
            dgBorrowerType.Columns[0].Width = 300;
            dgBorrowerType.Columns[1].Width = 140;
            dgBorrowerType.Columns[2].Width = 140;
            dgBorrowerType.Columns[3].Width = 140;
            dgBorrowerType.Columns[8].Width = 80;
            dgBorrowerType.Columns[9].Width = 40;
            dgBorrowerType.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgBorrowerType.Columns[4].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBorrowerType.Columns[5].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBorrowerType.Columns[6].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBorrowerType.Columns[7].DefaultCellStyle.Format = "MMM. dd, yyyy";
            dgBorrowerType.Columns[6].DefaultCellStyle.NullValue = "N/A";
            dgBorrowerType.Columns[7].DefaultCellStyle.NullValue = "N/A";
        }
        void vBorrower()
        {
            wfLogIn.q = "SELECT ID,"
                + " concat(FName, ' ',MName, ' ',LName)"
                + " FROM borrower where id in (select borrowerid from borrowbook)";
            wfLogIn.v();
            cbBorrower.Items.Add("All");
            aBorrowerID = new String[wfLogIn.table.Rows.Count];
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
            {
                cbBorrower.Items.Add(wfLogIn.table.Rows[a][1]);
                aBorrowerID[a] = wfLogIn.table.Rows[a][0].ToString();
            }
        }
        string sBorrowerID;
        String[] aBorrowerID;
        private void wfBookReport_Load(object sender, EventArgs e)
        {
            vLoad();
            vBorrower();
            cbBorrower.SelectedIndex = 0;
            sWhere = " where bb.dateborrow between '" + dtFrom.Value.ToString("yyyy-MM-dd 00:00:00")
               + "' and '" + dtTo.Value.ToString("yyyy-MM-dd 23:59:59")
               + "' and bb.borrowerid like '%" + sBorrowerID + "%'";
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
            printDocument1.DocumentName = "Book Report";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgBorrowerType, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 12, FontStyle.Bold,
                    GraphicsUnit.Point), Color.Black, true);
            return true;
        }
        Printing print;
        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbBorrower_SelectedIndexChanged(object sender, EventArgs e)
        {
            sBorrowerID = "";
            if (cbBorrower.SelectedIndex > 0)
                sBorrowerID = aBorrowerID[cbBorrower.SelectedIndex - 1];
            vLoad();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            vLoad();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            vLoad();
        }

        private void bnPrint_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }
    }
}