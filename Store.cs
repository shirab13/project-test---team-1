using System;
using System.Drawing;
using System.Windows.Forms;

namespace HebrewLearningApp
{
    
    public partial class Store : Form
    {
        private MainForm mainForm;
        private int coins = 100; // Initial coin count
        private Label lblCoins = new Label();

        public Store(MainForm _main)
        {
            this.mainForm = _main;
            InitializeComponent(); // This should call the method in Form1.Designer.cs
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // Additional initialization code, if any
        }

        //private void btnPurchase_Click(object sender, EventArgs e)
        //{
        //    if (listBoxItems.SelectedItem != null)
        //    {
        //        string item = listBoxItems.SelectedItem.ToString();
        //        int price = int.Parse(item.Split('-')[1].Trim().Split(' ')[0]);

        //        if (coins >= price)
        //        {
        //            coins -= price;
        //            lblCoins.Text = "Coins: " + coins;
        //            MessageBox.Show("You purchased: " + item.Split('-')[0].Trim());
        //        }
        //        else
        //        {
        //            MessageBox.Show("Not enough coins.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select an item to buy.");
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Code for textBox1 TextChanged event, if needed
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
