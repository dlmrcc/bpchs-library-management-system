using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class User_Setting : Form
    {
        public User_Setting()
        {
            InitializeComponent();
        }

        private void User_Setting_Load(object sender, EventArgs e)
        {
            if (ucUser.sSave == "Edit")
            {
                txtUsername.Text = wfLogIn.sUserName;
                txtPassword.Text = wfLogIn.sPassword;
                txtRetypePassword.Text = wfLogIn.sPassword;
                txtGivenName.Text = wfLogIn.sGName;
                txtLastName.Text = wfLogIn.sLName;
                txtMiddleName.Text = wfLogIn.sMName;
                txtSecurityAnswer.Text = wfLogIn.SecurityAnswer;
                cbSecurityQuestion.Text = wfLogIn.SecurityQuestion;
                txtContactNumber.Text = wfLogIn.sContactNo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show("Password and re-type password didn't match"
                    , "Did not match"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
            else
            {
                if (txtUsername.Text.Length < 5)
                {
                    MessageBox.Show("Password must be at least 6 character"
                        , "Password is too short"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }
                else if (txtPassword.Text.Length < 5)
                {
                    MessageBox.Show("Password must be at least 6 character"
                          , "Password is too short"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }
                else if (txtRetypePassword.Text.Length < 5)
                {
                    MessageBox.Show("Re-type Password must be at least 6 character"
                        , "Re-type Password is too short"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }
                else if (txtGivenName.Text == "")
                {
                    MessageBox.Show("Firstname must not be empty"
                        , "Firstname is empty"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }
                else if (txtLastName.Text == "")
                {
                    MessageBox.Show("Firstname must not be empty"
                      , "Lastname is empty"
                      , MessageBoxButtons.OK
                      , MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }
                else if (txtContactNumber.Text == "")
                {
                    MessageBox.Show("Contact number must not be empty"
                       , "Contact number is empty"
                       , MessageBoxButtons.OK
                       , MessageBoxIcon.Exclamation);
                    txtContactNumber.Focus();
                }
                else if (cbSecurityQuestion.Text == "")
                {
                    MessageBox.Show("Please select at least one Security Question"
                        , "Select security question"
                          , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    cbSecurityQuestion.Focus();
                }
                else if (txtSecurityAnswer.Text == "")
                {
                    MessageBox.Show("security Question must be empty"
                        , "Security question is empty"
                          , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    txtSecurityAnswer.Focus();
                }
                else
                {
                    if (ucUser.sSave == "Add")
                    {
                        wfLogIn.q = "SELECT staffid FROM staff where username ='" + txtUsername.Text
                            + "'or concat(gname,' ',mname,' ',lname) ='" + txtGivenName + " " + txtLastName.Text + "'";
                        wfLogIn.v();
                        if (wfLogIn.table.Rows.Count != 0)
                        {
                            MessageBox.Show("Username or Fullname is already exist!"
                                , "Already exist"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                            txtUsername.Focus();
                        }
                        else
                        {
                            vUserID();
            //     0    1       2         3     4       5      6            7                   8               9       10           11 
            //StaffID, GName, Password, MName, LName, SType, SStatus, SecurityQuestion, SecurityAnswer, Contact No, DateRegister, UserName
                            wfLogIn.q = "Insert into staff values ('" + sUserID
                                + "','" + txtGivenName.Text
                                + "','" + txtPassword.Text
                                + "','" + txtMiddleName.Text
                                + "','" + txtLastName.Text
                                + "','" + "Staff"
                                + "','" + "Active"
                                + "','" + cbSecurityQuestion.Text
                                + "','" + txtSecurityAnswer.Text
                                + "','" + txtContactNumber.Text
                                + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                                + "','" + txtUsername.Text
                                + "')";
                            wfLogIn.v();
                            MessageBox.Show("Adding Successful");
                        }
                    }
                    else
                    {
                        wfLogIn.q="select username, concat(`GName`,' ',`MName`,' ',`LName`)FROM staff where username='"
                            +txtUsername.Text+"'or concat(gName,'',LName)='"
                            +txtGivenName.Text +" "+txtLastName.Text +"'";
                        wfLogIn.v();
                        dbUsername=wfLogIn.table.Rows[0][wfLogIn.table.Columns[0],DataRowVersion.Current].ToString();
                        dbFullname=wfLogIn.table.Rows[0][wfLogIn.table.Columns[0],DataRowVersion.Current].ToString();
                        if (dbUsername.ToUpper() == txtUsername.Text.ToUpper())
                        {
                            vEdit();
                        }
                        else
                        {
                            if (wfLogIn.table.Rows.Count != 0)
                            {
                              MessageBox.Show("Username or Fullname is already exist!"
                                    ,"Already exist"
                                    ,MessageBoxButtons.OK
                                    ,MessageBoxIcon.Information);
                                txtUsername.Focus();
                            }
                            else
                            {
                                vEdit();
                            }
                        }
                    }
                }
            }
        }
        string dbUsername, dbFullname;
        
        void vEdit()
        {
            wfLogIn.q = "update staff set GName = '" + txtGivenName.Text
                 + "', Password = '" + txtPassword.Text
                 + "', MName = '" + txtMiddleName.Text
                 + "', LName = '" + txtLastName.Text
                 + "', SecurityQuestion = '" + cbSecurityQuestion.Text
                 + "', SecurityAnswer = '" + txtSecurityAnswer.Text
                 + "', `Contact No` = '" + txtContactNumber.Text
                 + "', UserName = '" + txtUsername.Text
                 + "' where StaffID = '" + wfLogIn.StaffID + "'";
            wfLogIn.v();
            wfLogIn.sContactNo = txtContactNumber.Text;
            wfLogIn.SecurityAnswer = cbSecurityQuestion.Text;
            wfLogIn.SecurityQuestion = txtSecurityAnswer.Text;
            wfLogIn.sGName = txtGivenName.Text;
            wfLogIn.sLName = txtLastName.Text;
            wfLogIn.sMName = txtMiddleName.Text;
            wfLogIn.sPassword = txtPassword.Text;
            wfLogIn.sUserName = txtUsername.Text;
            MessageBox.Show("Editing is successful");
        }
        int iUserID;
        string sUserID;
        void vUserID()
        {
            wfLogIn.q = "SELECT staffid FROM staff where dateregister like '" + DateTime.Now.ToString("yyyy") + "%'";
            wfLogIn.v();
            iUserID = wfLogIn.table.Rows.Count + 1;
            sUserID = "S-" + DateTime.Now.ToString("yyyy-") + iUserID.ToString("d4");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSecurityQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtContactNumber;
            wfLogIn.vKeyNumbers(e);
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        //}
    }
}
