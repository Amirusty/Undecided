﻿using System;
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
        private static string User;
        
        public CreateList()
        { 
            InitializeComponent();


            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
            
            User = MainMenu.UserName;
            
        }



        private void btnCreateList_Click(object sender, EventArgs e)
        {
            try
            {

                myConn.Open();


                string listName = tbxNewList.Text;


                if (!string.IsNullOrWhiteSpace(listName))
                {
                    string CreateListQuery = $"CREATE TABLE [{listName}] (" +
                         $"{User} TEXT," +  
                         $"ID AUTOINCREMENT PRIMARY KEY," + 
                         $"item_name TEXT, " +
                         $"item_quantity INT, " +
                         $"item_price CURRENCY," +
                         $"subtotal CURRENCY)";
                    OleDbCommand cmd = new OleDbCommand(CreateListQuery, myConn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show($"List '{listName}' created successfully.");
                    da = new OleDbDataAdapter($"SELECT *FROM {listName}", myConn);
                    ds = new DataSet();
                    dgvNewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    da.Fill(ds, $"{listName}");
                    dgvNewList.DataSource = ds.Tables[$"{listName}"];
                    dgvNewList.Columns[$"{User}"].Visible = false;
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
        private void RefreshDgv()
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
                    string itemName = tbxItem.Text;
                    int quantity = Convert.ToInt32(tbxQuantity.Text);
                    decimal price = Convert.ToDecimal(tbxPrice.Text);
                    int subtotal_int = quantity * (Convert.ToInt32(tbxPrice.Text));
                    decimal subtotal = Convert.ToDecimal(subtotal_int);
                    string userId = User;

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

                string listName = tbxNewList.Text;

                if (!string.IsNullOrWhiteSpace(listName))
                {
                    if (dgvNewList.SelectedRows.Count > 0)
                    {
                        int selectedID = Convert.ToInt32(dgvNewList.SelectedRows[0].Cells["ID"].Value);


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvNewList.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dgvNewList.SelectedRows[0].Cells["ID"].Value);
                string listName = tbxNewList.Text;
                string itemName = tbxItem.Text;
                int quantity = Convert.ToInt32(tbxQuantity.Text);
                decimal price = Convert.ToDecimal(tbxPrice.Text);
                decimal subtotal = quantity * price;
                dgvNewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

       

       
        
    }



}

