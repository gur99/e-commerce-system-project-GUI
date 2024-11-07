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
    public partial class Form5 : Form
    {
        private Form1 frm1;
        public Form5(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (StringException(textBoxUserName.Text) == false)
                return;
            if (StringException(textBoxPassword.Text) == false)
                return;

            int index_of_seller = frm1.IsSellerExist(textBoxUserName.Text);
            if (index_of_seller == -1)
            {
                MessageBox.Show("Seller not exist!");
                textBoxUserName.Clear();
                return;
            }

            if (frm1.IsPasswordCorrect(textBoxPassword.Text, index_of_seller) == false)
            {
                MessageBox.Show("Wrong Password.");
                textBoxPassword.Clear();
                return;
            }
            groupBoxAddProduct.Visible = true;
            groupBoxCurrentProductCart.Visible = true;
            groupBoxAddProductToSeller.Enabled = false;
            LoadListViewCurrentShoppingCart();



        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string seller_name =textBoxUserName.Text;
            string product_name;
            double price;
            int category; 
            bool special_package;

            if (StringException(textBoxProductName.Text) == false)
                return;
            if (DoubleException(textBoxProductPrice.Text) == false)
                return;
            price = double.Parse(textBoxProductPrice.Text);

            product_name = textBoxProductName.Text;
            var selectItem = listBoxCategory.SelectedItem;
            string category_name = listBoxCategory.GetItemText(selectItem);
            category = CategoryToInt(category_name);

            if (category == -1)
            {
                return;
            }


            if (frm1.IsSellerExist(seller_name) ==-1)
            {
                MessageBox.Show("Seller not Exist.");
                return;

            }


            if (frm1.GetProductOfSeller(seller_name, product_name))
            {
                MessageBox.Show("Product Already Exist.");
                return;
            }
            if (checkBoxSpecialPackage.Checked)
            {
                special_package = true;
            }
            else
            {
                special_package = false;
            }

            frm1.AddProductToSeller(product_name, price, category, special_package, seller_name);
            LoadListViewCurrentShoppingCart();

            textBoxProductName.Clear();
            textBoxProductPrice.Clear();
            checkBoxSpecialPackage.Checked = false;
            listBoxCategory.SelectedIndex = 0;

        }








        public  static int CategoryToInt(string category)
        {
            switch (category)
            {
                case "Kids":
                    return 1;
                case "Electricity":
                    return 2;
                case "Office":
                    return 3;
                case "Clothes":
                    return 4;
                default:
                    MessageBox.Show("Category not selected.");
                    return -1;
            }
        }





        //EXCEPTIONS
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

        // IntException
        public static bool DoubleException(string input)
        {

            try
            {
                double.Parse(input);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }


        private void LoadListViewCurrentShoppingCart()
        {
            listViewCurrentProductCart.Items.Clear();

            List<string> seller_products = frm1.ShowAllProductOfSeller(textBoxUserName.Text);
            if (seller_products == null)
            {
                return;
            }

            string[] arr_seller_products = new string[5];
            int i = 0;
            foreach (var item in seller_products)
            {

                if (i < 4)
                {
                    arr_seller_products[i] = item;
                    i++;
                }
                else if (i == 4)
                {
                    arr_seller_products[i] = item;
                    var listViewItem = new ListViewItem(arr_seller_products);

                    listViewCurrentProductCart.Items.Add(listViewItem);
                    Array.Clear(arr_seller_products, 0, arr_seller_products.Length);
                    i = 0;
                }
            }
        }






    }
}
