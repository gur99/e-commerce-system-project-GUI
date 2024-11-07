using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_E_Commerce_System
{
    public partial class Form6 : Form
    {
        private Form1 frm1;
        public Form6(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

 
        private void Form6_Load(object sender, EventArgs e)
        {
            loadListView();

        }


        private void loadListView()
        {
            LoadBuyersDetails();
            LoadSellersDetails();

        }
        private void LoadBuyersDetails()
        {
            List<string> all_buyers = frm1.GetAllBuyersDetails();
            if (all_buyers == null)
            {
                MessageBox.Show("No Buyers To Show Yet.");
                listViewBuyers.Visible = false;
                return;
            }

            listViewBuyers.Visible = true;
            string[] arr_buyers = new string[6];
            int i = 0;
            foreach (var item in all_buyers)
            {

                if (i < 5)
                {
                    arr_buyers[i] = item;
                    i++;
                }
                else if (i == 5)
                {
                    arr_buyers[i] = item;
                    var listViewItem = new ListViewItem(arr_buyers);
                    listViewBuyers.Items.Add(listViewItem);
                    Array.Clear(arr_buyers, 0, arr_buyers.Length);
                    i = 0;
                }
            }
        }
        private void LoadSellersDetails()
        {
            List<string> all_sellers = frm1.GetAllSellersDetails();
            if (all_sellers == null)
            {
                MessageBox.Show("No Sellers To Show Yet.");
                listViewSellers.Visible = false;
                return;
            }
            listViewSellers.Visible = true;
            string[] arr_sellers = new string[6];
            int i = 0;
            foreach (var item in all_sellers)
            {

                if (i < 5)
                {
                    arr_sellers[i] = item;
                    i++;
                }
                else if (i == 5)
                {
                    arr_sellers[i] = item;
                    var listViewItem = new ListViewItem(arr_sellers);
                    listViewSellers.Items.Add(listViewItem);
                    Array.Clear(arr_sellers, 0, arr_sellers.Length);
                    i = 0;
                }
            }
        }




    }
}
