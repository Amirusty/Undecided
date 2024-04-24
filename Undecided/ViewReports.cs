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
    public partial class ViewReports : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        private static string User;
        public ViewReports()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }
        private void refreshDGV()
        {
            try
            {

                dataGridView1.DataSource = null;


                myConn.Open();


                string query = "SELECT * FROM Reports";


                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, myConn))
                {

                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                string listName = "Reports";

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);


                        string deleteQuery = $"DELETE FROM [{listName}] WHERE ID = @ID";
                        OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn);
                        deleteCmd.Parameters.AddWithValue("@ID", selectedID);
                        deleteCmd.ExecuteNonQuery();
                        

                        MessageBox.Show("Item deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a table name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                myConn.Close();
                refreshDGV();

            }
        }
    }
}
