using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Undecided
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ViewAccounts viewAccounts = new ViewAccounts();

            ShowPageInPanel(viewAccounts);
        }
        private void ShowPageInPanel(Form form)
        {

            panel1.Controls.Clear();


            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            panel1.Controls.Add(form);


            form.Show();
        }

        private void btnLists_Click(object sender, EventArgs e)
        {

        }

        private void btnSched_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form = new Form1();
                
                this.Close();
                form.Show();

            }
            if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
