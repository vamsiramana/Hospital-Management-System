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
    public partial class pharmacistQuantity : Form
    {
        String operation;

        MySqlConnection conn;
        MySqlCommand comm;

        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
        }

        private void uIInitialization()
        {
            if (operation.Equals("Reduce"))
            {
                modifyB.Text = "Reduce";
                modifyL.Text = "Reduce By: ";
            }
            else if (operation.Equals("Increase"))
            {
                modifyB.Text = "Increase";
                modifyL.Text = "Increase By: ";
            }
            else
            {
                MessageBox.Show("Unexpected Error", "Warning!");
                return;
            }
        }

        public pharmacistQuantity(String op)
        {
            InitializeComponent();
            operation = op;
            uIInitialization();
        }

        private void updateTheQuantity()
        {
            try
            {
                connectDatabase();

                String query = "";
                int value = Int32.Parse(modifyTB.Text);
                int medicine_id = Int32.Parse(medicineIDTB.Text);
                if (operation.Equals("Increase"))
                {
                    query = "update medicine set medicine_quantity = medicine_quantity + " + value + " where medicine_id = " + medicine_id;
                }
                else if (operation.Equals("Reduce"))
                {
                    query = "update medicine set medicine_quantity = medicine_quantity - " + value + " where medicine_id = " + medicine_id;
                }

                comm = new MySqlCommand(query, conn);
                int returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Updated Successfully", "Information");
                }

                //checking for negative in "reduce"
                query = "update medicine set medicine_quantity = 0 where medicine_id = " + medicine_id;
                query += " and medicine_quantity < 0";
                comm = new MySqlCommand(query, conn);
                returnValue = comm.ExecuteNonQuery();
                if (returnValue >= 0)
                {
                    MessageBox.Show("Successful Background Cleaning", "Information");
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }

        }

        private void modifyB_Click(object sender, EventArgs e)
        {
            updateTheQuantity();
        }
    }
}
