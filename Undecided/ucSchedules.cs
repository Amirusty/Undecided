using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Undecided
{
    public partial class ucSchedules : UserControl
    {

        public ucSchedules()
        {
            InitializeComponent();
            this.Load += ucSchedules_Load;
        }

        public void FillData(DataRow row)
        {
            label1.Text = row["Sched_name"].ToString();
            label2.Text = row["List_used"].ToString();
            label3.Text = row["Datetime"].ToString();
            label4.Text = row["Location"].ToString();

        }

        private void ucSchedules_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                checkBox1.Checked = false;
            }
            if (checkBox1.Checked = false)
            {
                checkBox1.Checked = true;
            }
        }

        private void ucSchedules_Load(object sender, EventArgs e)
        {
            if (DateTime.TryParse(label3.Text, out DateTime scheduleDate))
            {
                if (scheduleDate.Date < DateTime.Now.Date)
                {
                    this.BackColor = Color.IndianRed;
                }
            }
        }
    }
}
