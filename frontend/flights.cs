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
            this.WindowState = FormWindowState.Normal;
            
            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string[] imagePaths = new string[]
                {
                    Path.Combine(currentDirectory, "Resources", "4.jpg"),
                    Path.Combine(currentDirectory, "Resources", "5.jpg"),
                    Path.Combine(currentDirectory, "Resources", "6.jpg")
                };

                for (int i = 0; i < imagePaths.Length; i++)
                {
                    if (File.Exists(imagePaths[i]))
                    {
                        images[i] = Image.FromFile(imagePaths[i]);
                    }
                    else
                    {
                        images[i] = CreatePlaceholderImage();
                    }
                }

                // Draw text on each image
                DrawTextOnImage(images[0], texts[0], new Font("Arial", 50), Brushes.White, new Point(textOffsetX, 50));
                DrawTextOnImage(images[1], texts[1], new Font("Arial", 25), Brushes.White, new Point(textOffsetX, 50));
                DrawTextOnImage(images[2], texts[2], new Font("Arial", 25), Brushes.White, new Point(textOffsetX, 50));
                
                // Display images
                pictureBox2.Image = images[0];
                pictureBox4.Image = images[1];
                pictureBox5.Image = images[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading flight images: {ex.Message}. Using placeholder images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                for (int i = 0; i < 3; i++)
                {
                    images[i] = CreatePlaceholderImage();
                }
            }
        }

        private Image CreatePlaceholderImage()
        {
            Bitmap placeholder = new Bitmap(800, 600);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.SteelBlue);
                g.DrawString("Flight Image Not Found", new Font("Arial", 20, FontStyle.Bold), Brushes.White, 200, 250);
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
            try
            {
                listView1.Clear();
                
                string origin = comboBox1.Text?.Trim() ?? "";
                string destination = comboBox2.Text?.Trim() ?? "";
                
                if (string.IsNullOrEmpty(origin) || origin.Length < 3)
                {
                    MessageBox.Show("Please select a valid origin airport (minimum 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (string.IsNullOrEmpty(destination) || destination.Length < 3)
                {
                    MessageBox.Show("Please select a valid destination airport (minimum 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var amadeusApi = new AmadeusAPI("wXRiLkGjtodE3Df9WCnlKcirDK3xHNwA", "yRONb3XKF1UxBAeA");
                var flights = await amadeusApi.GetFlightsx(origin, destination);
                
                if (flights == null || flights.Count == 0)
                {
                    MessageBox.Show("No flights found for the selected route. Please try different airports.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                listView1.View = View.Details;
                listView1.Columns.Add("Date", 100);
                listView1.Columns.Add("From", 100);
                listView1.Columns.Add("To", 100);
                listView1.Columns.Add("Segments", 70);
                listView1.Columns.Add("Price", 80);
                listView1.Columns.Add("#Seats", 90);

                foreach (var flight in flights)
                {
                    if (flight != null)
                    {
                        ListViewItem item = new ListViewItem(flight.date.ToShortDateString());
                        item.SubItems.Add(flight.origin ?? "N/A");
                        item.SubItems.Add(flight.destination ?? "N/A");
                        item.SubItems.Add(flight.segments.ToString());
                        item.SubItems.Add(flight.price.ToString("C"));
                        item.SubItems.Add(flight.noOfseats.ToString());

                        listView1.Items.Add(item);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error occurred: {ex.Message}. Please check your internet connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
