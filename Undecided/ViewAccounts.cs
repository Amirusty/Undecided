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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Undecided
{
    public partial class ViewAccounts : Form
    {
        OleDbConnection? myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public ViewAccounts()
        {
            InitializeComponent();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvAccounts.SelectedCells.Count > 0)
                {
                    string username = tbxUser.Text;

                    myConn.Open();

                    string deleteUserQuery = $"DELETE FROM [User] WHERE Username = @Username";
                    using (OleDbCommand deleteUserCmd = new OleDbCommand(deleteUserQuery, myConn))
                    {
                        deleteUserCmd.Parameters.AddWithValue("@Username", username);
                        deleteUserCmd.ExecuteNonQuery();
                    }

                    DataTable schemaTable = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();

                        DataTable columnsTable = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tableName, null });
                        string[] columnNames = columnsTable.AsEnumerable().Select(r => r.Field<string>("COLUMN_NAME")).ToArray();

                        
                        if (columnNames.Contains(username))
                        {
                            string deleteTableQuery = $"DROP TABLE [{tableName}]";

                            using (OleDbCommand command = new OleDbCommand(deleteTableQuery, myConn))
                            {
                                command.ExecuteNonQuery();
                                Console.WriteLine($"Table '{tableName}' deleted successfully.");
                            }
                        }
                    }

                    myConn.Close();

                    MessageBox.Show("Account and related tables deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a cell to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                
                FillDGV();
                ClearTextBox();
            }
        }

        private void ViewAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void ViewAccounts_Load(object sender, EventArgs e)
        {
            FillDGV();
        }
        private void FillDGV()
        {
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                myConn.Open();

                da = new OleDbDataAdapter("SELECT * FROM [User]", myConn);

                ds = new DataSet();
                da.Fill(ds, "User");

                dgvAccounts.DataSource = ds.Tables["User"];
                dgvAccounts.Columns["ID"].Visible = false;
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
        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];


                tbxUser.Text = row.Cells["Username"].Value.ToString();

                tbxPass.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccounts.SelectedCells.Count > 0)
                {
                    int rowIndex = dgvAccounts.SelectedCells[0].RowIndex;
                    int columnIndex = dgvAccounts.SelectedCells[0].ColumnIndex;

                    string user = tbxUser.Text;
                    string pass = tbxPass.Text;

                    int selectedID = Convert.ToInt32(dgvAccounts.Rows[rowIndex].Cells["ID"].Value);

                    myConn.Open();

                    string query = $"UPDATE [User] SET [Username] = @UserName, " +
                                   $"[Password] = @PassWord " +
                                   $"WHERE ID = @ID";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", user);
                        cmd.Parameters.AddWithValue("@PassWord", pass);
                        cmd.Parameters.AddWithValue("@ID", selectedID);

                        cmd.ExecuteNonQuery();
                    }
                    myConn.Close();

                    dgvAccounts.Rows[rowIndex].Cells[columnIndex].Value = user;
                    if (columnIndex == 1)
                    {
                        dgvAccounts.Rows[rowIndex].Cells[columnIndex].Value = pass;
                    }

                    MessageBox.Show("Item updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a cell to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            FillDGV();
            ClearTextBox();
        }
        private void ClearTextBox()
        {

            tbxUser.Text = "";
            tbxPass.Text = "";
        }
    }
    
}
