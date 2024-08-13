using System;
using System.Windows.Forms;

namespace HebrewLearningApp
{
    public partial class SelectGameForm : Form
    {
        private string gameType;
        private string username;
        private MainForm mainForm;
        private string userID;

        public SelectGameForm(string gameType, string username, string userID, MainForm _main)
        {
            InitializeComponent();
            this.gameType = gameType;
            this.username = username;
            this.userID = userID;
            this.mainForm = _main;
        }

        private void SelectGameForm_Load(object sender, EventArgs e)
        {
            CenterButtons(); // Center the buttons on form load
        }

        private void SelectGameForm_Resize(object sender, EventArgs e)
        {
            CenterButtons(); // Re-center the buttons on form resize
        }

        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int totalButtonHeight = btnGame1.Height + btnGame2.Height + btnBackToMenu.Height + 20; // 20 for spacing between buttons
            int startY = (formHeight - totalButtonHeight) / 2;

            btnGame1.Location = new System.Drawing.Point((formWidth - btnGame1.Width) / 2, startY);
            btnGame2.Location = new System.Drawing.Point((formWidth - btnGame2.Width) / 2, btnGame1.Location.Y + btnGame1.Height + 10);
            btnBackToMenu.Location = new System.Drawing.Point((formWidth - btnBackToMenu.Width) / 2, btnGame2.Location.Y + btnGame2.Height + 10);

            // Ensure the background is sized correctly
            backgroundPictureBox.Size = new System.Drawing.Size(formWidth, formHeight);
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            if (gameType == "Math")
            {
                // Load Math Game 1
            }
            else if (gameType == "Hebrew")
            {
                GameHebrew2 gameHebrew1 = new GameHebrew2(username, userID, mainForm);
                mainForm.LoadChildForm(gameHebrew1);
            }
            else if (gameType == "English")
            {
                // Load English Game 1
            }
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            if (gameType == "Math")
            {
                // Load Math Game 2
            }
            else if (gameType == "Hebrew")
            {
                GameHebrew3 gameHebrew2 = new GameHebrew3(username, userID, mainForm);
                mainForm.LoadChildForm(gameHebrew2);
            }
            else if (gameType == "English")
            {
                // Load English Game 2
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainForm.LoadChildForm(new MenuForm(username, userID, mainForm));
        }
    }
}
