using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BPCHS___Library_Management_System
{
    public partial class wfLogIn : Form
    {
        public static MySqlConnection cn = new MySqlConnection("server = localhost; username = root; database = bpchsls");
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static MySqlCommand cmd;
        public static MySqlDataReader rd;
        public static DataTable table;
        public static DataTable dg1;
        public static string q;
        public static void v()
        {
            table = new DataTable();
            da.SelectCommand = new MySqlCommand(q, cn);
            da.Fill(table);
        }
        public wfLogIn()
        {
            InitializeComponent();
        }
        public static String StaffID;
        public static String sGName;
        public static String sPassword;
        public static String sMName;
        public static String sLName;
        public static String SType;
        public static String SStatus;
        public static String SecurityQuestion;
        public static String SecurityAnswer;
        public static String sContactNo;
        public static String sDateRegister;
        public static String sUserName;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length < 6 || txtUserName.Text.Length > 20)
            {
                MessageBox.Show("Username must be at least 6 to 20 characters.", "Invalid username");
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Length < 6 || txtPassword.Text.Length > 20)
            {
                MessageBox.Show("Password must be at least 6 to 20 characters.", "Invalid password");
                txtPassword.Focus();
            }
            else
            {//             StaffID, GName, Password, MName, LName, SType, SStatus, SecurityQuestion, SecurityAnswer, Contact No, DateRegister, UserNamee
                q = "SELECt StaffID, GName, Password, MName, LName, SType, SStatus, SecurityQuestion, SecurityAnswer, `Contact No`, DateRegister, UserName FROM staff where (UserName ='" + txtUserName.Text + "' and password = '" + txtPassword.Text + "')";
                wfLogIn.v();
                if (table.Rows.Count > 0)
                {
                    StaffID = table.Rows[0][0].ToString();
                    sGName = table.Rows[0][1].ToString();
                    sPassword = table.Rows[0][2].ToString();
                    sMName = table.Rows[0][3].ToString();
                    sLName = table.Rows[0][4].ToString();
                    SType = table.Rows[0][5].ToString();
                    SStatus = table.Rows[0][6].ToString();
                    SecurityQuestion = table.Rows[0][7].ToString();
                    SecurityAnswer = table.Rows[0][8].ToString();
                    sContactNo = table.Rows[0][9].ToString();
                    sDateRegister = table.Rows[0][10].ToString();
                    sUserName = table.Rows[0][11].ToString();
                    if (txtPassword.Text + txtUserName.Text == sPassword + sUserName)
                    {
                        if (SStatus == "Active")
                        {
                            string sLogIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            q = "SELECT logid FROM loghistory where login like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
                            v();

                            q = "insert into loghistory values ('" + "L-" + DateTime.Now.ToString("yyyy-MM-") + (table.Rows.Count + 1).ToString("d5")
                                + "','" + StaffID
                                + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                + "',null)";
                            v();
                            Hide();
                            wfHome f = new wfHome();
                            f.WindowState = FormWindowState.Maximized;
                            f.ShowDialog();
                            Show();
                            q = "update loghistory set logout = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                + "' where staffid = '" + StaffID + "' and login = '" + sLogIn + "'";
                            v();
                        }
                        else
                        {
                            MessageBox.Show("Your account is currently block. Please contact your adminstrator.", "Blocked Account");
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.", "Invalid Log - In");
                        linkLabel1.Visible = true;
                        txtUserName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Invalid Log - In");
                    linkLabel1.Visible = true;
                    txtUserName.Focus();
                }
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wfForgotPassword f = new wfForgotPassword();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            button1_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static TextBox txtToolTipText;
        public static void vKeyLettersAndSpace(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 65 && e.KeyChar <= 90)
                || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nA - Z (Lower and Uppercase)\nSpace", txtToolTipText);
            }
        }

        public static String[] sArrayAddress;
        public static String sOldValue;
        public static String sNewValue;
        public static void vAllowSingleQuote()
        {
            sNewValue = "";
            sArrayAddress = sOldValue.Split('\'');
            for (int a = 0; a < sArrayAddress.Length; a++)
            {
                if (a < sArrayAddress.Length - 1)
                    sNewValue += sArrayAddress[a].ToString() + "\\'";
                else
                    sNewValue += sArrayAddress[a].ToString();
            }
        }

        public static void vKeyLetters(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 65 && e.KeyChar <= 90)
                || e.KeyChar == 8)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nA - Z (Lower and Uppercase)", txtToolTipText);
            }
        }
        public static void vKeyNumbers(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 48 && e.KeyChar <= 57)
                || e.KeyChar == 8)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nNumbers)", txtToolTipText);
            }
        }
        public static void vKeyNumbersAndPeriod(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if (((e.KeyChar >= 48 && e.KeyChar <= 57)
                || e.KeyChar == 8) || (e.KeyChar == 46) && (txtToolTipText.Text.IndexOf(',') == -1))
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nNumbers)", txtToolTipText);
            }
        }
        public static ToolTip tt = new ToolTip();
        public static void vKeyLettersAndNumbers(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 65 && e.KeyChar <= 90)
                || (e.KeyChar >= 48 && e.KeyChar <= 57)
                || e.KeyChar == 8 || e.KeyChar == 95)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nLetters from A - Z (Lower and Uppercase)\nNumbers", txtToolTipText);
            }
        }
        public static void vKeysOthers(KeyPressEventArgs e)
        {// @ # space ' letters numbers & ( ) / . ,
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 64 && e.KeyChar <= 90)
                || (e.KeyChar >= 44 && e.KeyChar <= 57)
                || e.KeyChar == 8 || e.KeyChar == 32
                || e.KeyChar == 35 || (e.KeyChar >= 38
                && e.KeyChar <= 41))
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nLetters from A - Z (Lower and Uppercase)"
                    + "\nNumbers\n@ / % ' & ( ) , . -", txtToolTipText);
            }
        }
        public static void vKeysToolStripOtherKeys(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 64 && e.KeyChar <= 90)
                || (e.KeyChar >= 44 && e.KeyChar <= 57)
                || e.KeyChar == 8 || e.KeyChar == 32
                || e.KeyChar == 35 || (e.KeyChar >= 38
                && e.KeyChar <= 41))
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nLetters from A - Z (Lower and Uppercase)"
                    + "\nNumbers\n@ / % ' & ( ) , . -", tsTxt);
            }
        }
        public static void vKeysToolStripvKeyLettersAndNumbers(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 65 && e.KeyChar <= 90)
                || (e.KeyChar >= 48 && e.KeyChar <= 57)
                || e.KeyChar == 8)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nLetters from A - Z (Lower and Uppercase)\nNumbers", tsTxt);
            }
        }

        public static void vKeysToolStripvKeyLettersAndSpace(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 65 && e.KeyChar <= 90)
                || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nA - Z (Lower and Uppercase)\nSpace", tsTxt);
            }
        }
        public static void vKeysToolStripvKeyLetters(KeyPressEventArgs e)
        {
            tt.RemoveAll();
            if ((e.KeyChar >= 97 && e.KeyChar <= 122)
                || (e.KeyChar >= 65 && e.KeyChar <= 90)
                || e.KeyChar == 8)
                e.Handled = false;
            else
            {
                e.Handled = true;
                tt.Show("The accepted keys are the following.\nA - Z (Lower and Uppercase)", tsTxt);
            }
        }
        public static ToolStrip tsTxt = new ToolStrip();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}