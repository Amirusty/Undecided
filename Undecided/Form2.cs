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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Undecided
{
    public partial class ViewLists : Form
    {
        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
        OleDbDataAdapter? da;
        public string User;
        DataSet? ds;
        int indexRow;
        public ViewLists()
        {
            InitializeComponent();
            da = new OleDbDataAdapter();
            ds = new DataSet();

            this.ControlBox = false;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            User = MainMenu.UserName;
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
            ViewListtoAcc();


        }
        private void ViewListtoAcc()
        {
            try
            {
                cbxListNames.Items.Clear();
                myConn.Open();

                string userColumnName = User;


                DataTable schemaTable = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });


                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();


                    DataTable tableSchema = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tableName, null });


                    foreach (DataRow columnRow in tableSchema.Rows)
                    {
                        string columnName = columnRow["COLUMN_NAME"].ToString();
                        if (columnName == userColumnName)
                        {
                            cbxListNames.Items.Add(tableName);

                        }
                    }
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            if (mainMenu != null)
            {
                mainMenu.panel1.Controls.Clear();
                CreateList createList = new CreateList();
                createList.TopLevel = false;
                createList.Dock = DockStyle.Fill;
                mainMenu.panel1.Controls.Add(createList);
                createList.Show();
            }


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            if (mainMenu != null)
            {
                mainMenu.panel1.Controls.Clear();
                OpenList open = new OpenList();
                open.TopLevel = false;
                open.Dock = DockStyle.Fill;
                mainMenu.panel1.Controls.Add(open);
                open.Show();
            }

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
                    ViewListtoAcc();
                    dgvLists.DataSource = null;
                    tbxListName.Text = null;
                    cbxListNames.SelectedIndex = 0;
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
            dgvLists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {

                RefreshDgv();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                myConn.Close();
                ViewListtoAcc();

            }

        }
        protected void RefreshDgv()
        {
            string listName = tbxListName.Text.ToString();
            if (tbxListName.Text == "")
            {
                MessageBox.Show("Please choose a valid list.");
            }
            else
            {
                da = new OleDbDataAdapter($"SELECT *FROM {listName}", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, listName);
                dgvLists.DataSource = ds.Tables[listName];
                string columnName = User;
                dgvLists.Columns[$"{columnName}"].Visible = false;
                myConn.Close();
            }

        }



        private void ViewLists_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void ViewLists_Load(object sender, EventArgs e)
        {
            ViewListtoAcc();
        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSort.SelectedItem.ToString() == "Name - Ascending")
            {
                var sortedItems = cbxListNames.Items.Cast<string>().OrderBy(item => item).ToArray();
                cbxListNames.Items.Clear();
                cbxListNames.Items.AddRange(sortedItems);
            }
            else if (cbxSort.SelectedItem.ToString() == "Name - Descending")
            {
                var sortedItems = cbxListNames.Items.Cast<string>().OrderByDescending(item => item).ToArray();
                cbxListNames.Items.Clear();
                cbxListNames.Items.AddRange(sortedItems);
            }
            else if (cbxSort.SelectedItem.ToString() == "Size - Ascending")
            {
                var tableCounts = GetTableRecordCounts();
                var sortedTables = tableCounts.OrderBy(tc => tc.Value).Select(tc => tc.Key).ToArray();
                UpdateComboBox(sortedTables);
            }
            else if (cbxSort.SelectedItem.ToString() == "Size - Descending")
            {
                var tableCounts = GetTableRecordCounts();
                var sortedTables = tableCounts.OrderByDescending(tc => tc.Value).Select(tc => tc.Key).ToArray();
                UpdateComboBox(sortedTables);
            }
            else if (cbxSort.SelectedItem.ToString() == "Total Amount - Ascending")
            {
                var tableSums = GetTableSubtotalSums();
                var sortedTables = tableSums.OrderBy(ts => ts.Value).Select(ts => ts.Key).ToArray();
                UpdateComboBox(sortedTables);
            }
            else if (cbxSort.SelectedItem.ToString() == "Total Amount - Descending")
            {
                var tableSums = GetTableSubtotalSums();
                var sortedTables = tableSums.OrderByDescending(ts => ts.Value).Select(ts => ts.Key).ToArray();
                UpdateComboBox(sortedTables);
            }
        }
        private void UpdateComboBox(string[] sortedTables)
        {
            cbxListNames.Items.Clear();
            cbxListNames.Items.AddRange(sortedTables);
        }
        private Dictionary<string, int> GetTableRecordCounts()
        {
            Dictionary<string, int> tableCounts = new Dictionary<string, int>();

            myConn.Open();
            foreach (string tableName in cbxListNames.Items)
            {
                using (OleDbCommand command = new OleDbCommand($"SELECT COUNT(*) FROM [{tableName}]", myConn))
                {
                    int count = (int)command.ExecuteScalar();
                    tableCounts[tableName] = count;
                }
            }
            myConn.Close();

            return tableCounts;
        }
        private Dictionary<string, double> GetTableSubtotalSums()
        {
            Dictionary<string, double> tableSums = new Dictionary<string, double>();

            myConn.Open();
            foreach (string tableName in cbxListNames.Items)
            {
                using (OleDbCommand command = new OleDbCommand($"SELECT SUM([subtotal]) FROM [{tableName}]", myConn))
                {
                    var result = command.ExecuteScalar();
                    double sum = result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
                    tableSums[tableName] = sum;
                }
            }
            myConn.Close();

            return tableSums;
        }
    }
}





