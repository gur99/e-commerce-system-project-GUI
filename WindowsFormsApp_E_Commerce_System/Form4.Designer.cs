namespace WindowsFormsApp_E_Commerce_System
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAddProductToBuyer = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProductList = new System.Windows.Forms.GroupBox();
            this.listViewStore = new System.Windows.Forms.ListView();
            this.seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.extra_price_for_packing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddingProduct = new System.Windows.Forms.TextBox();
            this.btnAddProductToCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSellerName = new System.Windows.Forms.TextBox();
            this.checkBoxSP = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSP = new System.Windows.Forms.GroupBox();
            this.groupBoxCurrentShoppingCart = new System.Windows.Forms.GroupBox();
            this.listViewCurrentShoppingCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAddProductToBuyer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxProductList.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSP.SuspendLayout();
            this.groupBoxCurrentShoppingCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddProductToBuyer
            // 
            this.groupBoxAddProductToBuyer.Controls.Add(this.btnDone);
            this.groupBoxAddProductToBuyer.Controls.Add(this.groupBox2);
            this.groupBoxAddProductToBuyer.Location = new System.Drawing.Point(12, 24);
            this.groupBoxAddProductToBuyer.Name = "groupBoxAddProductToBuyer";
            this.groupBoxAddProductToBuyer.Size = new System.Drawing.Size(247, 165);
            this.groupBoxAddProductToBuyer.TabIndex = 4;
            this.groupBoxAddProductToBuyer.TabStop = false;
            this.groupBoxAddProductToBuyer.Text = "ADD PRODUCT TO BUYER";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(76, 125);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(82, 46);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(142, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(82, 18);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(142, 22);
            this.textBoxUserName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // groupBoxProductList
            // 
            this.groupBoxProductList.Controls.Add(this.label2);
            this.groupBoxProductList.Controls.Add(this.listViewStore);
            this.groupBoxProductList.Location = new System.Drawing.Point(12, 339);
            this.groupBoxProductList.Name = "groupBoxProductList";
            this.groupBoxProductList.Size = new System.Drawing.Size(1224, 234);
            this.groupBoxProductList.TabIndex = 5;
            this.groupBoxProductList.TabStop = false;
            this.groupBoxProductList.Visible = false;
            // 
            // listViewStore
            // 
            this.listViewStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seller,
            this.category,
            this.product_name,
            this.id,
            this.price,
            this.extra_price_for_packing});
            this.listViewStore.HideSelection = false;
            this.listViewStore.Location = new System.Drawing.Point(6, 56);
            this.listViewStore.Name = "listViewStore";
            this.listViewStore.Size = new System.Drawing.Size(1212, 172);
            this.listViewStore.TabIndex = 0;
            this.listViewStore.UseCompatibleStateImageBehavior = false;
            this.listViewStore.View = System.Windows.Forms.View.Details;
            // 
            // seller
            // 
            this.seller.Text = "seller";
            this.seller.Width = 150;
            // 
            // category
            // 
            this.category.Text = "category";
            this.category.Width = 150;
            // 
            // product_name
            // 
            this.product_name.Text = "product name";
            this.product_name.Width = 150;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 150;
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store";
            // 
            // extra_price_for_packing
            // 
            this.extra_price_for_packing.Text = "extra price for packing";
            this.extra_price_for_packing.Width = 150;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.groupBoxSP);
            this.groupBoxAdd.Controls.Add(this.textBoxSellerName);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.btnAddProductToCart);
            this.groupBoxAdd.Controls.Add(this.textBoxAddingProduct);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 195);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(507, 148);
            this.groupBoxAdd.TabIndex = 6;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter product you would like to add to cart:";
            // 
            // textBoxAddingProduct
            // 
            this.textBoxAddingProduct.Location = new System.Drawing.Point(297, 22);
            this.textBoxAddingProduct.Name = "textBoxAddingProduct";
            this.textBoxAddingProduct.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddingProduct.TabIndex = 2;
            this.textBoxAddingProduct.TextChanged += new System.EventHandler(this.textBoxAddingProduct_TextChanged);
            // 
            // btnAddProductToCart
            // 
            this.btnAddProductToCart.Location = new System.Drawing.Point(346, 84);
            this.btnAddProductToCart.Name = "btnAddProductToCart";
            this.btnAddProductToCart.Size = new System.Drawing.Size(149, 33);
            this.btnAddProductToCart.TabIndex = 3;
            this.btnAddProductToCart.Text = "Add product to cart";
            this.btnAddProductToCart.UseVisualStyleBackColor = true;
            this.btnAddProductToCart.Click += new System.EventHandler(this.btnAddProductToCart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter seller name:";
            // 
            // textBoxSellerName
            // 
            this.textBoxSellerName.Location = new System.Drawing.Point(297, 53);
            this.textBoxSellerName.Name = "textBoxSellerName";
            this.textBoxSellerName.Size = new System.Drawing.Size(198, 22);
            this.textBoxSellerName.TabIndex = 5;
            this.textBoxSellerName.TextChanged += new System.EventHandler(this.textBoxSellerName_TextChanged);
            // 
            // checkBoxSP
            // 
            this.checkBoxSP.AutoSize = true;
            this.checkBoxSP.Location = new System.Drawing.Point(170, 15);
            this.checkBoxSP.Name = "checkBoxSP";
            this.checkBoxSP.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSP.TabIndex = 6;
            this.checkBoxSP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Special packaging";
            // 
            // groupBoxSP
            // 
            this.groupBoxSP.Controls.Add(this.label5);
            this.groupBoxSP.Controls.Add(this.checkBoxSP);
            this.groupBoxSP.Enabled = false;
            this.groupBoxSP.Location = new System.Drawing.Point(122, 81);
            this.groupBoxSP.Name = "groupBoxSP";
            this.groupBoxSP.Size = new System.Drawing.Size(200, 39);
            this.groupBoxSP.TabIndex = 8;
            this.groupBoxSP.TabStop = false;
            // 
            // groupBoxCurrentShoppingCart
            // 
            this.groupBoxCurrentShoppingCart.Controls.Add(this.listViewCurrentShoppingCart);
            this.groupBoxCurrentShoppingCart.Location = new System.Drawing.Point(525, 195);
            this.groupBoxCurrentShoppingCart.Name = "groupBoxCurrentShoppingCart";
            this.groupBoxCurrentShoppingCart.Size = new System.Drawing.Size(711, 148);
            this.groupBoxCurrentShoppingCart.TabIndex = 8;
            this.groupBoxCurrentShoppingCart.TabStop = false;
            this.groupBoxCurrentShoppingCart.Text = "Current Shopping Cart";
            this.groupBoxCurrentShoppingCart.Visible = false;
            // 
            // listViewCurrentShoppingCart
            // 
            this.listViewCurrentShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCurrentShoppingCart.HideSelection = false;
            this.listViewCurrentShoppingCart.Location = new System.Drawing.Point(6, 22);
            this.listViewCurrentShoppingCart.Name = "listViewCurrentShoppingCart";
            this.listViewCurrentShoppingCart.Size = new System.Drawing.Size(699, 116);
            this.listViewCurrentShoppingCart.TabIndex = 0;
            this.listViewCurrentShoppingCart.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentShoppingCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seller";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Extra price for special package";
            this.columnHeader6.Width = 100;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1248, 601);
            this.Controls.Add(this.groupBoxCurrentShoppingCart);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxProductList);
            this.Controls.Add(this.groupBoxAddProductToBuyer);
            this.Name = "Form4";
            this.Text = "Add Product To Buyer";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBoxAddProductToBuyer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxProductList.ResumeLayout(false);
            this.groupBoxProductList.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSP.ResumeLayout(false);
            this.groupBoxSP.PerformLayout();
            this.groupBoxCurrentShoppingCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddProductToBuyer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxProductList;
        private System.Windows.Forms.ListView listViewStore;
        private System.Windows.Forms.ColumnHeader seller;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader extra_price_for_packing;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button btnAddProductToCart;
        private System.Windows.Forms.TextBox textBoxAddingProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSellerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxSP;
        private System.Windows.Forms.GroupBox groupBoxSP;
        private System.Windows.Forms.GroupBox groupBoxCurrentShoppingCart;
        private System.Windows.Forms.ListView listViewCurrentShoppingCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}