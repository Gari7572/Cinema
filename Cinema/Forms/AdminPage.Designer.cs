namespace Cinema
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.Surname,
            this.Email,
            this.PhoneNum,
            this.Password});
            this.dataGridView1.Location = new System.Drawing.Point(38, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Ім\'я";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Прізвище";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Номер телефону";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Пароль";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightGray;
            this.Exit.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.Exit.Location = new System.Drawing.Point(638, 480);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(204, 36);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Закрити програму";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightGray;
            this.BackButton.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.BackButton.Location = new System.Drawing.Point(38, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(145, 36);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button BackButton;
    }
}