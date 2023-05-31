using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfDeweySet : Form
    {
        public wfDeweySet()
        {
            InitializeComponent();
        }
        private void wfDeweySet_Load(object sender, EventArgs e)
        {
            txtClass.Text = wfBookClassification.sClass;
            txtFrom.Text = wfBookClassification.sFrom;
            txtTo.Text = wfBookClassification.sTo;
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (txtClass.Text == "")
            {

            }
            else
            {
                wfLogIn.q = "update class = '" + txtClass.Text
                    + "' where id = '" + wfBookClassification.sID + "'";
                wfLogIn.v();
            }
        }
    }
}