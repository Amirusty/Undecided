using System;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Data;


//Change code sa location amiel pls tan awa ni - Grant

namespace Undecided
{
    public partial class Form1 : Form
    {
        public static string Username;
        public static string Password;

        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MinimizeBox = true;
            this.MaximizeBox = false;

        }

        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");

        OleDbCommand? cmd;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "SELECT COUNT(*) FROM [User] WHERE Username = @UserName AND [Password] = @Pass";
                using (cmd = new OleDbCommand(query, myConn))
                {
                    myConn.Open();

                    cmd.Parameters.AddWithValue("@UserName", tbxUser.Text);
                    cmd.Parameters.AddWithValue("@Pass", tbxPass.Text);

                    int count = (int)cmd.ExecuteScalar();
                    if (tbxUser.Text == "Admin101" && tbxPass.Text == "999111")
                    {

                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                        this.Hide();
                    }
                    else if (count > 0)
                    {
                        Username = tbxUser.Text;
                        Password = tbxPass.Text;
                        this.Hide();
                        MainMenu form4 = new MainMenu();
                        form4.Show();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
