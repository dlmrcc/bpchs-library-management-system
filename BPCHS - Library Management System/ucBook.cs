using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class ucBook : UserControl
    {
        public ucBook()
        {
            InitializeComponent();
        }
        void vLoad()
        {
            vDewey();
            wfLogIn.q = "SELECT accno `Accession #`,"//0
                + " dateaquired `Date Received`,"//1
                + " classno `Classification #`,"//2
                + " '' `Book Classification`,"//12
                + " title `Title`,"//3
                + " copy `Number of Copies`,"//4
                + " edition `Edition`,"//5
                + " copyright `Copy Rigth`,"//6
                + " publisher `Publisher`,"//7
                + " source `Source of Fund`,"//8
                + " price `Price`,"//9
                + " class `Remarks`,"//10
                + " Availability,"//10
                + " author `Author`,"//11
                + " Duration `Duration (Day)`"//11
                + " FROM book where (title like '" + txtSearch.Text
                + "%' or edition like '" + txtSearch.Text
                + "%' or copyright like '" + txtSearch.Text
                + "%' or publisher like '" + txtSearch.Text
                + "%' or source like '" + txtSearch.Text
                + "%' or class like '" + txtSearch.Text
                + "%' or author like '%" + txtSearch.Text + "%')";
            wfLogIn.v();
            dgBook.DataSource = wfLogIn.table;
            dgBook.Columns[1].DefaultCellStyle.Format = "MMM. dd yyyy";
            for (int a = 0; a < dgBook.Rows.Count; a++)
            {
                for (int s = 0; s < iDeweyCounter; s++)
                {
                    if (iFrom[s] <= Convert.ToInt32(dgBook.Rows[a].Cells[2].Value)
                        && iTo[s] >= Convert.ToInt32(dgBook.Rows[a].Cells[2].Value))
                        dgBook.Rows[a].Cells[3].Value = sClass[s];
                }
            }
        }
        private void UcBook_Load(object sender, EventArgs e)
        {
            vLoad();            
        }
        ColorConverter c = new ColorConverter();
        public static string sSaveBook;
        public static string sSaveAuthor;
        void vCallBook()
        {
            wfAccessionBooks a = new wfAccessionBooks();
            a.ShowDialog();
        }
        Int32[] iFrom = new Int32[10];
        Int32[] iTo = new Int32[10];
        String[] sClass = new String[10];
        int iDeweyCounter;
        void vDewey()
        {
            wfLogIn.q = "SELECT start, end, Class FROM bookdivision";
            wfLogIn.v();
            iDeweyCounter = wfLogIn.table.Rows.Count;
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
            {
                iFrom[a] = Convert.ToInt32(wfLogIn.table.Rows[a][0]);
                iTo[a] = Convert.ToInt32(wfLogIn.table.Rows[a][1]);
                sClass[a] = (wfLogIn.table.Rows[a][2]).ToString();
            }
        }
        private void bnAddBook_Click(object sender, EventArgs e)
        {
            sSaveBook = "Add";
            vCallBook();
            vLoad();
        }

        private void bnEditBook_Click(object sender, EventArgs e)
        {
            sSaveBook = "Edit";
            vCallBook();
            vLoad();
        }
        public static String saccno, sdateaquired, sclassno, stitle, scopy, sedition, scopyright, spublisher, ssource, sprice, sauthor, sclass, savail, sduration;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                saccno = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sdateaquired = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[1].Value.ToString();
                sclassno = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[2].Value.ToString();
                stitle = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[4].Value.ToString();
                scopy = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[5].Value.ToString();
                sedition = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[6].Value.ToString();
                scopyright = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[7].Value.ToString();
                spublisher = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[8].Value.ToString();
                ssource = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[9].Value.ToString();
                sprice = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[10].Value.ToString();
                sclass= dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[11].Value.ToString();
                savail = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[12].Value.ToString();
                sauthor = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[13].Value.ToString();
                sduration = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[14].Value.ToString();
                if (savail == "Available")
                {
                    bnAvail.Text = "Unavailable";
                }
                else
                {
                    bnAvail.Text = "Available";
                }
                if (sclass == "New")
                {
                    bnNewOld.Text = "Old";
                }
                else
                {
                    bnNewOld.Text = "New";
                }
            }
            catch
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            vLoad();
        }
        string sName = "BPCHS Book";
        Printing print;
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
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgBook, printDocument1, true, true, sName
                , new Font("Tahoma", 18, FontStyle.Bold,
                    GraphicsUnit.Point), Color.Black, true);
            return true;
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
        string sBookID;
        private void bnNewOld_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < dgBook.SelectedRows.Count; a++)
            {
                sBookID = dgBook.SelectedRows[a].Cells[0].Value.ToString();
                if (sclass == "New")
                {
                    wfLogIn.q = "update book set class = 'Old' where accno = '" + sBookID + "'";
                }
                else
                {
                    wfLogIn.q = "update book set class = 'New' where accno = '" + sBookID + "'";
                }
                wfLogIn.v();
            }
            vLoad();
        }

        private void bnAvail_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < dgBook.SelectedRows.Count; a++)
            {
                sBookID = dgBook.SelectedRows[a].Cells[0].Value.ToString();
                if (savail == "Available")
                {
                    wfLogIn.q = "update book set availability = 'Unavailable' where accno = '" + sBookID + "'";
                }
                else
                {
                    wfLogIn.q = "update book set availability = 'Available' where accno = '" + sBookID + "'";
                }
                wfLogIn.v();
            }            
            vLoad();
        }
    }
}