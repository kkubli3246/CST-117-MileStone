using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_MilestoneProject
{
    class Inventory
    {
        private string storeName;
        //private List<Item> itemList = new List<Item>();
        private Item[] itemList = new Item[0];

        //Constructor
        public Inventory(String storeName) 
        {
            this.storeName = storeName;
        }

        //Method is used for an inventory to add an item to the list
        public void addItem(Item item) 
        {           
            Item[] newItemList = new Item[itemList.Length + 1];

            for (int i = 0; i < itemList.Length; i++)
            {
                newItemList[i] = itemList[i];
            }
            newItemList[newItemList.Length - 1] = item;

            this.itemList = newItemList;

        }

        //Method is used for an invntory to remove an item from the list
        public void removeItem(Item item)
        {
            List<Item> list = new List<Item>(itemList);
            list.Remove(item);
            itemList = list.ToArray();
        }

        //Method that is used to restock an Item in the store
        public void restockItem(Item item)
        {
            for (int i = 0; i < itemList.Length; i++) 
            {
                if(item.getName() == itemList[i].getName())
                {
                    int stock = itemList[i].getQuantity();
                    itemList[i].setQuantity(stock += 10);
                }
            }
        }
        //Method restocks entire inventory
        public void restockAll()
        {
            for (int i = 0; i < itemList.Length; i++)
            {
                int stock = itemList[i].getQuantity(); 
                itemList[i].setQuantity(stock += 10);
            }
        }

        //Search by Item Name
        //@OverLoad
        public Item Search(string itemName)
        {
            Item result = new Item();
            for (int i = 0; i < itemList.Length; i++) 
            {
                if (itemList[i].getName() == itemName)
                {
                    result = itemList[i];
                }
            }
            return result;
        }

        //Search by price
        //@OverLoad
        public Item Search(double price)
        {
            Item result = new Item();

            for (int i = 0; i < itemList.Length; i++)
            {
                if (itemList[i].getPrice() == price)
                {
                    result = itemList[i];
                }
            }
            return result;
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

        public Item[] getInventory()
        {
            return this.itemList;
        }
    }
}
