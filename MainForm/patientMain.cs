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
    public partial class patientMain : Form
    {
        int patID;

        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataSet ds;
        DataTable dt;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        public patientMain(int id)
        {
            InitializeComponent();
            patID = id;
            initialization();
            fillInDGV();
            medicineBill();
            testBill();
        }

        private void fillInDGV()
        {
            try
            {
                connectDatabase();

                String query = "select bill_id,bill_amount from bill where patient_id = " + patID;
                query += " and bill_id in (select distinct bill_id from medicine_bill)";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_medicineBill");
                dt = ds.Tables["Tbl_medicineBill"];
                medicineBillsDGV.DataSource = ds;
                medicineBillsDGV.DataMember = "Tbl_medicineBill";

                query = "select bill_id,bill_amount from bill where patient_id = " + patID;
                query += " and bill_id in (select distinct bill_id from test_bill)";
                comm = new MySqlCommand(query, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_testBill");
                dt = ds.Tables["Tbl_testBill"];
                testBillsDGV.DataSource = ds;
                testBillsDGV.DataMember = "Tbl_testBill";

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }
        }

        private void medicineBill()
        {
            String total = "0";
            try
            {
                connectDatabase();

                String query = "select patient_id, sum(bill_amount) from bill where patient_id = " + patID;
                query += " and bill_id in (select distinct bill_id from medicine_bill) group by patient_id";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    total = "" + reader.GetValue(1);
                    break;
                }

                conn.Close();
                totalMedL.Text = "Total Medicine Bill: " + total;
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void testBill()
        {
            String total = "0";
            try
            {
                connectDatabase();

                String query = "select patient_id, sum(bill_amount) from bill where patient_id = " + patID;
                query += " and bill_id in (select distinct bill_id from test_bill) group by patient_id";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    total = "" + reader.GetValue(1);
                    break;
                }

                conn.Close();
                totalTestBillL.Text = "Total Test Bill: " + total;
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void initialization ()
        {
            try
            {
                connectDatabase();

                String query = "call total_medicine_amount (" + patID + ")";
                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Part One Achieved", "Update");
                }

                query = "call total_test_amount ( " + patID + ")";
                comm = new MySqlCommand(query, conn);
                returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Part Two Achieved", "Update");
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
