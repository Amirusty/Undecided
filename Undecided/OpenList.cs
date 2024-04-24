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
    public partial class OpenList : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public static string User;
        public OpenList()
        {

            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();

            User = MainMenu.UserName;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                string listName = tbxList.Text;

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    string itemName = tbxItem.Text;
                    int quantity = Convert.ToInt32(tbxQuantity.Text);
                    decimal price = Convert.ToDecimal(tbxPrice.Text);
                    int subtotal_int = quantity * (Convert.ToInt32(tbxPrice.Text));
                    decimal subtotal = Convert.ToDecimal(subtotal_int);

                    string insertQuery = $"INSERT INTO [{listName}] (item_name, item_quantity, item_price, subtotal) " +
                                         $"VALUES (@ItemName, @Quantity, @Price,@Subtotal)";
                    OleDbCommand insertCmd = new OleDbCommand(insertQuery, myConn);
                    insertCmd.Parameters.AddWithValue("@ItemName", itemName);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@Price", price);
                    insertCmd.Parameters.AddWithValue("@Subtotal", subtotal);

                    insertCmd.ExecuteNonQuery();


                    RefreshDgv();

                    MessageBox.Show("Item added successfully.");
                }
                else
                {
                    MessageBox.Show("Please enter a table name.");
                }
            }
            catch
            {
                MessageBox.Show("Error: Please input proper details. ");
            }
            finally
            {
                ClearTextBox();
                myConn.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                string listName = tbxList.Text;

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    if (dgvList.SelectedRows.Count > 0)
                    {
                        int selectedID = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);


                        string deleteQuery = $"DELETE FROM [{listName}] WHERE ID = @ID";
                        OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn);
                        deleteCmd.Parameters.AddWithValue("@ID", selectedID);
                        deleteCmd.ExecuteNonQuery();

                        RefreshDgv();

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
                ClearTextBox();
                myConn.Close();
            }
        }
        private void RefreshDgv()
        {
            string listName = tbxList.Text;
            string selectQuery = $"SELECT * FROM [{listName}]";
            OleDbDataAdapter da = new OleDbDataAdapter(selectQuery, myConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvList.DataSource = dt;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    int selectedID = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
                    string listName = tbxList.Text;
                    string itemName = tbxItem.Text;
                    int quantity = Convert.ToInt32(tbxQuantity.Text);
                    decimal price = Convert.ToDecimal(tbxPrice.Text);
                    decimal subtotal = quantity * price;


                    string query = $"UPDATE [{listName}] SET item_name = @ItemName, " +
                                    $"item_quantity = @Quantity, " +
                                    $"item_price = @Price, " +
                                    $"subtotal = @Subtotal " +
                    $"WHERE ID = @ID";
                    OleDbCommand cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@ID", selectedID);
                    myConn.Open();
                    cmd.ExecuteNonQuery();

                    RefreshDgv();
                    myConn.Close();
                    ClearTextBox();
                    MessageBox.Show("Item updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please select the row to update.");
                }
            }
            catch
            {
                MessageBox.Show("Error: Please input proper details. ");
            }
        }
        private void ClearTextBox()
        {
            tbxItem.Text = "";
            tbxPrice.Text = "";
            tbxQuantity.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            string listName = tbxList.Text.Trim();

            if (string.IsNullOrEmpty(listName))
            {
                MessageBox.Show("Please input a list name.");
                return;
            }

            try
            {


                myConn.Open();

                string tableName = tbxList.Text;
                string columnName = User; 
                bool tableFound = false;

                DataTable tables = myConn.GetSchema("Tables");
                foreach (DataRow table in tables.Rows)
                {
                    string tbl = table["TABLE_NAME"].ToString();
                    if (tbl == tableName)
                    {
                        tableFound = true;
                        OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + tableName + "]", myConn);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Columns.Contains(columnName))
                        {
                            dt.Columns[columnName].ColumnMapping = MappingType.Hidden;
                        }

                        dgvList.DataSource = dt;
                        dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        if (dgvList.Columns.Contains(columnName))
                        {
                            dgvList.Columns[columnName].Visible = false;
                        }
                        break;
                    }
                }

                if (tableFound)
                {
                    MessageBox.Show("List found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("List not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow row = dgvList.Rows[e.RowIndex];


                tbxItem.Text = row.Cells["item_name"].Value.ToString();
                tbxQuantity.Text = row.Cells["item_quantity"].Value.ToString();
                tbxPrice.Text = row.Cells["item_price"].Value.ToString();
            }
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

        private void OpenList_Load(object sender, EventArgs e)
        {
            ViewListtoAcc();
        }
    }
}
