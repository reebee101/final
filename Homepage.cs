using System.Diagnostics;

namespace home_page
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Size = new System.Drawing.Size(1000, 635);

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            logo.Parent = Background;
            logo.BackColor= Color.Transparent;
            Info.Parent = Background;
            Info.BackColor= Color.Transparent;
            contact.Parent= Background;
            contact.BackColor= Color.Transparent;
            login.Parent= Background;
            login.BackColor= Color.Transparent;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Categories bedroom = new Categories();
            this.Hide();
            bedroom.ShowDialog();
            this.Close();
        }

        private void bedroom_Click(object sender, EventArgs e)
        {
            Categories bedroom = new Categories();
            this.Hide();
            bedroom.ShowDialog();
            this.Close();
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            try
            {

                string url = "https://www.instagram.com/homify.officiall/";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            { MessageBox.Show($"An error occurred: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
    }
}