using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesComp
{
    static class Program
    {

        static List<Inventory> inventoryList;
        static List<Customer> customerList;
        static List<Invoice> invoiceList;
        static List<InvoiceItem> lineItems;
        

        [STAThread]
        static void Main()
        {
            //list of Inventory objects
            inventoryList = new List<Inventory> {
                new Inventory(1234, "blue ink pen", 1.19),
                new Inventory(1235, "black ink pen", 1.19),
                new Inventory(1236, "red ink pen", 1.19),
                new Inventory(2134, "blue pencil", .79),
                new Inventory(2135, "black pencil", .79),
                new Inventory(2136, "red pencil", .79),
                new Inventory(3124, "large eraser", 2.59),
                new Inventory(3125, "medium eraser", 1.59),
                new Inventory(3126, "cap eraser", .89),
                new Inventory(6233, "clear pushpins", 7.50),
                new Inventory(6234, "white pushpins", 7.50),
                new Inventory(6235, "green pushpins", 7.50),
                new Inventory(6236, "red pushpins", 7.50),
                new Inventory(6237, "blue pushpins", 7.50),
                new Inventory(6238, "yellow pushpins", 7.50),
                new Inventory(6239, "mixed pushpins", 7.50),
                new Inventory(5671, "small stapler", 4.25),
                new Inventory(5789, "stand stapler", 4.50),
                new Inventory(5312, "small staples", 1.25),
                new Inventory(5313, "large staples", 3.75)
            };

            //list of Customer objects
            customerList = new List<Customer>
            {
                new Customer(876, "Mary", "Johnson"),
                new Customer(490, "Larry", "Brooks"),
                new Customer(552, "Ann", "Masters"),
                new Customer(923, "Frank", "Jones"),
                new Customer(259, "Gary", "Martin")
            };

            //list of Invoice Objects
            invoiceList = new List<Invoice>
            {
                new Invoice(22, 876, 5, 2, 2019),
                new Invoice(25, 876, 5, 3, 2019),
                new Invoice(26, 259, 5, 4, 2019),
                new Invoice(27, 490, 2, 28, 2018),
                new Invoice(28, 923, 3, 15, 2018),
                new Invoice(30, 552, 8, 10, 2018)
            };

            //list of line item objects
            lineItems = new List<InvoiceItem>
            {
                new InvoiceItem(22, 1, 1234, 5),
                new InvoiceItem(22, 2, 1235, 5),
                new InvoiceItem(22, 3, 1236, 5),
                new InvoiceItem(22, 4, 6233, 5),
                new InvoiceItem(22, 5, 6239, 5),
                new InvoiceItem(25, 1, 5671, 1),
                new InvoiceItem(25, 2, 5312, 2),
                new InvoiceItem(25, 3, 2135, 2),
                new InvoiceItem(25, 4, 6239, 2),
                new InvoiceItem(30, 1, 2135, 10),
                new InvoiceItem(30, 2, 2136, 10),
                new InvoiceItem(30, 3, 1234, 10),
                new InvoiceItem(30, 4, 1235, 10),
                new InvoiceItem(30, 5, 6239, 10),
                new InvoiceItem(26, 1, 5789, 5),
                new InvoiceItem(26, 2, 5671, 3),
                new InvoiceItem(26, 3, 5312, 5),
                new InvoiceItem(26, 4, 5313, 2),
                new InvoiceItem(26, 5, 6239, 2),
                new InvoiceItem(27, 1, 3124, 4),
                new InvoiceItem(27, 2, 3125, 4),
                new InvoiceItem(27, 3, 2135, 4),
                new InvoiceItem(27, 4, 6239, 4),
                new InvoiceItem(28, 1, 6234, 4),
                new InvoiceItem(28, 2, 6235, 4),
                new InvoiceItem(28, 3, 6236, 4),
                new InvoiceItem(28, 4, 6237, 4),
                new InvoiceItem(28, 5, 6239, 4),
                new InvoiceItem(28, 6, 6238, 4)
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InvoiceForm());
        }

        //returns customerList
        public static List<Customer> getCustList() => customerList;

        //returns inventoryList
        public static List<Inventory> getInventoryList() => inventoryList;

        //returns invoiceList
        public static List<Invoice> getInvoiceList() => invoiceList;

        //returns invoiceItems list
        public static List<InvoiceItem> getInvoiceItems() => lineItems;
        
        
    }
}
