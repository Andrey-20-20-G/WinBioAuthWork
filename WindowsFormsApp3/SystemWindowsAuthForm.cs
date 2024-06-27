using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Settings_files;

namespace WindowsFormsApp3
{
    public partial class SystemWindowsAuthForm : Form
    {

        Point lastPoint;
        LocalWindowsAccountHelper localWindowsAccountHelper = new LocalWindowsAccountHelper();

        public SystemWindowsAuthForm()
        {
            InitializeComponent();
            Pass_textBox.PasswordChar = '⚫';
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void SystemWindowsAuthForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SystemWindowsAuthForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Auth_button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Pass_textBox.Text) || 
                String.IsNullOrEmpty(Login_textBox.Text))
            {
                MessageBox.Show("Убедитесь, что вы ввели и логин и пароль", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(localWindowsAccountHelper.LocalWindowsAvailableCheckAsync(
                    Login_textBox.Text, Pass_textBox.Text))
                {
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Убедитесь, что вы ввели корректные логин и пароль",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
