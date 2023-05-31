using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfBorrowersetting : Form
    {
        public wfBorrowersetting()
        {
            InitializeComponent();
        }
        void vBorrowerType()
        {
            cbBorrowerType.Items.Clear();
            wfLogIn.q = "SELECT distinct borrowertype FROM bookrate order by finestype";
            wfLogIn.v();
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
                cbBorrowerType.Items.Add(wfLogIn.table.Rows[a][0]);
        }
        private void Borrowersetting_Load(object sender, EventArgs e)
        {
            vBorrowerType();
            if (ucBorrower.sSave == "Edit")
            {
                txtConNum.Text = ucBorrower.sConnum;
                txtAddress.Text = ucBorrower.sAddress;
                txtFName.Text = ucBorrower.sFName;
                txtLName.Text = ucBorrower.sLName;
                txtMName.Text = ucBorrower.sMName;
                cbBorrowerType.Text = ucBorrower.sborrowertype;
                dtBDay.Text = ucBorrower.sBDay;
                cbBorrowerType_SelectedIndexChanged(sender, e);
            }
        }
        void vBorrowerID()
        {
            wfLogIn.q = "SELECT count(id) FROM borrower where dreg like '" + DateTime.Now.ToString("yyyy") + "%'";
            wfLogIn.v();
            sBorrowerID = DateTime.Now.ToString("yyyy-") + (Convert.ToInt32(wfLogIn.table.Rows[0][0]) + 1).ToString("d4");
        }
        string sBorrowerID;
        private void bnSave_Click(object sender, EventArgs e)
        {
            wfLogIn.sOldValue = txtAddress.Text;
            wfLogIn.vAllowSingleQuote();
            if (ucBorrower.sSave == "Add")
            {
                vBorrowerID();
                wfLogIn.q = "insert into borrower values ('" + sBorrowerID
                    + "','" + txtFName.Text
                    + "','" + txtMName.Text
                    + "','" + txtLName.Text
                    + "','" + dtBDay.Value.ToString("yyyy-MM-dd")
                    + "','" + wfLogIn.sNewValue
                    + "','" + sBookRateID
                    + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                    + "','" + txtConNum.Text + "')";
                wfLogIn.v();
            }
            else
            {
                wfLogIn.q = "update borrower set FName = '" + txtFName.Text
                    + "', MName = '" + txtMName.Text
                    + "', LName = '" + txtLName.Text
                    + "', BDay = '" + dtBDay.Value.ToString("yyyy-MM-dd")
                    + "', Address = '" + wfLogIn.sNewValue
                    + "', bookrateid = '" + sBookRateID
                    + "', connum = '" + txtConNum.Text
                    + "' where id = '" + ucBorrower.sID + "'";
                wfLogIn.v();
            }
            Close();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        String sBookRateID;
        private void cbBorrowerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT bookrateid FROM bookrate where borrowertype = '" + cbBorrowerType.Text + "'";
            wfLogIn.v();
            sBookRateID = wfLogIn.table.Rows[0][0].ToString();
        }

        private void txtConNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtConNum;
            wfLogIn.vKeyNumbers(e);
        }
    }
}