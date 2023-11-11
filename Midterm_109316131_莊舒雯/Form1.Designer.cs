
namespace Midterm_109316131_莊舒雯
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Original = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.rChannel = new System.Windows.Forms.Button();
            this.gChannel = new System.Windows.Forms.Button();
            this.bChannel = new System.Windows.Forms.Button();
            this.binarization = new System.Windows.Forms.Button();
            this.erode = new System.Windows.Forms.Button();
            this.dilate = new System.Windows.Forms.Button();
            this.denoise = new System.Windows.Forms.Button();
            this.sharpen = new System.Windows.Forms.Button();
            this.edge = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.rotation = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.Location = new System.Drawing.Point(57, 29);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(500, 500);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 0;
            this.Original.TabStop = false;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(690, 29);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(500, 500);
            this.Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Result.TabIndex = 1;
            this.Result.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gray
            // 
            this.gray.Location = new System.Drawing.Point(715, 618);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(112, 34);
            this.gray.TabIndex = 3;
            this.gray.Text = "Gray";
            this.gray.UseVisualStyleBackColor = true;
            this.gray.Visible = false;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // rChannel
            // 
            this.rChannel.Location = new System.Drawing.Point(833, 618);
            this.rChannel.Name = "rChannel";
            this.rChannel.Size = new System.Drawing.Size(112, 34);
            this.rChannel.TabIndex = 4;
            this.rChannel.Text = "R_Channel";
            this.rChannel.UseVisualStyleBackColor = true;
            this.rChannel.Visible = false;
            this.rChannel.Click += new System.EventHandler(this.rChannel_Click);
            // 
            // gChannel
            // 
            this.gChannel.Location = new System.Drawing.Point(951, 618);
            this.gChannel.Name = "gChannel";
            this.gChannel.Size = new System.Drawing.Size(112, 34);
            this.gChannel.TabIndex = 5;
            this.gChannel.Text = "G_Channel";
            this.gChannel.UseVisualStyleBackColor = true;
            this.gChannel.Visible = false;
            this.gChannel.Click += new System.EventHandler(this.gChannel_Click);
            // 
            // bChannel
            // 
            this.bChannel.Location = new System.Drawing.Point(1069, 618);
            this.bChannel.Name = "bChannel";
            this.bChannel.Size = new System.Drawing.Size(112, 34);
            this.bChannel.TabIndex = 6;
            this.bChannel.Text = "B_Channel";
            this.bChannel.UseVisualStyleBackColor = true;
            this.bChannel.Visible = false;
            this.bChannel.Click += new System.EventHandler(this.bChannel_Click);
            // 
            // binarization
            // 
            this.binarization.Location = new System.Drawing.Point(715, 658);
            this.binarization.Name = "binarization";
            this.binarization.Size = new System.Drawing.Size(112, 66);
            this.binarization.TabIndex = 7;
            this.binarization.Text = "Binarization 二值化";
            this.binarization.UseVisualStyleBackColor = true;
            this.binarization.Visible = false;
            this.binarization.Click += new System.EventHandler(this.binarization_Click);
            // 
            // erode
            // 
            this.erode.AccessibleDescription = "erode";
            this.erode.Location = new System.Drawing.Point(833, 658);
            this.erode.Name = "erode";
            this.erode.Size = new System.Drawing.Size(112, 66);
            this.erode.TabIndex = 8;
            this.erode.Text = "Erode 侵蝕";
            this.erode.UseVisualStyleBackColor = true;
            this.erode.Visible = false;
            this.erode.Click += new System.EventHandler(this.erode_Click);
            // 
            // dilate
            // 
            this.dilate.AccessibleDescription = "erode";
            this.dilate.Location = new System.Drawing.Point(951, 658);
            this.dilate.Name = "dilate";
            this.dilate.Size = new System.Drawing.Size(112, 66);
            this.dilate.TabIndex = 9;
            this.dilate.Text = "Dilate 擴張";
            this.dilate.UseVisualStyleBackColor = true;
            this.dilate.Visible = false;
            this.dilate.Click += new System.EventHandler(this.dilate_Click);
            // 
            // denoise
            // 
            this.denoise.AccessibleDescription = "erode";
            this.denoise.Location = new System.Drawing.Point(1069, 658);
            this.denoise.Name = "denoise";
            this.denoise.Size = new System.Drawing.Size(112, 66);
            this.denoise.TabIndex = 10;
            this.denoise.Text = "Denoise 去雜訊";
            this.denoise.UseVisualStyleBackColor = true;
            this.denoise.Visible = false;
            this.denoise.Click += new System.EventHandler(this.denoise_Click);
            // 
            // sharpen
            // 
            this.sharpen.Location = new System.Drawing.Point(715, 730);
            this.sharpen.Name = "sharpen";
            this.sharpen.Size = new System.Drawing.Size(112, 66);
            this.sharpen.TabIndex = 11;
            this.sharpen.Text = "Sharpen 銳化 ";
            this.sharpen.UseVisualStyleBackColor = true;
            this.sharpen.Visible = false;
            this.sharpen.Click += new System.EventHandler(this.sharpen_Click);
            // 
            // edge
            // 
            this.edge.Location = new System.Drawing.Point(833, 730);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(112, 66);
            this.edge.TabIndex = 12;
            this.edge.Text = "edge (Sobel)";
            this.edge.UseVisualStyleBackColor = true;
            this.edge.Visible = false;
            this.edge.Click += new System.EventHandler(this.edge_Click);
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(951, 730);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(112, 66);
            this.histogram.TabIndex = 13;
            this.histogram.Text = "Histogram直方圖等化";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Visible = false;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // rotation
            // 
            this.rotation.Location = new System.Drawing.Point(1069, 730);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(112, 66);
            this.rotation.TabIndex = 14;
            this.rotation.Text = "Rotation 旋轉";
            this.rotation.UseVisualStyleBackColor = true;
            this.rotation.Visible = false;
            this.rotation.Click += new System.EventHandler(this.rotation_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(715, 543);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(466, 69);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Value = 90;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(724, 543);
            this.trackBar2.Maximum = 360;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(466, 69);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 854);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.rotation);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.edge);
            this.Controls.Add(this.sharpen);
            this.Controls.Add(this.denoise);
            this.Controls.Add(this.dilate);
            this.Controls.Add(this.erode);
            this.Controls.Add(this.binarization);
            this.Controls.Add(this.bChannel);
            this.Controls.Add(this.gChannel);
            this.Controls.Add(this.rChannel);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Original);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.PictureBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Button rChannel;
        private System.Windows.Forms.Button gChannel;
        private System.Windows.Forms.Button bChannel;
        private System.Windows.Forms.Button binarization;
        private System.Windows.Forms.Button erode;
        private System.Windows.Forms.Button dilate;
        private System.Windows.Forms.Button denoise;
        private System.Windows.Forms.Button sharpen;
        private System.Windows.Forms.Button edge;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button rotation;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
    }
}

