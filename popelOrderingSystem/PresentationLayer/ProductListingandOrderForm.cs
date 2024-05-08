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
    public partial class ProductListingandOrderForm : Form
    {
        #region Variables
        public bool listFormClosed;
        private Collection<Product> products;
       
        private productCategory.productType prodValue;
        private Customer customer;
        private ProductController productController;
       
        private FormStates state;
        private Product product;
        private int productIndex = -1;
        decimal total;
        #endregion

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion

        #region Constructor
        public ProductListingandOrderForm(ProductController proController, Customer cust)
        {

            InitializeComponent();
            productController = proController;
            customer = cust;
            customerName.Text = cust.getName;
            this.Load += ProductListingForm_Load;
            this.Activated += ProductListingForm_Activated;
            this.FormClosed += CustomerListingForm_FormClosed;
            state = FormStates.View;
        }
        public ProductListingandOrderForm(ProductController proController)
        {

            InitializeComponent();
            productController = proController;
            this.Load += ProductListingForm_Load;
            this.Activated += ProductListingForm_Activated;
            this.FormClosed += CustomerListingForm_FormClosed;
            state = FormStates.View;
        }

        public ProductListingandOrderForm ()
        {
        }

        #endregion

        #region Property Method 
        public productCategory.productType ProdValue
        {
            set
            {
                prodValue = value;
            }
        }
        #endregion

        #region The List View 

        public void setUpProductListView()
        {
            ListViewItem productDetails;   //Declare variables
           
            //Clear current List View Control
            productListView.Clear();
            //Set Up Columns of List View
            productListView.Columns.Insert(0, "ProductNumber", 120, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Name", 150, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Price", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Quantity", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "ExpiryDate", 100, HorizontalAlignment.Left);

            products = null;                                                                    //customer collection will be filled by customerType

            switch (prodValue)
            {

                case productCategory.productType.nOcateegory:
                    products = productController.Allproduct;
                    listLabel.Text = "Listing of all Products";
                    break;

                case productCategory.productType.softdrinks:
                    products = productController.FindByRole(productController.Allproduct, productCategory.productType.softdrinks);
                    listLabel.Text = "Listing of all softdrinks";
                    //customerListView.Columns.Insert(5, "description", 100, HorizontalAlignment.Center);
                    break;
                case productCategory.productType.confectionery:
                    products = productController.FindByRole(productController.Allproduct, productCategory.productType.confectionery);
                    listLabel.Text = "Listing of all confectionery";
                    //customerListView.Columns.Insert(5, "description", 100, HorizontalAlignment.Center);
                    break;

            }


            //Add customer details to each ListView item 
            foreach (Product product in products)
            {

                productDetails = new ListViewItem();
                productDetails.Text = product.getProductID.ToString();
                productDetails.SubItems.Add(product.getName);
                productDetails.SubItems.Add(product.getPrice);
                productDetails.SubItems.Add(product.getQty);
                productDetails.SubItems.Add(product.getExpiryDate.ToString());

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
                productListView.Items.Add(productDetails);
            }
            productListView.Refresh();
            productListView.GridLines = true;
        }
        #endregion

        #region Form Events 
      
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

            productIdLabel.Visible = value;
            nameLabel.Visible = value;
            quantityLabel.Visible = value;
            priceLabel.Visible = value;
            categorylbl.Visible = value;



            cusNOTextBox.Visible = value;
            nameTextBox.Visible = value;
            quantityTextBox.Visible = value;
            priceTextBox.Visible = value;
            categoryTextbox.Visible = value;

        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                cusNOTextBox.Enabled = !value;
                cusNOTextBox.Enabled = !value;
                nameTextBox.Enabled = value;
                quantityTextBox.Enabled = value;
                priceTextBox.Enabled = value;
            }
            else
            {
                cusNOTextBox.Enabled = value;
                cusNOTextBox.Enabled = value;
            }
           

           
        }
        private void ClearAll()
        {
            cusNOTextBox.Text = "";
            cusNOTextBox.Text = "";
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";

        }
        private void PopulateTextBoxes(Product pro)
        {

            Softdrinks sofdri;
            Confectionery conf;


            cusNOTextBox.Text = pro.getProductID;
            nameTextBox.Text = pro.getName;
            quantityTextBox.Text = pro.getQty;
            priceTextBox.Text = pro.getPrice;


            switch (pro.category.getCategoryvalue)
            {
                case productCategory.productType.softdrinks:
                    sofdri = (Softdrinks)(pro.category);
                    categoryTextbox.Text = Convert.ToString(sofdri.getDescription);
                    break;
                case productCategory.productType.confectionery:
                    conf = (Confectionery)(pro.category);
                    categoryTextbox.Text = Convert.ToString(conf.getDescription);
                    break;

            }
        }
        private void PopulateObject(productCategory.productType protype)
        {
            Softdrinks sofdri;
            Confectionery conf;
            product = new Product(protype);

            product.getProductID = cusNOTextBox.Text;
            product.getName = nameTextBox.Text;
            product.getQty = quantityTextBox.Text;
            product.getPrice = priceTextBox.Text;

            switch (product.category.getCategoryvalue)
            {
                case productCategory.productType.softdrinks:
                    sofdri = (Softdrinks)(product.category);
                    sofdri.getDescription = categoryTextbox.Text.ToString();
                    break;
                case productCategory.productType.confectionery:
                    conf = (Confectionery)(product.category);
                    conf.getDescription = categoryTextbox.Text.ToString();
                    break;

            }
        }


        #endregion

        private void ProductListingForm_Activated(object sender, EventArgs e)
        {
               productListView.View = View.Details;
                //listViewShoppingCart = View.Details;
               setUpProductListView();
               setUpProductShoppingCart();
               ShowAll(true);
        }

        private void ProductListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void ProductListingForm_Load(object sender, EventArgs e)
        {
            productListView.View = View.Details;
            listViewShoppingCart.View= View.Details;
        }

        private void productListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (productListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                productIndex = productListView.SelectedItems[0].Index; 
              
                product = productController.Find(productListView.SelectedItems[0].Text);  //selected product becoms current product
                                                                                             //product = productController.Find(Convert.ToString(productListViews.SelectedItems[0]));  //selected product becomes current product
                PopulateTextBoxes(product);

            }
        }

      


    
        private void delete ()
        {
            
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure you want to Cancel an ORder  ??", "CANCEL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listViewShoppingCart.Items.RemoveAt(listViewShoppingCart.SelectedIndices[0]);
            }
        }
      

        private void AddToCartbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsValidData())
                {

                    ListViewItem item = new ListViewItem(cusNOTextBox.Text);
                    item.SubItems.Add(nameTextBox.Text);
                    item.SubItems.Add(priceTextBox.Text);
                    item.SubItems.Add(quantityTextBox.Text);
                    item.SubItems.Add(categoryTextbox.Text);
                    listViewShoppingCart.Items.Add(item);

                    total += (int.Parse(quantityTextBox.Text) * decimal.Parse(priceTextBox.Text));
                    productController.Find(cusNOTextBox.Text).getQty = (int.Parse(productController.Find(cusNOTextBox.Text).getQty) - int.Parse(quantityTextBox.Text)).ToString();

                    setUpProductListView();
                    totalCost.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }





        }
        public void setUpProductShoppingCart()
        {

            
            listViewShoppingCart.Clear();

            listViewShoppingCart.Columns.Insert(0, "ProductNumber", 120, HorizontalAlignment.Left);
            listViewShoppingCart.Columns.Insert(1, "Name", 150, HorizontalAlignment.Left);
            listViewShoppingCart.Columns.Insert(2, "Price", 100, HorizontalAlignment.Left);
            listViewShoppingCart.Columns.Insert(3, "Quantity", 100, HorizontalAlignment.Left);
            

            listViewShoppingCart.Refresh();
            listViewShoppingCart.GridLines = true;

          
        }
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            int fNumber = int.Parse(textBoxcredit.Text.Replace(",", ""));
            int sNumber = int.Parse(totalCost.Text.Replace(",", ""));

            if (fNumber < sNumber)
            {
                MessageBox.Show("Customer can not place Order. credit limit exceeded ", "credit limit exceeded ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information); //== DialogResult.Yes );
            }
               
            else
            {
                 printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {





            //Declarations
            Font BodyFont = new Font("Arial", 12);
            Font HeadingFont = new Font("Arial", 14, FontStyle.Bold);
            float HeadingLineSpacing = HeadingFont.GetHeight() + 2;
            float BodyLineSpacing = BodyFont.GetHeight() + 2;
            float HorizontalPrintMargin = e.MarginBounds.Left;
            float VerticalPrintMargin = e.MarginBounds.Top;
            string StringToPrint;

            List<Product> products = productController.FindExpired();
            String productlist = "";
            foreach (ListViewItem product in listViewShoppingCart.Items)
            {
                productlist += product.SubItems[0].Text + " " + product.SubItems[1].Text + " " + product.SubItems[2 ].Text  + product.SubItems[3].Text +  "\n";
            }
            //PrintHEading 
            StringToPrint = "Picking List for" ;
            e.Graphics.DrawString(StringToPrint, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);
            VerticalPrintMargin += HeadingLineSpacing;
            StringToPrint = productlist.ToString();
            VerticalPrintMargin += HeadingLineSpacing;
            e.Graphics.DrawString(StringToPrint, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);

            VerticalPrintMargin += HeadingLineSpacing * 2;

        }

        private void customerName_Click(object sender, EventArgs e)
        {

        }



        #region DATA VALIDATION 

        public bool IsValidData()
        {
            return

            IsWithinRange(quantityTextBox, "CustomerNumber", 0, 1000) &&
            IsDecimal(quantityTextBox, "CustomerNumber");

           

        }
        public bool IsWithinRange(TextBox quantityTextBox, string name,
             decimal min, decimal max)   
        {
            decimal number = Convert.ToDecimal(quantityTextBox.Text);
            if (number < 0 || number > 1000)
            {
                MessageBox.Show(name + " must be between " + 0 +
                " and " + 1000 + ".", "Entry Error");
                quantityTextBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox quantityTextBox, string Quantity)
        {
            decimal number = 0m;
            if (Decimal.TryParse(quantityTextBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(Quantity + " must be a decimal number.", "Entry Error");
                quantityTextBox.Focus();
                return false;
            }
        }

        #endregion 
    }
}
    
    

