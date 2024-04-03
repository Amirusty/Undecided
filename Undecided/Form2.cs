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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Undecided
{
    public partial class ViewLists : Form
    {
        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public ViewLists()
        {
            InitializeComponent();
            da = new OleDbDataAdapter();
            ds = new DataSet();
            dgvLists.Visible = false;
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
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void dgvDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
        private void RefreshPage()
        {
            try
            {
                myConn.Open();


                DataTable schemaTable = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                cbxListNames.Items.Clear();


                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    cbxListNames.Items.Add(tableName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                myConn.Close();
                tbxListName.Text = null;
                cbxListNames.SelectedIndex = 0;
                dgvLists.Rows.Clear();
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this list?", "Delete List", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    myConn.Open();

                    string tableName = tbxListName.Text;

                    if (!string.IsNullOrWhiteSpace(tableName))
                    {

                        string dropTableQuery = $"DROP TABLE [{tableName}]";
                        OleDbCommand dropTableCmd = new OleDbCommand(dropTableQuery, myConn);
                        dropTableCmd.ExecuteNonQuery();

                        MessageBox.Show($"Table '{tableName}' deleted successfully.");
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
                    RefreshPage();
                }
                return;
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void cbxListNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxListName.Text = cbxListNames.SelectedItem.ToString();

        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            dgvLists.Visible = true;
            myConn.Open();

            
            string tableName = tbxListName.Text;

            if (!string.IsNullOrWhiteSpace(tableName))
            {
                
                string selectQuery = $"SELECT * FROM [{tableName}]";

                
                da = new OleDbDataAdapter(selectQuery, myConn);
                ds = new DataSet();
                da.Fill(ds, tableName);

                
                dgvLists.Rows.Clear();

               
               
            }
            else
            {
                MessageBox.Show("Please enter a table name.");
            }
            myConn.Close(); 
            RefreshPage();
        }
    }
}
