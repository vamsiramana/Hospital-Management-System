using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void adminB_Click(object sender, EventArgs e)
        {
            adminLogin aL = new adminLogin();
            aL.Show();
        }

        private void doctorB_Click(object sender, EventArgs e)
        {
            multiPurposeLoginForm mPLF = new multiPurposeLoginForm("doctorLogin");
            mPLF.Show();
        }

        private void nurseB_Click(object sender, EventArgs e)
        {
            multiPurposeLoginForm mPLF = new multiPurposeLoginForm("nurseLogin");
            mPLF.Show();
        }

        private void internB_Click(object sender, EventArgs e)
        {
            multiPurposeLoginForm mPLF = new multiPurposeLoginForm("internLogin");
            mPLF.Show();
        }

        private void pharmacistB_Click(object sender, EventArgs e)
        {
            multiPurposeLoginForm mPLF = new multiPurposeLoginForm("pharmacistLogin");
            mPLF.Show();
        }

        private void patientB_Click(object sender, EventArgs e)
        {
            patientLoginForm pLF = new patientLoginForm();
            pLF.Show();
        }
    }
}
