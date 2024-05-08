using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using popelOrderingSystem.DatabaseLayer;


namespace popelOrderingSystem.BusinessLayer
{
    public class OrderController
    {
        #region Data Members 
        private OrderDB orderDB;
        private Collection<Order> orders;
        private Collection<Product> products;
        private Collection<Customer> customers;

        private Product product;
        private Customer customer;
        #endregion

        #region Properties
        public Collection<Order> Allorder
        {
            get
            {
                return orderDB.Allorders;
            }
        }
        #endregion


        #region Constructor
        public OrderController()
        {
            orderDB = new OrderDB();
            orders = orderDB.Allorders;
        }
        #endregion

        #region DataCommunication
        public void DataMaintenance(Order anOrd, DB.DBOperation operation)
        {
            int index = 0;

            orderDB.DataSetChange(anOrd, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    orders.Add(anOrd);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(anOrd);
                    orders[index] = anOrd;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(anOrd);
                    products.RemoveAt(index);
                    break;
            }



        }


        #endregion

        #region Search Methods
        //This method(function) searched through all the orders to finds onlly those with the required stattus
        public Collection<Order> FindByRole(Collection<Order> Ord, OrderStatus.orderType ordValue)
        {
            Collection<Order> matches = new Collection<Order>();

            foreach (Order emp in Ord)
            {
                if (emp.orderTy.getorderStatus == ordValue)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }

        public Order Find(string orderNumber)
        {
            int index = 0;
            bool found = (orders[index].getProductId == orderNumber);  //check if it is the first record
            int count = orders.Count;
            while (!(found) && (index < orders.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (orders[index].getProductId == orderNumber);   // this will be TRUE if found
            }
            return orders[index]; // this is the one!  
        }



        public int FindIndex(Order anOrd)
        {
            int counter = 0;
            bool found = false;
            found = anOrd.getProductId == orders[counter].getProductId;   //using a Boolean Expression to initialise found
            while (!(found) & counter < products.Count - 1)
            {
                counter += 1;
                found = (anOrd.getProductId == orders[counter].getProductId);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion

    }
}
