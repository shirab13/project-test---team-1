using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Media;

namespace HebrewLearningApp
{
    public partial class GameHebrew3 : Form
    {
        private MainForm mainForm;
        private int currentLevel = 1;
        private int coins = 0;
        private string[] levels;
        private string[] images;
        private string[] answers;
        private string[][] options;
        private string username;
        private string userID;


        public GameHebrew3(string username, string userID, MainForm _main)
        {
            this.mainForm = _main;
            InitializeComponent();
            this.username = username;
            this.userID = userID;
            LoadCoinsFromExcel(username);
            LoadLevels();
            LoadNextLevel();
            UpdateCoinsDisplay();
        }

        private void UpdateCoinsDisplay()
        {
            lblCoins.Text = coins.ToString();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            if (ValidateLevel())
            {
                coins++;
                if (UpdateCoinsInExcel(username, coins))
                {
                    PlayCorrectAnswerSound();
                    MessageBox.Show("!תשובה נכונה! קיבלת מטבע אחד.");
                    UpdateCoinsDisplay();
                }
                else
                {
                    MessageBox.Show("תשובה נכונה! קיבלת מטבע אחד. אך עדכון המטבעות נכשל");
                }
                currentLevel++;
                LoadNextLevel();
            }
            else
            {
                MessageBox.Show("בחירה שגויה");
            }
        }

        private void PlayCorrectAnswerSound()
        {
            SoundPlayer sound = new SoundPlayer("correct_sound.wav");
            sound.Play();
        }

        private bool ValidateLevel()
        {
            if (checkBox1.Checked && checkBox1.Text == answers[currentLevel - 1])
                return true;
            if (checkBox2.Checked && checkBox2.Text == answers[currentLevel - 1])
                return true;
            if (checkBox3.Checked && checkBox3.Text == answers[currentLevel - 1])
                return true;
            if (checkBox4.Checked && checkBox4.Text == answers[currentLevel - 1])
                return true;

            return false;
        }

        private void LoadNextLevel()
        {
            if (currentLevel > levels.Length)
            {
                MessageBox.Show("!סיימת את כל השלבים");
                mainForm.LoadChildForm(new MenuForm(username, userID, mainForm));
            }
            else
            {
                lblLevelDescription.Text = levels[currentLevel - 1];
                pictureBox.ImageLocation = images[currentLevel - 1];
                checkBox1.Text = options[currentLevel - 1][0];
                checkBox2.Text = options[currentLevel - 1][1];
                checkBox3.Text = options[currentLevel - 1][2];
                checkBox4.Text = options[currentLevel - 1][3];
            }
        }

        private void LoadLevels()
        {
            levels = new string[]
            {
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו",
                "בחר את המילה המתאימה לתמונה זו"
            };

            images = new string[]
            {
                "table-removebg-preview.png",
                "mouse.jpg",
                "pen.jpg",
                "phone.png",
                "pig.jpg",
                "star-removebg-preview.png",
                "door.png",
                "tree-removebg-preview.png",
                "lion.png",
                "ball.png"
            };

            answers = new string[]
            {
                "שולחן",
                "עכבר",
                "עט",
                "טלפון",
                "חזיר",
                "כוכב",
                "דלת",
                "עץ",
                "אריה",
                "כדור"
            };

            options = new string[][]
            {
                new string[] { "שולחן", "מחשב", "כיסא", "מדף" },
                new string[] { "חתול", "עכבר", "ארנב", "כלב" },
                new string[] { "עט", "עיפרון", "מחברת", "ספר" },
                new string[] { "מחשב", "טלפון", "מקלדת", "עכבר" },
                new string[] { "פרה", "כבשה", "חזיר", "סוס" },
                new string[] { "מטוס", "סירה", "מכונית", "כוכב" },
                new string[] { "בית", "דלת", "בניין", "בית ספר" },
                new string[] { "פרח", "ענן", "עץ", "שיח" },
                new string[] { "ירח", "שמש", "ענן", "אריה" },
                new string[] { "כלב", "כדור", "דג", "תוכי" }
            };
        }

        private void LoadCoinsFromExcel(string username)
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);
            using (var package = new ExcelPackage(file))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension?.Rows ?? 0;
                for (int row = 2; row <= rowCount; row++)
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        coins = int.Parse(worksheet.Cells[row, 6].Text);
                        return;
                    }
                }
            }
        }

        private bool UpdateCoinsInExcel(string username, int coins)
        {
            try
            {
                var filePath = "users.xlsx";
                var file = new FileInfo(filePath);
                using (var package = new ExcelPackage(file))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension?.Rows ?? 0;
                    for (int row = 2; row <= rowCount; row++)
                    {
                        if (worksheet.Cells[row, 1].Text == username)
                        {
                            worksheet.Cells[row, 6].Value = coins;
                            package.Save();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון קובץ ה-Excel: " + ex.Message);
            }
            return false;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure only one checkbox is checked at a time
            var senderCheckBox = sender as CheckBox;

            foreach (var control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox != senderCheckBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainForm.LoadChildForm(new MenuForm(username, userID, mainForm));
        }

        private void GameHebrew3_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void GameHebrew3_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // נזיז את הגיף לפני הכיתוב
            picCoin.Left = formWidth - picCoin.Width - 60;
            lblCoinsText.Left = picCoin.Left - lblCoinsText.Width - 5;
            lblCoins.Left = lblCoinsText.Left - lblCoins.Width - 5;

            lblLevelDescription.Left = (formWidth - lblLevelDescription.Width) / 2;
            pictureBox.Left = (formWidth - pictureBox.Width) / 2;
            pictureBox.Top = lblLevelDescription.Bottom + 10;

            int checkBoxWidth = checkBox1.Width + checkBox2.Width + checkBox3.Width + checkBox4.Width + 30; // Adjust for margins
            int startX = (formWidth - checkBoxWidth) / 2;

            checkBox1.Location = new System.Drawing.Point(startX, pictureBox.Location.Y + 180);
            checkBox2.Location = new System.Drawing.Point(startX + checkBox1.Width + 10, pictureBox.Location.Y + 180);
            checkBox3.Location = new System.Drawing.Point(startX + checkBox1.Width + checkBox2.Width + 20, pictureBox.Location.Y + 180);
            checkBox4.Location = new System.Drawing.Point(startX + checkBox1.Width + checkBox2.Width + checkBox3.Width + 30, pictureBox.Location.Y + 180);

            btnNextLevel.Location = new System.Drawing.Point((formWidth - btnNextLevel.Width) / 2, checkBox1.Location.Y + 50);
            btnBackToMenu.Location = new System.Drawing.Point(50, formHeight - btnBackToMenu.Height - 50);

            // Ensure the background is sized correctly
            backgroundPictureBox.Size = new System.Drawing.Size(formWidth, formHeight);
        }
    }
}
