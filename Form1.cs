//@Author: Kekoa Kubli
//@Date: 5/2/2020
//MileStone CST-117

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        Item item5 = new Item("Tanks", 33.99);
        Item item6 = new Item("Socks", 5.66);
        Item item7 = new Item("Jeans", 67.99);
        Item item8 = new Item("Blankets", 500000.01);
        Item item9 = new Item("Candles", 2.99);
        Item item10 = new Item("Bands", 1.66);
        Item item11 = new Item("Flip Flips", 34.99);
        Item item12 = new Item("Sweaters", 500000.01);

        Item search = new Item();


        public Form1()
        {
            InitializeComponent();

            inv.addItem(item1);
            inv.addItem(item2);
            inv.addItem(item3);
            inv.addItem(item4);
            inv.addItem(item5);
            inv.addItem(item6);
            inv.addItem(item7);
            inv.addItem(item8);
            inv.addItem(item9);
            inv.addItem(item10);
            inv.addItem(item11);
            inv.addItem(item12);

            this.Text = "Welcome to "  + inv.getStoreName();

            displayInv();
     }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Get the text from the user input and if its a double or a string to use appropriate search
            if (Double.TryParse(textBoxSearch.Text.ToString(), out double price))
            {
                Item result = inv.Search(price);
                search = result;

                if (!string.IsNullOrEmpty(result.getName()))
                {
                    string str = result.getName() + ":  $" + result.getPrice() + " x " + result.getQuantity() + " in stock";
                    labelSearch.Text = str;
                    buttonRestock.Show();
                }
                else
                {
                    labelSearch.Text = "No item in stock at that price!";
                }
            }
            else
            {
                Item result = inv.Search(textBoxSearch.Text.ToString());
                search = result;

                if (!string.IsNullOrEmpty(result.getName()))
                {
                    string str = result.getName() + ":  $" + result.getPrice() + " x " + result.getQuantity() + " in stock";
                    labelSearch.Text = str;
                    buttonRestock.Show();
                }
                else
                {
                    labelSearch.Text = "No item in stock with that name";
                }
            }
        }

        private void buttonRestockAll_Click(object sender, EventArgs e)
        {
            inv.restockAll();
            displayInv();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            if (add.ShowDialog() == DialogResult.OK) 
            {
                if (add.ItemName != null && add.ItemPrice != 0)
                {
                    inv.addItem(new Item(add.ItemName, Math.Round(add.ItemPrice, 2)));
                }
                else
                {
                    labelAddError.Text = "Item Name or Price Entered Incorrectly!";
                }
            }

            displayInv();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveItemForm remove = new RemoveItemForm();

            if (remove.ShowDialog() == DialogResult.OK)
            {
                Item item = inv.Search(remove.ItemName);

                inv.removeItem(item);
            }

            displayInv();
        }

        private void displayInv()
        {
            String invString = "";

            for (int i = 0; i < inv.getInventory().Count; i++)
            {
                Item current = inv.getInventory()[i];
                invString += current.getName() + ": " + current.getPrice() + " x " + current.getQuantity() + " in stock " + "\n";
            }

            tb_example.Text = invString;
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            inv.restockItem(search);
            displayInv();
            buttonRestock.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inv.getInventory().Sort();
            displayInv();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            
        }
    }
}
