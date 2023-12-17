namespace home_page
{
    partial class vanity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vanity));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.colors = new System.Windows.Forms.Panel();
            this.idNumber = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.material_val = new System.Windows.Forms.Label();
            this.style_val = new System.Windows.Forms.Label();
            this.width_val = new System.Windows.Forms.Label();
            this.len_value = new System.Windows.Forms.Label();
            this.style = new System.Windows.Forms.Label();
            this.price_val = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.PictureBox();
            this.ClosetPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(689, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buy item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(689, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 45);
            this.button2.TabIndex = 24;
            this.button2.Text = "Add to cart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cart
            // 
            this.cart.Image = global::home_page.Properties.Resources.cart;
            this.cart.Location = new System.Drawing.Point(903, 12);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(58, 59);
            this.cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cart.TabIndex = 25;
            this.cart.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Menu;
            this.search.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.Silver;
            this.search.Location = new System.Drawing.Point(720, 77);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(241, 25);
            this.search.TabIndex = 26;
            this.search.Text = "What can we help you find today? 🔍\n";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Script MT Bold", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logo.ForeColor = System.Drawing.SystemColors.Menu;
            this.logo.Location = new System.Drawing.Point(337, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(286, 85);
            this.logo.TabIndex = 27;
            this.logo.Text = "H⌂mify";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.next.ForeColor = System.Drawing.SystemColors.Menu;
            this.next.Location = new System.Drawing.Point(67, 26);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(20, 20);
            this.next.TabIndex = 43;
            this.next.Text = ">";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(31, 26);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(20, 20);
            this.back.TabIndex = 44;
            this.back.Text = "<";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // colors
            // 
            this.colors.Location = new System.Drawing.Point(492, 217);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(47, 45);
            this.colors.TabIndex = 60;
            this.colors.Paint += new System.Windows.Forms.PaintEventHandler(this.colors_Paint);
            // 
            // idNumber
            // 
            this.idNumber.AutoSize = true;
            this.idNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idNumber.Location = new System.Drawing.Point(492, 472);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(41, 20);
            this.idNumber.TabIndex = 59;
            this.idNumber.Text = "0003";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.ID.Location = new System.Drawing.Point(367, 472);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 28);
            this.ID.TabIndex = 58;
            this.ID.Text = "ID:";
            // 
            // material_val
            // 
            this.material_val.AutoSize = true;
            this.material_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.material_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.material_val.Location = new System.Drawing.Point(492, 422);
            this.material_val.Name = "material_val";
            this.material_val.Size = new System.Drawing.Size(66, 28);
            this.material_val.TabIndex = 57;
            this.material_val.Text = "Wood";
            // 
            // style_val
            // 
            this.style_val.AutoSize = true;
            this.style_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.style_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.style_val.Location = new System.Drawing.Point(492, 372);
            this.style_val.Name = "style_val";
            this.style_val.Size = new System.Drawing.Size(82, 28);
            this.style_val.TabIndex = 56;
            this.style_val.Text = "Modern";
            // 
            // width_val
            // 
            this.width_val.AutoSize = true;
            this.width_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.width_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.width_val.Location = new System.Drawing.Point(492, 322);
            this.width_val.Name = "width_val";
            this.width_val.Size = new System.Drawing.Size(109, 28);
            this.width_val.TabIndex = 55;
            this.width_val.Text = "200 meters";
            // 
            // len_value
            // 
            this.len_value.AutoSize = true;
            this.len_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.len_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.len_value.Location = new System.Drawing.Point(492, 272);
            this.len_value.Name = "len_value";
            this.len_value.Size = new System.Drawing.Size(90, 28);
            this.len_value.TabIndex = 54;
            this.len_value.Text = "50 meter";
            // 
            // style
            // 
            this.style.AutoSize = true;
            this.style.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.style.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.style.Location = new System.Drawing.Point(367, 372);
            this.style.Name = "style";
            this.style.Size = new System.Drawing.Size(60, 28);
            this.style.TabIndex = 53;
            this.style.Text = "Style:";
            // 
            // price_val
            // 
            this.price_val.AutoSize = true;
            this.price_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_val.Location = new System.Drawing.Point(492, 172);
            this.price_val.Name = "price_val";
            this.price_val.Size = new System.Drawing.Size(60, 28);
            this.price_val.TabIndex = 52;
            this.price_val.Text = "9,000";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.material.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.material.Location = new System.Drawing.Point(367, 422);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(90, 28);
            this.material.TabIndex = 51;
            this.material.Text = "Material:";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.width.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.width.Location = new System.Drawing.Point(367, 322);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(72, 28);
            this.width.TabIndex = 50;
            this.width.Text = "Width:";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.length.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.length.Location = new System.Drawing.Point(367, 272);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(81, 28);
            this.length.TabIndex = 49;
            this.length.Text = "Length:";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.color.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.color.Location = new System.Drawing.Point(367, 222);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(78, 28);
            this.color.TabIndex = 48;
            this.color.Text = "Colour:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.price.Location = new System.Drawing.Point(367, 172);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(61, 28);
            this.price.TabIndex = 47;
            this.price.Text = "Price:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.name.Location = new System.Drawing.Point(367, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(81, 31);
            this.name.TabIndex = 46;
            this.name.Text = "Vanity";
            // 
            // Background
            // 
            this.Background.Image = global::home_page.Properties.Resources.gui3;
            this.Background.Location = new System.Drawing.Point(-1, -4);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(985, 561);
            this.Background.TabIndex = 45;
            this.Background.TabStop = false;
            // 
            // ClosetPicture
            // 
            this.ClosetPicture.Image = ((System.Drawing.Image)(resources.GetObject("ClosetPicture.Image")));
            this.ClosetPicture.Location = new System.Drawing.Point(31, 182);
            this.ClosetPicture.Name = "ClosetPicture";
            this.ClosetPicture.Size = new System.Drawing.Size(299, 268);
            this.ClosetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosetPicture.TabIndex = 61;
            this.ClosetPicture.TabStop = false;
            // 
            // vanity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.ClosetPicture);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.material_val);
            this.Controls.Add(this.style_val);
            this.Controls.Add(this.width_val);
            this.Controls.Add(this.len_value);
            this.Controls.Add(this.style);
            this.Controls.Add(this.price_val);
            this.Controls.Add(this.material);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.color);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Background);
            this.Name = "vanity";
            this.Text = "vanity";
            ((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosetPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private PictureBox cart;
        private TextBox search;
        private Label logo;
        private Label next;
        private Label back;
        private Panel colors;
        private Label idNumber;
        private Label ID;
        private Label material_val;
        private Label style_val;
        private Label width_val;
        private Label len_value;
        private Label style;
        private Label price_val;
        private Label material;
        private Label width;
        private Label length;
        private Label color;
        private Label price;
        private Label name;
        private PictureBox Background;
        private PictureBox ClosetPicture;
    }
}