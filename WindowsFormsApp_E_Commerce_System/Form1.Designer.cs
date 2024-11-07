namespace WindowsFormsApp_E_Commerce_System
{
    partial class Form1
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
            this.groupBoxMenue = new System.Windows.Forms.GroupBox();
            this.btnADDBUYER = new System.Windows.Forms.Button();
            this.btnDisplayAllUsers = new System.Windows.Forms.Button();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.btnAddProductToSeller = new System.Windows.Forms.Button();
            this.btnAddProductToBuyer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenue
            // 
            this.groupBoxMenue.Controls.Add(this.btnADDBUYER);
            this.groupBoxMenue.Controls.Add(this.btnDisplayAllUsers);
            this.groupBoxMenue.Controls.Add(this.btnAddSeller);
            this.groupBoxMenue.Controls.Add(this.btnAddProductToSeller);
            this.groupBoxMenue.Controls.Add(this.btnAddProductToBuyer);
            this.groupBoxMenue.Location = new System.Drawing.Point(462, 133);
            this.groupBoxMenue.Name = "groupBoxMenue";
            this.groupBoxMenue.Size = new System.Drawing.Size(320, 178);
            this.groupBoxMenue.TabIndex = 19;
            this.groupBoxMenue.TabStop = false;
            this.groupBoxMenue.Text = "MENUE";
            // 
            // btnADDBUYER
            // 
            this.btnADDBUYER.Location = new System.Drawing.Point(6, 29);
            this.btnADDBUYER.Name = "btnADDBUYER";
            this.btnADDBUYER.Size = new System.Drawing.Size(255, 23);
            this.btnADDBUYER.TabIndex = 19;
            this.btnADDBUYER.Text = "ADD BUYER";
            this.btnADDBUYER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADDBUYER.UseVisualStyleBackColor = true;
            this.btnADDBUYER.Click += new System.EventHandler(this.btnAddBuyer_Click);
            // 
            // btnDisplayAllUsers
            // 
            this.btnDisplayAllUsers.Location = new System.Drawing.Point(6, 145);
            this.btnDisplayAllUsers.Name = "btnDisplayAllUsers";
            this.btnDisplayAllUsers.Size = new System.Drawing.Size(255, 23);
            this.btnDisplayAllUsers.TabIndex = 23;
            this.btnDisplayAllUsers.Text = "DISPLAY ALL USERS";
            this.btnDisplayAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayAllUsers.UseVisualStyleBackColor = true;
            this.btnDisplayAllUsers.Click += new System.EventHandler(this.btnDisplayAllUsers_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Location = new System.Drawing.Point(6, 58);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(255, 23);
            this.btnAddSeller.TabIndex = 20;
            this.btnAddSeller.Text = "ADD SELLER";
            this.btnAddSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSeller.UseVisualStyleBackColor = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // btnAddProductToSeller
            // 
            this.btnAddProductToSeller.Location = new System.Drawing.Point(6, 116);
            this.btnAddProductToSeller.Name = "btnAddProductToSeller";
            this.btnAddProductToSeller.Size = new System.Drawing.Size(255, 23);
            this.btnAddProductToSeller.TabIndex = 22;
            this.btnAddProductToSeller.Text = "ADD PRODUCT TO SELLER";
            this.btnAddProductToSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProductToSeller.UseVisualStyleBackColor = true;
            this.btnAddProductToSeller.Click += new System.EventHandler(this.btnAddProductToSeller_Click);
            // 
            // btnAddProductToBuyer
            // 
            this.btnAddProductToBuyer.Location = new System.Drawing.Point(6, 87);
            this.btnAddProductToBuyer.Name = "btnAddProductToBuyer";
            this.btnAddProductToBuyer.Size = new System.Drawing.Size(255, 23);
            this.btnAddProductToBuyer.TabIndex = 21;
            this.btnAddProductToBuyer.Text = "ADD PRODUCT TO BUYER";
            this.btnAddProductToBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProductToBuyer.UseVisualStyleBackColor = true;
            this.btnAddProductToBuyer.Click += new System.EventHandler(this.btnAddProductToBuyer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(540, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "       E-KINGUR \r\nE Commerce System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1229, 593);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxMenue);
            this.Name = "Form1";
            this.Text = "Menue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMenue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenue;
        private System.Windows.Forms.Button btnADDBUYER;
        private System.Windows.Forms.Button btnDisplayAllUsers;
        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.Button btnAddProductToSeller;
        private System.Windows.Forms.Button btnAddProductToBuyer;
        private System.Windows.Forms.Label label4;
    }
}

