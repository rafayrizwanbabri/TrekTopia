using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//fullname field
        {

        }

        private void button2_Click(object sender, EventArgs e) //sign up button
        {
            try
            {
                string fullname = textBox1.Text.Trim();
                string email = textBox2.Text.Trim();
                string username = textBox3.Text.Trim();
                string password = textBox4.Text.Trim();
                
                if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("All fields are required. Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (password.Length < 5)
                {
                    MessageBox.Show("Password length must be at least 5 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Email ID is not in correct format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                Database database = new Database();
                bool done = database.AddUser(fullname, email, username, password);
                if (done == true)
                {
                    MessageBox.Show("Registration successful! Welcome to TrekTopia.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//email field
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//username field
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//password
        {

        }
    }
}
