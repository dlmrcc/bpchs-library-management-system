using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfHollidays : Form
    {
        public wfHollidays()
        {
            InitializeComponent();
        }
        void vLoad()
        {
            wfLogIn.q = "SELECT dayid, actname `Activity`, actdate `Activity Date` FROM hollidays where sy = '" + cbSy.Text 
                + "' order by actdate";
            wfLogIn.v();
            dAct.DataSource = wfLogIn.table;
            dAct.Columns[0].Visible = false;
            dAct.Columns[1].Width = 346;
            dAct.Columns[2].Width = 487 - 345;
            dAct.Columns[2].DefaultCellStyle.Format = "MMM. dd, yyyy";
        }
        void vSchoolYear()
        {
            cbSy.Items.Clear();
            wfLogIn.q = "SELECT distinct sy FROM hollidays";
            wfLogIn.v();
            for (
                int a = 0;
                a < wfLogIn.table.Rows.Count;
                a++
            )
            {
                cbSy.Items.Add(wfLogIn.table.Rows[a][0]);
            }
        }
        private void wfHollidays_Load(object sender, EventArgs e)
        {
            vSchoolYear();
        }

        private void cbSy_SelectedIndexChanged(object sender, EventArgs e)
        {
            vLoad();
        }
        void vValiDate()
        {
            wfLogIn.q = "select dayid, actname from hollidays where actdate = '" + dtFrom.Value.AddDays(a).ToString("yyyy-MM-dd") + "'";
            wfLogIn.v();
        }
        string sSave;
        int a;
        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.Value = dtFrom.Value;
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
        }
        void vAdd()
        {
            TimeSpan ts = dtTo.Value - dtFrom.Value;
            int iSpan = (int)ts.TotalDays;
            if (dtFrom.Value == dtTo.Value)
            {
                if (dtFrom.Value.ToString("ddd") == "Sat" || dtFrom.Value.ToString("ddd") == "Sun")
                {

                }
                else
                {
                    vValiDate();
                    if (wfLogIn.table.Rows.Count == 0)
                    {
                        wfLogIn.q = "insert into hollidays values (null,'" + txtAct.Text
                                + "','" + dtFrom.Value.ToString("yyyy-MM-dd")
                                + "','" + cbSy.Text + "')";
                        wfLogIn.v();
                    }
                    else
                    {
                        MessageBox.Show(dtFrom.Value.ToString("MMM. dd, yyyy")
                            + " has already named for " + wfLogIn.table.Rows[0][1].ToString()
                            , "Holliday date has been already exist.");
                    }
                }
            }
            else
            {
                for (a = 0; a <= iSpan; a++)
                {
                    if (dtFrom.Value.AddDays(a).ToString("ddd") == "Sat" || dtFrom.Value.AddDays(a).ToString("ddd") == "Sun")
                    {

                    }
                    else
                    {
                        vValiDate();
                        if (wfLogIn.table.Rows.Count == 0)
                        {
                            wfLogIn.q = "insert into hollidays values (null,'" + txtAct.Text
                                  + "','" + dtFrom.Value.AddDays(a).ToString("yyyy-MM-dd")
                                  + "','" + cbSy.Text + "')";
                            wfLogIn.v();
                        }
                        else
                        {
                            MessageBox.Show(dtFrom.Value.AddDays(a).ToString("MMM. dd, yyyy")
                                + " has already named for " + wfLogIn.table.Rows[0][1].ToString()
                                , "Holliday date has been already exist.");
                        }
                    }
                }
            }
            vSchoolYear();
            vLoad();
        }
        private void bnSave_Click(object sender, EventArgs e)
        {
            if (txtAct.Text == "")
            {
                MessageBox.Show("Activity must not be empty.", "Invalid activity");
                txtAct.Focus();
            }
            else if (cbSy.Text == "")
            {
                MessageBox.Show("School Year must not be empty.", "Invalid School Year");
                cbSy.Focus();
            }
            else
            {
                if (sSave == "Add")
                {
                    vAdd();           
                }
                else
                {
                    wfLogIn.q = "delete from hollidays where actdate between '"+dtFrom.Value.ToString("yyyy-MM-dd")+"' and '"+dtTo.Value.ToString("yyyy-MM-dd")+"'";
                    wfLogIn.v();
                    vAdd();
                }
            }
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}