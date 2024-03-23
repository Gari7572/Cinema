namespace Cinema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.AdminLogButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema|Theatre|Concert Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(390, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логін";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(390, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(393, 252);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(415, 23);
            this.LoginBox.TabIndex = 3;
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(393, 332);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(415, 23);
            this.PassBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(393, 392);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(118, 39);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Вхід";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AdminLogButton
            // 
            this.AdminLogButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AdminLogButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLogButton.Location = new System.Drawing.Point(681, 164);
            this.AdminLogButton.Name = "AdminLogButton";
            this.AdminLogButton.Size = new System.Drawing.Size(189, 47);
            this.AdminLogButton.TabIndex = 6;
            this.AdminLogButton.Text = "Вхід для адміна";
            this.AdminLogButton.UseVisualStyleBackColor = false;
            this.AdminLogButton.Click += new System.EventHandler(this.AdminLogButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExitButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(714, 502);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 39);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Bisque;
            this.RegButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(653, 392);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(155, 39);
            this.RegButton.TabIndex = 8;
            this.RegButton.Text = "Реєстрація";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.ticket;
            this.pictureBox1.Location = new System.Drawing.Point(35, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AdminLogButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Вхід";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button AdminLogButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

