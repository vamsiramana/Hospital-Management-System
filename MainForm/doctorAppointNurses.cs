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
    public partial class doctorAppointNurses : Form
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
                String treatment_date = dateTB.Text;
                String query = "select nurse_id from nurse where nurse_id not in (select nurse_id from assist where treatment_date = '" + treatment_date +"')";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_availableNurses");
                dt = ds.Tables["Tbl_availableNurses"];
                availableNursesDGV.DataSource = ds;
                availableNursesDGV.DataMember = "Tbl_availableNurses";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }

        }


        public doctorAppointNurses(int id)
        {
            InitializeComponent();
            docID = id;
        }

        private void appointB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                int nurse_id = Int32.Parse(nurseIDTB.Text);
                String treatment_date = dateTB.Text;
                String query = "insert into assist values (" + docID + "," + nurse_id + "," + "'" + treatment_date + "')";
                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Updated Succesfully", "Information");
                }                       
                conn.Close();
            }
            catch(Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void findB_Click(object sender, EventArgs e)
        {
            fillInDGV();
        }
    }
}
