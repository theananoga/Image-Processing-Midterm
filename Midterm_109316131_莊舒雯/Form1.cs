using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_109316131_莊舒雯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            trackBar1.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            trackBar1.Visible = false;
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //open image
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png"; //file
            if (DialogResult.OK == openFile.ShowDialog())
            {
                Original.Image = new Bitmap(openFile.FileName);
                gray.Visible = true;
                rChannel.Visible = true;
                gChannel.Visible = true;
                bChannel.Visible = true;
                binarization.Visible = true;
                erode.Visible = true;
                dilate.Visible = true;
                denoise.Visible = true;
                sharpen.Visible = true;
                edge.Visible = true;
                histogram.Visible = true;
                rotation.Visible = true;

            }

        }

        private void reset()
        {
            label1.Visible = false;
            label2.Visible = false;
            trackBar1.Visible = false;
            trackBar2.Visible = false;
        }

        private void gray_Click(object sender, EventArgs e) //convert gray
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Processing.ConvertGray(img);
            Result.Image = img;

        }

        private void rChannel_Click(object sender, EventArgs e) //red channel
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Processing.rChannel(img);
            Result.Image = img;
        }

        private void gChannel_Click(object sender, EventArgs e) //green channel
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Processing.gChannel(img);
            Result.Image = img;
        }

        private void bChannel_Click(object sender, EventArgs e) //blue channel
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Processing.bChannel(img);
            Result.Image = img;

        }
        private void trackBar1_Scroll(object sender, EventArgs e) //trackbar binarization
        {
            label1.Text = trackBar1.Value.ToString();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Processing.Binarization(img, trackBar1.Value);
            Result.Image = img;
        }
        private void binarization_Click(object sender, EventArgs e) //binarization
        {
            reset();
            label1.Visible = true;
            trackBar1.Visible = true;
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Processing.Binarization(img, trackBar1.Value);
            Result.Image = img;

        }

        private void erode_Click(object sender, EventArgs e) //erode
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.erode(img);
            Result.Image = copy;
        }

        private void dilate_Click(object sender, EventArgs e) //dilation
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.dilate(img);
            Result.Image = copy;
        }

        private void denoise_Click(object sender, EventArgs e) //denoise
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.denoise(img);
            Result.Image = copy;
        }

        private void sharpen_Click(object sender, EventArgs e) //sharpen
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.sharpen(img);
            Result.Image = copy;
        }
        private void edge_Click(object sender, EventArgs e) //edge sobel
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.edge(img);
            Result.Image = copy;
        }

        private void histogram_Click(object sender, EventArgs e) //histogram
        {
            reset();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.histogram(img);
            Result.Image = copy;
        }
        private void trackBar2_Scroll(object sender, EventArgs e) //trackbar rotate
        {
            label2.Text = trackBar2.Value.ToString();
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.rotation(img, trackBar2.Value);
            Result.Image = copy;

        }
        private void rotation_Click(object sender, EventArgs e) //rotate
        {
            reset();
            label2.Visible = true;
            trackBar2.Visible = true;
            Bitmap img = new Bitmap((Bitmap)this.Original.Image);
            Bitmap copy = Processing.rotation(img, trackBar2.Value);
            Result.Image = copy;

        }

    }
}
