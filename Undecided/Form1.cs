using System;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Data;



namespace Undecided
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Grace Anne Cogtas\\Documents\\UserLogin.mdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming 'myConn' is the existing OleDbConnection object
                string query = "SELECT COUNT(*) FROM [User] WHERE Username = @UserName AND [Password] = @Pass";
                using (cmd = new OleDbCommand(query, myConn))
                {
                    myConn.Open();

                    cmd.Parameters.AddWithValue("@UserName", tbxUser.Text);
                    cmd.Parameters.AddWithValue("@Pass", tbxPass.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // If user exists, close current form and open Form2
                        this.Hide(); // Hide the current form instead of closing it
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            catch { }
        }
        public void Check()
        {
            List<int> lists = new List<int>();

        }
    }
}
