using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Undecided
{
    public partial class CreateSched : Form
    {
        public static int _year, _month;
        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;
        public CreateSched()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grace Anne Cogtas\\source\\repos\\Undecided\\Databases\\ProjectDatabase.mdb");
            da = new OleDbDataAdapter();
            ds = new DataSet();
            this.ControlBox = false;
            this.MinimizeBox = true;
        }

        private void CreateSched_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            lbMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startofTheMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startingDayOfWeek = (int)startofTheMonth.DayOfWeek;

            // Add empty controls for the days before the start of the month
            for (int i = 0; i < startingDayOfWeek; i++)
            {
                ucDay uc = new ucDay("");
                flowLayoutPanel1.Controls.Add(uc);
            }

            // Add controls for each day of the month
            for (int i = 1; i <= daysInMonth; i++)
            {
                ucDay uc = new ucDay(i.ToString());
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void btnCreateSched_Click(object sender, EventArgs e)
        {
            CreateSchedule createSchedule = new CreateSchedule();
            createSchedule.Show();
        }
    }
}
