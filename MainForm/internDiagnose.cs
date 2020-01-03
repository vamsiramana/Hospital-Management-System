using MySql.Data.MySqlClient;
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
    public partial class internDiagnose : Form
    {
        int internID;

        MySqlConnection conn;
        MySqlCommand comm;

        public internDiagnose(int ID)
        {
            InitializeComponent();
            internID = ID;
        }

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            String patientID = patientIDTB.Text;
            String oldSymptom = oldSymptomTB.Text;
            String diagnosis = diagnosisTB.Text;
            int flag = 0;
            try
            {
                connectDatabase();

                String query = "call update_symptom (" + patientID + ",'" + oldSymptom + "', '" + diagnosis + "')";

                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue > 0)
                {
                    flag = 1;
                    MessageBox.Show("Updated Diagnosis.", "Update");
                }
                if (flag == 0)
                {
                    MessageBox.Show("No such entry found.", "Information");
                    conn.Close();
                    return;
                }
                query = "update patient set intern_id = " + internID + " where patient_id = " + patientID;
                comm = new MySqlCommand(query, conn);
                returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Patient Records Updated.", "Update");
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }
    }
}
