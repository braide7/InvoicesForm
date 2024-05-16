using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesComp
{
    class InvoiceItem
    {
        private int invoiceID, line, inventoryID, qntySold;

        public InvoiceItem(int invoiceID, int lineNum, int inventoryID, int qntySold)
        {
            InvoiceID = invoiceID;
            LineNum = lineNum;
            InventoryID = inventoryID;
            QntySold = qntySold;
        }

        public int InvoiceID 
        {
            get { return this.invoiceID; }
            set { this.invoiceID = value; }
        }

        public int LineNum
        {
            get { return this.line; }
            set { this.line = value; }
        }

        public int InventoryID
        {
            get { return this.inventoryID; }
            set { this.inventoryID = value; }
        }

        public int QntySold
        {
            get { return this.qntySold; }
            set { this.qntySold = value; }
        }

    }
}
