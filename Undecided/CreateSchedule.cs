using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CreateSchedule : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public static string User;
        public CreateSchedule()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();

            User = MainMenu.UserName;
        }

        private void btnCreateSched_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                if (cbxList.SelectedItem != null)
                {
                    string query = "INSERT INTO Schedules (Sched_name, List_used, Time, Location, Username) VALUES (@SchedName, @ListUsed, @Time, @Location, @Username)";
                    OleDbCommand cmd = new OleDbCommand(query, myConn);

                    cmd.Parameters.AddWithValue("@SchedName", tbxName.Text);
                    cmd.Parameters.AddWithValue("@ListUsed", cbxList.SelectedItem);
                    cmd.Parameters.AddWithValue("@Time", dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Location", cbxLocation.SelectedItem);
                    cmd.Parameters.AddWithValue("@Username", "User");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Schedule added successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a list.");
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
