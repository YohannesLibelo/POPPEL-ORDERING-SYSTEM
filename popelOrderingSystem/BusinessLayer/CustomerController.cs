using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using popelOrderingSystem.BusinessLayer;
using System.Collections.ObjectModel;
using popelOrderingSystem.DatabaseLayer;

namespace popelOrderingSystem.BusinessLayer
{
    public class CustomerController 
    {
        #region Data Members
        private CustomerDB customerDB;
        private Collection<Customer> customers;
        #endregion

        #region Properties
        public Collection<Customer> Allcustomer
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerController()
        {
            customerDB = new CustomerDB();
            customers = customerDB.Allcustomer;
        }
        #endregion

        #region DataCommunication
        public void DataMaintenance(Customer aCus, DB.DBOperation operation)
        {
            int index = 0;

            customerDB.DataSetChange(aCus, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    customers.Add(aCus);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aCus);
                    customers[index] = aCus;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aCus);
                    customers.RemoveAt(index);
                    break;
            }
        }
        #endregion

        #region Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            return customerDB.UpdateDataSource(customer);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Collection<Customer> FindByRole(Collection<Customer> cus, CustomerType.ShopType provValue)
        {
            Collection<Customer> matches = new Collection<Customer>();

            foreach (Customer emp in cus)
            {
                if (emp.Cuscat.getCustomervalue == provValue)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }

        public Customer Find(string CustomerNumber)
        {
            int index = 0;
            bool found = (customers[index].getCustomerNumber == CustomerNumber);  //check if it is the first record
            int count = customers.Count;
            while (!(found) && (index < customers.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (customers[index].getCustomerNumber == CustomerNumber);   // this will be TRUE if found
            }
            return customers[index];  // this is the one!  
        }

        public int FindIndex(Customer aCus)
        {
            int counter = 0;
            bool found = false;
            found = (aCus.getCustomerNumber == customers[counter].getCustomerNumber);   //using a Boolean Expression to initialise found
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (aCus.getCustomerNumber == customers[counter].getCustomerNumber);
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
