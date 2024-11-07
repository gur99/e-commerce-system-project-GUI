using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_E_Commerce_System
{
    public partial class Form4 : Form
    {
        Form1 frm1;
        public Form4(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void btnDone_Click(object sender, EventArgs e)
        {

            if (StringException(textBoxUserName.Text) == false)
                return;
            if (StringException(textBoxPassword.Text) == false)
                return;


            int index_of_buyer = frm1.IsBuyerExist(textBoxUserName.Text);
            if (index_of_buyer == -1)
            {
                MessageBox.Show("Buyer not exist!");
                textBoxUserName.Clear();
                return;
            }
            if (frm1.IsPasswordCorrect(textBoxPassword.Text, index_of_buyer)==false)
            {
                MessageBox.Show("Wrong Password.");
                textBoxPassword.Clear();
                return;
            }
            groupBoxProductList.Visible = true;
            groupBoxAdd.Visible = true;
            groupBoxCurrentShoppingCart.Visible = true;
            groupBoxAddProductToBuyer.Enabled = false;

            LoadListViewCurrentShoppingCart();

            List<string> all_products = frm1.GetAllProducts();
            if (all_products == null)
            {
                MessageBox.Show("No Products To Show Yet.");
                this.Close();
                return;
            }

            string [] arr_products = new string[6];
            int i = 0;
            foreach (var item in all_products)
            {

                if (i < 5) 
                { 
                    arr_products[i] = item;
                    i++;
                }
                else if(i==5)
                {
                    arr_products[i] = item;
                    var listViewItem =  new ListViewItem(arr_products);
                    listViewStore.Items.Add(listViewItem);
                    Array.Clear(arr_products,0, arr_products.Length);
                    i = 0;
                }
            }
        }





        //Exception
        public static bool StringException(string input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new Exception("Input cannot be null or whitespace only");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }


        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            if (StringException(textBoxAddingProduct.Text) == false)
                return;
            string product_name = textBoxAddingProduct.Text;
            
            if (StringException(textBoxSellerName.Text) == false)
                return;
            string seller_name = textBoxSellerName.Text;


            if (frm1.CheckProductToCart(product_name,seller_name) == false)
                return;

            string buyer_name = textBoxUserName.Text;
            if (checkBoxSP.Checked == true)
            {
                frm1.AddProductToBuyerCart(seller_name, product_name, buyer_name, true);
            }
            else
            {
                frm1.AddProductToBuyerCart(seller_name, product_name, buyer_name, false);
            }
            
            LoadListViewCurrentShoppingCart();

            textBoxSellerName.Clear();
            textBoxAddingProduct.Clear();
            checkBoxSP.Checked = false;


        }


        private void LoadListViewCurrentShoppingCart()
        {
            listViewCurrentShoppingCart.Items.Clear();
            List<string> buyer_products = frm1.GetShoppingCartForBuyer(textBoxUserName.Text);
            if (buyer_products == null)
            {
                return;
            }

            string[] arr_buyer_products = new string[6];
            int i = 0;
            foreach (var item in buyer_products)
            {

                if (i < 5)
                {
                    arr_buyer_products[i] = item;
                    i++;
                }
                else if (i == 5)
                {
                    arr_buyer_products[i] = item;
                    var listViewItem = new ListViewItem(arr_buyer_products);
                    
                    listViewCurrentShoppingCart.Items.Add(listViewItem);
                    Array.Clear(arr_buyer_products, 0, arr_buyer_products.Length);
                    i = 0;
                }
            }
        }

        private void textBoxAddingProduct_TextChanged(object sender, EventArgs e)
        {

            string product_name = textBoxAddingProduct.Text;

            string seller_name = textBoxSellerName.Text;
            if (frm1.IsSpecialPackaged(product_name, seller_name) == false)
            {
                groupBoxSP.Enabled = false;
                checkBoxSP.Checked = false;
            }
            else
            {
                groupBoxSP.Enabled = true;

            }


        }


        private void ClearListViewCurrentShoppingCartValues()
        {
            foreach (ListViewItem item in listViewCurrentShoppingCart.Items)
            {
                item.Text = null;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    subItem.Text = null;
                }

            }
        }
        
        private void textBoxSellerName_TextChanged(object sender, EventArgs e)
        {
            string product_name = textBoxAddingProduct.Text;

            string seller_name = textBoxSellerName.Text;
            if (frm1.IsSpecialPackaged(product_name, seller_name) == false)
            {
                groupBoxSP.Enabled = false;
                checkBoxSP.Checked = false;
            }
            else
            {
                groupBoxSP.Enabled = true;

            }
        }
    }
}
