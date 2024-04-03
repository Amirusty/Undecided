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
        public OpenList()
        {

            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu form4 = new MainMenu();
            form4.Show();
            this.Close();
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
        private void ClearTextBox()
        {
            tbxItem.Text = "";
            tbxPrice.Text = "";
            tbxQuantity.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            string listName = tbxList.Text;

            da = new OleDbDataAdapter($"SELECT *FROM {listName}", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, listName);
            dgvList.DataSource = ds.Tables[listName];
            myConn.Close();

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
    }
}
