using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class ucBorrower : UserControl
    {
        public ucBorrower()
        {
            InitializeComponent();
        }

        private void UCborrower_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT ID `Borrower ID`"//0
                + ", concat(FName,' ',MName, ' ',LName) `Borrower`"//1
                + ",FName, MName, LName"//2//3//4
                + ", connum `Contact #`"//5
                + ", BDay `Birthday`"//6
                + ", Address "//7
                + ", br.borrowertype `BORROWER TYPE` FROM borrower b left join bookrate br on br.bookrateid = b.bookrateid"//7
                + " where concat(FName,' ',MName, ' ',LName) like '%" + boprint.Text
                + "%' or address = '%" + boprint.Text
                + "%' or connum = '%" + boprint.Text
                + "%' or br.borrowertype like '%" + boprint.Text + "%'";
            wfLogIn.v();
            dataGridView1.DataSource = wfLogIn.table;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "MMM. dd, yyyy";
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
            printDocument1.DocumentName = sName;
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new  System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dataGridView1, printDocument1, true, true, sName
                , new Font("Tahoma", 18, FontStyle.Bold,
                    GraphicsUnit.Point), Color.Black, true);
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UCborrower_Load(sender, e);
        }
        public static String sID, sFName, sMName, sLName, sBDay, sAddress, sborrowertype, sConnum;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sFName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sMName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                sLName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sConnum = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
                sBDay = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                sAddress = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
                sborrowertype = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            }
            catch { }
        }
        public static String sSave;
        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCall();
            UCborrower_Load(sender, e);
        }
        void vCall()
        {
            wfBorrowersetting b = new wfBorrowersetting();
            b.ShowDialog();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCall();
            UCborrower_Load(sender, e);
        }
        string sName = "BPCHS Borrower Information";
        Printing print;
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
