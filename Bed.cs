using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_page
{
    public partial class Bed : Form
    {
        public Bed()
        {
            InitializeComponent();
        }

        private void Bed_Load(object sender, EventArgs e)
        {
            logo.Parent = Background;
            logo.BackColor = Color.Transparent;

            cart.BackColor = Color.Transparent;
            cart.Parent = Background;

            cart_inside.Parent = Background;
            cart_inside.BackColor = Color.Transparent;

            colors.BackColor = Color.Transparent;
            colors.Parent= Background;

            back.BackColor= Color.Transparent;
            back.Parent= Background;

            next.BackColor= Color.Transparent;
            next.Parent= Background;

        
        }

        private void colors_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.colors.CreateGraphics();
            Pen p = new Pen(Color.Wheat, 15);
            g.DrawEllipse(p, 15, 15, 15, 15);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Homepage form = new Homepage();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            closet form = new closet();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Categories form = new Categories();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("item added to cart");
        }

        private void cart_val_Click(object sender, EventArgs e)
        {        }
    }
}
