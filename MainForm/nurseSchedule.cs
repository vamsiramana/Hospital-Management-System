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
    public partial class nurseSchedule : Form
    {
        String nurseName;
        int nurseID;

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

        private void getNurseID()
        {
            try
            {
                connectDatabase();
                String query = "select nurse_id from nurse where nurse_name = '" + nurseName + "'";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    nurseID = (int)reader["nurse_id"];
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }
        }

        private void fillInDGV()
        {
            try
            {
                connectDatabase();
                String query = "select doctor_id, treatment_date from assist where nurse_id = " + nurseID;
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_dates");
                dt = ds.Tables["Tbl_dates"];
                datesDGV.DataSource = ds;
                datesDGV.DataMember = "Tbl_dates";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
            }
        }

        public nurseSchedule(String name)
        {
            InitializeComponent();
            nurseName = name;
            getNurseID();
            iDL.Text = iDL.Text + " " + nurseID;
            fillInDGV();
        }
    }
}
