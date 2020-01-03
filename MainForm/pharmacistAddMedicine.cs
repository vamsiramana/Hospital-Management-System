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
    public partial class pharmacistAddMedicine : Form
    {
        int medicine_id;
        MySqlDataReader reader;
        MySqlConnection conn;
        MySqlCommand comm;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        private void fetchMedicineID()
        {
            try
            {
                connectDatabase();

                medicine_id = 0;
                String query = "select medicine_id from medicine order by medicine_id desc";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    medicine_id = (int)reader.GetValue(0);
                    break;
                }
                medicine_id += 1;

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E, "Exception Encountered");
                conn.Close();
            }
        }

        public pharmacistAddMedicine()
        {
            InitializeComponent();
            fetchMedicineID();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();

                String medicine_name = nameTB.Text;
                int quantity = Int32.Parse(quantityTB.Text);
                int price = Int32.Parse(priceTB.Text);
                String manufacturer_name = manufacturerTB.Text;
                String query = "insert into medicine values (" + medicine_id + ",'" + medicine_name + "',";
                query += price + "," + quantity + ",'" + manufacturer_name + "')";

                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Inserted Succesfully", "Update");
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
