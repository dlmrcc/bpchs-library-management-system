using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class ucLogHist : UserControl
    {
        public ucLogHist()
        {
            InitializeComponent();
        }
        private void ucLogHist_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT LogID `LOG ID`,"
                + " concat(s.GName,' ', s.MName,' ', s.LName) USER,"
                + " LogIN `LOG IN`,"
                + " LOgOut `LOG OUT` FROM loghistory l left join staff s on l.staffid = s.staffid where concat(s.GName,' ', s.MName,' ', s.LName) like '%" + textBox1.Text + "%'";
            wfLogIn.v();
            dataGridView1.DataSource = wfLogIn.table;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "MMM. dd yyyy hh:mm:ss tt";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "MMM. dd yyyy hh:mm:ss tt";
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
            printDocument1.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dataGridView1, printDocument1, true, true, sName
                , new Font("Tahoma", 18, FontStyle.Bold,
                    GraphicsUnit.Point), Color.Black, true);
            return true;

        }
        string sName = "BPCHS Log History";
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucLogHist_Load(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}