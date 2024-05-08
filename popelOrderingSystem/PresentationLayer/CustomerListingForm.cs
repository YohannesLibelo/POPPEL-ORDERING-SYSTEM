using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using popelOrderingSystem.BusinessLayer;
using popelOrderingSystem.DatabaseLayer;



namespace popelOrderingSystem.PresentationLayer
{
    public partial class CustomerListingForm : Form
    {
        #region Variables
        public bool listFormClosed;
        private Collection<Customer> customers;
        private CustomerType.ShopType provValue;
        private CustomerController customerController;
        private ProductController productController;
        private FormStates state;
        private Customer customer;
        


        #endregion

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3,
            AddtoOrder = 4
        }

        internal void customerListView_SelectedIndexChanged_1()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Constructor
        public CustomerListingForm(CustomerController cusController, ProductController PrpController)
        {

            InitializeComponent();
            customerController = cusController;
            productController= PrpController;
            this.Load += CustomerListingForm_Load;
            this.Activated += CustomerListingForm_Activated_1;
            this.FormClosed += CustomerListingForm_FormClosed;
          
            state = FormStates.View;
        }

        public CustomerListingForm ()
        {

        }
        #endregion

        #region Property Method 
        public CustomerType.ShopType ProvValue
        {
            set
            {
                provValue = value;
            }
        }
        #endregion

        #region The List View 
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;   //Declare variables
            
            //Clear current List View Control
            customerListView.Clear();
            //Set Up Columns of List View
            customerListView.Columns.Insert(0, "CustomerNumber", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(1, "Name", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(2, "phone", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(3, "email", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(4, "Address", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(5, "BlackListed", 100, HorizontalAlignment.Left);


            
            customers = null;                                                                    //customer collection will be filled by customerType

            switch (provValue)
            {
                case CustomerType.ShopType.tradeCustomer:
                    customers = customerController.FindByRole(customerController.Allcustomer, CustomerType.ShopType.tradeCustomer);
                    //listLabel.Text = "Listing of all tradeCustomer";
                    //customerListView.Columns.Insert(5, "description", 100, HorizontalAlignment.Center);
                    break;

                case CustomerType.ShopType.smallBusiness:
                    customers = customerController.FindByRole(customerController.Allcustomer, CustomerType.ShopType.retailers);
                    //listLabel.Text = "Listing of all smallBusiness customers";
                    //customerListView.Columns.Insert(5, "description", 100, HorizontalAlignment.Center);
                    break;
                case CustomerType.ShopType.retailers:
                    customers = customerController.FindByRole(customerController.Allcustomer, CustomerType.ShopType.retailers);
                    //listLabel.Text = "Listing of all Non retailers customers";
                   // customerListView.Columns.Insert(5, "description", 100, HorizontalAlignment.Center);

                    break;
            }


            //Add customer details to each ListView item 
            foreach (Customer customer in customers)
            {

                customerDetails = new ListViewItem();
                customerDetails.Text = customer.getCustomerNumber.ToString();
                customerDetails.SubItems.Add(customer.getName);
                customerDetails.SubItems.Add(customer.getphone);
                customerDetails.SubItems.Add(customer.getemail);
                customerDetails.SubItems.Add(customer.getAddress);
                customerDetails.SubItems.Add(customer.getblackListed);

               
                //switch (customer.Cuscat.getCustomervalue)
                //{
                //    case CustomerType.ShopType.smallBusiness:
                //        wc = (smallBusiness)customer.Cuscat;
                //        customerDetails.SubItems.Add(wc.getDescription.ToString());
                //        break;
                //    case CustomerType.ShopType.retailers:
                //        nwc = (retailers)customer.Cuscat;
                //        customerDetails.SubItems.Add(nwc.getDescription.ToString());
                //        customerDetails.SubItems.Add(nwc.getdeliveryFee.ToString());
                //        break;
                //}
                customerListView.Items.Add(customerDetails);
            }
            customerListView.Refresh();
            customerListView.GridLines = true;
        }
        #endregion

        #region Form Events 
        private void CustomerListingForm_Load(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
        }

        private void CustomerListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        //private void CustomerListingForm_Activated(object sender, EventArgs e)
        //{
        //    customerListView.View = View.Details;
        //    setUpCustomerListView();
        //    ShowAll(true);
        //}
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {

            cusNOLabel.Visible = value;
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            addressLabel.Visible = value;
            lblEmail.Visible = value;
            Creditlbl.Visible = value;
            blacklistedlbl.Visible = value;
            


            cusNOTextBox.Visible = value;
            nameTextBox.Visible = value;
            phoneTextBox.Visible = value;
            addressTextBox.Visible = value;
            emailTextbox.Visible = value;
            txtCredit.Visible = value;
            textBoxBlackListed.Visible = value;


            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;

        }
            private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                cusNOTextBox.Enabled = !value;
                cusNOTextBox.Enabled = !value;
            }
            else
            {
                cusNOTextBox.Enabled = value;
                cusNOTextBox.Enabled = value;
            }
            nameTextBox.Enabled = value;
            phoneTextBox.Enabled = value;
            addressTextBox.Enabled = value;

            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
        }
        private void ClearAll()
        {
            cusNOTextBox.Text = "";
            cusNOTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            addressTextBox.Text = "";

        }
        private void PopulateTextBoxes(Customer cus)
        {

          


            cusNOTextBox.Text = cus.getCustomerNumber;
            emailTextbox.Text = cus.getemail;
            nameTextBox.Text = cus.getName;
            phoneTextBox.Text = cus.getphone;
            addressTextBox.Text = cus.getAddress;
            txtCredit.Text = cus.getCredit.ToString();
            textBoxBlackListed.Text=cus.getblackListed.ToString();


            
        }
        private void PopulateObject(CustomerType.ShopType provtype)
        {
            
            customer = new Customer(provtype);

            customer.getCustomerNumber = cusNOTextBox.Text;
            customer.getemail = emailTextbox.Text;
            customer.getName = nameTextBox.Text;
            customer.getphone = phoneTextBox.Text;
            customer.getAddress = addressTextBox.Text;
            customer.getCredit = Convert.ToInt32(txtCredit.Text);
            customer.getblackListed = textBoxBlackListed.Text;

            
         }
        #endregion

       

        private void submitButton_Click(object sender, EventArgs e)
        {
            PopulateObject(provValue);
            if (state == FormStates.Edit)
            {
                customerController.DataMaintenance(customer, DB.DBOperation.Edit);

            }
            else//delete code
            {

            }
            customerController.FinalizeChanges(customer);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();   //refresh List View
        }

        private void CustomerListingForm_Load_1(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            PopulateObject(customer.Cuscat.getCustomervalue);
            if (state == FormStates.Edit)
            {
                customerController.DataMaintenance(customer, DB.DBOperation.Edit);

            }
            else//delete code
            {
                customerController.DataMaintenance(customer, DB.DBOperation.Delete);
            }
            customerController.FinalizeChanges(customer);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();   //refresh List View
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //set the form state to Edit
            state = FormStates.Edit;
            deleteButton.Visible = false;
            EnableEntries(true);//call the EnableEntities method
        }

        private void CustomerListingForm_Activated_1(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
            setUpCustomerListView();
            ShowAll(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            EnableEntries(false);//call the EnableEntities method
        }

        public  void customerListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (customerListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                customer = customerController.Find(customerListView.SelectedItems[0].Text);  //selected customer becoms current customer
                                                                                             //customer = customerController.Find(Convert.ToString(customerListViews.SelectedItems[0]));  //selected customer becomes current customer
                PopulateTextBoxes(customer);

            }
        }

        private void listLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBlackListed.Text == "True")
            {
                MessageBox.Show("Customer Can not place an order , Customer is Blacklisted", "TRUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            else 
            {
               
                
                PopulateObject(provValue);
                ProductListingandOrderForm proForm = new ProductListingandOrderForm(productController, customer);


                proForm.Show();



                proForm.customerName.Text = nameTextBox.Text;
                proForm.textBoxcredit.Text = txtCredit.Text;

            }


        }
    }
}

