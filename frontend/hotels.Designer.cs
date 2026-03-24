namespace WinFormsApp1
{
    partial class hotels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotels));
            pictureBox5 = new PictureBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            comboBox5 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(908, 626);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(420, 337);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(695, 152);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(379, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1127, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Subheading", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(931, 253);
            button1.Name = "button1";
            button1.Size = new Size(190, 60);
            button1.TabIndex = 5;
            button1.Text = "Search Hotels";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(1023, 152);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(161, 33);
            comboBox5.TabIndex = 16;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PAR", "SYD", "NYC", "LON" });
            comboBox1.Location = new Point(89, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 33);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(1595, 55);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(120, 120);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1469, 55);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(120, 120);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1343, 55);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(120, 120);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1023, 104);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 11;
            label5.Text = "Rooms";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(379, 104);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 8;
            label4.Text = "Check In";
            label4.Click += label4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(47, 30);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(186, 156);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(272, 45);
            label6.Name = "label6";
            label6.Size = new Size(415, 130);
            label6.TabIndex = 23;
            label6.Text = "HOTELS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(695, 104);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 6;
            label2.Text = "Check Out";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 104);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 5;
            label1.Text = "City";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1721, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(47, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1281, 343);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.Location = new Point(1343, 202);
            listView1.Name = "listView1";
            listView1.Size = new Size(498, 761);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(473, 626);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(429, 337);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(47, 626);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(420, 337);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 6000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 6000;
            timer3.Tick += timer3_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(157, 559);
            label3.Name = "label3";
            label3.Size = new Size(183, 47);
            label3.TabIndex = 27;
            label3.Text = "Beachfront";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1026, 559);
            label7.Name = "label7";
            label7.Size = new Size(202, 47);
            label7.TabIndex = 28;
            label7.Text = "Countryside";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(613, 559);
            label8.Name = "label8";
            label8.Size = new Size(139, 47);
            label8.TabIndex = 29;
            label8.Text = "Tropical";
            // 
            // hotels
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(listView1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox1);
            Name = "hotels";
            Text = "hotels";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox comboBox5;
        private ComboBox comboBox1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label label3;
        private Label label7;
        private Label label8;
    }
}