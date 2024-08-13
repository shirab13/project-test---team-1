using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace HebrewLearningApp
{
    public partial class MenuForm : Form
    {
        private string username;
        private string userID;
        private MainForm mainForm;

        public MenuForm(string username, string userID, MainForm _main)
        {
            InitializeComponent();
            this.username = username;
            this.userID = userID;
            this.mainForm = _main;
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            GamesForm gamesForm = new GamesForm(username, userID, mainForm);
            mainForm.LoadChildForm(gamesForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UpdateLoginStatus(userID, false);
            mainForm.LoadChildForm(new MainForm(mainForm));
        }

        // Method to handle form load event
        private void MenuForm_Load(object sender, EventArgs e)
        {
            CenterButtons(); // Center the buttons on form load
        }

        // Method to handle form resize event
        private void MenuForm_Resize(object sender, EventArgs e)
        {
            CenterButtons(); // Re-center the buttons on form resize
        }

        // Method to center buttons on the form
        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int totalButtonHeight = btnGames.Height + btnShop.Height + btnUserProfile.Height + btnLogout.Height + 30; // 30 for spacing between buttons
            int startY = (formHeight - totalButtonHeight) / 2;

            btnGames.Location = new System.Drawing.Point((formWidth - btnGames.Width) / 2, startY);
            btnShop.Location = new System.Drawing.Point((formWidth - btnShop.Width) / 2, btnGames.Location.Y + btnGames.Height + 10);
            btnUserProfile.Location = new System.Drawing.Point((formWidth - btnUserProfile.Width) / 2, btnShop.Location.Y + btnShop.Height + 10);
            btnLogout.Location = new System.Drawing.Point((formWidth - btnLogout.Width) / 2, btnUserProfile.Location.Y + btnUserProfile.Height + 10);
        }

        private void UpdateLoginStatus(string id, bool loggedIn)
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                if (package.Workbook.Worksheets.Count == 0)
                    return;

                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++)
                {
                    if (worksheet.Cells[row, 3].Text == id)
                    {
                        worksheet.Cells[row, 7].Value = loggedIn ? "Yes" : "No";
                        package.Save();
                        break;
                    }
                }
            }
        }
    }
}
