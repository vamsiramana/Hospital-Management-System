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
    public partial class patientLoginForm : Form
    {
        public patientLoginForm()
        {
            InitializeComponent();
        }

        private void oldB_Click(object sender, EventArgs e)
        {
            patientOldLoginForm pOLF = new patientOldLoginForm();
            pOLF.Show();
        }

        private void newB_Click(object sender, EventArgs e)
        {
            patientNewLoginForm pNLF = new patientNewLoginForm();
            pNLF.Show();
        }
    }
}
