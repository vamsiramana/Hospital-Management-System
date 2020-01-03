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
    

    public partial class docPrescribeMed : Form
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

                query = "select * from medicine";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_medicine");
                dt = ds.Tables["Tbl_medicine"];
                medicinesDGV.DataSource = ds;
                medicinesDGV.DataMember = "Tbl_medicine";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }
          

        }
            

        public docPrescribeMed(int id)
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

                String query = "select m_prescription_id from medicine_prescription order by m_prescription_id desc";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    prescription = (int)reader.GetValue(0);
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
            int medID = Int32.Parse(medIDTB.Text);
            try
            {
                connectDatabase();
                String command = "insert into medicine_prescription values(" + prescription + "," + docID + ",";
                command += medID + "," + pID + ", 0)";
                comm = new MySqlCommand(command, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Prescribed successfully", "Update");
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }
        }
    }
}
