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
    public partial class CreateList : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;

        public CreateList()
        {
            InitializeComponent();

            // Initialize OleDb objects
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sonia cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Close();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            try
            {

                myConn.Open();


                string listName = tbxNewList.Text;


                if (!string.IsNullOrWhiteSpace(listName))
                {
                    string CreateListQuery = $"CREATE TABLE [{listName}] (ID AUTOINCREMENT PRIMARY KEY," +
                                     $"item_name TEXT, " +
                                     $"item_quantity INT, " +
                                     $"item_price CURRENCY)";
                    OleDbCommand cmd = new OleDbCommand(CreateListQuery, myConn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show($"List '{listName}' created successfully.");
                    da = new OleDbDataAdapter($"SELECT *FROM {listName}", myConn);
                    ds = new DataSet();

                    da.Fill(ds, $"{listName}");
                    dgvNewList.DataSource = ds.Tables[$"{listName}"];
                    myConn.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a list name.");
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

        private void dgvNewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow row = dgvNewList.Rows[e.RowIndex];


                tbxItem.Text = row.Cells["item_name"].Value.ToString();
                tbxQuantity.Text = row.Cells["item_quantity"].Value.ToString();
                tbxPrice.Text = row.Cells["item_price"].Value.ToString();
            }
        }
        private void RefreshDataGridView()
        {
            string listName = tbxNewList.Text;
            string selectQuery = $"SELECT * FROM [{listName}]";
            OleDbDataAdapter da = new OleDbDataAdapter(selectQuery, myConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNewList.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                string listName = tbxNewList.Text;

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    // Get item details from text boxes or other input controls
                    string itemName = tbxItem.Text;
                    int quantity = Convert.ToInt32(tbxQuantity.Text);
                    decimal price = Convert.ToDecimal(tbxPrice.Text);

                    // Insert the new item into the table
                    string insertQuery = $"INSERT INTO [{listName}] (item_name, item_quantity, item_price) " +
                                         $"VALUES (@ItemName, @Quantity, @Price)";
                    OleDbCommand insertCmd = new OleDbCommand(insertQuery, myConn);
                    insertCmd.Parameters.AddWithValue("@ItemName", itemName);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@Price", price);
                    insertCmd.ExecuteNonQuery();

                    // Refresh the DataGridView to reflect the changes
                    RefreshDataGridView();

                    MessageBox.Show("Item added successfully.");
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
            }
        }

        // Button click event handler to delete an item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                string listName = tbxNewList.Text;

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    // Get the ID of the selected item from the DataGridView
                    int selectedID = Convert.ToInt32(dgvNewList.SelectedRows[0].Cells["ID"].Value);

                    // Delete the item from the table
                    string deleteQuery = $"DELETE FROM [{listName}] WHERE ID = @ID";
                    OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn);
                    deleteCmd.Parameters.AddWithValue("@ID", selectedID);
                    deleteCmd.ExecuteNonQuery();

                    // Refresh the DataGridView to reflect the changes
                    RefreshDataGridView();

                    MessageBox.Show("Item deleted successfully.");
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
            }
        }
    }
}

