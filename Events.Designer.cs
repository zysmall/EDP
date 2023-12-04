namespace Event_MS
{
    partial class Events
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 106);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(488, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 84);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 2;
            label1.Text = "Manage Events";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(1054, 11);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Location = new Point(-45, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(1099, 10);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1030, 190);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGreen;
            textBox1.Location = new Point(102, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 329);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 5;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 378);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 6;
            label3.Text = "Customer ID";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGreen;
            textBox2.Location = new Point(102, 370);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.LightGreen;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(310, 329);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 329);
            label4.Name = "label4";
            label4.Size = new Size(83, 16);
            label4.TabIndex = 9;
            label4.Text = "Event Date";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PaleGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(583, 329);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(477, 332);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 11;
            label5.Text = "Venue ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(776, 325);
            label6.Name = "label6";
            label6.Size = new Size(87, 16);
            label6.TabIndex = 12;
            label6.Text = "Venue name\r\n";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGreen;
            textBox3.Location = new Point(907, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(789, 374);
            label7.Name = "label7";
            label7.Size = new Size(74, 16);
            label7.TabIndex = 14;
            label7.Text = "dURATION ";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGreen;
            textBox4.Location = new Point(907, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(488, 374);
            label8.Name = "label8";
            label8.Size = new Size(54, 16);
            label8.TabIndex = 16;
            label8.Text = "sTAtus";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightGreen;
            textBox5.Location = new Point(338, 367);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(221, 377);
            label9.Name = "label9";
            label9.Size = new Size(112, 16);
            label9.TabIndex = 18;
            label9.Text = "Customer name";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.PaleGreen;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(583, 371);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(124, 23);
            comboBox2.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(275, 435);
            button1.Name = "button1";
            button1.Size = new Size(84, 36);
            button1.TabIndex = 20;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(644, 435);
            button2.Name = "button2";
            button2.Size = new Size(84, 36);
            button2.TabIndex = 21;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(467, 435);
            button3.Name = "button3";
            button3.Size = new Size(85, 36);
            button3.TabIndex = 22;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1054, 506);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Events";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Events";
            Load += Events_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}