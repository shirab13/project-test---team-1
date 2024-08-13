namespace HebrewLearningApp
{
    partial class GamesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox backgroundPictureBox; // Add this for the background image
        private System.Windows.Forms.Button btnGameHebrew;
        private System.Windows.Forms.Button btnGameMath;
        private System.Windows.Forms.Button btnGameEnglish;
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
            this.btnGameHebrew = new System.Windows.Forms.Button();
            this.btnGameMath = new System.Windows.Forms.Button();
            this.btnGameEnglish = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(500, 500);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPictureBox.TabIndex = 4;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.ImageLocation = "board.png"; // Set your background image path here
            // 
            // btnGameHebrew
            // 
            this.btnGameHebrew.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnGameHebrew.Size = new System.Drawing.Size(200, 60);
            this.btnGameHebrew.Location = new System.Drawing.Point(50, 30);
            this.btnGameHebrew.Name = "btnGameHebrew";
            this.btnGameHebrew.TabIndex = 0;
            this.btnGameHebrew.Text = "משחקי עברית";
            this.btnGameHebrew.UseVisualStyleBackColor = true;
            this.btnGameHebrew.Click += new System.EventHandler(this.btnGameHebrew_Click);
            // 
            // btnGameMath
            // 
            this.btnGameMath.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnGameMath.Size = new System.Drawing.Size(200, 60);
            this.btnGameMath.Location = new System.Drawing.Point(50, 100);
            this.btnGameMath.Name = "btnGameMath";
            this.btnGameMath.TabIndex = 1;
            this.btnGameMath.Text = "משחקי חשבון";
            this.btnGameMath.UseVisualStyleBackColor = true;
            this.btnGameMath.Click += new System.EventHandler(this.btnGameMath_Click);
            // 
            // btnGameEnglish
            // 
            this.btnGameEnglish.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnGameEnglish.Size = new System.Drawing.Size(200, 60);
            this.btnGameEnglish.Location = new System.Drawing.Point(50, 170);
            this.btnGameEnglish.Name = "btnGameEnglish";
            this.btnGameEnglish.TabIndex = 2;
            this.btnGameEnglish.Text = "משחקי אנגלית";
            this.btnGameEnglish.UseVisualStyleBackColor = true;
            this.btnGameEnglish.Click += new System.EventHandler(this.btnGameEnglish_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.Size = new System.Drawing.Size(200, 60);
            this.btnBackToMenu.Location = new System.Drawing.Point(50, 240);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "חזור למסך הראשי";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // GamesForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnGameEnglish);
            this.Controls.Add(this.btnGameMath);
            this.Controls.Add(this.btnGameHebrew);
            this.Controls.Add(this.backgroundPictureBox); // Add background picture box last to ensure it is behind other controls
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            this.Load += new System.EventHandler(this.GamesForm_Load);
            this.Resize += new System.EventHandler(this.GamesForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
