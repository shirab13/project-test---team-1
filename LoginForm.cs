using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HebrewLearningApp
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        private string userID; // שדה חדש לשמירת מזהה המשתמש

        public LoginForm(MainForm _main)
        {
            this.mainForm = _main;
            InitializeComponent();
        }

        private async void LoadBackgroundImageAsync(string imagePath)
        {
            try
            {
                Image image = await Task.Run(() => Image.FromFile(imagePath));
                backgroundPictureBox.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterControls();
            LoadBackgroundImageAsync("log_in_back.png"); // נתיב לתמונה
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            txtUsername.Location = new System.Drawing.Point((formWidth - txtUsername.Width) / 2, (formHeight - txtUsername.Height) / 2 - 60);
            lblUsername.Location = new System.Drawing.Point(txtUsername.Location.X + txtUsername.Width + 10, txtUsername.Location.Y);

            txtPassword.Location = new System.Drawing.Point((formWidth - txtPassword.Width) / 2, txtUsername.Location.Y + 40);
            lblPassword.Location = new System.Drawing.Point(txtPassword.Location.X + txtPassword.Width + 10, txtPassword.Location.Y);

            btnLogin.Location = new System.Drawing.Point((formWidth - btnLogin.Width) / 2 + 50, txtPassword.Location.Y + 50);
            btnBack.Location = new System.Drawing.Point(10, 10);

            btnBack.Location = new System.Drawing.Point(50, formHeight - btnBack.Height - 50);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            ResetLoginStatus(); // אתחול מצב ההתחברות לכל המשתמשים

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("התחברת בהצלחה");
                UpdateLoginStatus(userID, true); // הוספת קריאה לפונקציה בעת התחברות
                Form menuForm = new MenuForm(username, userID, mainForm);
                mainForm.LoadChildForm(menuForm);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadChildForm(new MainForm(mainForm));
        }

        private bool ValidateLogin(string username, string password)
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);
            using (var package = new ExcelPackage(file))
            {
                // בדוק אם יש גיליונות בכלל ואם הגיליון הראשון קיים
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("קובץ ה-Excel אינו מכיל גיליונות.");
                    return false;
                }

                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++)
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        if (worksheet.Cells[row, 2].Text == password)
                        {
                            userID = worksheet.Cells[row, 3].Text; // שמירת מזהה המשתמש
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("סיסמה שגויה");
                            return false;
                        }
                    }
                }

                MessageBox.Show("שם משתמש שגוי");
                return false;
            }
        }

        private void ResetLoginStatus()
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("קובץ ה-Excel אינו מכיל גיליונות.");
                    return;
                }

                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++)
                {
                    worksheet.Cells[row, 7].Value = "No";
                }

                package.Save();
            }
        }

        private void UpdateLoginStatus(string id, bool loggedIn)
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("קובץ ה-Excel אינו מכיל גיליונות.");
                    return;
                }

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
