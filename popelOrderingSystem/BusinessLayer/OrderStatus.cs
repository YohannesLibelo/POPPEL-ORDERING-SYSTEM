using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class OrderStatus
    {
        #region data members
        public enum orderType
        {
            Processing = 1,
            Collected = 2,

        }
     

        private orderType orderStatus;
        protected string description;

        #endregion

        #region Property Methods

        public orderType getorderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }


        public string getDescription
        {
            get { return description; }
            set { description = value; }
        }
        #endregion
    }
}
