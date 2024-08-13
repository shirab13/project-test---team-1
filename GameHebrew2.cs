using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using OfficeOpenXml;

namespace HebrewLearningApp
{
    public partial class GameHebrew2 : Form
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

        public GameHebrew2(string username, string userID, MainForm _main)
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

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            if (ValidateLevel())
            {
                coins++;
                UpdateCoinsInExcel(username, coins);
                PlayCorrectAnswerSound();
                MessageBox.Show("תשובה נכונה! קיבלת מטבע אחד.");
                currentLevel++;
                LoadNextLevel();
                UpdateCoinsDisplay();
            }
            else
            {
                MessageBox.Show("בחירה שגויה, נסה שנית.");
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
                MessageBox.Show("סיימת את כל השלבים!");
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
                "?באיזה אות מתחילה המילה שמופיעה שבתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
                "?באיזה אות מתחילה המילה שמופיעה בתמונה",
            };

            images = new string[]
            {
                "Apple.jpg",
                "dog.png",
                "cat.jpg",
                "sun-removebg-preview.png",
                "water.jpg",
                "car-removebg-preview.png",
                "flower.png",
                "fish.jpg",
                "tree-removebg-preview.png",
                "house-removebg-preview.png"
            };

            answers = new string[]
            {
                "ת",
                "כ",
                "ח",
                "ש",
                "מ",
                "ר",
                "פ",
                "ד",
                "ע",
                "ב"
            };

            options = new string[][]
            {
                new string[] { "ת", "ט", "פ", "מ" },
                new string[] { "ק", "ל", "כ", "נ" },
                new string[] { "ח", "ז", "ט", "נ" },
                new string[] { "ש", "ח", "כ", "ל" },
                new string[] { "מ", "ח", "נ", "כ" },
                new string[] { "ג", "ר", "ח", "ט" },
                new string[] { "פ", "כ", "ת", "ר" },
                new string[] { "ד", "נ", "ח", "מ" },
                new string[] { "ע", "פ", "כ", "ל" },
                new string[] { "ב", "ע", "פ", "ל" }
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

        private void UpdateCoinsInExcel(string username, int coins)
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
                        return;
                    }
                }
            }
        }

        private void UpdateCoinsDisplay()
        {
            lblCoins.Text = coins.ToString();
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

            int checkBoxTotalWidth = checkBox1.Width + checkBox2.Width + checkBox3.Width + checkBox4.Width + 30;
            int checkBoxStartX = (formWidth - checkBoxTotalWidth) / 2;
            int checkBoxY = pictureBox.Bottom + 20;

            checkBox1.Location = new System.Drawing.Point(checkBoxStartX, checkBoxY);
            checkBox2.Location = new System.Drawing.Point(checkBox1.Right + 10, checkBoxY);
            checkBox3.Location = new System.Drawing.Point(checkBox2.Right + 10, checkBoxY);
            checkBox4.Location = new System.Drawing.Point(checkBox3.Right + 10, checkBoxY);

            btnNextLevel.Left = (formWidth - btnNextLevel.Width) / 2;
            btnNextLevel.Top = checkBox1.Bottom + 20;

            btnBackToMenu.Location = new System.Drawing.Point(10, formHeight - btnBackToMenu.Height - 10);
        }



        private void GameHebrew2_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void GameHebrew2_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainForm.LoadChildForm(new MenuForm(username, userID, mainForm));
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var senderCheckBox = sender as CheckBox;

            foreach (var control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox != senderCheckBox)
                {
                    checkBox.Checked = false;
                }
            }
        }
    }
}
