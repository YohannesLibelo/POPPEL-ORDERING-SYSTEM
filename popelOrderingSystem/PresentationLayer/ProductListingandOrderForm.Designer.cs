namespace popelOrderingSystem.PresentationLayer
{
    partial class ProductListingandOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListingandOrderForm));
            this.categorylbl = new System.Windows.Forms.Label();
            this.categoryTextbox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cusNOTextBox = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productListView = new System.Windows.Forms.ListView();
            this.listLabel = new System.Windows.Forms.Label();
            this.AddToCartbtn = new System.Windows.Forms.Button();
            this.createanOrderbtn = new System.Windows.Forms.Button();
            this.listViewShoppingCart = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.creditScore = new System.Windows.Forms.Label();
            this.textBoxcredit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylbl.ForeColor = System.Drawing.Color.Cyan;
            this.categorylbl.Location = new System.Drawing.Point(89, 479);
            this.categorylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(69, 17);
            this.categorylbl.TabIndex = 77;
            this.categorylbl.Text = "Category";
            // 
            // categoryTextbox
            // 
            this.categoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextbox.Location = new System.Drawing.Point(222, 475);
            this.categoryTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTextbox.Name = "categoryTextbox";
            this.categoryTextbox.ReadOnly = true;
            this.categoryTextbox.Size = new System.Drawing.Size(311, 23);
            this.categoryTextbox.TabIndex = 76;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(931, 444);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 54);
            this.deleteButton.TabIndex = 73;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(222, 419);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(311, 23);
            this.priceTextBox.TabIndex = 71;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.Cyan;
            this.priceLabel.Location = new System.Drawing.Point(119, 424);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 17);
            this.priceLabel.TabIndex = 70;
            this.priceLabel.Text = "Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(222, 446);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(311, 23);
            this.quantityTextBox.TabIndex = 69;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Cyan;
            this.quantityLabel.Location = new System.Drawing.Point(95, 452);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(63, 17);
            this.quantityLabel.TabIndex = 68;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(222, 393);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(311, 23);
            this.nameTextBox.TabIndex = 67;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.nameLabel.Location = new System.Drawing.Point(110, 398);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 17);
            this.nameLabel.TabIndex = 66;
            this.nameLabel.Text = "Name";
            // 
            // cusNOTextBox
            // 
            this.cusNOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNOTextBox.Location = new System.Drawing.Point(222, 366);
            this.cusNOTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusNOTextBox.Name = "cusNOTextBox";
            this.cusNOTextBox.ReadOnly = true;
            this.cusNOTextBox.Size = new System.Drawing.Size(311, 23);
            this.cusNOTextBox.TabIndex = 65;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productIdLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ForeColor = System.Drawing.Color.Cyan;
            this.productIdLabel.Location = new System.Drawing.Point(83, 372);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(75, 17);
            this.productIdLabel.TabIndex = 64;
            this.productIdLabel.Text = "Product Id";
            // 
            // productListView
            // 
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(96, 141);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(618, 141);
            this.productListView.TabIndex = 63;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.SelectedIndexChanged += new System.EventHandler(this.productListView_SelectedIndexChanged);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(52, 88);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(0, 13);
            this.listLabel.TabIndex = 62;
            // 
            // AddToCartbtn
            // 
            this.AddToCartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddToCartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartbtn.Location = new System.Drawing.Point(257, 530);
            this.AddToCartbtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddToCartbtn.Name = "AddToCartbtn";
            this.AddToCartbtn.Size = new System.Drawing.Size(144, 38);
            this.AddToCartbtn.TabIndex = 78;
            this.AddToCartbtn.Text = "Add to Cart";
            this.AddToCartbtn.UseVisualStyleBackColor = true;
            this.AddToCartbtn.Click += new System.EventHandler(this.AddToCartbtn_Click);
            // 
            // createanOrderbtn
            // 
            this.createanOrderbtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.createanOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createanOrderbtn.Location = new System.Drawing.Point(994, 444);
            this.createanOrderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.createanOrderbtn.Name = "createanOrderbtn";
            this.createanOrderbtn.Size = new System.Drawing.Size(67, 52);
            this.createanOrderbtn.TabIndex = 79;
            this.createanOrderbtn.Text = "Create an Order";
            this.createanOrderbtn.UseVisualStyleBackColor = true;
            this.createanOrderbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewShoppingCart
            // 
            this.listViewShoppingCart.HideSelection = false;
            this.listViewShoppingCart.Location = new System.Drawing.Point(758, 132);
            this.listViewShoppingCart.Name = "listViewShoppingCart";
            this.listViewShoppingCart.Size = new System.Drawing.Size(578, 141);
            this.listViewShoppingCart.TabIndex = 80;
            this.listViewShoppingCart.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Create an order for:";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.Color.Cyan;
            this.customerName.Location = new System.Drawing.Point(162, 61);
            this.customerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(0, 17);
            this.customerName.TabIndex = 83;
            this.customerName.Click += new System.EventHandler(this.customerName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(767, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Total Price:";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCost.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.ForeColor = System.Drawing.Color.Cyan;
            this.totalCost.Location = new System.Drawing.Point(887, 292);
            this.totalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(0, 17);
            this.totalCost.TabIndex = 88;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // creditScore
            // 
            this.creditScore.AutoSize = true;
            this.creditScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditScore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditScore.ForeColor = System.Drawing.Color.Cyan;
            this.creditScore.Location = new System.Drawing.Point(1084, 86);
            this.creditScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditScore.Name = "creditScore";
            this.creditScore.Size = new System.Drawing.Size(87, 17);
            this.creditScore.TabIndex = 89;
            this.creditScore.Text = "Credit Score";
            // 
            // textBoxcredit
            // 
            this.textBoxcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcredit.Location = new System.Drawing.Point(1181, 82);
            this.textBoxcredit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxcredit.Name = "textBoxcredit";
            this.textBoxcredit.ReadOnly = true;
            this.textBoxcredit.Size = new System.Drawing.Size(155, 23);
            this.textBoxcredit.TabIndex = 90;
            // 
            // ProductListingandOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::popelOrderingSystem.Properties.Resources.shopping_cart__new;
            this.ClientSize = new System.Drawing.Size(1526, 646);
            this.Controls.Add(this.textBoxcredit);
            this.Controls.Add(this.creditScore);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewShoppingCart);
            this.Controls.Add(this.createanOrderbtn);
            this.Controls.Add(this.AddToCartbtn);
            this.Controls.Add(this.categorylbl);
            this.Controls.Add(this.categoryTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cusNOTextBox);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.listLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "ProductListingandOrderForm";
            this.Text = "ProductListingForm";
            this.Activated += new System.EventHandler(this.ProductListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductListingForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categorylbl;
        private System.Windows.Forms.TextBox categoryTextbox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox cusNOTextBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Button AddToCartbtn;
        private System.Windows.Forms.Button createanOrderbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalCost;
        public System.Windows.Forms.Label customerName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label creditScore;
        public System.Windows.Forms.TextBox textBoxcredit;
        public System.Windows.Forms.ListView listViewShoppingCart;
    }
}