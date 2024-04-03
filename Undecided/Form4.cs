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
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ViewLists form = new ViewLists();
            form.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

            History history = new History();
            history.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateList createList = new CreateList();
            createList.Show();
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenList openList = new OpenList();
            openList.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchItem searchItem = new SearchItem();
            searchItem.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
