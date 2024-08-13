using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace HebrewLearningApp
{
    public partial class MainForm : Form
    {
        private MainForm mainForm;

        public MainForm(MainForm _main)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterButtons();
            LoadBackgroundImageAsync("back.png");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterButtons();
        }

        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int buttonSpacing = 20; // Space between buttons

            // Calculate the positions to center the buttons
            int btnLoginX = (formWidth - btnLogin.Width) / 2;
            int btnLoginY = (formHeight - (btnLogin.Height + buttonSpacing + btnRegister.Height)) / 2;

            int btnRegisterX = btnLoginX;
            int btnRegisterY = btnLoginY + btnLogin.Height + buttonSpacing;

            // Set the new positions
            btnLogin.Location = new Point(btnLoginX, btnLoginY);
            btnRegister.Location = new Point(btnRegisterX, btnRegisterY);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            this.LoadChildForm(loginForm);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.LoadChildForm(registerForm);
        }

        public void LoadChildForm(Form childForm)
        {
            // Close any existing child form
            foreach (Control control in this.Controls)
            {
                if (control is Form existingChildForm)
                {
                    existingChildForm.Close();
                }
            }

            // Set the new child form properties
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the new child form to the parent form
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
