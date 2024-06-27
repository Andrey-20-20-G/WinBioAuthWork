namespace WindowsFormsApp3
{
    partial class AppAuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppAuthForm));
            this.Back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Auth_button = new System.Windows.Forms.Button();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(262, 391);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(665, 59);
            this.Back_button.TabIndex = 19;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(64, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(64, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Login";
            // 
            // Auth_button
            // 
            this.Auth_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auth_button.Location = new System.Drawing.Point(262, 326);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(665, 59);
            this.Auth_button.TabIndex = 16;
            this.Auth_button.Text = "Auth";
            this.Auth_button.UseVisualStyleBackColor = true;
            this.Auth_button.Click += new System.EventHandler(this.Auth_button_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.Login_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Login_textBox.Location = new System.Drawing.Point(262, 171);
            this.Login_textBox.Multiline = true;
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(665, 61);
            this.Login_textBox.TabIndex = 15;
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.Pass_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Pass_textBox.Location = new System.Drawing.Point(262, 250);
            this.Pass_textBox.Multiline = true;
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(665, 61);
            this.Pass_textBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(406, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1094, 466);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Auth_button);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppAuthForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppAuthForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppAuthForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Auth_button;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label label1;
    }
}