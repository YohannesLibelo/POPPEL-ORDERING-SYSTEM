using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public class retailers : CustomerType
    {
        #region Data Members

        private decimal deliveryFee;

        #endregion

        #region Constructors
        public retailers() : base()
        {
            getCustomervalue = CustomerType.ShopType.retailers;
            description = "Retailers";
            deliveryFee = 0;

        }
        #endregion

        #region Property Method 
        public decimal getdeliveryFee
        {
            get { return deliveryFee; }
            set { deliveryFee = value; }
        }

        #endregion

        #region Method 
        public override decimal Total()
        {
            return deliveryFee;
        }

        #endregion
    }
}
