using System;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;



namespace Undecided
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch {
                MessageBox.Show("Error. Please try again");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {

        }
        public void Check()
        {
            List<int> lists = new List<int>();

        }
    }
}
