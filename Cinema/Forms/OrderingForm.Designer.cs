namespace Cinema
{
    partial class OrderingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BackButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.ComboBoxNumTickets = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaceLabel = new System.Windows.Forms.Label();
            this.PlaceBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label2.Location = new System.Drawing.Point(29, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label3.Location = new System.Drawing.Point(30, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість квитків";
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.TitleBox.Location = new System.Drawing.Point(179, 155);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(276, 23);
            this.TitleBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 205);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightGray;
            this.BackButton.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.BackButton.Location = new System.Drawing.Point(12, 503);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 37);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BuyButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.BuyButton.Location = new System.Drawing.Point(201, 442);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(186, 37);
            this.BuyButton.TabIndex = 8;
            this.BuyButton.Text = "Обрати місця";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label4.Location = new System.Drawing.Point(794, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Детальніше:";
            // 
            // SumLabel
            // 
            this.SumLabel.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.SumLabel.Location = new System.Drawing.Point(461, 293);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(45, 24);
            this.SumLabel.TabIndex = 10;
            this.SumLabel.Text = "Ціна";
            this.SumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBoxNumTickets
            // 
            this.ComboBoxNumTickets.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.ComboBoxNumTickets.FormattingEnabled = true;
            this.ComboBoxNumTickets.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComboBoxNumTickets.Location = new System.Drawing.Point(180, 293);
            this.ComboBoxNumTickets.Name = "ComboBoxNumTickets";
            this.ComboBoxNumTickets.Size = new System.Drawing.Size(275, 26);
            this.ComboBoxNumTickets.TabIndex = 12;
            this.ComboBoxNumTickets.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNumTickets_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(797, 102);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(236, 331);
            this.Description.TabIndex = 13;
            this.Description.Text = "";
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.TypeBox.Location = new System.Drawing.Point(179, 102);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.ReadOnly = true;
            this.TypeBox.Size = new System.Drawing.Size(276, 23);
            this.TypeBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label5.Location = new System.Drawing.Point(29, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тип події";
            // 
            // PlaceLabel
            // 
            this.PlaceLabel.AutoSize = true;
            this.PlaceLabel.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.PlaceLabel.Location = new System.Drawing.Point(30, 340);
            this.PlaceLabel.Name = "PlaceLabel";
            this.PlaceLabel.Size = new System.Drawing.Size(95, 19);
            this.PlaceLabel.TabIndex = 16;
            this.PlaceLabel.Text = "Місце події:";
            // 
            // PlaceBox
            // 
            this.PlaceBox.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.PlaceBox.Location = new System.Drawing.Point(180, 337);
            this.PlaceBox.Name = "PlaceBox";
            this.PlaceBox.ReadOnly = true;
            this.PlaceBox.Size = new System.Drawing.Size(276, 57);
            this.PlaceBox.TabIndex = 17;
            this.PlaceBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(532, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.label6.Location = new System.Drawing.Point(30, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Час";
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Items.AddRange(new object[] {
            "10:00",
            "12:00",
            "14:00",
            "16:00",
            "18:00",
            "20:00"});
            this.TimeComboBox.Location = new System.Drawing.Point(178, 250);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(275, 26);
            this.TimeComboBox.TabIndex = 19;
            // 
            // OrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 563);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlaceBox);
            this.Controls.Add(this.PlaceLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ComboBoxNumTickets);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderingForm";
            this.Text = "OrderingForm";
            this.Load += new System.EventHandler(this.OrderingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.ComboBox ComboBoxNumTickets;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PlaceLabel;
        private System.Windows.Forms.RichTextBox PlaceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TimeComboBox;
    }
}