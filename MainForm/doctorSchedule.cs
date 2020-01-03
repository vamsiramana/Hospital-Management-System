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
    public partial class doctorSchedule : Form
    {
        int docID;

        public doctorSchedule(int id)
        {
            InitializeComponent();
            docID = id;
            fillInDGV();
        }

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
                String query = "select patient_id, treatment_date from treats where doctor_id = " + docID;
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_Ddates");
                dt = ds.Tables["Tbl_Ddates"];
                datesDGV.DataSource = ds;
                datesDGV.DataMember = "Tbl_Ddates";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
            }
        }
    }
}
