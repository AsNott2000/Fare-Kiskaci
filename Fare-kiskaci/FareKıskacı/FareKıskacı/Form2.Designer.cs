namespace FareKıskacı
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sure_sayaci = new System.Windows.Forms.Label();
            this.skor_sayisi = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.fare = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.sure = new System.Windows.Forms.Label();
            this.skor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton1 = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sure_sayaci
            // 
            this.sure_sayaci.AutoSize = true;
            this.sure_sayaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.sure_sayaci.Location = new System.Drawing.Point(736, -134);
            this.sure_sayaci.Name = "sure_sayaci";
            this.sure_sayaci.Size = new System.Drawing.Size(36, 26);
            this.sure_sayaci.TabIndex = 13;
            this.sure_sayaci.Text = "60";
            // 
            // skor_sayisi
            // 
            this.skor_sayisi.AutoSize = true;
            this.skor_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.skor_sayisi.Location = new System.Drawing.Point(82, -134);
            this.skor_sayisi.Name = "skor_sayisi";
            this.skor_sayisi.Size = new System.Drawing.Size(24, 26);
            this.skor_sayisi.TabIndex = 12;
            this.skor_sayisi.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(680, -146);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, -146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // fare
            // 
            this.fare.BackColor = System.Drawing.Color.Transparent;
            this.fare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fare.Image = ((System.Drawing.Image)(resources.GetObject("fare.Image")));
            this.fare.Location = new System.Drawing.Point(346, 92);
            this.fare.Name = "fare";
            this.fare.Size = new System.Drawing.Size(99, 127);
            this.fare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fare.TabIndex = 9;
            this.fare.TabStop = false;
            this.fare.Click += new System.EventHandler(this.fare_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.sure.Location = new System.Drawing.Point(728, 24);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(24, 26);
            this.sure.TabIndex = 20;
            this.sure.Text = "0";
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.skor.Location = new System.Drawing.Point(74, 24);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(24, 26);
            this.skor.TabIndex = 19;
            this.skor.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar1.Location = new System.Drawing.Point(12, 702);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(134, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ses Düzeyi";
            // 
            // playButton1
            // 
            this.playButton1.BackColor = System.Drawing.Color.Transparent;
            this.playButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton1.Image = ((System.Drawing.Image)(resources.GetObject("playButton1.Image")));
            this.playButton1.Location = new System.Drawing.Point(298, 620);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(100, 100);
            this.playButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playButton1.TabIndex = 24;
            this.playButton1.TabStop = false;
            this.playButton1.Click += new System.EventHandler(this.playButton1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Location = new System.Drawing.Point(404, 620);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 100);
            this.CancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelButton.TabIndex = 25;
            this.CancelButton.TabStop = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sure_sayaci);
            this.Controls.Add(this.skor_sayisi);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.fare);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sure_sayaci;
        private System.Windows.Forms.Label skor_sayisi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox fare;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox playButton1;
        private System.Windows.Forms.PictureBox CancelButton;
    }
}