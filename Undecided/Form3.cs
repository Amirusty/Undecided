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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Undecided
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Grace Anne Cogtas\\Documents\\UserLogin.mdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        private void btnCreateNewAcc_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO [User] (Username, [Password]) VALUES (@UserName, @Pass)";

            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
            {
                try
                {
                    myConn.Open();

                    
                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE Username = @UserName";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", tbxNewUser.Text);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists!");
                            return;
                        }
                    }

                    
                    cmd.Parameters.AddWithValue("@UserName", tbxNewUser.Text);
                    cmd.Parameters.AddWithValue("@Pass", tbxNewPass.Text);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create user!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
