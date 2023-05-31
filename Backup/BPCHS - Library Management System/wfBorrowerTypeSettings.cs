using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfBorrowerTypeSettings : Form
    {
        public wfBorrowerTypeSettings()
        {
            InitializeComponent();
        }

        private void BorrowerTypeSettings_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT borrowertypeid, type `BORROWER TYPE`, rate `RATE`, maximum `MAX BORROW`, finetype `FINES TYPE`, initialfines `LIMIT (DAYS)` FROM borrowertype";
            wfLogIn.v();
            dgBorrowerType.DataSource = wfLogIn.table;
            dgBorrowerType.Columns[0].Visible = false;
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            wfBorrowerTypeSet s = new wfBorrowerTypeSet();
            s.ShowDialog();
            BorrowerTypeSettings_Load(sender, e);
        }
        public static String sborrowertypeid, stype, srate, svalue, sfinetype, sinitialfines;
        private void dgBorrowerType_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sborrowertypeid = dgBorrowerType.Rows[dgBorrowerType.CurrentCell.RowIndex].Cells[0].Value.ToString();
                stype = dgBorrowerType.Rows[dgBorrowerType.CurrentCell.RowIndex].Cells[1].Value.ToString();
                srate = dgBorrowerType.Rows[dgBorrowerType.CurrentCell.RowIndex].Cells[2].Value.ToString();
                svalue = dgBorrowerType.Rows[dgBorrowerType.CurrentCell.RowIndex].Cells[3].Value.ToString();
                sfinetype = dgBorrowerType.Rows[dgBorrowerType.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sinitialfines = dgBorrowerType.Rows[dgBorrowerType.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BorrowerTypeSettings_Load(sender, e);
        }

        private void bnPrint_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
