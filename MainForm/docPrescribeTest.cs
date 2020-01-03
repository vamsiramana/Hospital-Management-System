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
    public partial class docPrescribeTest : Form
    {
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        MySqlDataReader reader;

        int docID;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        private void fillDataGrids()
        {
            try
            {
                connectDatabase();
                String query = "select distinct patient_id, symptom from patient_symptom where diagnose_status = 1 ";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_patientSymptom");
                dt = ds.Tables["Tbl_patientSymptom"];
                patientsDGV.DataSource = ds;
                patientsDGV.DataMember = "Tbl_patientSymptom";

                query = "select * from test";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_test");
                dt = ds.Tables["Tbl_test"];
                testsDGV.DataSource = ds;
                testsDGV.DataMember = "Tbl_test";

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }


        public docPrescribeTest(int id)
        {
            InitializeComponent();
            fillDataGrids();
            docID = id;
        }

        int prescription = 0;
        private void getPrescriptionNo()
        {
            try
            {
                connectDatabase();

                String query = "select t_prescription_id from test_prescription order by t_prescription_id desc";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    prescription = (int) reader.GetValue(0);
                    break;
                }
                prescription += 1;

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Ecountered");
                conn.Close();
            }
        }

        private void prescribeB_Click(object sender, EventArgs e)
        {
            getPrescriptionNo();
            int pID = Int32.Parse(patIDTB.Text);
            int testID = Int32.Parse(testIDTB.Text);
            try
            {
                connectDatabase();
                String command = "insert into test_prescription values(" + prescription + "," + docID + ",";
                command += testID + "," + pID + ", 0)";
                comm = new MySqlCommand(command, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Prescribed Succesfully", "Update");
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
