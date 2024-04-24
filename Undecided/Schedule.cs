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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MinimizeBox = true;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateSched createSched = new CreateSched();
            ShowPageInPanel(createSched);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewSchedules viewSchedules = new ViewSchedules();
            ShowPageInPanel(viewSchedules);
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();


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

        private void Schedule_Load(object sender, EventArgs e)
        {
            CreateSched createSched1 = new CreateSched();   
            ShowPageInPanel(createSched1); 
        }
    }
}
