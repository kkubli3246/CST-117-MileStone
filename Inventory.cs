using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_MilestoneProject
{
    class Inventory
    {
        private string storeName;
        private List<Item> itemList = new List<Item>();

        //Constructor
        public Inventory(String storeName) 
        {
            this.storeName = storeName;
        }

        //Method is used for an inventory to add an item to the list
        public void addItem(Item item) 
        {
            this.itemList.Add(item);
        }

        //Method is used for an invntory to remove an item from the list
        public void removeItem(Item item)
        {
            this.itemList.Remove(item);
        }

        //Getters and Setters
        public string getStoreName() 
        {
            return this.storeName;
        }
        public void setStoreName(string storeName) 
        {
            this.storeName = storeName;
        }

        public List<Item> getInventory()
        {
            return this.itemList;
        }
    }
}
