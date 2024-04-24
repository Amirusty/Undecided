using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.DataFormats;

namespace Undecided
{
    public partial class CreateSchedule : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public static string User ="";
        public CreateSchedule()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();

            User = MainMenu.UserName;
        }

        private void btnCreateSched_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                if (cbxListNames.SelectedItem != null)
                {
                    string query = "INSERT INTO Schedules (Sched_name, List_used, Time, Location, Username) VALUES (@SchedName, @ListUsed, @Time, @Location, @Username)";
                    OleDbCommand cmd = new OleDbCommand(query, myConn);
                    dtpDate.Format = DateTimePickerFormat.Short;
                    cmd.Parameters.AddWithValue("@SchedName", tbxName.Text);
                    cmd.Parameters.AddWithValue("@ListUsed", cbxListNames.SelectedItem);
                    cmd.Parameters.AddWithValue("@Time", dtpDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Location", cbxLocation.SelectedItem);
                    cmd.Parameters.AddWithValue("@Username", "User");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Schedule added successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a list.");
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
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateSchedule_Load(object sender, EventArgs e)
        {
            ViewListtoAcc();
            ShowMalls();

        }
        private void ShowMalls()
        {
            try
            {
                myConn.Open();
                cbxLocation.Items.Insert(0, "");
                DataTable locationsTable = myConn.GetSchema("Tables");
                DataRow[] locationsRows = locationsTable.Select("TABLE_NAME = 'Locations'");
                if (locationsRows.Length > 0)
                {
                    DataTable locationsData = new DataTable();
                    using (OleDbCommand command = new OleDbCommand("SELECT Shop_name FROM Locations", myConn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(locationsData);
                        }
                    }
                    cbxLocation.DataSource = locationsData;
                    cbxLocation.DisplayMember = "Shop_name";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                ucLocation uc = new ucLocation();

                if (cbxLocation.SelectedItem != null)
                {
                    DataRowView selectedRow = cbxLocation.SelectedItem as DataRowView;

                    if (selectedRow != null)
                    {
                        
                        uc.LoadData(selectedRow);

                        flowLayoutPanel1.Controls.Add(uc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
