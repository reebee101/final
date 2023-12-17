namespace home_page
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.Background = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bedroom = new System.Windows.Forms.Button();
            this.living = new System.Windows.Forms.Button();
            this.bathroom = new System.Windows.Forms.Button();
            this.instagram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(-6, -5);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1027, 596);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Script MT Bold", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logo.ForeColor = System.Drawing.SystemColors.Menu;
            this.logo.Location = new System.Drawing.Point(348, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(286, 85);
            this.logo.TabIndex = 1;
            this.logo.Text = "H⌂mify";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Info.Location = new System.Drawing.Point(70, 565);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(826, 16);
            this.Info.TabIndex = 2;
            this.Info.Text = "Address: 123 street, 2nd floor                                   Phone number: 01" +
    "0000000                                  Email: Homify@gmail.com";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contact.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.contact.Location = new System.Drawing.Point(2, 530);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(112, 20);
            this.contact.TabIndex = 3;
            this.contact.Text = "Contact us:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Menu;
            this.search.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.Silver;
            this.search.Location = new System.Drawing.Point(713, 46);
            this.search.Margin = new System.Windows.Forms.Padding(10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(241, 26);
            this.search.TabIndex = 4;
            this.search.Text = "What can we help you find today? 🔍\n";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lucida Fax", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.SystemColors.Menu;
            this.login.Location = new System.Drawing.Point(850, 20);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(121, 16);
            this.login.TabIndex = 5;
            this.login.Text = "Log In/Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::home_page.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(679, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 260);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::home_page.Properties.Resources.Untitled;
            this.pictureBox2.Location = new System.Drawing.Point(354, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 260);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 260);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bedroom
            // 
            this.bedroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.bedroom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bedroom.ForeColor = System.Drawing.SystemColors.Menu;
            this.bedroom.Location = new System.Drawing.Point(108, 435);
            this.bedroom.Name = "bedroom";
            this.bedroom.Size = new System.Drawing.Size(118, 37);
            this.bedroom.TabIndex = 13;
            this.bedroom.Text = "Bedrooms";
            this.bedroom.UseVisualStyleBackColor = false;
            this.bedroom.Click += new System.EventHandler(this.bedroom_Click);
            // 
            // living
            // 
            this.living.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.living.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.living.ForeColor = System.Drawing.SystemColors.Menu;
            this.living.Location = new System.Drawing.Point(430, 435);
            this.living.Name = "living";
            this.living.Size = new System.Drawing.Size(126, 37);
            this.living.TabIndex = 14;
            this.living.Text = "Living rooms";
            this.living.UseVisualStyleBackColor = false;
            // 
            // bathroom
            // 
            this.bathroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.bathroom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bathroom.ForeColor = System.Drawing.SystemColors.Menu;
            this.bathroom.Location = new System.Drawing.Point(764, 435);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(111, 37);
            this.bathroom.TabIndex = 15;
            this.bathroom.Text = "Bathrooms";
            this.bathroom.UseVisualStyleBackColor = false;
            // 
            // instagram
            // 
            this.instagram.Image = global::home_page.Properties.Resources.instage;
            this.instagram.Location = new System.Drawing.Point(888, 542);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(95, 49);
            this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instagram.TabIndex = 16;
            this.instagram.TabStop = false;
            this.instagram.Click += new System.EventHandler(this.Instagram_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 590);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.bathroom);
            this.Controls.Add(this.living);
            this.Controls.Add(this.bedroom);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.search);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Background);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Background;
        private Label logo;
        private Label Info;
        private Label contact;
        private TextBox search;
        private Label login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button bedroom;
        private Button living;
        private Button bathroom;
        private PictureBox instagram;
    }
}