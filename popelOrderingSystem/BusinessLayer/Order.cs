using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace popelOrderingSystem.BusinessLayer
{
    public class Order
    {
        #region Data Member
        private string productId;
        private string ProductName;
        private string orderQty;
        private string orderPrice;
        private string orderTot;
        public  OrderStatus orderTy;

        #endregion

        #region Constructor 
        public Order(OrderStatus.orderType orderCatag)
        {
            switch (orderCatag)
            {
                
                case OrderStatus.orderType.Processing:
                    orderTy = new Processing();
                    break;
                case OrderStatus.orderType.Collected:
                    orderTy = new Collected();
                    break;

            }
        }
        public Order()
        {
        }
        public Order( string ProductName, string productId, string orderQty, string orderPrice, string orderTot)
        {
     
            this .getProductName = ProductName;
            this .getProductId = productId;
        
            this .getOrderQty = orderQty;
            this .getOrderPrice = orderPrice;
            this .getOrderTot = orderTot;


        }
        #endregion

        #region Property methods

        public string getProductName
        {
            get { return  ProductName; }
            set { ProductName = value; }
        }
      

        public string getProductId
        {
            get { return productId; }
            set { productId = value; }

        }

       
        public string getOrderQty
        {
            get { return orderQty; }
            set { orderQty = value; }
        }

        public string getOrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }

        public string getOrderTot
        {
            get { return orderTot; }
            set { orderTot = value; }
        }
        

        #endregion
    }
}
