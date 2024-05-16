using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesComp
{
    class Customer
    {
        private int custID;
        private string custFName, custLName;

        public Customer(int ID, string firstName, string lastName) 
        {
            CustID = ID;
            CustFName = firstName;
            CustLName = lastName;

        }

        public int CustID 
        {
            get { return this.custID; }
            set { this.custID = value; }
        }

        public string CustFName
        {
            get { return this.custFName; }
            set { this.custFName = value; }
        }

        public string CustLName
        {
            get { return this.custLName; }
            set { this.custLName = value; }
        }

        public string getFullName() => this.CustFName + " " + this.CustLName;
    }
}
