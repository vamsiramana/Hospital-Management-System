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
    public partial class patientNewLoginForm : Form
    {
        int patID;
        int entry_id;

        public patientNewLoginForm()
        {
            InitializeComponent();
            patID = 0;
            entry_id = 0;
        }

        MySqlDataReader reader;
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter dataAdapter;
        DataTable table;


        private void connectDatabase()
        {
            String db = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(db);
            conn.Open();
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
                    entry_id = (int)reader.GetValue(0);
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
                connectDatabase();

                table = new DataTable();
                String command = "select * from patient where patient_name = '" + nameTB.Text + "'";
                dataAdapter = new MySqlDataAdapter(command, conn);
                dataAdapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    //get ID first
                    command = "select patient_id from patient order by patient_id desc";
                    comm = new MySqlCommand(command, conn);
                    reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        patID = (int)reader.GetValue(0);
                        break;
                    }
                    conn.Close();

                    patID += 1;
                    String name = nameTB.Text;
                    String age = ageTB.Text;
                    if(!(Int32.Parse(age) > 0))
                    {
                        MessageBox.Show("Age Not correct. (Age > 0)", "Warning");
                        conn.Close();
                        return;
                    }
                    String gender = genderTB.Text;
                    if (!gender.Equals("Male", StringComparison.InvariantCultureIgnoreCase) && !gender.Equals("Female", StringComparison.InvariantCultureIgnoreCase) && !gender.Equals("Other", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MessageBox.Show("Gender Not correct. (Male, Female, Other)", "Warning");
                        conn.Close();
                        return;
                    }
                    String symptom = symptomTB.Text;

                    //insert into tables
                    getEntryID();
                    connectDatabase();
                    command = "call insertIntoPatient(" + patID + ", NULL, '" + name + "', '" +gender + "'," + age;
                    command += ", '" + symptom + "', " + entry_id + ")";
                    comm = new MySqlCommand(command, conn);
                    int returnValue = comm.ExecuteNonQuery();
                    if (returnValue >= 0)
                    {
                        MessageBox.Show("Welcome. Your data has been recorded. ", "Information");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Similar name found, please enter a different variation of your name.", "Error.");
                }

                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E + "", "Exception Encountered");
            }
        }
    }
}
