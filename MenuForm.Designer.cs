namespace HebrewLearningApp
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnLogout;

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
            this.btnGames = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(50, 30);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(200, 60); // Increase button size
            this.btnGames.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold); // Increase font size
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "משחקים";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);

            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(50, 100);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(200, 60); // Increase button size
            this.btnShop.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold); // Increase font size
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "חנות";
            this.btnShop.UseVisualStyleBackColor = true;

            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Location = new System.Drawing.Point(50, 170);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(200, 60); // Increase button size
            this.btnUserProfile.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold); // Increase font size
            this.btnUserProfile.TabIndex = 2;
            this.btnUserProfile.Text = "הצגת משתמש";
            this.btnUserProfile.UseVisualStyleBackColor = true;

            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 240);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 60); // Increase button size
            this.btnLogout.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold); // Increase font size
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "התנתקות";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // MenuForm
            // 
            this.BackgroundImage = System.Drawing.Image.FromFile("menu.png"); // Set your background image here
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // Adjust background image layout
            this.ClientSize = new System.Drawing.Size(400, 400); // Adjusted form size to accommodate larger buttons
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUserProfile);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnGames);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Resize += new System.EventHandler(this.MenuForm_Resize);
            this.ResumeLayout(false);
        }
    }
}
