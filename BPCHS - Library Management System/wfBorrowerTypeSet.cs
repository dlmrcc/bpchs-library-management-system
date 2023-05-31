using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    public partial class wfBorrowerTypeSet : Form
    {
        public wfBorrowerTypeSet()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            wfLogIn.q = "update borrowertype set type = '" + cbBorrowerType.Text
                + "', rate = '" + txtRate.Text
                + "', maximum = '" + txtValue.Text
                + "', finetype = '" + cbFinesType.Text
                + "', initialfines = '" + txtLimitDays.Text
                + "' where borrowertypeid = '" + wfBorrowerTypeSettings.sborrowertypeid + "'";
            wfLogIn.v();
            Close();
        }

        private void BorrowerTypeSet_Load(object sender, EventArgs e)
        {
            cbFinesType.Text = wfBorrowerTypeSettings.sfinetype;
            txtLimitDays.Text = wfBorrowerTypeSettings.sinitialfines;
            txtRate.Text = wfBorrowerTypeSettings.srate;
            txtValue.Text = wfBorrowerTypeSettings.svalue;
            cbBorrowerType.Text = wfBorrowerTypeSettings.stype;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtRate;
            wfLogIn.vKeyNumbers(e);
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtValue;
            wfLogIn.vKeyNumbers(e);
        }

        private void txtLimitDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            wfLogIn.txtToolTipText = txtLimitDays;
            wfLogIn.vKeyNumbers(e);
        }
    }
}