namespace WinFormsApp1
{
    partial class flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flights));
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(47, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1277, 344);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(910, 174);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(594, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1153, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Subheading", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(957, 233);
            button1.Name = "button1";
            button1.Size = new Size(190, 60);
            button1.TabIndex = 5;
            button1.Text = "Search Flights";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "PAR", "LON", "NYC", "SYD", "BKK" });
            comboBox2.Location = new Point(302, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 33);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PAR", "LON", "NYC", "SYD", "BKK" });
            comboBox1.Location = new Point(79, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 33);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(584, 126);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 8;
            label4.Text = "Departure";
            label4.Click += label4_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(289, 71);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(114, 30);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Multi City";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(192, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 30);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Return";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(79, 69);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 30);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "One Way";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 126);
            label3.Name = "label3";
            label3.Size = new Size(39, 32);
            label3.TabIndex = 7;
            label3.Text = "To";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(910, 126);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 6;
            label2.Text = "Return";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 126);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 5;
            label1.Text = "From";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 554);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 414);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(904, 554);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(420, 414);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(478, 554);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(420, 414);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(47, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(186, 156);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(1595, 28);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(120, 120);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 12;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1469, 28);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(120, 120);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1343, 28);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(120, 120);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1721, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(272, 18);
            label6.Name = "label6";
            label6.Size = new Size(436, 130);
            label6.TabIndex = 13;
            label6.Text = "FLIGHTS";
            // 
            // listView1
            // 
            listView1.Location = new Point(1343, 177);
            listView1.Name = "listView1";
            listView1.Size = new Size(498, 791);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // flights
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Name = "flights";
            Text = "flights";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox3;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ListView listView1;
    }
}