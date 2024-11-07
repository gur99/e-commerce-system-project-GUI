using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_E_Commerce_System
{
    public partial class Form1 : Form
    {

        private Administrative_Department e_kingur;
        private string e_commerce_system_name = "E-KinGur";

        //CONSTRUCTOR1
        public Form1()
        {
            InitializeComponent();
            e_kingur = new Administrative_Department(e_commerce_system_name);

            string TXTFilePath = Directory.GetCurrentDirectory() + "\\e_kingur" + ".txt";
            e_kingur.LoadDataFromFile(TXTFilePath);
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            e_kingur = new Administrative_Department(e_commerce_system_name);

            string TXTFilePath = Directory.GetCurrentDirectory() + "\\e_kingur" + ".txt";
            e_kingur.LoadDataFromFile(TXTFilePath);
        }

        // BUTTON- ADD BUYER
        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.ShowDialog();
        
        }
        // METHOD- ADD BUYER
        public bool AddBuyer(string user_name, string password, string street, int building_number, string city, string state)
        {
            Address address = new Address(street, building_number, city, state);
            Buyer buyer = new Buyer(user_name, password, address);
            if (e_kingur.IsUserExist(user_name)==-1)
            {
                e_kingur.AddBuyer(buyer);
                MessageBox.Show("ADD BUYER!");
                return true;
            }
           
            MessageBox.Show("User Already Exist. Try another username");
            return false;
                
        }

        // BUTTON- ADD SELLER
        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.ShowDialog();
        }

        // METHOD- ADD SELLER
        public bool AddSeller(string user_name, string password, string street, int building_number, string city, string state)
        {
            Address address = new Address(street, building_number, city, state);
            Seller seller = new Seller(user_name, password, address);
            if (e_kingur.IsUserExist(user_name) == -1)
            {
                e_kingur.AddSeller(seller);
                MessageBox.Show("ADD SELLER!");
                string TXTFilePath = Directory.GetCurrentDirectory() + "\\e_kingur" + ".txt";
                e_kingur.SaveToFile(TXTFilePath);
                return true;
            }
            MessageBox.Show("User Already Exist. Try another username");
            return false;
        }

        //Button - Add Product To Buyer
        private void btnAddProductToBuyer_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(this);
            frm4.ShowDialog();
        }
        
        //Method-IS Buyer Exist
        public int IsBuyerExist(string buyer_name)
        {
            return e_kingur.IsBuyerExist(buyer_name);
        }
        //Method-IS Seller Exist
        public int IsSellerExist(string seller_name)
        {
            return e_kingur.IsSellerExist(seller_name);
        }

        //Method Cheking Password
        public bool IsPasswordCorrect(string password,int index_of_user)
        {
            if (e_kingur.GetUsers()[index_of_user].IsPasswordCorrect(password) == false)
            {
                return false;
            }
            return true;
        }

        public List<string> GetAllProducts()
        {
            List<string> res=e_kingur.ShowAllProduct();
            return res;
        }

        private void btnAddProductToSeller_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            frm5.ShowDialog();
        }

        //Method- chicking if a product already exist
        public bool GetProductOfSeller(string seller_name, string product_name)
        {
            if (e_kingur.GetProductOfSeller(seller_name, product_name) == null)
                return false;
            else
                return true;

        }
        //Method for adding product to seller
        public void AddProductToSeller(string product_name, double product_price, int category_choice,bool is_specail_package, string seller_username)
        {
            Product product;
            if (is_specail_package == true)
            {
                 product = new PackagedProduct(product_name,product_price,seller_username,category_choice,false);
            }
            else
            {
                 product = new Product(product_name,product_price,seller_username,category_choice);
            }
            Seller seller = e_kingur.GetSellerByName(seller_username);
            e_kingur.AddProductToSeller(product, seller);
            
            string TXTFilePath = Directory.GetCurrentDirectory() + "\\e_kingur" + ".txt";
            e_kingur.SaveToFile(TXTFilePath);
            MessageBox.Show("Product added successfuly!");
        }

        //Method- getting list of product to display
        public List<string>getProduct()
        {
            List<string> all_products;
            all_products=e_kingur.ShowAllProduct();
            return all_products;
        }
        //Method- check product for adding to cart
        public bool CheckProductToCart(string product_name,string seller_name)
        {
            //if (e_kingur.IsMultipleProduct(product_name) > 1)
            //{
            //    MessageBox.Show("Ther is Multiple Sellers who sell: "+product_name+"\nWhich one would you prefer? ~enter seller name")
            //}
            if(e_kingur.IsUserExist(seller_name) == -1)
            {
                MessageBox.Show("Seller doesnt exist.");
                return false;
            }
            else if (e_kingur.IsMultipleProduct(product_name) == -1)
            {
                MessageBox.Show("product doesnt exist.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddProductToBuyerCart(string seller_name,string product_name,string buyer_name,bool is_special_packing)
        {
            int index_of_buyer;
            Buyer buyer;
            Product product;

            index_of_buyer=e_kingur.IsBuyerExist(buyer_name);
            if (index_of_buyer == -1)
            {
                MessageBox.Show("Buyer not found.");
                return;
            }
          
            buyer= e_kingur.GetBuyerByName(buyer_name);

            product = e_kingur.GetProductOfSeller(seller_name,product_name);
            if (product == null)
            {
                MessageBox.Show("This Seller Doesn't Sell: " + product_name);
                return;
            }


            PackagedProduct temp = product as PackagedProduct;
            if(temp!= null)
            {
                temp = new PackagedProduct(temp);
                
                if (is_special_packing)
                    {
                     temp.SetIsSpecialPackaging(true);
                     product = temp;
                    }
                else if (is_special_packing == false)
                {
                    PackagedProduct new_temp = new PackagedProduct(temp);
                    new_temp.SetIsSpecialPackaging(false);
                    product = new_temp;
                }
            }

            e_kingur.AddProductToBuyer(product,buyer);
            MessageBox.Show("Product added successfuly!");
        }

        //Method- check if a product is special_Packaged
        public bool IsSpecialPackaged(string product_name,string seller_name)
        {
            Product product;
            product = e_kingur.GetProductOfSeller(seller_name,product_name);

            PackagedProduct temp = product as PackagedProduct;
            if (temp != null)
            {
                return true;
            }
            return false;
        }

        public List<string> GetAllBuyersDetails()
        {
            List<string> buyers = new List<string>();
            buyers = e_kingur.GetAllBuyersDetails();
            return buyers;
        }
        public List<string> GetAllSellersDetails()
        {
            List<string> sellers = new List<string>();
            sellers = e_kingur.GetAllSellersDetails();
            return sellers;
        }

        private void btnDisplayAllUsers_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6(this);
            frm6.ShowDialog();
        }

        public List<string> GetShoppingCartForBuyer(string buyer_name)
        {
            List<string> products = new List<string>();
            products = e_kingur.GetShoppingCartForBuyer(buyer_name);
            return products;

        }


        //Method- Show All Products of Selller
        public List<string> ShowAllProductOfSeller(string seller_name)
        {
            List<string> products = new List<string>();
            products = e_kingur.GetShoppingCartForSeller(seller_name);
            return products;
        }


    }
}
