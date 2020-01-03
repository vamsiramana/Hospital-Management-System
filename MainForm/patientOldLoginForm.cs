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
    public partial class patientOldLoginForm : Form
    {
        public patientOldLoginForm()
        {
            InitializeComponent();
            entry_id = 0;
        }

        MySqlConnection conn;
        MySqlDataReader reader;
        MySqlCommand comm;
        int id;
        int entry_id;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void connectDatabase()
        {
            String oradb = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(oradb);
            conn.Open();
        }

        private void getID()
        {
            try
            {
                connectDatabase();
                String temp = "";
                String command = "select * from patient where patient_name = '" + nameTB.Text + "'";
                comm = new MySqlCommand(command, conn);
                reader = comm.ExecuteReader();
                bool flag = false;
                while (reader.Read())
                {
                    temp = "" + reader.GetValue(2);

                    if (temp.Equals(nameTB.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        flag = true;
                        id = (int)reader.GetValue(0);
                        reader.Close();
                        break;
                    }
                    
                }
                if (!flag)
                {
                    MessageBox.Show("No such user found. Please confirm that you have used the software before.", "Invalid Entry");
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void getEntryID()
        {
            try
            {
                connectDatabase();

                String query = "select entry_id from patient_symptom order by entry_id desc";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    entry_id = (int) reader.GetValue(0);
                    break;
                }
                entry_id += 1;

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            try
            {
                getEntryID();
                connectDatabase();
                String temp = "";
                String command = "select * from patient where patient_name = '" + nameTB.Text + "'";
                comm = new MySqlCommand(command, conn);
                reader = comm.ExecuteReader();
                bool flag = false;
                while (reader.Read())
                {
                    temp = "" + reader.GetValue(2);
                 
                    if (temp.Equals(nameTB.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        id = (int) reader.GetValue(0);
                        flag = true;
                        reader.Close();
                        command = "insert into patient_symptom values(" + entry_id + "," + id + ",'" + symptomTB.Text + "', 0)";
                        comm = new MySqlCommand(command, conn);
                        int returnValue = comm.ExecuteNonQuery();
                        if (returnValue >= 0)
                        {
                            MessageBox.Show("Welcome. ", "Information");
                        }
                        break; 
                    }  
                }
                if (!flag)
                {
                    MessageBox.Show("No such combination found. Please confirm that you have used the software before.", "Invalid Entry");
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
                conn.Close();
            }
        }

        private void billsB_Click(object sender, EventArgs e)
        {
            getID();
            patientMain pM = new patientMain(id);
            pM.Show();
        }

        private void treatmentB_Click(object sender, EventArgs e)
        {
            try
            {
                getID();
                connectDatabase();

                String query = "select treatment_date from treats where patient_id = " + id + " order by treatment_date desc";
                comm = new MySqlCommand(query, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    String text = "" + reader.GetValue(0);
                    String[] textList = text.Split(' ');
                    text = "Upcoming Treatment Date: " + textList[0];
                    MessageBox.Show(text, "Treatment Date");
                    break;
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
