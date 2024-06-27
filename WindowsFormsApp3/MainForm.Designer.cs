namespace WindowsFormsApp3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Username_label = new System.Windows.Forms.Label();
            this.Main_textBox = new System.Windows.Forms.TextBox();
            this.Read_button = new System.Windows.Forms.Button();
            this.Write_button = new System.Windows.Forms.Button();
            this.log_out_button = new System.Windows.Forms.PictureBox();
            this.FileName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.log_out_button)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Username_label.Location = new System.Drawing.Point(24, 41);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(168, 36);
            this.Username_label.TabIndex = 7;
            this.Username_label.Text = "Username";
            // 
            // Main_textBox
            // 
            this.Main_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Main_textBox.Location = new System.Drawing.Point(30, 99);
            this.Main_textBox.Multiline = true;
            this.Main_textBox.Name = "Main_textBox";
            this.Main_textBox.Size = new System.Drawing.Size(686, 262);
            this.Main_textBox.TabIndex = 8;
            // 
            // Read_button
            // 
            this.Read_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Read_button.Location = new System.Drawing.Point(30, 382);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(314, 59);
            this.Read_button.TabIndex = 10;
            this.Read_button.Text = "Read";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Write_button
            // 
            this.Write_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Write_button.Location = new System.Drawing.Point(350, 382);
            this.Write_button.Name = "Write_button";
            this.Write_button.Size = new System.Drawing.Size(314, 59);
            this.Write_button.TabIndex = 11;
            this.Write_button.Text = "Write";
            this.Write_button.UseVisualStyleBackColor = true;
            this.Write_button.Click += new System.EventHandler(this.Write_button_Click);
            // 
            // log_out_button
            // 
            this.log_out_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.log_out_button.Image = global::WindowsFormsApp3.Properties.Resources.exit;
            this.log_out_button.Location = new System.Drawing.Point(1033, 12);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(49, 65);
            this.log_out_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.log_out_button.TabIndex = 3;
            this.log_out_button.TabStop = false;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // FileName_textBox
            // 
            this.FileName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.FileName_textBox.Location = new System.Drawing.Point(738, 167);
            this.FileName_textBox.Multiline = true;
            this.FileName_textBox.Name = "FileName_textBox";
            this.FileName_textBox.Size = new System.Drawing.Size(344, 78);
            this.FileName_textBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(787, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название файла";
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(670, 382);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(314, 59);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1094, 466);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileName_textBox);
            this.Controls.Add(this.Write_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Main_textBox);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.log_out_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.log_out_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox log_out_button;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Main_textBox;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Write_button;
        private System.Windows.Forms.TextBox FileName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_button;
    }
}