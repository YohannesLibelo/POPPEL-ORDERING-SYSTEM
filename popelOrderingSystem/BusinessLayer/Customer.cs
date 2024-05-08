using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public class Customer :Person
    {
        #region Data Member
        public CustomerType Cuscat;
        private string customerNumber;
        private decimal credit;
        private decimal credit_limit;
        private string blackListed;

        #endregion

        #region Property methods
        public string getCustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }


        public string getblackListed
        {
            get { return blackListed; }
            set { blackListed = value; }
        }
        public decimal getCredit
        {
            get { return credit; }
            set { credit = value; }
        }

        public decimal getcreditlimit
        {
            get { return credit_limit; }
            set { credit_limit = value; }
        }


        #endregion

        #region Constructor
        public Customer(CustomerType.ShopType Customercatg) 
        {
            switch (Customercatg)
            {
                case CustomerType.ShopType.tradeCustomer:
                    Cuscat = new tradeCustomer();
                    break;
                case CustomerType.ShopType.smallBusiness:
                    Cuscat = new smallBusiness();
                    break;
                case CustomerType.ShopType.retailers:
                    Cuscat = new retailers();
                    break;
            }
        }
        #endregion

    }
}
