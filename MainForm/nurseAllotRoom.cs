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
    public partial class nurseAllotRoom : Form
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
                String query = "select room_id, ward_id from room where patient_id is NULL";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_availableRooms");
                dt = ds.Tables["Tbl_availableRooms"];
                availableRoomsDGV.DataSource = ds;
                availableRoomsDGV.DataMember = "Tbl_availableRooms";
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }


        public nurseAllotRoom()
        {
            InitializeComponent();
            fillInDGV();
        }

        private void allotB_Click(object sender, EventArgs e)
        {
            
            try
            {
                connectDatabase();

                //exit if there exists the same patient already.
                int pat_id = Int32.Parse(patientIDTB.Text);
                int room_id = Int32.Parse(roomIDTB.Text);
                String query = "select * from room where patient_id = " + pat_id;
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    //patient already alloted
                    MessageBox.Show("The patient has already been given a room", "Notice");
                    conn.Close();
                    return;
                }
                reader.Close();
                query = "update room set patient_id = " + pat_id + " where room_id = " + room_id;
                comm = new MySqlCommand(query, conn);
                int retval = comm.ExecuteNonQuery();
                if (retval >= 0)
                {
                    MessageBox.Show("Updated the rooms", "Notification");
                    fillInDGV();
                    updateDischargeTable(pat_id);
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered.");
                conn.Close();
            }
        }

        private void updateDischargeTable(int pat_id)
        {
            try
            {
                connectDatabase();
                String dated = "" ;
                String query = "select date (sysdate())";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    dated = "" + reader.GetValue(0);
                    int pos = dated.IndexOf(" ");
                    dated = dated.Substring(0, pos);
                    String[] datedlist = dated.Split('-');
                    dated = datedlist[2] + "-" + datedlist[1] + "-" + datedlist[0];
                    break;
                }
                reader.Close();

                query = "insert into discharge values (" + pat_id + ",'" + dated + "', NULL)";
                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Updated the admission date.", "Update");
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
