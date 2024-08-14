using System;
using System.Drawing; // For PaintEventArgs
using System.Windows.Forms; // For EventArgs and other Windows Forms controls


namespace HebrewLearningApp
{
    partial class Store
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCoins = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoins
            // 
            this.lblCoins.ForeColor = System.Drawing.Color.Black;
            this.lblCoins.Location = new System.Drawing.Point(862, 9);
            this.lblCoins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(100, 30);
            this.lblCoins.TabIndex = 0;
            this.lblCoins.Text = "Coins: 100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(960, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(413, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "ברוכים הבאים לחנות";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(862, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = ":מטבעות";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(256, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(256, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "מדבקות";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(86, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 69);
            this.button2.TabIndex = 13;
            this.button2.Text = "צעצועים";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(317, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 332);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1046, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCoins);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Children\'s Game Store";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;

        // Event handlers
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Handle purchase logic here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear any previous controls from the panel
            panel1.Controls.Clear();

            // Enable auto-scroll for the panel
            panel1.AutoScroll = true;

            // Define the images to load
            string[] imagePaths = new string[]
            {
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\rainbow.jpg",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\dog.png",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\hello_kitty.jpg",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\wow.png",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\octopus.jpg"
            };

            // Set the X position for the price buttons on the left
            int priceButtonXPosition = 150; // Left margin for price buttons
            int imageXPosition = priceButtonXPosition + 100; // Image position to the right of price buttons

            // Create and display PictureBox controls and Price Buttons for each image
            for (int i = 0; i < imagePaths.Length; i++)
            {
                // Add a price button next to each item
                Button priceButton = new Button();
                priceButton.Text = "1 מטבע";
                priceButton.Location = new Point(priceButtonXPosition, i * 130 + 35); // Position on the left
                priceButton.Size = new Size(100, 30);
                priceButton.Tag = 1; // Price in coins
                priceButton.Click += new EventHandler(PurchaseButton_Click);

                panel1.Controls.Add(priceButton);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePaths[i]);
                pictureBox.Location = new Point(imageXPosition, i * 130); // Position images to the right of price buttons
                pictureBox.Size = new Size(100, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                panel1.Controls.Add(pictureBox);
            }

            // Add a Return button
            Button returnButton = new Button();
            returnButton.Text = "חזור";
            returnButton.BackColor = System.Drawing.Color.SeaShell;
            returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            returnButton.Location = new Point(10, 10); // Top-left corner
            returnButton.Size = new Size(120, 50);
            returnButton.Click += new EventHandler(ReturnButton_Click);

            panel1.Controls.Add(returnButton);
        }






        private void button2_Click(object sender, EventArgs e)
        {
            // Clear any previous controls from the panel
            panel1.Controls.Clear();

            // Enable auto-scroll for the panel
            panel1.AutoScroll = true;

            // Define the images to load
            string[] imagePaths = new string[]
            {
                 @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\doll1.jpg",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\doll2.jpg",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\car.jpg",
                @"C:\Users\Dorin\Desktop\assignments\year2\semester2\bdikot\Files_For_Project\pictures\plane.jpg"
            };

            // Set the X position for the price buttons on the left
            int priceButtonXPosition = 150; // Left margin for price buttons
            int imageXPosition = priceButtonXPosition + 100; // Image position to the right of price buttons

            // Create and display PictureBox controls and Price Buttons for each image
            for (int i = 0; i < imagePaths.Length; i++)
            {
                // Add a price button next to each item
                Button priceButton = new Button();
                priceButton.Text = "2 מטבעות";
                priceButton.Location = new Point(priceButtonXPosition, i * 130 + 35); // Position on the left
                priceButton.Size = new Size(100, 30);
                priceButton.Tag = 2; // Price in coins
                priceButton.Click += new EventHandler(PurchaseButton_Click);

                panel1.Controls.Add(priceButton);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePaths[i]);
                pictureBox.Location = new Point(imageXPosition, i * 130); // Position images to the right of price buttons
                pictureBox.Size = new Size(100, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                panel1.Controls.Add(pictureBox);
            }

            // Add a Return button
            Button returnButton = new Button();
            returnButton.Text = "חזור";
            returnButton.BackColor = System.Drawing.Color.SeaShell;
            returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            returnButton.Location = new Point(10, 10); // Top-left corner
            returnButton.Size = new Size(120, 50);
            returnButton.Click += new EventHandler(ReturnButton_Click);

            panel1.Controls.Add(returnButton);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle any custom painting logic here
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle click event on pictureBox1 (if needed)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle click event on label1 (if needed)
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // Clear the panel or navigate back to the main menu
            panel1.Controls.Clear();


            // Re-add the original buttons to the panel
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            Button priceButton = sender as Button;
            int price = (int)priceButton.Tag;

            if (coins >= price)
            {
                coins -= price;
                lblCoins.Text = "Coins: " + coins;
                MessageBox.Show("Purchase successful!");
            }
            else
            {
                MessageBox.Show("Not enough coins!");
            }
        }


    }
}
