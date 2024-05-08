using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popelOrderingSystem.BusinessLayer
{
    public class Person
    {
        #region Data Member
        private string Name;
        private string Address;
        private string email;
        private string phone;

        #endregion

        #region Constructor 

        public Person()
        {
        }
        public Person(string Name, string Address, string email, string phone)
        {
            this.getName = Name;
            this.getAddress = Address;
            this.getemail = email;
            this.getphone = phone;

        }
        #endregion

        #region Properties 
        public string getName
        {
            get { return Name; }
            set { Name = value; }
        }

        public String getAddress
        {
            get { return Address; }
            set { Address = value; }
        }

        public string getemail
        {
            get { return email; }
            set { email = value; }
        }

        public string getphone
        {
            get { return phone; }
            set { phone = value; }
        }

        #endregion
    }
}
