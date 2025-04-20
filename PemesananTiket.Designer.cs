namespace trainticket
{
    partial class PemesananTiket
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(35, 205);
            button4.Name = "button4";
            button4.Size = new Size(180, 40);
            button4.TabIndex = 5;
            button4.Text = "Daftar Tiket";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(34, 141);
            button3.Name = "button3";
            button3.Size = new Size(180, 40);
            button3.TabIndex = 4;
            button3.Text = "Data Perjalanan";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(34, 85);
            button2.Name = "button2";
            button2.Size = new Size(180, 40);
            button2.TabIndex = 3;
            button2.Text = "Pemesanan Tiket";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 22);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 2;
            label2.Text = "Welcome";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 388);
            button1.Name = "button1";
            button1.Size = new Size(134, 36);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightPink;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 18);
            label1.Name = "label1";
            label1.Size = new Size(194, 31);
            label1.TabIndex = 0;
            label1.Text = "Pemesanan Tiket";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 85);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Penumpang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 122);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Keberangkatan\r\n";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 161);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Stasiun Tujuan\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 194);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Stasiun Awal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 235);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 6;
            label7.Text = "Kelas";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 270);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 7;
            label8.Text = "Jumlah Penumpang";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(455, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(455, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(455, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(455, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(455, 232);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(455, 270);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(164, 27);
            textBox6.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(525, 320);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Train;
            pictureBox1.Location = new Point(648, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // PemesananTiket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PemesananTiket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PemesananTiket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button5;
        private PictureBox pictureBox1;
    }
}