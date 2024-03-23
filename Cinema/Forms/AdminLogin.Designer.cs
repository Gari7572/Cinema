namespace Cinema
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightGray;
            this.ExitButton.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.ExitButton.Location = new System.Drawing.Point(752, 487);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(118, 39);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightBlue;
            this.LoginButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.LoginButton.Location = new System.Drawing.Point(543, 342);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(202, 39);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Вхід";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.PassBox.Location = new System.Drawing.Point(481, 268);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(339, 23);
            this.PassBox.TabIndex = 12;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.LoginBox.Location = new System.Drawing.Point(481, 204);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(339, 23);
            this.LoginBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label3.Location = new System.Drawing.Point(361, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label2.Location = new System.Drawing.Point(360, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логін";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 82);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вхід до адмін системи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightGray;
            this.BackButton.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.BackButton.Location = new System.Drawing.Point(34, 487);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(118, 39);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(24, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}