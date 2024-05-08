using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class Product
    {
        #region Data Member 
        public string productId;
        private string Name;
        private string Qty;
        private string price ;
        public productCategory category;
        public DateTime ExpiryDate; 
        #endregion

        #region Constructor 

        public Product()
        {
        }
        public Product(string productId, string Name, string Qty, string price, DateTime ExpiryDate)
        {
            this.getProductID = productId;
            this.getName = Name;
            this.getQty = Qty;
            this.getPrice = price;
            this.getExpiryDate = ExpiryDate;



        }
        public Product (productCategory.productType productcat)
        {
            switch (productcat)
            {
                case productCategory.productType.confectionery:
                    category = new Confectionery();
                    break;
                case productCategory.productType.softdrinks:
                    category = new Softdrinks();
                    break;
               


            }
        }


        #endregion

        #region Properties 

        public string getProductID
        {
            get {return productId; }
            set { productId = value;}
        }

        public string getName
        {
            get {return Name; }
            set { Name = value;}
        }

        public string getQty
        {
          get { return Qty; }
          set { Qty = value;}
        }

        public string getPrice
        {
            get { return price;}
            set {price = value;}
        }

       public DateTime getExpiryDate
        {
            get { return ExpiryDate; }
            set { ExpiryDate = value;}
        }

        #endregion


        #region override method
        public override string ToString()
        {
            string s = this.getProductID + " "        + this.getName ;
            return s;
        }


        #endregion
    }
}
