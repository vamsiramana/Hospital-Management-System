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
    public partial class adminMain : Form
    {
        String query;
        int option;

        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void databaseConnection()
        {
            String oradb = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(oradb);
            conn.Open();
        }

        public adminMain()
        {
            InitializeComponent();
            option = 1;
            query = "";
            comboboxEntries();
        }

        private void runB_Click(object sender, EventArgs e)
        {
            if (query.Equals(""))
            {
                MessageBox.Show("Empty Query", "Error");
                return;
            }

            databaseConnection();
            if (option == 1)
            {
                try
                {
                    comm.CommandText = query;
                    comm.CommandType = CommandType.Text;
                    ds = new DataSet();
                    da = new MySqlDataAdapter(comm.CommandText, conn);
                    da.Fill(ds, "Tbl_select");
                    dt = ds.Tables["Tbl_select"];
                    selectQueryDGV.DataSource = ds;
                    selectQueryDGV.DataMember = "Tbl_select";
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error in Query ", "Error");
                    MessageBox.Show(""+E, "Exception Handled");
                }
            }
            else
            {
                try
                {
                    comm = new MySqlCommand(query, conn);
                    int returnValue = comm.ExecuteNonQuery();
                    MessageBox.Show(returnValue + " Returned", "Status");
                    comboboxEntries();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error in Query ", "Error");
                    MessageBox.Show("" + E, "Exception Handled");
                }
            }
            conn.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            query = queryTB.Text;
        }

        private void selectRB_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
        }

        private void notSelectRB_CheckedChanged(object sender, EventArgs e)
        {
            option = 2;
        }

        private void comboboxEntries()
        {
            if (tableNamesdB.Items.Count > 0)
            {
                tableNamesdB.Items.Clear();
            }

            databaseConnection();
            String command = "show tables";
            comm = new MySqlCommand(command, conn);
            MySqlDataReader reader;
            reader = comm.ExecuteReader();
            
            while (reader.Read())
            {
                tableNamesdB.Items.Add(reader[0].ToString());
            }

            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryTB.Text = "";
            tableNamesdB.SelectedIndex = -1;
        }
    }
}
