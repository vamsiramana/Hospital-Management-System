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
    public partial class pharmacistMain : Form
    {
        String pharmacistName;

        MySqlDataReader reader;
        MySqlConnection conn;
        MySqlCommand comm;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        public pharmacistMain(String name)
        {
            InitializeComponent();
            pharmacistName = name;
        }

        private void viewB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();

                int medicine_id = Int32.Parse(medicineIDTB.Text);
                String query = "select * from medicine where medicine_id = " + medicine_id;
                String information = "";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    information += "ID: " + reader.GetValue(0) + "\n";
                    information += "Name: " + reader.GetValue(1) + "\n";
                    information += "Price: " + reader.GetValue(2) + "\n";
                    information += "Quantity: " + reader.GetValue(3) + "\n";
                    information += "Manufacturer: " + reader.GetValue(4) + "\n";
                }
                if (information.Equals(""))
                {
                    MessageBox.Show("No such medicine found.", "Information.");
                }
                else
                {
                    MessageBox.Show(information, "Medicine Information");
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered.");
                conn.Close();
            }
        }

        private void viewAllB_Click(object sender, EventArgs e)
        {
            pharmacistViewAll pVA = new pharmacistViewAll();
            pVA.Show();
        }

        private void reduceB_Click(object sender, EventArgs e)
        {
            pharmacistQuantity pQ = new pharmacistQuantity("Reduce");
            pQ.Show();
        }

        private void increaseB_Click(object sender, EventArgs e)
        {
            pharmacistQuantity pQ = new pharmacistQuantity("Increase");
            pQ.Show();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            pharmacistAddMedicine pAM = new pharmacistAddMedicine();
            pAM.Show();
        }

        private void modifyB_Click(object sender, EventArgs e)
        {
            pharmacistModifyMedicine pMM = new pharmacistModifyMedicine();
            pMM.Show();
        }
    }
}
