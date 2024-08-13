using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HebrewLearningApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CenterControls();
            LoadBackgroundImageAsync("register.png");
            backgroundPictureBox.SendToBack();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string id = txtID.Text;
            string email = txtEmail.Text;
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : string.Empty;

            string validationError = ValidateRegistration(username, password, id, email);
            if (validationError == null)
            {
                SaveToExcel(username, password, id, email, gender);
                MessageBox.Show("נרשמת בהצלחה. קובץ ה-Excel נשמר ב-" + Path.GetFullPath("users.xlsx"));
                this.Close();
            }
            else
            {
                MessageBox.Show(validationError);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the registration form to go back to the main form
        }

        private string ValidateRegistration(string username, string password, string id, string email)
        {
            if (!Regex.IsMatch(username, @"^(?=[a-zA-Z]*\d{0,2}[a-zA-Z]*$)[a-zA-Z\d]{6,8}$"))
                return "שם המשתמש צריך להיות בין 6 ל-8 תווים, ולכלול עד 2 ספרות בכל מיקום.";

            if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$"))
                return "הסיסמה צריכה להיות בין 8 ל-10 תווים, לכלול לפחות אות אחת, ספרה אחת ותו מיוחד אחד.";

            if (string.IsNullOrEmpty(id) || id.Length != 9 || !id.All(char.IsDigit))
                return "מספר תעודת הזהות צריך להיות בן 9 ספרות.";

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "כתובת המייל אינה תקינה.";

            var idOrEmailError = IsIDOrEmailExists(id, email);
            if (idOrEmailError != null)
                return idOrEmailError;

            return null;
        }

        private string IsIDOrEmailExists(string id, string email)
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                if (package.Workbook.Worksheets.Count == 0)
                    return null;

                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++)
                {
                    if (worksheet.Cells[row, 3].Text == id)
                        return "תעודת הזהות כבר קיימת במערכת.";
                    if (worksheet.Cells[row, 4].Text == email)
                        return "כתובת האימייל כבר קיימת במערכת.";
                }
            }
            return null;
        }

        private void SaveToExcel(string username, string password, string id, string email, string gender)
        {
            var filePath = "users.xlsx";
            var file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet;
                if (package.Workbook.Worksheets.Count == 0)
                {
                    worksheet = package.Workbook.Worksheets.Add("Users");
                    worksheet.Cells[1, 1].Value = "Username";
                    worksheet.Cells[1, 2].Value = "Password";
                    worksheet.Cells[1, 3].Value = "ID";
                    worksheet.Cells[1, 4].Value = "Email";
                    worksheet.Cells[1, 5].Value = "Gender";
                    worksheet.Cells[1, 6].Value = "Coins";
                    worksheet.Cells[1, 7].Value = "LoggedIn"; // הוספת עמודת LoggedIn
                }
                else
                {
                    worksheet = package.Workbook.Worksheets[0];
                }

                var rowCount = worksheet.Dimension?.Rows ?? 0;
                worksheet.Cells[rowCount + 1, 1].Value = username;
                worksheet.Cells[rowCount + 1, 2].Value = password;
                worksheet.Cells[rowCount + 1, 3].Value = id;
                worksheet.Cells[rowCount + 1, 4].Value = email;
                worksheet.Cells[rowCount + 1, 5].Value = string.IsNullOrEmpty(gender) ? (object)DBNull.Value : gender;
                worksheet.Cells[rowCount + 1, 6].Value = 0;
                worksheet.Cells[rowCount + 1, 7].Value = "No"; // הוספת ערך התחברות התחלתי

                package.Save();
            }
        }

        // פונקציה לעדכון הסטטוס של משתמשים
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

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            txtUsername.Location = new System.Drawing.Point((formWidth - txtUsername.Width) / 2, (formHeight - txtUsername.Height) / 2 - 120);
            lblUsername.Location = new System.Drawing.Point(txtUsername.Location.X + txtUsername.Width + 10, txtUsername.Location.Y + 3);

            txtPassword.Location = new System.Drawing.Point((formWidth - txtPassword.Width) / 2, txtUsername.Location.Y + 50);
            lblPassword.Location = new System.Drawing.Point(txtPassword.Location.X + txtPassword.Width + 10, txtPassword.Location.Y + 3);

            txtID.Location = new System.Drawing.Point((formWidth - txtID.Width) / 2, txtPassword.Location.Y + 50);
            lblID.Location = new System.Drawing.Point(txtID.Location.X + txtID.Width + 10, txtID.Location.Y + 3);

            txtEmail.Location = new System.Drawing.Point((formWidth - txtEmail.Width) / 2, txtID.Location.Y + 50);
            lblEmail.Location = new System.Drawing.Point(txtEmail.Location.X + txtEmail.Width + 10, txtEmail.Location.Y + 3);

            rbMale.Location = new System.Drawing.Point((formWidth - rbMale.Width) / 2 - 30, txtEmail.Location.Y + 50);
            rbFemale.Location = new System.Drawing.Point(rbMale.Location.X + rbMale.Width + 10, rbMale.Location.Y);

            btnRegister.Location = new System.Drawing.Point((formWidth - btnRegister.Width) / 2, rbMale.Location.Y + 50);
            btnBack.Location = new System.Drawing.Point(50, formHeight - btnBack.Height - 50);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
