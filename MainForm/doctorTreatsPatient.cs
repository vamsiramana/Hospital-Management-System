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
    public partial class doctorTreatsPatient : Form
    {

        int docID;

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
                String treatment_date = treatmentTB.Text;
                String query = "select nurse_id, treatment_date from assist where doctor_id = '" + docID + "'";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_allotedNurses");
                dt = ds.Tables["Tbl_allotedNurses"];
                allotedNursesDGV.DataSource = ds;
                allotedNursesDGV.DataMember = "Tbl_allotedNurses";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }

        }

        public doctorTreatsPatient(int id)
        {
            InitializeComponent();
            docID = id;
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            fillInDGV();
        }

        private void fixB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                int patient_id = Int32.Parse(patientIDTB.Text);
                String treatment_date = treatmentTB.Text;
                String query = "insert into treats values (" + docID + "," + patient_id + "," + "'" + treatment_date + "')";
                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Updated Succesfully", "Information");
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
