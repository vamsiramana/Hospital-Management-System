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
    public partial class multiPurposeLoginForm : Form
    {
        String table_chosen;

        public multiPurposeLoginForm(String table_identified)
        {
            table_chosen = table_identified;
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataTable table;
        private void connectDatabase()
        {
            String oradb = "server=localhost;user id=root;password=vamsi123;database=dbs2";
            conn = new MySqlConnection(oradb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
                table = new DataTable();
                String command = "select * from " + table_chosen + " where name = '" + nameTB.Text + "' and password = '" + passwordTB.Text + "'";
                dataAdapter = new MySqlDataAdapter(command, conn);
                dataAdapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("No such combination found", "Invalid Entry");
                }
                else
                {
                    if (table_chosen.Equals("doctorLogin"))
                    {
                        doctorMain dM = new doctorMain(nameTB.Text);
                        dM.Show();
                    }
                    else if (table_chosen.Equals("nurseLogin"))
                    {
                        nurseMain nM = new nurseMain(nameTB.Text);
                        nM.Show();
                    }
                    else if (table_chosen.Equals("pharmacistLogin"))
                    {
                        pharmacistMain pM = new pharmacistMain(nameTB.Text);
                        pM.Show();
                    }
                    else if (table_chosen.Equals("internLogin"))
                    {
                        internMain iM = new internMain(nameTB.Text);
                        iM.Show();
                    }
                    else
                    {
                        //originally intended for patient. (modified)
                    }
                    this.Close();
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
