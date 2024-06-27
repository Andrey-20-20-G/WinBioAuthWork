namespace WindowsFormsApp3
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.CloseWindow_button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signUp_button = new System.Windows.Forms.Label();
            this.bioAuth_button = new System.Windows.Forms.PictureBox();
            this.appAuth_button = new System.Windows.Forms.PictureBox();
            this.windowsAuth_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bioAuth_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appAuth_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsAuth_button)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseWindow_button
            // 
            this.CloseWindow_button.AutoSize = true;
            this.CloseWindow_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseWindow_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseWindow_button.Location = new System.Drawing.Point(1075, 9);
            this.CloseWindow_button.Name = "CloseWindow_button";
            this.CloseWindow_button.Size = new System.Drawing.Size(31, 29);
            this.CloseWindow_button.TabIndex = 0;
            this.CloseWindow_button.Text = "X";
            this.CloseWindow_button.Click += new System.EventHandler(this.CloseWindow_button_Click);
            this.CloseWindow_button.MouseEnter += new System.EventHandler(this.CloseWindow_button_MouseEnter);
            this.CloseWindow_button.MouseLeave += new System.EventHandler(this.CloseWindow_button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите вариант входа";
            // 
            // signUp_button
            // 
            this.signUp_button.AutoSize = true;
            this.signUp_button.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.ForeColor = System.Drawing.SystemColors.Window;
            this.signUp_button.Location = new System.Drawing.Point(401, 447);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(284, 27);
            this.signUp_button.TabIndex = 6;
            this.signUp_button.Text = "У меня нет учетной записи";
            this.signUp_button.Click += new System.EventHandler(this.signUp_button_Click);
            this.signUp_button.MouseEnter += new System.EventHandler(this.signUp_button_MouseEnter);
            this.signUp_button.MouseLeave += new System.EventHandler(this.signUp_button_MouseLeave);
            // 
            // bioAuth_button
            // 
            this.bioAuth_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bioAuth_button.Image = global::WindowsFormsApp3.Properties.Resources.Снимок_экрана_2024_06_25_074917_Photoroom;
            this.bioAuth_button.Location = new System.Drawing.Point(161, 232);
            this.bioAuth_button.Name = "bioAuth_button";
            this.bioAuth_button.Size = new System.Drawing.Size(112, 116);
            this.bioAuth_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bioAuth_button.TabIndex = 2;
            this.bioAuth_button.TabStop = false;
            this.bioAuth_button.Click += new System.EventHandler(this.bioAuth_button_Click);
            this.bioAuth_button.MouseEnter += new System.EventHandler(this.bioAuth_button_MouseEnter);
            this.bioAuth_button.MouseLeave += new System.EventHandler(this.bioAuth_button_MouseLeave);
            // 
            // appAuth_button
            // 
            this.appAuth_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appAuth_button.Image = global::WindowsFormsApp3.Properties.Resources.icons8_логин_и_пароль_64;
            this.appAuth_button.Location = new System.Drawing.Point(786, 232);
            this.appAuth_button.Name = "appAuth_button";
            this.appAuth_button.Size = new System.Drawing.Size(112, 116);
            this.appAuth_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appAuth_button.TabIndex = 4;
            this.appAuth_button.TabStop = false;
            this.appAuth_button.Click += new System.EventHandler(this.appAuth_button_Click);
            this.appAuth_button.MouseEnter += new System.EventHandler(this.appAuth_button_MouseEnter);
            this.appAuth_button.MouseLeave += new System.EventHandler(this.appAuth_button_MouseLeave);
            // 
            // windowsAuth_button
            // 
            this.windowsAuth_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windowsAuth_button.Image = global::WindowsFormsApp3.Properties.Resources.windows_icon_icons_com_60494;
            this.windowsAuth_button.Location = new System.Drawing.Point(468, 232);
            this.windowsAuth_button.Name = "windowsAuth_button";
            this.windowsAuth_button.Size = new System.Drawing.Size(112, 116);
            this.windowsAuth_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowsAuth_button.TabIndex = 3;
            this.windowsAuth_button.TabStop = false;
            this.windowsAuth_button.Click += new System.EventHandler(this.windowsAuth_button_Click);
            this.windowsAuth_button.MouseEnter += new System.EventHandler(this.windowsAuth_button_MouseEnter);
            this.windowsAuth_button.MouseLeave += new System.EventHandler(this.windowsAuth_button_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1116, 522);
            this.Controls.Add(this.appAuth_button);
            this.Controls.Add(this.windowsAuth_button);
            this.Controls.Add(this.bioAuth_button);
            this.Controls.Add(this.signUp_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseWindow_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.bioAuth_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appAuth_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsAuth_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseWindow_button;
        private System.Windows.Forms.PictureBox bioAuth_button;
        private System.Windows.Forms.PictureBox windowsAuth_button;
        private System.Windows.Forms.PictureBox appAuth_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signUp_button;
    }
}

