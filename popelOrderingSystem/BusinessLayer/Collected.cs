using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public  class Collected : OrderStatus
    {
        public Collected() : base()
        {
            getorderStatus = OrderStatus.orderType.Collected;
        }

      
    }
}
