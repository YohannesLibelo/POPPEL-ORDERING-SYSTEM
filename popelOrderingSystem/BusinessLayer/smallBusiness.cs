using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class smallBusiness :CustomerType
    {
        #region Data Members

        private decimal deliveryFee;
        #endregion

        #region Constructors
        public smallBusiness() : base()
        {
            getCustomervalue = CustomerType.ShopType.smallBusiness;
            description = " small Business";
           
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
