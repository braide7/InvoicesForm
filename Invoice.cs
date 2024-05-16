using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesComp
{
    class Invoice
    {
        private int invID, custID;
        private Date invDate;

        public Invoice(int invoiceID, int customerID, int m, int d, int y)
        {
            InvoiceID = invoiceID;
            CustID = customerID;
            InvDate = new Date(m, d, y);
        }

        public int InvoiceID
        {
            get { return this.invID; }
            set { this.invID = value; }
        }

        public int CustID
        {
            get { return this.custID; }
            set { this.custID = value; }
        }

        public Date InvDate 
        {
            get { return this.invDate; }
            set { this.invDate = value; }
        }
            
    }
}
