using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undecided
{
    public partial class MainMenu : Form
    {
        public static string UserName;
        public static string PassWord;
        public MainMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MinimizeBox = true;
            UserName = Form1.Username;
            PassWord = Form1.Password;
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            ViewLists form = new ViewLists();
            ShowPageInPanel(form);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

            History history = new History();
            ShowPageInPanel(history);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateList createList = new CreateList();
            ShowPageInPanel(createList);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenList openList = new OpenList();
            ShowPageInPanel(openList);
        }



        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ShowPageInPanel(Form form)
        {

            panel1.Controls.Clear();


            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            panel1.Controls.Add(form);


            form.Show();
        }

        private void btnSched_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
            this.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form = new Form1();
                Form1.Username = "";
                Form1.Password = "";
                UserName = "";
                PassWord = "";
                this.Close();
                form.Show();

            }
            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchItem searchItem = new SearchItem();
            ShowPageInPanel(searchItem); 
        }
    }
}
