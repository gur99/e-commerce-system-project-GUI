namespace WindowsFormsApp_E_Commerce_System
{
    partial class Form6
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
            this.listViewSellers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.building_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listViewBuyers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewSellers
            // 
            this.listViewSellers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user_name,
            this.password,
            this.street,
            this.building_number,
            this.city,
            this.state});
            this.listViewSellers.HideSelection = false;
            this.listViewSellers.Location = new System.Drawing.Point(12, 45);
            this.listViewSellers.Name = "listViewSellers";
            this.listViewSellers.Size = new System.Drawing.Size(776, 170);
            this.listViewSellers.TabIndex = 0;
            this.listViewSellers.UseCompatibleStateImageBehavior = false;
            this.listViewSellers.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sellers";
            // 
            // user_name
            // 
            this.user_name.Text = "user name";
            this.user_name.Width = 100;
            // 
            // password
            // 
            this.password.Text = "password";
            this.password.Width = 100;
            // 
            // street
            // 
            this.street.Text = "street";
            this.street.Width = 100;
            // 
            // building_number
            // 
            this.building_number.Text = "building number";
            this.building_number.Width = 100;
            // 
            // city
            // 
            this.city.Text = "city";
            this.city.Width = 100;
            // 
            // state
            // 
            this.state.Text = "state";
            this.state.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buyers";
            // 
            // listViewBuyers
            // 
            this.listViewBuyers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewBuyers.HideSelection = false;
            this.listViewBuyers.Location = new System.Drawing.Point(15, 240);
            this.listViewBuyers.Name = "listViewBuyers";
            this.listViewBuyers.Size = new System.Drawing.Size(776, 170);
            this.listViewBuyers.TabIndex = 2;
            this.listViewBuyers.UseCompatibleStateImageBehavior = false;
            this.listViewBuyers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "user name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "password";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "street";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "building number";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "city";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "state";
            this.columnHeader6.Width = 100;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewBuyers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSellers);
            this.Name = "Form6";
            this.Text = "Display Users";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSellers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader building_number;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewBuyers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}