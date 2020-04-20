using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_MilestoneProject
{
    public partial class Form1 : Form
    {
        Inventory inv = new Inventory("Bucky's");

        Item item1 = new Item("Shirts", 24.99);
        Item item2 = new Item("Pants", 54.66);
        Item item3 = new Item("Shoes", 34.99);
        Item item4 = new Item("Car", 500000.01);


        public Form1()
        {
            InitializeComponent();

            inv.addItem(item1);
            inv.addItem(item2);
            inv.addItem(item3);
            inv.addItem(item4);


            string invString = "";

            inv.removeItem(item4);

            for (int i = 0; i < inv.getInventory().Count; i++) 
            {
                Item current = inv.getInventory()[i];
                invString += current.getName() + ": " + current.getPrice() + "\n";
            }

            tb_example.Text = invString;

        }

    }
}
