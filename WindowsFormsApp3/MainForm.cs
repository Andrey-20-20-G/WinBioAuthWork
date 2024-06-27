using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.AccessRoles;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        Point lastPoint;
        string path;
        public MainForm()
        {
            InitializeComponent();
            Username_label.Text = UserModel.Login;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            UserModel.EndSession();
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void log_out_button_MouseEnter(object sender, EventArgs e)
        {
            log_out_button.BorderStyle = BorderStyle.Fixed3D;
        }

        private void log_out_button_MouseLeave(object sender, EventArgs e)
        {
            log_out_button.BorderStyle = BorderStyle.None;
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FileName_textBox.Text))
            {
                MessageBox.Show("Не задано имя файла",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserModel.Access.Read)
            {
                path = "../Files/" + FileName_textBox.Text + ".txt";
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файла с таким именем не существует",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (StreamReader stream = new StreamReader(path, true))
                {
                    Main_textBox.Text = stream.ReadToEnd();
                }
                Debug.WriteLine(DateTime.Now + " " + " " +  
                    UserModel.Login + "Read: " + Main_textBox.Text);
                FileName_textBox.Text = "";
            }
            else
            {
                MessageBox.Show($"У пользователя {UserModel.Login} нет прав на чтение файла. " +
                    $"Перезайдите в систему от пользователя, " +
                    $"у которого есть права доступа на чтение или обратитесь к администратору",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Write_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FileName_textBox.Text))
            {
                MessageBox.Show("Не задано имя файла",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserModel.Access.Write)
            {
                string path = "../Files/" + FileName_textBox.Text + ".txt";

                using (StreamWriter stream = new StreamWriter(path, true))
                {
                    stream.WriteLine(Main_textBox.Text);
                }
                Debug.WriteLine(DateTime.Now + " " + " " +
                    UserModel.Login + "Write: " + Main_textBox.Text);
                MessageBox.Show("Запись добавлена",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_textBox.Text = "";
                FileName_textBox.Text = "";
            }
            else
            {
                MessageBox.Show($"У пользователя {UserModel.Login} нет прав на запись в файл. " +
                    $"Перезайдите в систему от пользователя, " +
                    $"у которого есть права доступа на запись или обратитесь к администратору",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FileName_textBox.Text))
            {
                MessageBox.Show("Не задано имя файла",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserModel.Access.Delete)
            {
                string path = "../Files/" + FileName_textBox.Text + ".txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    MessageBox.Show("Такого файла не существует",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Debug.WriteLine(DateTime.Now + " " + " " +
                    UserModel.Login + "Delete: " + Main_textBox.Text);
                MessageBox.Show("Файл удален",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_textBox.Text = "";
                FileName_textBox.Text = "";
            }
            else
            {
                MessageBox.Show($"У пользователя {UserModel.Login} нет прав на удаление файла. " +
                    $"Перезайдите в систему от пользователя, " +
                    $"у которого есть права доступа на удаление или обратитесь к администратору",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
