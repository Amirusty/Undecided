using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Undecided
{
    public partial class SearchItem : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public static string User;
        public SearchItem()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
            User = MainMenu.UserName;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow row = dgvList.Rows[e.RowIndex];


                tbxName.Text = row.Cells["item_name"].Value.ToString();
                tbxQuantity.Text = row.Cells["item_quantity"].Value.ToString();
                tbxPrice.Text = row.Cells["item_price"].Value.ToString();
            }
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            ViewListtoAcc();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            myConn.Open();

            string tableName = cbxListNames.SelectedItem.ToString();
            string columnName = "item_name";
            string userColumnName = User;

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + tableName + "]", myConn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Columns.Contains(userColumnName))
            {
                dt.Columns[userColumnName].ColumnMapping = MappingType.Hidden;
            }

            dgvList.DataSource = dt;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            myConn.Close();
        }
        private void ViewListtoAcc()
        {
            try
            {
                cbxListNames.Items.Clear();
                string itemToFind = tbxItem.Text;
                string userColumnName = User;
                myConn.Open();
                int n=0;



                DataTable tables = myConn.GetSchema("Tables");
                foreach (DataRow table in tables.Rows)
                {
                    string tableName = table["TABLE_NAME"].ToString();
                    if (tableName.Substring(0, 4) != "MSys")
                    {
                        OleDbCommand cmd = new OleDbCommand($"SELECT * FROM [{tableName}]", myConn);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Columns.Contains(userColumnName) && dt.Columns.Contains("item_name"))
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["item_name"].ToString() == itemToFind)
                                {
                                    cbxListNames.Items.Add(tableName);
                                    n++;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (n > 0)
                {
                    MessageBox.Show("Item found!");
                }
                else
                {
                    MessageBox.Show("Item not found!");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                myConn.Close();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                string listName = cbxListNames.Text;

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    string itemName = tbxName.Text;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    int selectedID = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
                    string listName = cbxListNames.Text;
                    string itemName = tbxName.Text;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void RefreshDgv()
        {
            string listName = cbxListNames.Text;
            string selectQuery = $"SELECT * FROM [{listName}]";
            OleDbDataAdapter da = new OleDbDataAdapter(selectQuery, myConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvList.DataSource = dt;
        }
        private void ClearTextBox()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
            tbxQuantity.Text = "";
        }
    }
}
