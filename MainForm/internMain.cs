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
    public partial class internMain : Form
    {
        String internName;
        int internID;

        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        MySqlDataReader reader;

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

                String query = "select distinct patient_id, symptom from patient_symptom where diagnose_status = 0";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_patientSymptom");
                dt = ds.Tables["Tbl_patientSymptom"];
                patientSymptomDGV.DataSource = ds;
                patientSymptomDGV.DataMember = "Tbl_patientSymptom";

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void getInternID()
        {
            try
            {
                connectDatabase();

                String query = "select intern_id from intern where intern_name = '" + internName +"'";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    internID = (int)reader.GetValue(0);
                    break;
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        public internMain(String name)
        {
            InitializeComponent();
            internName = name;
            fillInDGV();
            getInternID();
            internIDL.Text += " " + internID;
        }

        private void diagnoseB_Click(object sender, EventArgs e)
        {
            internDiagnose iD = new internDiagnose(internID);
            iD.Show();
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            fillInDGV();
        }
    }
}
