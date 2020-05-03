//@Author: Kekoa Kubli
//@Date: 5/2/2020
//MileStone CST-117

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



            inv.removeItem(item4);

           

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {

            string invString = "";

            for (int i = 0; i < inv.getInventory().Length; i++)
            {
                Item current = inv.getInventory()[i];
                invString += current.getName() + ": " + current.getPrice() + " x " + current.getQuantity() + " in stock " + "\n";
            }

            tb_example.Text = invString;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Get the text from the user input and if its a double or a string to use appropriate search
            if (Double.TryParse(textBoxSearch.Text.ToString(), out double price))
            {
                Item result = inv.Search(price);

                if (!string.IsNullOrEmpty(result.getName()))
                {
                    string str = result.getName() + " " + result.getPrice() + " x " + result.getQuantity() + " in stock";
                    tb_example.Text = str;
                }
                else
                {
                    tb_example.Text = "No item in stock at that price!";
                }
            }
            else
            {
                Item result = inv.Search(textBoxSearch.Text.ToString());

                if (!string.IsNullOrEmpty(result.getName()))
                {
                    string str = result.getName() + " " + result.getPrice() + " x " + result.getQuantity() + " in stock";
                    tb_example.Text = str;
                }
                else
                {
                    tb_example.Text = "No item in stock with that name";
                }
            }
        }

        private void buttonRestockAll_Click(object sender, EventArgs e)
        {
            inv.restockAll();
        }
    }
}
