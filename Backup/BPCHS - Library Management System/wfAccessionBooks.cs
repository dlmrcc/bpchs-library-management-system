using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfAccessionBooks : Form
    {
        public wfAccessionBooks()
        {
            InitializeComponent();
        }
        void vTitle()
        {
            cbTitle.Items.Clear();
            wfLogIn.q = "SELECT distinct title FROM book order by title";
            wfLogIn.v();
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
                cbTitle.Items.Add(wfLogIn.table.Rows[a][0]);
        }
        void vEdition()
        {
            cbEd.Items.Clear();
            wfLogIn.q = "SELECT distinct edition FROM book order by edition";
            wfLogIn.v();
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
                cbEd.Items.Add(wfLogIn.table.Rows[a][0]);
        }
        void vPublisher()
        {
            cbPub.Items.Clear();
            wfLogIn.q = "SELECT distinct publisher FROM book order by publisher";
            wfLogIn.v();
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
                cbPub.Items.Add(wfLogIn.table.Rows[a][0]);
        }
        void vSource()
        {
            cbSFund.Items.Clear();
            wfLogIn.q = "SELECT distinct source FROM book order by source";
            wfLogIn.v();
            for (int a = 0; a < wfLogIn.table.Rows.Count; a++)
                cbSFund.Items.Add(wfLogIn.table.Rows[a][0]);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (ucBook.sSaveBook == "Edit")
            {
                cbAvailability.Enabled = false;
                cbClass.Enabled = false;
                wfLogIn.q = "SELECT copy FROM book where title = '" + ucBook.stitle + "' order by copy desc limit 1";
                wfLogIn.v();
                txtDuration.Text = ucBook.sduration;
                txtPrice.Text = ucBook.sprice;
                txtAuthor.Text = ucBook.sauthor;
                txtClass.Text = ucBook.sclassno;
                tbCopy.Text = "1 - " + wfLogIn.table.Rows[0][0].ToString(); ;
                tbCR.Text = ucBook.scopyright;
                cbEd.Text = ucBook.sedition;
                cbPub.Text = ucBook.spublisher;
                cbSFund.Text = ucBook.ssource;
                cbTitle.Text = ucBook.stitle;
                cbClass.Text = ucBook.sclass;
                cbAvailability.Text = ucBook.savail;
                tbCopy.Enabled = false;
            }
            vTitle();
            vSource();
            vPublisher();
            vEdition();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void bnSave_Click(object sender, EventArgs e)
        {
            if (cbTitle.Text.Length < 6 || cbTitle.Text.Length > 100)
            {
                MessageBox.Show("Book Title Must be at least 6 to 100 characters.", "Invalid Title");
                cbTitle.Focus();
            }
            else if (Convert.ToDouble(txtClass.Text) < 0 || Convert.ToDouble(txtClass.Text) > 1000)
            {
                MessageBox.Show("Classification Number must be at least 0 to 999", "Invalid Classification Number");
                txtClass.Focus();
            }
            else if (tbCopy.Text == "")
            {
                MessageBox.Show("Copy must not be empty", "Invalid Copy");
                txtClass.Focus();
            }
            else
            {
                if (ucBook.sSaveBook == "Add")
                {
                    int accepted = 0;
                    for (int a = 1; a < Convert.ToInt32(tbCopy.Text) + 1; a++)
                    {
                        wfLogIn.q = "select accno from book where concat(title,copy) = '" + cbTitle.Text + a + "'";
                        wfLogIn.v();
                        if (wfLogIn.table.Rows.Count == 0)
                        {
                            accepted++;
                            wfLogIn.q = "insert into book values (null,'" + dtDateAcq.Value.ToString("yyyy-MM-dd")
                                + "','" + txtClass.Text
                                + "','" + cbTitle.Text
                                + "','" + a
                                + "','" + cbEd.Text
                                + "','" + tbCR.Text
                                + "','" + cbPub.Text
                                + "','" + cbSFund.Text
                                + "','" + txtPrice.Text
                                + "','" + txtAuthor.Text
                                + "','" + cbClass.Text
                                + "','" + cbAvailability.Text
                                + "','" + txtDuration.Text + "')";
                            wfLogIn.v();
                        }
                    }
                    MessageBox.Show(accepted + " copies of " + cbTitle.Text + " has been successfully added");
                }
                else
                {
                    wfLogIn.q = "update book set classno = '" + txtClass.Text
                        + "', title = '" + cbTitle.Text
                        + "', edition = '" + cbEd.Text
                        + "', copyright = '" + tbCR.Text
                        + "', publisher = '" + cbPub.Text
                        + "', source = '" + cbSFund.Text
                        + "', price = '" + txtPrice.Text
                        + "', author = '" + txtAuthor.Text
                        + "', duration = '" + txtDuration.Text
                        + "' where title = '" + ucBook.stitle + "'";
                    wfLogIn.v();
                }
                Close();
            }
        }
        private void bnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void tbCopy_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = tbCopy;
            wfLogIn.vKeyNumbers(e);
        }

        private void txtClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtClass;
            wfLogIn.vKeyNumbers(e);
        }

        private void tbCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = tbCR;
            wfLogIn.vKeyNumbers(e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtPrice;
            wfLogIn.vKeyNumbers(e);
        }
    }
}