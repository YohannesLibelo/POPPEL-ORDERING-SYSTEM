namespace popelOrderingSystem.PresentationLayer
{
    partial class CustomerListingForm
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
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cusNOTextBox = new System.Windows.Forms.TextBox();
            this.cusNOLabel = new System.Windows.Forms.Label();
            this.customerListView = new System.Windows.Forms.ListView();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.Creditlbl = new System.Windows.Forms.Label();
            this.blacklistedlbl = new System.Windows.Forms.Label();
            this.textBoxBlackListed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(433, 445);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(137, 23);
            this.emailTextbox.TabIndex = 61;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(350, 449);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 60;
            this.lblEmail.Text = "Email";
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(836, 459);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(65, 37);
            this.cancelButton.TabIndex = 57;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(777, 457);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(54, 38);
            this.submitButton.TabIndex = 56;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(836, 405);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 45);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(777, 405);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(54, 45);
            this.editButton.TabIndex = 54;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(433, 415);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(137, 23);
            this.addressTextBox.TabIndex = 53;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(333, 418);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 52;
            this.addressLabel.Text = "Address";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(433, 385);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(137, 23);
            this.phoneTextBox.TabIndex = 51;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(316, 387);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 17);
            this.phoneLabel.TabIndex = 50;
            this.phoneLabel.Text = "Telephone";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(433, 355);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 23);
            this.nameTextBox.TabIndex = 49;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(347, 356);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Name";
            // 
            // cusNOTextBox
            // 
            this.cusNOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNOTextBox.Location = new System.Drawing.Point(433, 325);
            this.cusNOTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusNOTextBox.Name = "cusNOTextBox";
            this.cusNOTextBox.Size = new System.Drawing.Size(137, 23);
            this.cusNOTextBox.TabIndex = 47;
            // 
            // cusNOLabel
            // 
            this.cusNOLabel.AutoSize = true;
            this.cusNOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNOLabel.Location = new System.Drawing.Point(342, 325);
            this.cusNOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cusNOLabel.Name = "cusNOLabel";
            this.cusNOLabel.Size = new System.Drawing.Size(50, 17);
            this.cusNOLabel.TabIndex = 46;
            this.cusNOLabel.Text = "CusNo";
            // 
            // customerListView
            // 
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(275, 74);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(635, 225);
            this.customerListView.TabIndex = 45;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.SelectedIndexChanged += new System.EventHandler(this.customerListView_SelectedIndexChanged_1);
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoOrder.Location = new System.Drawing.Point(777, 501);
            this.btnAddtoOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(129, 38);
            this.btnAddtoOrder.TabIndex = 62;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = true;
            this.btnAddtoOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCredit
            // 
            this.txtCredit.BackColor = System.Drawing.Color.Red;
            this.txtCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCredit.Location = new System.Drawing.Point(834, 331);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.ReadOnly = true;
            this.txtCredit.Size = new System.Drawing.Size(76, 23);
            this.txtCredit.TabIndex = 63;
            // 
            // Creditlbl
            // 
            this.Creditlbl.AutoSize = true;
            this.Creditlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creditlbl.Location = new System.Drawing.Point(620, 331);
            this.Creditlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Creditlbl.Name = "Creditlbl";
            this.Creditlbl.Size = new System.Drawing.Size(142, 17);
            this.Creditlbl.TabIndex = 64;
            this.Creditlbl.Text = "Customer Credit Limit";
            // 
            // blacklistedlbl
            // 
            this.blacklistedlbl.AutoSize = true;
            this.blacklistedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistedlbl.Location = new System.Drawing.Point(244, 492);
            this.blacklistedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blacklistedlbl.Name = "blacklistedlbl";
            this.blacklistedlbl.Size = new System.Drawing.Size(148, 17);
            this.blacklistedlbl.TabIndex = 65;
            this.blacklistedlbl.Text = "Customer Black Listed";
            // 
            // textBoxBlackListed
            // 
            this.textBoxBlackListed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlackListed.Location = new System.Drawing.Point(433, 486);
            this.textBoxBlackListed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBlackListed.Name = "textBoxBlackListed";
            this.textBoxBlackListed.Size = new System.Drawing.Size(137, 23);
            this.textBoxBlackListed.TabIndex = 66;
            // 
            // CustomerListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::popelOrderingSystem.Properties.Resources.Cretenewcustomer;
            this.ClientSize = new System.Drawing.Size(1124, 663);
            this.Controls.Add(this.textBoxBlackListed);
            this.Controls.Add(this.Creditlbl);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.btnAddtoOrder);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cusNOTextBox);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.blacklistedlbl);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cusNOLabel);
            this.Name = "CustomerListingForm";
            this.Text = "CustomerListingForm";
            this.Activated += new System.EventHandler(this.CustomerListingForm_Activated_1);
            this.Load += new System.EventHandler(this.CustomerListingForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox cusNOTextBox;
        private System.Windows.Forms.Label cusNOLabel;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.Label Creditlbl;
        public System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label blacklistedlbl;
        private System.Windows.Forms.TextBox textBoxBlackListed;
    }
}