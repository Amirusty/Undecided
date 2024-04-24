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
            MainMenu mainMenu = new MainMenu();
            CreateList createList = new CreateList();
            mainMenu.panel1.Controls.Clear();
            mainMenu.ShowPageInPanel(createList);

            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            OpenList open = new OpenList();
            mainMenu.panel1.Controls.Clear();
            mainMenu.ShowPageInPanel(open);
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
    }
}
