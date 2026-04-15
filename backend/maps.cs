using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class hotels : Form
    {
        private List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        private int currentIndex = 0;
        private List<System.Drawing.Image> images1 = new List<System.Drawing.Image>();
        private int c1 = 0;
        private List<System.Drawing.Image> images2 = new List<System.Drawing.Image>();
        private int c2 = 0;

        public hotels()
        {
            InitializeComponent();

            var image1 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\a.jpg"); // Load the image
            images.Add((image1));
            var image2 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\b.jpg");
            images.Add((image2));
            var image3 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\c.jpg");
            images.Add((image3));

            var image4 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\a1.jpg");
            images1.Add((image4));
            var image5 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\b1.jpg");
            images1.Add((image5));
            var image6 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\c1.jpg");
            images1.Add((image6));

            var image7 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\a2.jpg");
            images2.Add((image7));
            var image8 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\b2.jpg");
            images2.Add((image8));
            var image9 = System.Drawing.Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\c2.jpg");
            images2.Add((image9));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (images.Count == 0)
                return;

            pictureBox4.BackgroundImage = images[currentIndex];
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;

            currentIndex++;
            if (currentIndex == images.Count)
                currentIndex = 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (images1.Count == 0)
                return;

            pictureBox2.BackgroundImage = images1[c1];
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

            c1++;
            if (c1 == images1.Count)
                c1 = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (images2.Count == 0)
                return;

            pictureBox5.BackgroundImage = images2[c2];
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;

            c2++;
            if (c2 == images2.Count)
                c2 = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hotels h = new hotels();
            h.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            flights f = new flights();
            f.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cars c = new cars();
            c.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            maps m = new maps();
            m.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            var amadeusApi = new AmadeusAPI("wXRiLkGjtodE3Df9WCnlKcirDK3xHNwA", "yRONb3XKF1UxBAeA");
            var x = comboBox1.Text;
            if(x == null || x.Length  < 3) {
                return;
            }
            var hotels = await amadeusApi.GetHotels(x);
            listView1.View = View.Details;
            listView1.Columns.Add("Hotels", 400);

            foreach (var hotel in hotels)
            {
                ListViewItem item = new ListViewItem(hotel);
                listView1.Items.Add(item);
            }

        }
    }
}
