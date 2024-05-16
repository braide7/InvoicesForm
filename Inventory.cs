using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesComp
{
    class Inventory
    {
        private int itemID;
        private string itemName;
        private double itemCost;

        public Inventory(int ID, string name, double cost) 
        {
            ItemID = ID;
            ItemName = name;
            ItemCost = cost;
        }

        public int ItemID 
        {
            get { return this.itemID; }
            set { this.itemID = value; }
        }
        public string ItemName
        {
            get { return this.itemName; }
            set { this.itemName = value; }
        }

        public double ItemCost
        {
            get { return this.itemCost; }
            set { this.itemCost = value; }
        }
    }
}
