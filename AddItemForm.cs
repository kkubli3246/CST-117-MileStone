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
    public partial class AddItemForm : Form
    {
        string name;
        double price;

        //Returns Item Name
        public string ItemName
        {
            get { return name; }
            set { name = value; }
        }

        //Returns Item Price
        public double ItemPrice 
        {
            get { return price; }
            set { price = value; }
        }
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string nameInput = textBoxName.Text.ToString();
            

            bool p = Double.TryParse(textBoxPrice.Text.ToString(), out double priceInput);

            if (nameInput == null)
            {
                labelNameError.Text = "Please enter a valid name";
            }
            else if (!p)
            {
                labelPriceError.Text = "Please Enter a Valid Price for your Item";
            }
            else if (nameInput != "" && p)
            {
                ItemName = nameInput;
                ItemPrice = priceInput; 
            }

            labelNameError.Text = nameInput + priceInput;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
