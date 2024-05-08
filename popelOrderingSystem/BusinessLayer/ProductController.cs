using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using popelOrderingSystem.DatabaseLayer;
namespace popelOrderingSystem.BusinessLayer
{
    public  class ProductController
    {
        #region Data Members 
        private ProductDB productDB;
        private Collection<Product> products;
        #endregion

        #region Properties
        public Collection<Product> Allproduct
        {
            get
            {
                return products;
            }
        }
        #endregion

        #region Constructor
        public ProductController()
        {
            productDB = new ProductDB();
            products = productDB.Allproduct;
        }
        #endregion

        #region DataCommunication
        public void DataMaintenance(Product aProd, DB.DBOperation operation)
        {
            int index = 0;

            productDB.DataSetChange(aProd, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    products.Add(aProd);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aProd);
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aProd);
                    products.RemoveAt(index);
                    break;
            }
        }
        #endregion

        #region Commit the changes to the database
        public bool FinalizeChanges(Product product)
        {
            return productDB.UpdateDataSource(product);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the products to finds onlly those with the required category
        public Collection<Product> FindByRole(Collection<Product> pro, productCategory.productType provValue)
        {
            Collection<Product> matches = new Collection<Product>();

            foreach (Product emp in pro)
            {
                if (emp.category.getCategoryvalue == provValue)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }

        public Product Find(string productId)
        {
            int index = 0;
            bool found = (products[index].getProductID == productId);  //check if it is the first record
            int count = products.Count;
            while (!(found) && (index < products.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (products[index].getProductID == productId);   // this will be TRUE if found
            }
            return products[index]; // this is the one!  
        }
       
        public int FindIndex(Product aProd)
        {
            int counter = 0;
            bool found = false;
            found = (aProd.getProductID == products[counter].getProductID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < products.Count - 1)
            {
                counter += 1;
                found = (aProd.getProductID == products[counter].getProductID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region findExpiredProducts

        public List<Product> FindAll()
        {
            return products.ToList();
        }

        public List<Product> FindExpired()
        {
            //DateTime today = DateTime.Today;
            //DateTime firstExp = products.ToList().First().ExpiryDate;
            //bool isExpierd = firstExp < today;
            List<Product> expProducts = products.ToList().FindAll(item => item.ExpiryDate < DateTime.Today);
            return expProducts;
        }
        #endregion
    }

}
