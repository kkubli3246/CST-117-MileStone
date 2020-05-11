using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_MilestoneProject
{
    class Item : IComparable
    {
        private string name;
        private double price;
        private int quantity;


        //Basic Constructor     
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
            this.quantity = 10;
        }
        public Item(){}

        public string getName() 
        {
            return this.name;
        }
        public void setName(string name) 
        {
            this.name = name;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity() 
        {
            return this.quantity;
        }

       
     

        public int CompareTo(object obj)
        {
            Item other = obj as Item;
            if (this.price > other.price)
            {
                return 1;
            }
            else if (this.price < other.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            throw new NotImplementedException();
            
        }
    }
}
