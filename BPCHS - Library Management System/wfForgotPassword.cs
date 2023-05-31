using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfForgotPassword : Form
    {
        int ho = 0;
        public wfForgotPassword()
        {
            InitializeComponent();
        }
        string sSecAns, sPassword;
        private void button2_Click(object sender, EventArgs e)
        {
            ho++;
            if (ho == 2)
            {
                this.AcceptButton = bnCon2;
            }
            if (txtUsername.Enabled == false)
            {
                if (sSecAns.ToUpper() == txtSecAns.Text.ToUpper())
                {
                    AcceptButton = bnCon2;
                    panel1.Enabled = false;
                    panel2.Visible = true;
                    txtNewPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Your Security Answer didn't match", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                wfLogIn.q = "SELECT password, securityquestion,securityanswer FROM staff where username = '" + txtUsername.Text + "'";
                wfLogIn.v();
                if (wfLogIn.table.Rows.Count != 0)
                {
                    AcceptButton = bnCon1;
                    sPassword = wfLogIn.table.Rows[0][wfLogIn.table.Columns[0], DataRowVersion.Current].ToString();
                    lbSecQues.Text = wfLogIn.table.Rows[0][wfLogIn.table.Columns[1], DataRowVersion.Current].ToString();
                    sSecAns = wfLogIn.table.Rows[0][wfLogIn.table.Columns[2], DataRowVersion.Current].ToString();
                    txtUsername.Enabled = false;
                    lbSA.Visible = true;
                    lbSecQues.Visible = true;
                    lbSQ.Visible = true;
                    txtSecAns.Visible = true;
                    txtSecAns.Focus();
                }
                else
                {
                    MessageBox.Show("Username does not exist!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your password is (" + sPassword + ")", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length < 5)
            {
                MessageBox.Show("New password must be at least 6 characters", "Character is too short");
                txtNewPassword.Focus();
            }
            else if (txtRetypePassword.Text.Length < 5)
            {
                MessageBox.Show("Retype - password must be at least 6 characters", "Character is too short");
                txtRetypePassword.Focus();
            }
            else if (txtRetypePassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("New password and re-type password did not match", "Password didn't match");
                txtNewPassword.Clear();
                txtRetypePassword.Clear();
                txtNewPassword.Focus();
            }
            else
            {
                wfLogIn.q = "update staff set password = '" + txtNewPassword.Text + "' where username = '" + txtUsername.Text + "'";
                wfLogIn.v();
                MessageBox.Show("Password has been successfully change.", "Password Change");
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}