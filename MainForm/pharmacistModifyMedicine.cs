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
    public partial class pharmacistModifyMedicine : Form
    {
        MySqlDataReader reader;
        MySqlConnection conn;
        MySqlCommand comm;

        int medicineID;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }


        public pharmacistModifyMedicine()
        {
            InitializeComponent();
            
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                medicineID = Int32.Parse(medicineIDTB.Text);
                

                String query = "select * from medicine where medicine_id = " + medicineID;
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    medicineNameTB.Text = "" + reader.GetValue(1);
                    medicinePriceTB.Text = "" + reader.GetValue(2);
                    medicineQuantityTB.Text = "" + reader.GetValue(3);
                    medicineManufacturerTB.Text = "" + reader.GetValue(4);
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            String name = medicineNameTB.Text;
            String price = medicinePriceTB.Text;
            String quantity = medicineQuantityTB.Text;
            String manufacturer = medicineManufacturerTB.Text;

            try
            {
                connectDatabase();

                String query = "call updateMedicines( " + medicineID + ",'" + name + "', " + price + "," + quantity + ",'" + manufacturer +"')";
                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Updated Successfully.", "Information");
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            medicineNameTB.Text = "";
            medicinePriceTB.Text = "";
            medicineQuantityTB.Text = "";
            medicineManufacturerTB.Text = "";
            medicineIDTB.Text = "";
        }
    }
}
