using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using popelOrderingSystem.BusinessLayer;
using popelOrderingSystem.DatabaseLayer;

namespace popelOrderingSystem.PresentationLayer
{
    public partial class CreateNewCustomerForm : Form
    {
        #region DataMembers 
        private CustomerType.ShopType provValue;
        private CustomerController customerController;
        private Customer customer;

        public bool customerFormClosed = false;
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

        #region Constructor 
        public CreateNewCustomerForm(CustomerController aController)
        {
            InitializeComponent();
            customerController = aController;
        }

        public CreateNewCustomerForm ()
        {

        }
        #endregion


        #region Utility Methods
        private void ShowAll(bool value)
        {
            textBoxAddress.Visible = value;
            textBoxName.Visible = value;
            textBoxPhoneNumber.Visible = value;
            textBoxEmail.Visible = value;
            textNumber.Visible = value;
            txtProvince.Visible = value;

            lablNumber.Visible = value;
            lblName.Visible = value;
            lblAddress.Visible = value;
            lblPhone.Visible = value;
            lblEmail.Visible = value;
            lblProvince.Visible = value;
        }

        private void ClearAll()
        {
            textBoxAddress.Text = "";
            textBoxName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxEmail.Text = "";
            textNumber.Text = "";
        }

        private void PopulateObject(CustomerType.ShopType provtype)
        {
            smallBusiness wc;
            retailers nwc;
            customer = new Customer(provtype);

            customer.getCustomerNumber = textNumber.Text;
            customer.getemail = textBoxEmail.Text;
            customer.getName = textBoxName.Text;
            customer.getphone = textBoxPhoneNumber.Text;
            customer.getAddress = textBoxAddress.Text;

            switch (customer.Cuscat.getCustomervalue)
            {
                case CustomerType.ShopType.smallBusiness:
                    wc = (smallBusiness)(customer.Cuscat);
                    wc.getDescription = txtProvince.Text.ToString();
                    break;
                case CustomerType.ShopType.retailers:
                    nwc = (retailers)(customer.Cuscat);
                    nwc.getDescription = txtProvince.Text.ToString();
                    //nwc.getdeliveryFee = decimal.Parse(txtDelivery.Text);
                    break;
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            PopulateObject(provValue);
            MessageBox.Show("To be submitted to the Database!");
            customerController.DataMaintenance(customer, DB.DBOperation.Add);
            customerController.FinalizeChanges(customer);
            ClearAll();
            ShowAll(false);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ShowAll(false);



        }

        private void CustomerForm_Activated(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        private void tradeCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Trade Customer";
            provValue = CustomerType.ShopType.tradeCustomer;
            ShowAll(true);
            textNumber.Focus();
        }

        private void smallBusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            this.Text = "Add Small Business";
            provValue = CustomerType.ShopType.smallBusiness;
            ShowAll(true);
            textNumber.Focus();
        }

        private void retailersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Retailers";
            provValue = CustomerType.ShopType.retailers;
            ShowAll(true);
            textNumber.Focus();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (IsValidScore())
                {
                    PopulateObject(provValue);
                    MessageBox.Show("Are you sure you want to save this Customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //== DialogResult.Yes );
                    customerController.DataMaintenance(customer, DB.DBOperation.Add);
                    customerController.FinalizeChanges(customer);
                    ClearAll();
                    ShowAll(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }

            
        }


        #region DATA VALIDATION METHODS

        private bool IsValidScore()
        {
            return
                IsPresent(textNumber, "CustomerNumber");
                
        }

     

        private bool IsPresent(TextBox textNumber, string CustomerNumber)
        {
            if (textNumber.Text == "")
            {
                MessageBox.Show(CustomerNumber + " is a required field.", "Entry Error");
                textNumber.Focus();
                return false;
            }
            return true;
        }

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           customerFormClosed=true;
        }
    }
}
