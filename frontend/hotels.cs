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
            this.WindowState = FormWindowState.Normal;
            
            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                System.Diagnostics.Debug.WriteLine($"Current Directory: {currentDirectory}");
                
                // Load first set of images
                string[] imagePaths1 = new string[]
                {
                    Path.Combine(currentDirectory, "Resources", "a.jpg"),
                    Path.Combine(currentDirectory, "Resources", "b.jpg"),
                    Path.Combine(currentDirectory, "Resources", "c.jpg")
                };
                
                // Load second set of images
                string[] imagePaths2 = new string[]
                {
                    Path.Combine(currentDirectory, "Resources", "a1.jpg"),
                    Path.Combine(currentDirectory, "Resources", "b1.jpg"),
                    Path.Combine(currentDirectory, "Resources", "c1.jpg")
                };
                
                // Load third set of images
                string[] imagePaths3 = new string[]
                {
                    Path.Combine(currentDirectory, "Resources", "a2.jpg"),
                    Path.Combine(currentDirectory, "Resources", "b2.jpg"),
                    Path.Combine(currentDirectory, "Resources", "c2.jpg")
                };
                
                // Load images with fallback to placeholder
                foreach (var path in imagePaths1)
                {
                    System.Diagnostics.Debug.WriteLine($"Checking image path: {path}");
                    if (File.Exists(path))
                    {
                        System.Diagnostics.Debug.WriteLine($"Image found: {path}");
                        images.Add(System.Drawing.Image.FromFile(path));
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Image NOT found: {path}");
                        images.Add(CreatePlaceholderImage());
                    }
                }
                
                foreach (var path in imagePaths2)
                {
                    System.Diagnostics.Debug.WriteLine($"Checking image path: {path}");
                    if (File.Exists(path))
                    {
                        System.Diagnostics.Debug.WriteLine($"Image found: {path}");
                        images1.Add(System.Drawing.Image.FromFile(path));
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Image NOT found: {path}");
                        images1.Add(CreatePlaceholderImage());
                    }
                }
                
                foreach (var path in imagePaths3)
                {
                    System.Diagnostics.Debug.WriteLine($"Checking image path: {path}");
                    if (File.Exists(path))
                    {
                        System.Diagnostics.Debug.WriteLine($"Image found: {path}");
                        images2.Add(System.Drawing.Image.FromFile(path));
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Image NOT found: {path}");
                        images2.Add(CreatePlaceholderImage());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception loading images: {ex.Message}");
                MessageBox.Show($"Error loading hotel images: {ex.Message}. Using placeholder images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Add placeholder images if loading fails
                for (int i = 0; i < 3; i++)
                {
                    images.Add(CreatePlaceholderImage());
                    images1.Add(CreatePlaceholderImage());
                    images2.Add(CreatePlaceholderImage());
                }
            }
        }
        
        private System.Drawing.Image CreatePlaceholderImage()
        {
            Bitmap placeholder = new Bitmap(800, 600);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.LightSlateGray);
                g.DrawString("Hotel Image Not Found", new Font("Arial", 20, FontStyle.Bold), Brushes.White, 200, 250);
            }
            return placeholder;
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
            try
            {
                listView1.Clear();
                
                string cityCode = comboBox1.Text?.Trim() ?? "";
                
                if (string.IsNullOrEmpty(cityCode) || cityCode.Length < 3)
                {
                    MessageBox.Show("Please enter a valid city code (minimum 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var amadeusApi = new AmadeusAPI("wXRiLkGjtodE3Df9WCnlKcirDK3xHNwA", "yRONb3XKF1UxBAeA");
                var hotels = await amadeusApi.GetHotels(cityCode);
                
                if (hotels == null || hotels.Count == 0)
                {
                    MessageBox.Show("No hotels found for the specified city. Please try a different city code.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                listView1.View = View.Details;
                listView1.Columns.Add("Hotels", 400);

                foreach (var hotel in hotels)
                {
                    if (!string.IsNullOrEmpty(hotel))
                    {
                        ListViewItem item = new ListViewItem(hotel);
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
                MessageBox.Show($"An error occurred while fetching hotels: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
