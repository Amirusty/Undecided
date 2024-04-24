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
        }

        public void FillData(DataRow row)
        {
            label1.Text = row["Sched_name"].ToString();
            label2.Text = row["List_used"].ToString();
            label3.Text = row["Time"].ToString();
            label4.Text = row["Location"].ToString();
            
        }
    }
}
