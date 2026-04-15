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
    public partial class activities : Form
    {
        public activities()
        {
            InitializeComponent();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Visible == true)
            {
                pictureBox13.Visible = true;
                pictureBox17.Visible = false;
            }
            else if (pictureBox13.Visible == true)
            {
                pictureBox17.Visible = true;
                pictureBox13.Visible = false;
            }
            if (pictureBox5.Visible == true)
            {
                pictureBox10.Visible = true;
                pictureBox5.Visible = false;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox5.Visible = true;
                pictureBox10.Visible = false;
            }
            if (pictureBox4.Visible == true)
            {
                pictureBox11.Visible = true;
                pictureBox4.Visible = false;
            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox11.Visible = false;
            }
            if (pictureBox2.Visible == true)
            {
                pictureBox12.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox12.Visible = false;
            }
            if (textBox1.Visible == true)
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
            }
            else if (textBox2.Visible == true)
            {
                textBox2.Visible = false;
                textBox1.Visible = true;
            }
            if (textBox4.Visible == true)
            {
                textBox4.Visible = false;
                textBox5.Visible = true;
            }
            else if (textBox5.Visible == true)
            {
                textBox5.Visible = false;
                textBox4.Visible = true;
            }
            if (textBox6.Visible == true)
            {
                textBox6.Visible = false;
                textBox7.Visible = true;
            }
            else if (textBox7.Visible == true)
            {
                textBox7.Visible = false;
                textBox6.Visible = true;
            }
            if (textBox8.Visible == true)
            {
                textBox8.Visible = false;
                textBox9.Visible = true;
            }
            else if (textBox9.Visible == true)
            {
                textBox9.Visible = false;
                textBox8.Visible = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
