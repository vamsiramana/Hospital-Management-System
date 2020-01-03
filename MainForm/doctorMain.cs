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
    public partial class doctorMain : Form
    {
        String docName;
        int docID;

        MySqlDataReader reader;
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        private void getID()
        {
            try
            {
                connectDatabase();
                String query = "select doctor_id from doctor where doctor_name = '" + docName + "'";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    docID = (int)reader["doctor_id"];
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }
        }

        public doctorMain(String name)
        {
            InitializeComponent();
            docName = name;
            MessageBox.Show("Welcome " + docName, "Hello.");
            getID();
            doctorNameL.Text = doctorNameL.Text + docName + "( " + docID + " )";
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewPatientsB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                String query = "select * from patient";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_patient");
                dt = ds.Tables["Tbl_patient"];
                patientsDGV.DataSource = ds;
                patientsDGV.DataMember = "Tbl_patient";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void prescribeMedB_Click(object sender, EventArgs e)
        {
            docPrescribeMed dPM = new docPrescribeMed(docID);
            dPM.Show();
        }

        private void prescribeTestB_Click(object sender, EventArgs e)
        {
            docPrescribeTest dPT = new docPrescribeTest(docID);
            dPT.Show();
        }

        private void appointNurseB_Click(object sender, EventArgs e)
        {
            doctorAppointNurses dAN = new doctorAppointNurses(docID);
            dAN.Show();
        }

        private void treatsB_Click(object sender, EventArgs e)
        {
            doctorTreatsPatient dTP = new doctorTreatsPatient(docID);
            dTP.Show();
        }

        private void patientSymptomB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                String query = "select distinct patient_id, symptom,diagnose_status from patient_symptom";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_patientSymptom");
                dt = ds.Tables["Tbl_patientSymptom"];
                patientsDGV.DataSource = ds;
                patientsDGV.DataMember = "Tbl_patientSymptom";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void admittedPatientsB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                String query = "select * from discharge where discharge_date is null";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_patient");
                dt = ds.Tables["Tbl_patient"];
                patientsDGV.DataSource = ds;
                patientsDGV.DataMember = "Tbl_patient";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void scheduleB_Click(object sender, EventArgs e)
        {
            doctorSchedule dS = new doctorSchedule(docID);
            dS.Show();
        }
    }
}
