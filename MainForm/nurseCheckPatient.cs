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
    public partial class nurseCheckPatient : Form
    {
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

        private void fillInDGV()
        {
            try 
            {
                connectDatabase();
                String query = "select * from room where patient_id is not NULL";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_roomsAndPatients");
                dt = ds.Tables["Tbl_roomsAndPatients"];
                roomsAndPatientsDGV.DataSource = ds;
                roomsAndPatientsDGV.DataMember = "Tbl_roomsAndPatients";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
            }
            
        }


        public nurseCheckPatient()
        {
            InitializeComponent();
            fillInDGV();
        }

        private void lookUpB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                patientDetailsRTB.Text = "";
                int patient_id = Int32.Parse(patientIDTB.Text);
                comm = new MySqlCommand("select * from patient where patient_id = " + patient_id, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    patientDetailsRTB.Text = " Patient ID: " + reader.GetValue(0);
                    patientDetailsRTB.Text += "\n Intern ID: " + reader.GetValue(1);
                    patientDetailsRTB.Text += "\n Patient Name:  " + reader.GetValue(2);
                    patientDetailsRTB.Text += "\n Patient Sex: " + reader.GetValue(3); 
                    patientDetailsRTB.Text += "\n Patient Age: " + reader.GetValue(4);
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            fillInDGV();
            MessageBox.Show("Refreshed.", "Notice");
        }
    }
}
