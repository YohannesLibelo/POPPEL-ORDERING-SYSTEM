using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class Confectionery :productCategory
    {
        #region Data Members

        //private decimal deliveryFee;

        #endregion

        #region Constructors
        public Confectionery() : base()
        {


            getCategoryvalue = productCategory.productType.confectionery;
            description = "Confectionery";
            //deliveryFee = 0;

        }
        #endregion

       
    }
}
