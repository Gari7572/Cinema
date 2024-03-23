namespace Cinema
{
    partial class ConcertSeats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcertSeats));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketButton = new System.Windows.Forms.Button();
            this.SummLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fan1button = new System.Windows.Forms.Button();
            this.Fan2Button = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Сума:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Кількість:";
            // 
            // TicketButton
            // 
            this.TicketButton.BackColor = System.Drawing.Color.LightGray;
            this.TicketButton.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.TicketButton.Location = new System.Drawing.Point(746, 465);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(114, 60);
            this.TicketButton.TabIndex = 52;
            this.TicketButton.Text = "Купити";
            this.TicketButton.UseVisualStyleBackColor = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // SummLabel
            // 
            this.SummLabel.AutoSize = true;
            this.SummLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.SummLabel.Location = new System.Drawing.Point(186, 70);
            this.SummLabel.Name = "SummLabel";
            this.SummLabel.Size = new System.Drawing.Size(55, 21);
            this.SummLabel.TabIndex = 41;
            this.SummLabel.Text = "Сума";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.AmountLabel.Location = new System.Drawing.Point(186, 26);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(88, 21);
            this.AmountLabel.TabIndex = 40;
            this.AmountLabel.Text = "Кількість";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.NameLabel.Location = new System.Drawing.Point(421, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 20);
            this.NameLabel.TabIndex = 39;
            this.NameLabel.Text = "Назва";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label1.Location = new System.Drawing.Point(241, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 60);
            this.label1.TabIndex = 33;
            this.label1.Text = "Сцена";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fan1button
            // 
            this.Fan1button.BackColor = System.Drawing.Color.Gainsboro;
            this.Fan1button.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.Fan1button.Location = new System.Drawing.Point(190, 292);
            this.Fan1button.Name = "Fan1button";
            this.Fan1button.Size = new System.Drawing.Size(518, 147);
            this.Fan1button.TabIndex = 56;
            this.Fan1button.Text = "ФАН-ЗОНА 1";
            this.Fan1button.UseVisualStyleBackColor = false;
            this.Fan1button.Click += new System.EventHandler(this.Fan1button_Click);
            // 
            // Fan2Button
            // 
            this.Fan2Button.BackColor = System.Drawing.Color.BurlyWood;
            this.Fan2Button.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.Fan2Button.Location = new System.Drawing.Point(190, 127);
            this.Fan2Button.Name = "Fan2Button";
            this.Fan2Button.Size = new System.Drawing.Size(518, 147);
            this.Fan2Button.TabIndex = 57;
            this.Fan2Button.Text = "ФАН-ЗОНА 2";
            this.Fan2Button.UseVisualStyleBackColor = false;
            this.Fan2Button.Click += new System.EventHandler(this.Fan2Button_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.AddressLabel.Location = new System.Drawing.Point(694, 27);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(185, 44);
            this.AddressLabel.TabIndex = 58;
            this.AddressLabel.Text = "Адреса";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.DateLabel.Location = new System.Drawing.Point(694, 71);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(52, 21);
            this.DateLabel.TabIndex = 59;
            this.DateLabel.Text = "Дата";
            // 
            // ConcertSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.Fan2Button);
            this.Controls.Add(this.Fan1button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketButton);
            this.Controls.Add(this.SummLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConcertSeats";
            this.Text = "ConcertSeats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TicketButton;
        private System.Windows.Forms.Label SummLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fan1button;
        private System.Windows.Forms.Button Fan2Button;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}