using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public class CustomerType
    {

        #region data members
        public enum ShopType
        {
            tradeCustomer = 0,
            smallBusiness = 1,
            retailers = 2,
        }
        protected ShopType Customercat;
        protected string description;
        #endregion

        #region constructor 
        public CustomerType()
        {
            Customercat = CustomerType.ShopType.tradeCustomer;
            description = "Trade Customer";
        }
        #endregion

        #region Property Methods

        public ShopType getCustomervalue
        {
            get { return Customercat; }
            set { Customercat = value; }
        }

        public string getDescription
        {
            get { return description; }
            set { description = value; }
        }

        #endregion
        #region Method 
        public virtual decimal Total()
        {
            return 0;
        }

        #endregion
    }
}
