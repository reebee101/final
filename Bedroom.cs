using Microsoft.VisualBasic.Logging;
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
    public partial class Categories : Form
    {
        public Categories()
        {
            this.Name="bedrooms";
            this.Text = "bedrooms";
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            logo.Parent = Background;
            logo.BackColor = Color.Transparent;

           // bedroom.Parent = Background;
            //bedroom.BackColor = Color.Transparent;
            
            cart.BackColor = Color.Transparent;
            cart.Parent= Background;

            back.BackColor = Color.Transparent;
            back.Parent = Background;

            next.BackColor = Color.Transparent;
            next.Parent = Background;
        }

        private void bedroom_Click(object sender, EventArgs e)
        {

            //Form3 Bed = new Form3();
            //this.Hide();
            //Bed.ShowDialog();
            //this.Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            this.Hide();
            homepage.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bed Bed = new Bed();
            this.Hide();
            Bed.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            closet form = new closet();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            closet form = new closet();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        vanity form = new vanity();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vanity form = new vanity();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Form3 Bed = new Form3();
            //this.Hide();
            //Bed.ShowDialog();
            //this.Close();
        }

        private void BedPic_Click(object sender, EventArgs e)
        {
            Bed Bed = new Bed();
            this.Hide();
            Bed.ShowDialog();
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Bed form = new Bed();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Homepage form = new Homepage();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
