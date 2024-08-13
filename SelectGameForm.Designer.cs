namespace HebrewLearningApp
{
    partial class SelectGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox backgroundPictureBox; // Background PictureBox
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnBackToMenu;

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
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.btnGame1 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(500, 500);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPictureBox.TabIndex = 0;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.ImageLocation = "kids.png"; // Set your background image path
            // 
            // btnGame1
            // 
            this.btnGame1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnGame1.Size = new System.Drawing.Size(200, 60);
            this.btnGame1.Location = new System.Drawing.Point(50, 40); // Positioning will be adjusted dynamically
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.TabIndex = 1;
            this.btnGame1.Text = "משחק 1";
            this.btnGame1.UseVisualStyleBackColor = true;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame2
            // 
            this.btnGame2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnGame2.Size = new System.Drawing.Size(200, 60);
            this.btnGame2.Location = new System.Drawing.Point(50, 110); // Positioning will be adjusted dynamically
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.TabIndex = 2;
            this.btnGame2.Text = "משחק 2";
            this.btnGame2.UseVisualStyleBackColor = true;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.Size = new System.Drawing.Size(200, 60);
            this.btnBackToMenu.Location = new System.Drawing.Point(50, 180); // Positioning will be adjusted dynamically
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "חזור למסך הראשי";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // SelectGameForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.backgroundPictureBox); // Add background picture box last to be behind other controls
            this.Name = "SelectGameForm";
            this.Text = "SelectGameForm";
            this.Load += new System.EventHandler(this.SelectGameForm_Load);
            this.Resize += new System.EventHandler(this.SelectGameForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
