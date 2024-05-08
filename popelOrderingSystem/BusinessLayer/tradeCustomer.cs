using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public class tradeCustomer : CustomerType
    {
        #region Data Members
        private decimal deliveryFee;

        #endregion

        #region Constructors
        public tradeCustomer() : base()
        {
            getCustomervalue = CustomerType.ShopType.tradeCustomer;
            description = " Trade Customer";
            deliveryFee = 0;
        }
        #endregion

        #region Property Methods 
        public decimal getdeliveryFee
        {
            get { return deliveryFee; }
            set { deliveryFee = value; }
        }

        #endregion

        #region Methods
        public override decimal Total()
        {
            return deliveryFee = 0;
        }
        #endregion
    }
}
