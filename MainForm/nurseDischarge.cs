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
    public partial class nurseDischarge : Form
    {

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
                String query = "select patient_id, admit_date from discharge where discharge_date is NULL";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_admittedPatients");
                dt = ds.Tables["Tbl_admittedPatients"];
                patientsDGV.DataSource = ds;
                patientsDGV.DataMember = "Tbl_admittedPatients";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }


        public nurseDischarge()
        {
            InitializeComponent();
            fillInDGV();
        }

        private void dischargeB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();

                int patient_id = Int32.Parse(patientIDTB.Text);
                String discharge_date = dischargeDateTB.Text;

                String query = "update discharge set discharge_date = '" + discharge_date + "' where patient_id = " + patient_id + " and discharge_date is null";
                comm = new MySqlCommand(query, conn);

                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Updated Succesfully", "Information");
                    query = "update room set patient_id = NULL where patient_id = " + patient_id;
                    comm = new MySqlCommand(query, conn);
                    returnValue = comm.ExecuteNonQuery();
                    if (returnValue >= 0)
                    {
                        MessageBox.Show("Rooms have been updated successfully.", "Information");
                        fillInDGV();
                    }
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
