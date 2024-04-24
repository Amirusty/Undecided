using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undecided
{
    public partial class ViewSchedules : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public ViewSchedules()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewSchedules_Load(object sender, EventArgs e)
        {
            try
            {



                myConn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Schedules", myConn);
                OleDbDataReader reader = cmd.ExecuteReader();




                while (reader.Read())
                {
                    ucSchedules uc = new ucSchedules();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        uc.FillData(row);
                        flowLayoutPanel1.Controls.Add(uc);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }

            


           
            myConn.Close();
        }

    }
}
