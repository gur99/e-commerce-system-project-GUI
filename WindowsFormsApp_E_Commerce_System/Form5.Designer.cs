namespace WindowsFormsApp_E_Commerce_System
{
    partial class Form5
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
            this.groupBoxAddProductToSeller = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxSpecialPackage = new System.Windows.Forms.CheckBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.groupBoxCurrentProductCart = new System.Windows.Forms.GroupBox();
            this.listViewCurrentProductCart = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extra_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAddProductToSeller.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            this.groupBoxCurrentProductCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddProductToSeller
            // 
            this.groupBoxAddProductToSeller.Controls.Add(this.btnDone);
            this.groupBoxAddProductToSeller.Controls.Add(this.groupBox2);
            this.groupBoxAddProductToSeller.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddProductToSeller.Name = "groupBoxAddProductToSeller";
            this.groupBoxAddProductToSeller.Size = new System.Drawing.Size(357, 148);
            this.groupBoxAddProductToSeller.TabIndex = 5;
            this.groupBoxAddProductToSeller.TabStop = false;
            this.groupBoxAddProductToSeller.Text = "ADD PRODUCT TO SELLER";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(116, 115);
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
            this.groupBox2.Size = new System.Drawing.Size(344, 75);
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
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.btnSaveProduct);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductName);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductPrice);
            this.groupBoxAddProduct.Controls.Add(this.listBoxCategory);
            this.groupBoxAddProduct.Controls.Add(this.checkBoxSpecialPackage);
            this.groupBoxAddProduct.Controls.Add(this.label3);
            this.groupBoxAddProduct.Controls.Add(this.label4);
            this.groupBoxAddProduct.Controls.Add(this.label5);
            this.groupBoxAddProduct.Controls.Add(this.label2);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(12, 176);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(357, 248);
            this.groupBoxAddProduct.TabIndex = 6;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Would you like to add special package";
            // 
            // checkBoxSpecialPackage
            // 
            this.checkBoxSpecialPackage.AutoSize = true;
            this.checkBoxSpecialPackage.Location = new System.Drawing.Point(258, 175);
            this.checkBoxSpecialPackage.Name = "checkBoxSpecialPackage";
            this.checkBoxSpecialPackage.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSpecialPackage.TabIndex = 12;
            this.checkBoxSpecialPackage.UseVisualStyleBackColor = true;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 16;
            this.listBoxCategory.Items.AddRange(new object[] {
            "Kids",
            "Electricity",
            "Office",
            "Clothes"});
            this.listBoxCategory.Location = new System.Drawing.Point(116, 96);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(160, 68);
            this.listBoxCategory.TabIndex = 14;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(116, 67);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(160, 22);
            this.textBoxProductPrice.TabIndex = 15;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(116, 39);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(160, 22);
            this.textBoxProductName.TabIndex = 16;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(103, 208);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(109, 23);
            this.btnSaveProduct.TabIndex = 17;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // groupBoxCurrentProductCart
            // 
            this.groupBoxCurrentProductCart.Controls.Add(this.listViewCurrentProductCart);
            this.groupBoxCurrentProductCart.Location = new System.Drawing.Point(377, 12);
            this.groupBoxCurrentProductCart.Name = "groupBoxCurrentProductCart";
            this.groupBoxCurrentProductCart.Size = new System.Drawing.Size(546, 412);
            this.groupBoxCurrentProductCart.TabIndex = 7;
            this.groupBoxCurrentProductCart.TabStop = false;
            this.groupBoxCurrentProductCart.Text = "Current product cart";
            this.groupBoxCurrentProductCart.Visible = false;
            // 
            // listViewCurrentProductCart
            // 
            this.listViewCurrentProductCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.product_name,
            this.id,
            this.price,
            this.extra_price});
            this.listViewCurrentProductCart.HideSelection = false;
            this.listViewCurrentProductCart.Location = new System.Drawing.Point(6, 21);
            this.listViewCurrentProductCart.Name = "listViewCurrentProductCart";
            this.listViewCurrentProductCart.Size = new System.Drawing.Size(530, 385);
            this.listViewCurrentProductCart.TabIndex = 0;
            this.listViewCurrentProductCart.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentProductCart.View = System.Windows.Forms.View.Details;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 100;
            // 
            // product_name
            // 
            this.product_name.Text = "Product name";
            this.product_name.Width = 100;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 100;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 100;
            // 
            // extra_price
            // 
            this.extra_price.Text = "Extra Price";
            this.extra_price.Width = 100;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.groupBoxCurrentProductCart);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.groupBoxAddProductToSeller);
            this.Name = "Form5";
            this.Text = "Add Product To Seller";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBoxAddProductToSeller.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            this.groupBoxCurrentProductCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddProductToSeller;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxSpecialPackage;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.GroupBox groupBoxCurrentProductCart;
        private System.Windows.Forms.ListView listViewCurrentProductCart;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader extra_price;
    }
}