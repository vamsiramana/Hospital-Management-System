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
    public partial class nurseMain : Form
    {
        String nurseName;



        public nurseMain(String name)
        {
            InitializeComponent();
            nurseName = name;
            nurseNameL.Text = nurseNameL.Text + name;
        }

        private void checkB_Click(object sender, EventArgs e)
        {
            nurseCheckPatient nCP = new nurseCheckPatient();
            nCP.Show();
        }

        private void allotRoomB_Click(object sender, EventArgs e)
        {
            nurseAllotRoom nAR = new nurseAllotRoom();
            nAR.Show();
        }

        private void dischargeB_Click(object sender, EventArgs e)
        {
            nurseDischarge nD = new nurseDischarge();
            nD.Show();
        }

        private void scheduleB_Click(object sender, EventArgs e)
        {
            nurseSchedule nS = new nurseSchedule(nurseName);
            nS.Show();
        }

        private void allPatientsB_Click(object sender, EventArgs e)
        {
            nurseViewAllPatients nVAP = new nurseViewAllPatients();
            nVAP.Show();
        }
    }
}
