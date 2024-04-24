using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undecided
{
    public partial class ucLocation : UserControl
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public ucLocation()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        
        private void ucLocation_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(DataRowView selectedRow)
        {
            if (selectedRow.Row.Table.Columns.Contains("Location_map"))
            {
                pictureBox1.Image = (Image)selectedRow["Location_map"];
            }
            else
            {
                MessageBox.Show("No pic found");
            }

            label1.Text = selectedRow["Shop_name"].ToString();
            label3.Text = selectedRow["Address"].ToString();
            label2.Text = selectedRow["Working_hours"].ToString();

            
            AutoSize = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            label3.AutoSize = true;
            label3.MaximumSize = new Size(flowLayoutPanel1.Width - 50, 0);
        }
    }
}
