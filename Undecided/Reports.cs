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
    public partial class Reports : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        private static string User = "";
        public Reports()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();

            User = MainMenu.UserName;
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
        public void InsertReport(string Content, string Username)
        {
            try
            {
                myConn.Open();

                string query = "INSERT INTO Reports (Content, Username) VALUES (?, ?)";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@Content", Content);
                cmd.Parameters.AddWithValue("@Username", Username);

                cmd.ExecuteNonQuery();
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            InsertReport(tbxReport.Text, User);
            MessageBox.Show("Feedback submitted!");
            this.Close();
        }
    }
}
