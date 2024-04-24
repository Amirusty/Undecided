using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undecided
{
    public partial class ViewSchedules : Form
    {
        OleDbConnection myConn;

        public static string User;
        public ViewSchedules()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            User = MainMenu.UserName;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewSchedules_Load(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Schedules", myConn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["Username"].ToString() != User)
                    {
                        continue; // Skip the current iteration of the loop
                    }
                    ucSchedules uc = new ucSchedules();
                    uc.FillData(row);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }






        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ucSchedules uc = new ucSchedules();
                if (uc.checkBox1.Checked)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected schedule?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        
                            myConn.Open();
                            string scheduleName = uc.checkBox1.Tag.ToString();
                            string query = "DELETE FROM Schedules WHERE Sched_name = @SchedName";
                            OleDbCommand cmd = new OleDbCommand(query, myConn);
                            cmd.Parameters.AddWithValue("@SchedName", scheduleName);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Schedule deleted successfully.");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please select a schedule to delete.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
