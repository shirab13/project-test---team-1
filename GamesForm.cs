using System;
using System.Windows.Forms;

namespace HebrewLearningApp
{
    public partial class GamesForm : Form
    {
        private MainForm mainForm;
        private string username;
        private string userID;

        public GamesForm(string username, string userID, MainForm _main)
        {
            InitializeComponent();
            this.username = username;
            this.mainForm = _main;
            this.userID = userID;
        }

        private void GamesForm_Load(object sender, EventArgs e)
        {
            CenterButtons(); // Center the buttons on form load
        }

        private void GamesForm_Resize(object sender, EventArgs e)
        {
            CenterButtons(); // Re-center the buttons on form resize
        }

        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int totalButtonHeight = btnGameHebrew.Height + btnGameMath.Height + btnGameEnglish.Height + btnBackToMenu.Height + 30; // 30 for spacing between buttons
            int startY = (formHeight - totalButtonHeight) / 2;

            btnGameHebrew.Location = new System.Drawing.Point((formWidth - btnGameHebrew.Width) / 2, startY);
            btnGameMath.Location = new System.Drawing.Point((formWidth - btnGameMath.Width) / 2, btnGameHebrew.Location.Y + btnGameHebrew.Height + 10);
            btnGameEnglish.Location = new System.Drawing.Point((formWidth - btnGameEnglish.Width) / 2, btnGameMath.Location.Y + btnGameMath.Height + 10);
            btnBackToMenu.Location = new System.Drawing.Point((formWidth - btnBackToMenu.Width) / 2, btnGameEnglish.Location.Y + btnGameEnglish.Height + 10);
        }

        private void btnGameHebrew_Click(object sender, EventArgs e)
        {
            SelectGameForm selectGameForm = new SelectGameForm("Hebrew", username, userID, mainForm);
            mainForm.LoadChildForm(selectGameForm);
        }

        private void btnGameMath_Click(object sender, EventArgs e)
        {
            SelectGameForm selectGameForm = new SelectGameForm("Math", username, userID, mainForm);
            mainForm.LoadChildForm(selectGameForm);
        }

        private void btnGameEnglish_Click(object sender, EventArgs e)
        {
            SelectGameForm selectGameForm = new SelectGameForm("English", username, userID, mainForm);
            mainForm.LoadChildForm(selectGameForm);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainForm.LoadChildForm(new MenuForm(username, userID, mainForm));
        }
    }
}
