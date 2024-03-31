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
    public partial class Form2 : Form
    {
        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sonia cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Form2()
        {
            InitializeComponent();
            da = new OleDbDataAdapter();
            ds = new DataSet();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Connection test                                                   

            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void dgvDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {

                
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateList createList = new CreateList();
            createList.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Confirm  confirm = new Confirm();
            DialogResult result = confirm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                
            }
            else if (result == DialogResult.No)
            {
                
            }
        }
    }
}
