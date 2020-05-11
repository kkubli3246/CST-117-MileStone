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
    public partial class RemoveItemForm : Form
    {
        string itemName;

        public string ItemName 
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public RemoveItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getTB = textBoxNameInput.Text.ToString();

            if(getTB != null) 
            {
                itemName = getTB;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
