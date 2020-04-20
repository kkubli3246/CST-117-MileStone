using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_MilestoneProject
{
    class Item
    {
        private string name;
        private double price;
        
        
        //Basic Constructor     
        public Item(string name, double price) 
        {
            this.name = name;
            this.price = price;
        }

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
    }
}
