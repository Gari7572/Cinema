namespace Cinema
{
    partial class TypeOfArt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeOfArt));
            this.CinemaButton = new System.Windows.Forms.Button();
            this.TheatreButton = new System.Windows.Forms.Button();
            this.ConcertButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CinemaButton
            // 
            this.CinemaButton.BackColor = System.Drawing.Color.Moccasin;
            this.CinemaButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.CinemaButton.Location = new System.Drawing.Point(74, 365);
            this.CinemaButton.Name = "CinemaButton";
            this.CinemaButton.Size = new System.Drawing.Size(220, 62);
            this.CinemaButton.TabIndex = 3;
            this.CinemaButton.Text = "Кіно";
            this.CinemaButton.UseVisualStyleBackColor = false;
            this.CinemaButton.Click += new System.EventHandler(this.CinemaButton_Click);
            // 
            // TheatreButton
            // 
            this.TheatreButton.BackColor = System.Drawing.Color.Wheat;
            this.TheatreButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.TheatreButton.Location = new System.Drawing.Point(341, 365);
            this.TheatreButton.Name = "TheatreButton";
            this.TheatreButton.Size = new System.Drawing.Size(220, 62);
            this.TheatreButton.TabIndex = 4;
            this.TheatreButton.Text = "Театр";
            this.TheatreButton.UseVisualStyleBackColor = false;
            this.TheatreButton.Click += new System.EventHandler(this.TheatreButton_Click);
            // 
            // ConcertButton
            // 
            this.ConcertButton.BackColor = System.Drawing.Color.Moccasin;
            this.ConcertButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.ConcertButton.Location = new System.Drawing.Point(612, 365);
            this.ConcertButton.Name = "ConcertButton";
            this.ConcertButton.Size = new System.Drawing.Size(220, 62);
            this.ConcertButton.TabIndex = 5;
            this.ConcertButton.Text = "Концерт";
            this.ConcertButton.UseVisualStyleBackColor = false;
            this.ConcertButton.Click += new System.EventHandler(this.ConcertButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cinema.Properties.Resources.m_concert;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(612, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cinema.Properties.Resources.m_theatre;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.m_Cinema;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.EmailLabel.Location = new System.Drawing.Point(71, 52);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(54, 19);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "label1";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightGray;
            this.ExitButton.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.ExitButton.Location = new System.Drawing.Point(762, 509);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 32);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TypeOfArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ConcertButton);
            this.Controls.Add(this.TheatreButton);
            this.Controls.Add(this.CinemaButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypeOfArt";
            this.Text = "TypeOfArt";
            this.Load += new System.EventHandler(this.TypeOfArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button CinemaButton;
        private System.Windows.Forms.Button TheatreButton;
        private System.Windows.Forms.Button ConcertButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}