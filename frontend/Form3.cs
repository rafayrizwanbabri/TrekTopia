using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        //private List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        private int currentIndex = 0;
        private System.Drawing.Image[] images = new System.Drawing.Image[3];
        private string text = "Step into Serenity, Trek with TrekTopia!";
        private int textOffsetX = 50;

        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;

            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string[] imagePaths = new string[]
                {
                    Path.Combine(currentDirectory, "Resources", "1.jpg"),
                    Path.Combine(currentDirectory, "Resources", "2.jpg"),
                    Path.Combine(currentDirectory, "Resources", "3.jpg")
                };

                for (int i = 0; i < imagePaths.Length; i++)
                {
                    if (File.Exists(imagePaths[i]))
                    {
                        images[i] = Image.FromFile(imagePaths[i]);
                    }
                    else
                    {
                        // Create a placeholder image if file doesn't exist
                        images[i] = CreatePlaceholderImage();
                    }
                }

                DrawTextOnImage(images[0], text, new Font("Sitka Subheading", 40), Brushes.White, new Point(textOffsetX, 70));
                DrawTextOnImage(images[1], text, new Font("Sitka Subheading", 40), Brushes.White, new Point(textOffsetX, 70));
                DrawTextOnImage(images[2], text, new Font("Sitka Subheading", 60), Brushes.White, new Point(60, 90));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}. Using placeholder images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                for (int i = 0; i < 3; i++)
                {
                    images[i] = CreatePlaceholderImage();
                }
            }
        }

        private System.Drawing.Image CreatePlaceholderImage()
        {
            Bitmap placeholder = new Bitmap(800, 600);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.DarkSlateBlue);
                g.DrawString("Image Not Found", new Font("Arial", 24, FontStyle.Bold), Brushes.White, 250, 250);
                g.DrawString("TrekTopia", new Font("Arial", 40, FontStyle.Bold), Brushes.LightBlue, 300, 350);
            }
            return placeholder;
        }
        private void DrawTextOnImage(Image image, string text, Font font, Brush brush, Point location)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.DrawString(text, font, brush, location);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (images.Length == 0)
                return;

            pictureBox1.BackgroundImage = images[currentIndex];
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            currentIndex++;
            if (currentIndex == images.Length)
                currentIndex = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            flights f = new flights();
            f.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hotels h = new hotels();
            h.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cars c = new cars();
            c.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            maps m = new maps();
            m.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
