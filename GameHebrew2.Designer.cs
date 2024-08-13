using System.Drawing;
namespace HebrewLearningApp
{
    partial class GameHebrew2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.Label lblLevelDescription;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Label lblCoinsText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.lblLevelDescription = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.lblCoinsText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnNextLevel.Location = new System.Drawing.Point(133, 394);
            this.btnNextLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(200, 50);
            this.btnNextLevel.TabIndex = 0;
            this.btnNextLevel.Text = "לשלב הבא";
            this.btnNextLevel.UseVisualStyleBackColor = true;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // lblLevelDescription
            // 
            this.lblLevelDescription.AutoSize = true;
            this.lblLevelDescription.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblLevelDescription.Location = new System.Drawing.Point(133, 62);
            this.lblLevelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevelDescription.Name = "lblLevelDescription";
            this.lblLevelDescription.Size = new System.Drawing.Size(200, 50);
            this.lblLevelDescription.TabIndex = 1;
            this.lblLevelDescription.Text = "Level Description";
            this.lblLevelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(133, 103);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Location = new System.Drawing.Point(133, 246);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 50);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Option 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.Location = new System.Drawing.Point(263, 246);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 50);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Option 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.Location = new System.Drawing.Point(393, 246);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 50);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Option 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.Location = new System.Drawing.Point(523, 246);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 50);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Option 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.Location = new System.Drawing.Point(10, 10);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(160, 50);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "חזור לתפריט";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblCoinsText
            // 
            this.lblCoinsText.AutoSize = true;
            this.lblCoinsText.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCoinsText.Location = new System.Drawing.Point(820, 20);
            this.lblCoinsText.Name = "lblCoinsText";
            this.lblCoinsText.Size = new System.Drawing.Size(120, 22);
            this.lblCoinsText.TabIndex = 9;
            this.lblCoinsText.Text = ": מטבעות";
            this.lblCoinsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblCoins.Location = new System.Drawing.Point(780, 20);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 26);
            this.lblCoins.TabIndex = 10;
            this.lblCoins.Text = "0";
            this.lblCoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picCoin
            // 
            this.picCoin.Location = new System.Drawing.Point(860, 15);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(60, 60);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 11;
            this.picCoin.TabStop = false;
            this.picCoin.Image = Image.FromFile("coin.gif"); // נתיב לתמונה שלך של המטבע
            // 
            // GameHebrew2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Image.FromFile("Garden_backround.jpg"); // נתיב לתמונת הרקע שלך
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblCoinsText);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblLevelDescription);
            this.Controls.Add(this.btnNextLevel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameHebrew2";
            this.Text = "Game Hebrew 2";
            this.Load += new System.EventHandler(this.GameHebrew2_Load);
            this.Resize += new System.EventHandler(this.GameHebrew2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
