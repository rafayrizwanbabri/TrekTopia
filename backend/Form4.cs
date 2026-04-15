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

            images[0] = Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\1.jpg");
            images[1] = Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\2.jpg");
            images[2] = Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\3.jpg");

            DrawTextOnImage(images[0], text, new Font("Sitka Subheading", 40), Brushes.White, new Point(textOffsetX, 70));
            DrawTextOnImage(images[1], text, new Font("Sitka Subheading", 40), Brushes.White, new Point(textOffsetX, 70));
            DrawTextOnImage(images[2], text, new Font("Sitka Subheading", 250), Brushes.White, new Point(60, 90));

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
