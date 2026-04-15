using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class flights : Form
    {
        private Image[] images = new Image[3];
        private string[] texts = { "Istanbul", "Kuala Lumpur", "Riyadh" };
        private int textOffsetX = 20;

        public flights()
        {
            InitializeComponent();

            images[0] = Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\4.jpg");
            images[1] = Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\5.jpg");
            images[2] = Image.FromFile(@"C:\Users\Admin\Downloads\WinFormsApp1\\Resources\\6.jpg");

            // Draw text on each image
            DrawTextOnImage(images[0], texts[0], new Font("Arial", 50), Brushes.White, new Point(textOffsetX, 50));
            DrawTextOnImage(images[1], texts[1], new Font("Arial", 25), Brushes.White, new Point(textOffsetX, 50));
            DrawTextOnImage(images[2], texts[2], new Font("Arial", 25), Brushes.White, new Point(textOffsetX, 50));
            
            // Display images
            pictureBox2.Image = images[0];
            pictureBox4.Image = images[1];
            pictureBox5.Image = images[2];
        }
        private void DrawTextOnImage(Image image, string text, Font font, Brush brush, Point location)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.DrawString(text, font, brush, location);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cars c = new cars();
            c.ShowDialog();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            maps m = new maps();
            m.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            var amadeusApi = new AmadeusAPI("wXRiLkGjtodE3Df9WCnlKcirDK3xHNwA", "yRONb3XKF1UxBAeA");
            var x = comboBox1.Text;
            if (x == null || x.Length < 3)
            {
                return;
            }
            var flights = await amadeusApi.GetFlightsx(comboBox1.Text, comboBox2.Text);
            listView1.View = View.Details;
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("From", 100);
            listView1.Columns.Add("To", 100);
            //listView1.Columns.Add("Segments", 60);
            listView1.Columns.Add("Price", 70);
            listView1.Columns.Add("#Seats", 90);


            foreach (var flight in flights)
            {
                ListViewItem item = new ListViewItem(flight.date.ToShortDateString());
                item.SubItems.Add(flight.origin);
                item.SubItems.Add(flight.destination);
                item.SubItems.Add(flight.segments.ToString());
                item.SubItems.Add(flight.price.ToString("C"));
                item.SubItems.Add(flight.noOfseats.ToString());

                listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
