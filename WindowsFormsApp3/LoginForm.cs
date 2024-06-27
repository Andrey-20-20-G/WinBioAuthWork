using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Windows.Security.Credentials.UI;
using WindowsFormsApp3.AccessRoles;
using WindowsFormsApp3.Settings_files;

namespace WindowsFormsApp3
{
    public partial class LoginForm : Form
    {
        Point lastPoint;
        MicrosoftPassportHelper microsoftPassportHelper = new MicrosoftPassportHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void AuthenticateWithWindowsHello()
        {
            try
            {
                var consentResult = await UserConsentVerifier.RequestVerificationAsync(
                    "Для доступа к приложению подтвердите свою личность с помощью Windows Hello.");

                if (consentResult == UserConsentVerificationResult.Verified)
                {
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.Show();
                    // Продолжить выполнение приложения или открыть главную форму
                }
                else
                {
                    MessageBox.Show("Аутентификация не удалась. Попробуйте снова.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseWindow_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseWindow_button_MouseEnter(object sender, EventArgs e)
        {
            CloseWindow_button.ForeColor = Color.Red;
        }

        private void CloseWindow_button_MouseLeave(object sender, EventArgs e)
        {
            CloseWindow_button.ForeColor = Color.White;
        }

        
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private async void bioAuth_button_Click(object sender, EventArgs e)
        {
            
            if (await microsoftPassportHelper.MicrosoftPassportAvailableCheckAsync())
            {
                AuthenticateWithWindowsHello();
            }
            else
            {
                
            }
            
        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var appRegForm = new AppRegForm();
            appRegForm.Show();
        }

        private void windowsAuth_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var systemWindowsAuthForm = new SystemWindowsAuthForm();
            systemWindowsAuthForm.Show();
        }

        private void signUp_button_MouseEnter(object sender, EventArgs e)
        {
            signUp_button.ForeColor = Color.BlueViolet;
        }

        private void signUp_button_MouseLeave(object sender, EventArgs e)
        {
            signUp_button.ForeColor = Color.White;
        }

        private void bioAuth_button_MouseHover(object sender, EventArgs e)
        {
            bioAuth_button.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bioAuth_button_MouseEnter(object sender, EventArgs e)
        {
            bioAuth_button.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bioAuth_button_MouseLeave(object sender, EventArgs e)
        {
            bioAuth_button.BorderStyle = BorderStyle.None;
        }

        private void windowsAuth_button_MouseEnter(object sender, EventArgs e)
        {
            windowsAuth_button.BorderStyle = BorderStyle.Fixed3D;
        }

        private void windowsAuth_button_MouseLeave(object sender, EventArgs e)
        {
            windowsAuth_button.BorderStyle = BorderStyle.None;
        }

        private void appAuth_button_MouseEnter(object sender, EventArgs e)
        {
            appAuth_button.BorderStyle = BorderStyle.Fixed3D;
        }

        private void appAuth_button_MouseLeave(object sender, EventArgs e)
        {
            appAuth_button.BorderStyle = BorderStyle.None;
        }

        private void appAuth_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var appAuthForm = new AppAuthForm();
            appAuthForm.Show();
        }
    }
}
