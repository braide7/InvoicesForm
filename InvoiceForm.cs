using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesComp
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //radio button sorts customers by last name
        private void rBtnName_CheckedChanged(object sender, EventArgs e)
        {
            //checks if button is checked
            if (rBtnName.Checked)
            {
                //clears text box - left
                rTextLeft.Clear();

                //gets customer list
                List<Customer> custList = Program.getCustList();

                //LINQ to sort data
                var custByLastName =
                    from c in custList
                    orderby c.CustLName
                    select c;

                //loop through LINQ to display to form
                foreach (Customer c in custByLastName)
                {
                    rTextLeft.Text += $"{c.CustID}   {c.CustLName}, {c.CustFName}\n";
                }

            }
        }

        //radio button sorts by inventory ID
        private void rBtnInvID_CheckedChanged(object sender, EventArgs e)
        {
            //checks if button is checked
            if (rBtnInvID.Checked)
            {
                //clears rich text box  - left
                rTextLeft.Clear();

                //get list of inventory items
                List<Inventory> inventoryList = Program.getInventoryList();

                //LINQ sorts by inventory ID
                var invByInvID =
                    from i in inventoryList
                    orderby i.ItemID
                    select i;

                //loop through LINQ to display to form
                foreach (Inventory i in invByInvID)
                {
                    rTextLeft.Text += $"{i.ItemID}\t {i.ItemName}\t {i.ItemCost:c}\n";
                }

            }
        }

        //radio button sorts by customer ID
        private void rBtnCustID_CheckedChanged(object sender, EventArgs e)
        {
            //checks if button is checked
            if (rBtnCustID.Checked)
            {
                //clears text box - left
                rTextLeft.Clear();

                //gets Customer list 
                List<Customer> custList = Program.getCustList();

                //LINQ sorts customer by CustID
                var custByCustID =
                    from c in custList
                    orderby c.CustID
                    select c;

                //loop through LINQ displaying sorted customer info
                foreach (Customer c in custByCustID)
                {
                    rTextLeft.Text += $"{c.CustID}   {c.CustFName} {c.CustLName}\n";
                }

            }

        }

        //radio button sorts by cost
        private void rBtnInvCost_CheckedChanged(object sender, EventArgs e)
        {
            //checks if btn is clicked
            if (rBtnInvCost.Checked)
            {
                //clears text box - left
                rTextLeft.Clear();

                //gets inventory data
                List<Inventory> inventoryList = Program.getInventoryList();

                //LINQ to sort by Inventory Cost
                var invByInvCost =
                    from i in inventoryList
                    orderby i.ItemCost
                    select i;

                //Loop through LINQ display inventory by cost asc
                foreach (Inventory i in invByInvCost)
                {
                    rTextLeft.Text += $"{i.ItemCost:C}\t {i.ItemID}\t {i.ItemName}\n";
                }

            }
        }

        
        //radio button groups by invoices, displays all items and cost on invoice. Simulates long calculation
        private async void rBtnInvoices_CheckedChanged(object sender, EventArgs e)
        {
            //check if btn is checked
            if (rBtnInvoices.Checked)
            {
                double invoiceCost = 0;
                double totalInvoiceCost = 0;

                //clear rich text box - right
                rTextRight.Clear();

                //message to user indicating long calc
                rTextRight.Text = "Calculating. . .";

                //Task to run async - calcs fib(40) to simulate processing time
                Task<long> calcFib = Task.Run(() => Fibonacci(40));

                await calcFib;

                //import lists 
                List<Invoice> invoiceList = Program.getInvoiceList();
                List<InvoiceItem> lineItems = Program.getInvoiceItems();
                List<Customer> custList = Program.getCustList();
                List<Inventory> inventoryList = Program.getInventoryList();

                //LINQ, joins Invoices, line items, customer, and inventory. Groups by invoice ID
                var invoiceGroupByInvoiceID =
                    from i in invoiceList
                    join line in lineItems
                    on i.InvoiceID equals line.InvoiceID
                    join c in custList
                    on i.CustID equals c.CustID
                    join inv in inventoryList
                    on line.InventoryID equals inv.ItemID
                    group new
                    {
                        c.CustFName,
                        c.CustLName,
                        c.CustID,
                        i.InvDate,
                        inv.ItemName,
                        inv.ItemCost,
                        line.InventoryID,
                        line.QntySold,
                        line.LineNum,
                        i.InvoiceID,
                        lineCost = line.QntySold * inv.ItemCost
                    } by i.InvoiceID into invGr
                    orderby invGr.Key
                    select invGr;

                //removes calculating message
                rTextRight.Clear();

                rTextRight.Text = "Invoices\n\n";

                //loop through LINQ display invoices with line items, customer, date
                foreach (var inv in invoiceGroupByInvoiceID)
                {
                    rTextRight.Text += $"\nInvoice {inv.Key}\n";

                    int loop = 0;
                    invoiceCost = 0;
                    foreach (var i in inv)
                    {
                        //displays customer info and invoice date once
                        if (loop == 0)
                        {
                            rTextRight.Text += $"Customer {i.CustID} {i.CustFName} {i.CustLName}\t\t {i.InvDate}\n";
                            loop++;
                        }

                        //loops through line items, displays to user and calculates total cost
                        rTextRight.Text += $"{i.LineNum}    {i.ItemName}\t @{i.ItemCost:c}\t\t qty sold {i.QntySold}\t cost {i.lineCost:C}\n";
                        invoiceCost += i.lineCost;

                    }
                    totalInvoiceCost += invoiceCost;

                    //displays total cost for invoice
                    rTextRight.Text += $"Total for invoice: {invoiceCost:c}\n";
                }

                //displays total cost for all invoices 
                rTextRight.Text += $"Total for all invioces: {totalInvoiceCost:c}\n";

            }
        }


        //radio button groups by inventory items, displays total sold of item. Simulates long calculation
        private async void rBtnInvSold_CheckedChanged(object sender, EventArgs e)
        {
            //is btn checked
            if (rBtnInvSold.Checked)
            {
                double itemCost = 0;
                double totalCost = 0;

                //clears rich text box - right
                rTextRight.Clear();

                //message to user indicating long calc
                rTextRight.Text = "Calculating. . .";

                //Task to run async - calcs fib(40) to simulate processing time
                Task<long> calcFib = Task.Run(() => Fibonacci(40));

                await calcFib;

                //get lists of data
                List<InvoiceItem> lineItems = Program.getInvoiceItems();

                List<Inventory> inventoryList = Program.getInventoryList();

                //LINQ groups by inventory ID shows invoices item was purchased on and totals
                var invoiceGroupByInventoryID =
                    from i in inventoryList
                    join line in lineItems
                    on i.ItemID equals line.InventoryID
                    group new
                    {
                        i.ItemID,
                        i.ItemCost,
                        line.QntySold,
                        line.InvoiceID,
                        lineCost = line.QntySold * i.ItemCost

                    } by i.ItemID into soldGr
                    orderby soldGr.Key
                    select soldGr;



                //clears calculating message
                rTextRight.Clear();

                rTextRight.Text = "Inventory items sold\n\n";

                //Loop through LINQ 
                foreach (var inv in invoiceGroupByInventoryID)
                {
                    //displays inventory ID
                    rTextRight.Text += $"\nInventory item: {inv.Key}\n";


                    itemCost = 0;
                    foreach (var i in inv)
                    {
                        //displays invoice #, # sold, and line item cost
                        rTextRight.Text += $"   Invoice {i.InvoiceID}\t sold {i.QntySold}\t {i.lineCost:c}\n";
                        itemCost += i.lineCost;

                    }
                    totalCost += itemCost;
                    //displays total sold for that item
                    rTextRight.Text += $"   Total sold: {itemCost:c}\n";
                }
                //displays total sold overall
                rTextRight.Text += $"\nTotal cost for all items: {totalCost:c}\n";

            }

        }


        //radio button groups by customer invoices, displays invoice total cost. Simulates long calculation
        private async void rBtnInvCust_CheckedChanged(object sender, EventArgs e)
        {
            //is btn checked
            if (rBtnInvCust.Checked)
            {
                double invoiceCost = 0;
                double totalCost = 0;
                double custCost = 0;

                //clears rich text box - right
                rTextRight.Clear();

                //message to user indicating long calc
                rTextRight.Text = "Calculating. . .";

                //Task to run async - calcs fib(40) to simulate processing time
                Task<long> calcFib = Task.Run(() => Fibonacci(40));

                await calcFib;

                //get lists of data
                List<Invoice> invoiceList = Program.getInvoiceList();
                List<InvoiceItem> lineItems = Program.getInvoiceItems();
                
                List<Inventory> inventoryList = Program.getInventoryList();

                //LINQ groups invoices by customer
                var invoiceGroupByCustID =
                    from i in invoiceList
                    join line in lineItems
                    on i.InvoiceID equals line.InvoiceID
                    join inv in inventoryList
                    on line.InventoryID equals inv.ItemID

                    group new
                    {
                        i.CustID,
                        i.InvoiceID,
                        line.QntySold,
                        line.LineNum,
                        inv.ItemCost,
                        cost = line.QntySold * inv.ItemCost,
                        

                    } by i.CustID into custGr
                    orderby custGr.Key
                    select custGr;



                //removes calculating message
                rTextRight.Clear();

                rTextRight.Text = "Invoices sorted by Customer\n\n";

                foreach (var cust in invoiceGroupByCustID)
                {
                    //displays cust ID
                    rTextRight.Text += $"\nCustomer {cust.Key}\n";

                    
                    invoiceCost = 0;
                    custCost = 0;

                    foreach (var c in cust)
                    {
                        //checks to see if this is the first line item for invoice
                        if (c.LineNum.Equals(1))
                        {
                            //checks to see if invoice cost is 0 - if not display to user
                            if (invoiceCost != 0) 
                            {
                                //displays invoice total - only if cust has multiple invoices
                                rTextRight.Text += $" Total {invoiceCost:c}\n";
                                //reset invoice cost to 0 for next invoice
                                invoiceCost = 0;
                            }
                            //displays invoice ID 
                            rTextRight.Text += $"   Invoice {c.InvoiceID}";
                        }

                        //increments invoice cost
                        invoiceCost += c.cost;

                        //increments total customer cost
                        custCost += c.cost;
                    }
                    
                    //displays invoice total
                    rTextRight.Text += $" Total {invoiceCost:c}\n";

                    totalCost += custCost;
                }
                //display total cost 
                rTextRight.Text += $"\nTotal\t\t {totalCost:c}\n";


            }

        }

        //to calc fibonacci, used to simulate long processing time
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
