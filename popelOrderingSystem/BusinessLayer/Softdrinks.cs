using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public class Softdrinks: productCategory
    {
       

        #region Constructors
        public Softdrinks() : base()
        {


            getCategoryvalue = productCategory.productType.softdrinks;
            description = "soft drinks";
           

        }
        #endregion

       

        
    }
}
