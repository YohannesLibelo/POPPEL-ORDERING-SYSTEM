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

namespace popelOrderingSystem.PresentationLayer
{
    public partial class MainMDIParent1 : Form
    {
        private int childFormNumber = 0;
        private CustomerListingForm customerListForm;
        private CreateNewCustomerForm customerForm;
        private CustomerController customerController;
        private ProductListingandOrderForm productListForm;
        private ProductController productController;
        private OrderController orderController;
        


        public MainMDIParent1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customerController = new CustomerController();
            productController = new ProductController();
            orderController = new OrderController(); 

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

       
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (customerListForm == null)
            {
                CreateNewCustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewCustomerListForm();
            }

            customerListForm.setUpCustomerListView();
           
            customerListForm.Show();
        }

        private void CustomerMDIParent1_Load(object sender, EventArgs e)
        {

        }
        #region Create a New ChildForm 
        public void CreateNewCustomerForm()
        {
            customerForm = new CreateNewCustomerForm(customerController);
            customerForm.MdiParent = this;//Setting the MDI Parent
            customerForm.StartPosition = FormStartPosition.CenterParent;
        }

        public void CreateNewCustomerListForm()
        {
            customerListForm = new CustomerListingForm(customerController,productController);
            customerListForm.MdiParent = this;        // Setting the MDI Parent
            customerListForm.StartPosition = FormStartPosition.CenterParent;
        }


        public void CreateNewProductListForm()
        {
           productListForm = new ProductListingandOrderForm(productController);
           productListForm.MdiParent = this;        // Setting the MDI Parent
           productListForm.StartPosition = FormStartPosition.CenterParent;
       }

        #endregion

        private void closecurrentForms()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }


        private void retailersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            closecurrentForms();


            if (customerListForm == null)
            {
                CreateNewCustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewCustomerListForm();
            }
            customerListForm.ProvValue = CustomerType.ShopType.retailers;
            customerListForm.setUpCustomerListView();
            customerListForm.Dock = DockStyle.Fill;
            customerListForm.Show();
        }

        private void smallBusinessToolStripMenuItem_Click_1(object sender, EventArgs e)
        {




            closecurrentForms();

            if (customerListForm == null)
            {
                CreateNewCustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewCustomerListForm();
            }
            customerListForm.ProvValue = CustomerType.ShopType.smallBusiness;
            customerListForm.setUpCustomerListView();
            customerListForm.Dock = DockStyle.Fill;
            customerListForm.Show();
        }

        private void tradeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closecurrentForms();
            if (customerListForm == null)
            {
                CreateNewCustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewCustomerListForm();
            }
            customerListForm.ProvValue = CustomerType.ShopType.tradeCustomer;
            customerListForm.setUpCustomerListView();
            customerListForm.Dock= DockStyle.Fill;
            customerListForm.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closecurrentForms();
            CreateNewCustomerForm();
            customerForm.Dock = DockStyle.Fill;
            customerForm.Show();
            

        }

        private void confectioneryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closecurrentForms();
            if (productListForm == null)
            {
                CreateNewProductListForm();
            }
            if (productListForm.listFormClosed)
            {
                CreateNewProductListForm();
            }
            productListForm.ProdValue = productCategory.productType.confectionery;
            productListForm.setUpProductListView();
            productListForm.setUpProductShoppingCart();
            productListForm.Dock = DockStyle.Fill;
            productListForm.Show();
        }

        private void softdrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            closecurrentForms();
            if (productListForm == null)
            {
                CreateNewProductListForm();
            }
            if (productListForm.listFormClosed)
            {
                CreateNewProductListForm();
            }
            productListForm.ProdValue = productCategory.productType.softdrinks;
            productListForm.setUpProductListView();
            productListForm.setUpProductShoppingCart();
            productListForm.Dock = DockStyle.Fill;
            productListForm.Show();
        }

        private void expiredProductsToolStripMenuItem_Click(object sender, EventArgs e)

        {
            closecurrentForms();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        #region Print Functionality
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
            foreach (Product product in products)
            {
                productlist = productlist + product.ToString() + "\n";
            }

            //PrintHEading 
            StringToPrint = "A list of all  Expired Products in Inventory";
            e.Graphics.DrawString(StringToPrint, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);
            VerticalPrintMargin += HeadingLineSpacing;
            StringToPrint = productlist.ToString();
            VerticalPrintMargin += HeadingLineSpacing;
            e.Graphics.DrawString(StringToPrint, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);

            VerticalPrintMargin += HeadingLineSpacing * 2;

            



            #endregion


        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closecurrentForms();

            if (productListForm == null)
            {
                CreateNewProductListForm();
            }
            if (productListForm.listFormClosed)
            {
                CreateNewProductListForm();
            }
            productListForm.ProdValue = productCategory.productType.nOcateegory;
            productListForm.setUpProductListView();
            productListForm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void addToOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            closecurrentForms();

            if (productListForm == null)
            {
                CreateNewProductListForm();
            }
            if (productListForm.listFormClosed)
            {
                CreateNewProductListForm();
            }
            productListForm.ProdValue = productCategory.productType.nOcateegory;
            productListForm.setUpProductListView();
            productListForm.Show();
            
        }

        

        
    }
}
