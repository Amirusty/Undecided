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

        private async void InitializeWebView2Async(string mart)
        {
            await webView21.EnsureCoreWebView2Async(null);
           
            webView21.CoreWebView2.Navigate(mart);
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if (tbxItem.Text.ToString() == null)
            {

            }
        }



        private void SearchItem_Load(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void cbxMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string market = "";
            if (cbxMarkets.SelectedItem.ToString() == "Landers")
            {
                market = "https://www.landers.ph";
                InitializeWebView2Async(market);
               
            }
            else if (cbxMarkets.SelectedItem.ToString() == "Gaisano")
            {
                market = "https://shopgaisano.com";

                InitializeWebView2Async(market);
            }
            else if (cbxMarkets.SelectedItem.ToString() == "SM")
            {
                market = "https://smmarkets.ph";
                InitializeWebView2Async(market);
            }
            else if (cbxMarkets.SelectedItem.ToString() == "Metro Ayala")
            {
                market = "https://shopmetro.ph/ayala-supermarket/";
                InitializeWebView2Async(market);
            }
            else if (cbxMarkets.SelectedItem.ToString() == "Robinsons ")
            {
                market = "gocart.ph/robinsons-supermarket";
                InitializeWebView2Async(market);
            }
            
        }
    }
}





