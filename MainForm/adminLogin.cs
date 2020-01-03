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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String passwordEntered = keyTB.Text;
            if (passwordEntered.Equals("plausible"))
            {
                adminMain aM = new adminMain();
                aM.Show();
                this.Close();
            }
            else
            {
                keyTB.Text = "";
                MessageBox.Show("Invalid Password", "Error Message");
            }
        }
    }
}
