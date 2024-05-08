using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class productCategory
    {
        #region data members
        public enum productType
        {
            nOcateegory = 0,
            confectionery = 1,
            softdrinks = 2,
        }
        protected productType productcat;
        protected string description;
        #endregion


        #region  
        public productCategory()
        {
            productcat = productCategory.productType.nOcateegory;
            description = "NO cateegory";
        }
        #endregion

        #region Property Methods

        public productType getCategoryvalue
        {
            get { return productcat; }
            set { productcat = value; }
        }

        public string getDescription
        {
            get { return description; }
            set { description = value; }
        }
        #endregion
    }
}
