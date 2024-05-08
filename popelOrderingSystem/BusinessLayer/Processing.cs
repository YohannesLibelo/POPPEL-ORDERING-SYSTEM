using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class Processing : OrderStatus
    {
        public Processing (): base()
        {
            getorderStatus =  OrderStatus.orderType.Processing;
        }

     
    }
}
