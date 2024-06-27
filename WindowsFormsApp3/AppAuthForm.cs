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
    public partial class AppAuthForm : Form
    {
        Point lastPoint;

        public AppAuthForm()
        {
            InitializeComponent();
            Pass_textBox.PasswordChar = '⚫';
        }

        private void AppAuthForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AppAuthForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Auth_button_Click(object sender, EventArgs e)
        {
            var dbCom = new DBcommands();
            if (String.IsNullOrEmpty(Pass_textBox.Text) ||
                String.IsNullOrEmpty(Login_textBox.Text))
            {
                MessageBox.Show("Убедитесь, что вы ввели и логин и пароль",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Pass_textBox.Text.Length < 4)
                {
                    MessageBox.Show("Минимальная длина пароля 4 символа! " +
                        "Попробуйте ввести данные еще раз");
                    return;
                }
                if (dbCom.CheckUser(Login_textBox.Text, Pass_textBox.Text))
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

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
