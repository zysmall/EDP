namespace Event_MS
{
    partial class Venues
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
            label5 = new Label();
            label4 = new Label();
            EditBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            VCapacityTb = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            VNameTb = new TextBox();
            VAddressTb = new TextBox();
            VPhoneTb = new TextBox();
            VManagerTb = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(570, 325);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 84;
            label5.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(778, 393);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 83;
            label4.Text = "Phone";
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.LightGreen;
            EditBtn.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(478, 448);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(103, 36);
            EditBtn.TabIndex = 82;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.LightGreen;
            DeleteBtn.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(624, 448);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(102, 36);
            DeleteBtn.TabIndex = 81;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.LightGreen;
            SaveBtn.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(311, 448);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(102, 36);
            SaveBtn.TabIndex = 80;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // VCapacityTb
            // 
            VCapacityTb.BackColor = Color.LightGreen;
            VCapacityTb.Location = new Point(395, 356);
            VCapacityTb.Name = "VCapacityTb";
            VCapacityTb.Size = new Size(118, 23);
            VCapacityTb.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 325);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 76;
            label2.Text = "Venue Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Location = new Point(12, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(1066, 10);
            panel3.TabIndex = 74;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 523);
            panel2.Name = "panel2";
            panel2.Size = new Size(1078, 11);
            panel2.TabIndex = 73;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1042, 190);
            dataGridView1.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 77);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 2;
            label1.Text = "Manage venues";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(466, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(395, 325);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 77;
            label3.Text = "Capacity";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 106);
            panel1.TabIndex = 72;
            // 
            // VNameTb
            // 
            VNameTb.BackColor = Color.LightGreen;
            VNameTb.Location = new Point(219, 356);
            VNameTb.Name = "VNameTb";
            VNameTb.Size = new Size(118, 23);
            VNameTb.TabIndex = 89;
            // 
            // VAddressTb
            // 
            VAddressTb.BackColor = Color.LightGreen;
            VAddressTb.Location = new Point(570, 344);
            VAddressTb.Multiline = true;
            VAddressTb.Name = "VAddressTb";
            VAddressTb.Size = new Size(144, 89);
            VAddressTb.TabIndex = 90;
            // 
            // VPhoneTb
            // 
            VPhoneTb.BackColor = Color.LightGreen;
            VPhoneTb.Location = new Point(778, 423);
            VPhoneTb.Name = "VPhoneTb";
            VPhoneTb.Size = new Size(118, 23);
            VPhoneTb.TabIndex = 91;
            // 
            // VManagerTb
            // 
            VManagerTb.BackColor = Color.LightGreen;
            VManagerTb.Location = new Point(778, 356);
            VManagerTb.Name = "VManagerTb";
            VManagerTb.Size = new Size(118, 23);
            VManagerTb.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(778, 325);
            label7.Name = "label7";
            label7.Size = new Size(112, 16);
            label7.TabIndex = 93;
            label7.Text = "Venue Manager";
            // 
            // Venues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 534);
            Controls.Add(label7);
            Controls.Add(VManagerTb);
            Controls.Add(VPhoneTb);
            Controls.Add(VAddressTb);
            Controls.Add(VNameTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EditBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(VCapacityTb);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Venues";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venues";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private TextBox VCapacityTb;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private TextBox VNameTb;
        private TextBox VAddressTb;
        private TextBox VPhoneTb;
        private TextBox VManagerTb;
        private Label label7;
    }
}