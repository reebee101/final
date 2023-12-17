namespace home_page
{
    partial class Bed
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
            this.Background = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.cart = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.ClosetPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.price_val = new System.Windows.Forms.Label();
            this.style = new System.Windows.Forms.Label();
            this.len_value = new System.Windows.Forms.Label();
            this.width_val = new System.Windows.Forms.Label();
            this.style_val = new System.Windows.Forms.Label();
            this.material_val = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.idNumber = new System.Windows.Forms.Label();
            this.cart_inside = new System.Windows.Forms.Label();
            this.colors = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Image = global::home_page.Properties.Resources.gui3;
            this.Background.Location = new System.Drawing.Point(-3, -1);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(985, 561);
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Script MT Bold", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logo.ForeColor = System.Drawing.SystemColors.Menu;
            this.logo.Location = new System.Drawing.Point(339, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(286, 85);
            this.logo.TabIndex = 3;
            this.logo.Text = "H⌂mify";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cart
            // 
            this.cart.Image = global::home_page.Properties.Resources.cart;
            this.cart.Location = new System.Drawing.Point(902, 9);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(58, 59);
            this.cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cart.TabIndex = 19;
            this.cart.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Menu;
            this.search.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.Silver;
            this.search.Location = new System.Drawing.Point(719, 74);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(241, 25);
            this.search.TabIndex = 20;
            this.search.Text = "What can we help you find today? 🔍\n";
            // 
            // ClosetPicture
            // 
            this.ClosetPicture.Image = global::home_page.Properties.Resources._6caa8c668e59c70d4c82d7b04a8f3fec;
            this.ClosetPicture.Location = new System.Drawing.Point(31, 175);
            this.ClosetPicture.Name = "ClosetPicture";
            this.ClosetPicture.Size = new System.Drawing.Size(299, 327);
            this.ClosetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosetPicture.TabIndex = 21;
            this.ClosetPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(668, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Buy item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(668, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add to cart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.name.Location = new System.Drawing.Point(365, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 31);
            this.name.TabIndex = 24;
            this.name.Text = "Beige king sized bed";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.price.Location = new System.Drawing.Point(365, 175);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(61, 28);
            this.price.TabIndex = 25;
            this.price.Text = "Price:";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.color.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.color.Location = new System.Drawing.Point(365, 225);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(78, 28);
            this.color.TabIndex = 26;
            this.color.Text = "Colour:";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.length.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.length.Location = new System.Drawing.Point(365, 275);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(81, 28);
            this.length.TabIndex = 27;
            this.length.Text = "Length:";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.width.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.width.Location = new System.Drawing.Point(365, 325);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(72, 28);
            this.width.TabIndex = 28;
            this.width.Text = "Width:";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.material.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.material.Location = new System.Drawing.Point(365, 425);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(90, 28);
            this.material.TabIndex = 29;
            this.material.Text = "Material:";
            // 
            // price_val
            // 
            this.price_val.AutoSize = true;
            this.price_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_val.Location = new System.Drawing.Point(490, 175);
            this.price_val.Name = "price_val";
            this.price_val.Size = new System.Drawing.Size(71, 28);
            this.price_val.TabIndex = 30;
            this.price_val.Text = "15,000";
            // 
            // style
            // 
            this.style.AutoSize = true;
            this.style.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.style.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.style.Location = new System.Drawing.Point(365, 375);
            this.style.Name = "style";
            this.style.Size = new System.Drawing.Size(60, 28);
            this.style.TabIndex = 31;
            this.style.Text = "Style:";
            // 
            // len_value
            // 
            this.len_value.AutoSize = true;
            this.len_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.len_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.len_value.Location = new System.Drawing.Point(490, 275);
            this.len_value.Name = "len_value";
            this.len_value.Size = new System.Drawing.Size(101, 28);
            this.len_value.TabIndex = 33;
            this.len_value.Text = "100 meter";
            // 
            // width_val
            // 
            this.width_val.AutoSize = true;
            this.width_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.width_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.width_val.Location = new System.Drawing.Point(490, 325);
            this.width_val.Name = "width_val";
            this.width_val.Size = new System.Drawing.Size(109, 28);
            this.width_val.TabIndex = 34;
            this.width_val.Text = "250 meters";
            // 
            // style_val
            // 
            this.style_val.AutoSize = true;
            this.style_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.style_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.style_val.Location = new System.Drawing.Point(490, 375);
            this.style_val.Name = "style_val";
            this.style_val.Size = new System.Drawing.Size(82, 28);
            this.style_val.TabIndex = 35;
            this.style_val.Text = "Modern";
            // 
            // material_val
            // 
            this.material_val.AutoSize = true;
            this.material_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.material_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.material_val.Location = new System.Drawing.Point(490, 425);
            this.material_val.Name = "material_val";
            this.material_val.Size = new System.Drawing.Size(66, 28);
            this.material_val.TabIndex = 36;
            this.material_val.Text = "Wood";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.ID.Location = new System.Drawing.Point(365, 475);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 28);
            this.ID.TabIndex = 37;
            this.ID.Text = "ID:";
            // 
            // idNumber
            // 
            this.idNumber.AutoSize = true;
            this.idNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idNumber.Location = new System.Drawing.Point(490, 475);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(41, 20);
            this.idNumber.TabIndex = 38;
            this.idNumber.Text = "0001";
            // 
            // cart_inside
            // 
            this.cart_inside.AutoSize = true;
            this.cart_inside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(114)))), ((int)(((byte)(92)))));
            this.cart_inside.Location = new System.Drawing.Point(925, 26);
            this.cart_inside.Name = "cart_inside";
            this.cart_inside.Size = new System.Drawing.Size(0, 20);
            this.cart_inside.TabIndex = 39;
            // 
            // colors
            // 
            this.colors.Location = new System.Drawing.Point(490, 220);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(47, 45);
            this.colors.TabIndex = 40;
            this.colors.Paint += new System.Windows.Forms.PaintEventHandler(this.colors_Paint);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(31, 26);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(20, 20);
            this.back.TabIndex = 41;
            this.back.Text = "<";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.next.ForeColor = System.Drawing.SystemColors.Menu;
            this.next.Location = new System.Drawing.Point(67, 26);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(20, 20);
            this.next.TabIndex = 42;
            this.next.Text = ">";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Bed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.cart_inside);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClosetPicture);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Background);
            this.Name = "Bed";
            this.Text = "Bed";
            this.Load += new System.EventHandler(this.Bed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosetPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Background;
        private Label logo;
        private PictureBox cart;
        private TextBox search;
        private PictureBox ClosetPicture;
        private Button button1;
        private Button button2;
        private Label name;
        private Label price;
        private Label color;
        private Label length;
        private Label width;
        private Label material;
        private Label price_val;
        private Label style;
        private Label len_value;
        private Label width_val;
        private Label style_val;
        private Label material_val;
        private Label ID;
        private Label idNumber;
        private Label cart_inside;
        private Panel colors;
        private Label back;
        private Label next;
    }
}