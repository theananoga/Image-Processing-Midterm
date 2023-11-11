using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Midterm_109316131_莊舒雯
{
    class Processing
    {
        public Processing()
        {
        }

        public static bool ConvertGray(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j); //get the i,j pixel color
                    int red = bmpColor.R; 
                    int green = bmpColor.G; 
                    int blue = bmpColor.B;
                    int gray = (red + green + blue) / 3; //get the gray
                    red = gray;
                    green = gray;
                    blue = gray;

                    bmp.SetPixel(i, j, Color.FromArgb(red, green, blue)); //set color i,j pixel to gray

                }
            }
            return true;
        }

        public static bool rChannel(Bitmap bmp)
        {

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = (int)(bmpColor.R); //get the red only
                    bmp.SetPixel(i, j, Color.FromArgb(red, red, red));
                }
            }

            return true;
        }

        public static bool gChannel(Bitmap bmp)
        {

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int green = (int)(bmpColor.G); //get the green only
                    bmp.SetPixel(i, j, Color.FromArgb(green, green, green));
                }
            }

            return true;
        }

        public static bool bChannel(Bitmap bmp)
        {

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int blue = (int)(bmpColor.B); //get the blue only
                    bmp.SetPixel(i, j, Color.FromArgb(blue, blue, blue));
                }
            }

            return true;
        }

        public static Bitmap Binarization(Bitmap bmp, int trackbar)
        {

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int gray = (int)((bmpColor.R + bmpColor.G + bmpColor.B) / 3); //change the pixel to gray first
                    if (gray > trackbar) 
                    {
                        gray = 255; //more big value more white
                    }
                    else 
                    {
                        gray = 0; //more small value more black
                    }

                    bmp.SetPixel(i, j, Color.FromArgb(gray, gray, gray));

                }
            }
            return bmp;
        }

        public static Bitmap erode(Bitmap bmp)
        {
            bmp = Binarization(bmp, 120); //binarization first with 120 value
            Bitmap copy = new Bitmap(bmp);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int black = 0;
                    int white = 255;
                    int stride = 10; //stride

                    //kalo putih tes atas bawah kiri kanan ada item ato ga
                    //check the white one (up,down,left,right of i,j) is black or not 
                    //kalo ada item di jadiin item
                    //if there is black change to black
                    if (bmpColor.R == white)
                    {
                        //check i,j left = i-1, j
                        for (int k = 1; k <= stride; k++)
                        {
                            if (i - k >= 0) //check left fangdai
                            {
                                Color left = bmp.GetPixel(i - k, j);
                                if (left.R == black)
                                {
                                    //klo item i,j dijadiin item
                                    //if i,j black, set black
                                    copy.SetPixel(i, j, Color.FromArgb(black, black, black));
                                    break;
                                }
                            }
                        }

                        //check i,j up = i,j-1
                        for (int k = 1; k <= stride; k++)
                        {
                            if (j - k >= 0) //check up fangdai
                            {
                                Color up = bmp.GetPixel(i, j - k);
                                if (up.R == black)
                                {
                                    //klo item i,j dijadiin item
                                    //if i,j black, set black
                                    copy.SetPixel(i, j, Color.FromArgb(black, black, black));
                                    break;
                                }
                            }

                        }

                        //check i,j right = i+1,j
                        for (int k = 1; k <= stride; k++)
                        {
                            if (i + k < bmp.Width) //check right fangdai
                            {
                                Color right = bmp.GetPixel(i + k, j); 
                                if (right.R == black)
                                {
                                    //klo item i,j dijadiin item
                                    //if i,j black, set black
                                    copy.SetPixel(i, j, Color.FromArgb(black, black, black));
                                    break;
                                }
                            }

                        }

                        //check i,j down =i,j+1
                        for (int k = 1; k <= stride; k++)
                        {
                            if (j + k < bmp.Height) //check down fangdai
                            {
                                Color down = bmp.GetPixel(i, j + k);
                                if (down.R == black)
                                {
                                    //klo item i,j dijadiin item
                                    //if i,j black set black
                                    copy.SetPixel(i, j, Color.FromArgb(black, black, black));
                                    break;
                                }
                            }
                        }
                    }

                }
            }
            return copy;
        }
        public static Bitmap dilate(Bitmap bmp)
        {
            bmp = Binarization(bmp, 120); 
            Bitmap copy = new Bitmap(bmp);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int black = 0;
                    int white = 255;
                    int stride = 10; //stirde

                    //kalo putih tes atas bawah kiri kanan ada item ato ga
                    //check the white one (up,down,left,right of i,j) is black or not 
                    //kalo ada item di jadiin putih
                    //if there is black change to white
                    if (bmpColor.R == white)
                    {

                        //check left = i-1, j
                        for (int k = 1; k <= stride; k++)
                        {
                            if (i - k >= 0)
                            {
                                Color left = bmp.GetPixel(i - k, j);
                                if (left.R == black)
                                {
                                    //klo item i,j dijadiin putih
                                    //if i,j black, set white
                                    copy.SetPixel(i - k, j, Color.FromArgb(white, white, white));

                                }
                            }
                        }

                        //check up = i,j-1
                        for (int k = 1; k <= stride; k++)
                        {
                            if (j - k >= 0)
                            {
                                Color up = bmp.GetPixel(i, j - k);
                                if (up.R == black)
                                {
                                    //klo item i,j dijadiin putih
                                    //if i,j black, set white
                                    copy.SetPixel(i, j - k, Color.FromArgb(white, white, white));

                                }
                            }

                        }

                        //check right = i+1,j
                        for (int k = 1; k <= stride; k++)
                        {
                            if (i + k < bmp.Width)
                            {
                                Color right = bmp.GetPixel(i + k, j);
                                if (right.R == black)
                                {
                                    //klo item i,j dijadiin putiih
                                    //if i,j black, set white
                                    copy.SetPixel(i + k, j, Color.FromArgb(white, white, white));

                                }
                            }

                        }

                        //check down =i,j+1
                        for (int k = 1; k <= stride; k++)
                        {
                            if (j + k < bmp.Height)
                            {
                                Color down = bmp.GetPixel(i, j + k);
                                if (down.R == black)
                                {
                                    //klo item i,j dijadiin putih
                                    //if i,j black, set white
                                    copy.SetPixel(i, j + k, Color.FromArgb(white, white, white));

                                }
                            }
                        }
                    }

                }
            }
            return copy;
        }

        public static Bitmap denoise(Bitmap bmp)
        {

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    Color left, right, up, down, upLeft, upRight, downLeft, downRight;
    

                    //check left i-1,j fangdai
                    if (i - 1 < 0) //if out of the bitmap, get the i,j
                    {
                        left = bmp.GetPixel(i, j);

                    }
                    else
                    {
                        left = bmp.GetPixel(i - 1, j);

                    }
                    //check leftup i-1,j-1
                    if (i - 1 < 0 || j - 1 < 0) //if out of the bitmap, get the i,j
                    {

                        upLeft = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        upLeft = bmp.GetPixel(i - 1, j - 1);
                    }


                    //check up i,j-1
                    if (j - 1 < 0) //if out of the bitmap, get the i,j
                    {
                        up = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        up = bmp.GetPixel(i, j - 1);
                    }


                    //check up right i+1,j-1
                    if (i + 1 >= bmp.Width || j - 1 < 0) //if out of the bitmap, get the i,j
                    {
                        upRight = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        upRight = bmp.GetPixel(i + 1, j - 1);
                    }

                    //check right i+1,j
                    if (i + 1 >= bmp.Width)//if out of the bitmap, get the i,j
                    {
                        right = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        right = bmp.GetPixel(i + 1, j);
                    }


                    //check right down i+1,j+1
                    if (i + 1 >= bmp.Width || j + 1 >= bmp.Height) //if out of the bitmap, get the i,j
                    {
                        downRight = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        downRight = bmp.GetPixel(i + 1, j + 1);
                    }


                    //check down i,j+1
                    if (j + 1 >= bmp.Height)//if out of the bitmap, get the i,j
                    {
                        down = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        down = bmp.GetPixel(i, j + 1);

                    }

                    //check down left i-1,j+1
                    if (i - 1 < 0 || j + 1 >= bmp.Height) //if out of the bitmap, get the i,j
                    {
                        downLeft = bmp.GetPixel(i, j);
                    }
                    else
                    {
                        downLeft = bmp.GetPixel(i - 1, j + 1);
                    }

                    //array 9
                    int[] num = { left.R, up.R, down.R, right.R, upLeft.R, upRight.R, downLeft.R, downRight.R, bmpColor.R };

                    //sorting
                    for (int k = 0; k < num.Length; k++)
                    {
                        for (int l = 0; l < num.Length; l++)
                        {
                            if (num[k] > num[l])
                            {
                                int temp = num[k];
                                num[k] = num[l];
                                num[l] = temp;
                            }
                        }

                    }

                    int median = num[num.Length / 2]; //search the median
                    bmp.SetPixel(i, j, Color.FromArgb(median, median, median));

                }
            }

            return bmp;
        }
        public static Bitmap sharpen(Bitmap bmp)
        {
            Bitmap copy = new Bitmap(bmp);

            int filterWidth = 3;
            int filterHeight = 3;

            double[,] filter = new double[filterWidth, filterHeight]; //make two dimension array (erweijuzhen)

            //high-pass filter
            filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
            filter[1, 1] = 9;

            //two dimension array color
            Color[,] result = new Color[bmp.Width, bmp.Height];


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    double red = 0.0;
                    double green = 0.0;
                    double blue = 0.0;

                    for (int filterX = 0; filterX < filterWidth; filterX++)
                    {
                        for (int filterY = 0; filterY < filterHeight; filterY++)
                        {
                            int imageX = (i - filterWidth / 2 + filterX + bmp.Width) % bmp.Width;
                            int imageY = (j - filterHeight / 2 + filterY + bmp.Height) % bmp.Height;

                            Color bmpColor = bmp.GetPixel(imageX, imageY);

                            red += bmpColor.R * filter[filterX, filterY]; //accumulate red with the filter
                            green += bmpColor.G * filter[filterX, filterY]; //accumulate green with the filter
                            blue += bmpColor.B * filter[filterX, filterY]; //accumulate blue with the filter
                        }


                        int r = Math.Min(Math.Max((int)(red), 0), 255);
                        int g = Math.Min(Math.Max((int)(green), 0), 255);
                        int b = Math.Min(Math.Max((int)(blue), 0), 255);

                        result[i, j] = Color.FromArgb(r, g, b);
                    }

                }


            }
            for (int i = 0; i < bmp.Width; ++i)
            {
                for (int j = 0; j < bmp.Height; ++j)
                {
                    copy.SetPixel(i, j, result[i, j]); //set the pixel
                }
            }

            return copy;
        }

        public static Bitmap edge(Bitmap bmp)
        {
            Bitmap copy = new Bitmap(bmp.Width,bmp.Height);
            int[,] kernel1 = new int[,] { //array two dimension
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };
            int[,] kernel2 = new int[,] { //array two dimension
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int filterWidth = 3;
            int filterHeight = 3;

            Color[,] result = new Color[bmp.Width, bmp.Height]; //array two dimension

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    result[i, j] = bmp.GetPixel(i, j); //get pixel
                }
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int r1 = 0;
                    int g1 = 0;
                    int b1 = 0;
                    int r2 = 0;
                    int g2 = 0;
                    int b2 = 0;

                    for (int filterX = 0; filterX < filterWidth; filterX++)
                    {
                        for (int filterY = 0; filterY < filterHeight; filterY++)
                        {
                            int x1 = i, y1 = j, x2 = i, y2 = j;
                            if (i == 0) //check if out of bitmap
                            {
                                x1 = 1;
                            }

                            if (j == 0) //check if out of bitmap
                            {
                                y1 = 1;
                            }

                            if (i == bmp.Width - 1) //check if out of bitmap
                            {
                                x1 = bmp.Width - 2;
                            }
                            if (j == bmp.Height - 1) //check if out of bitmap
                            {
                                y1 = bmp.Height - 2;
                            }

                            r1 += kernel1[filterX, filterY] * result[x1 + filterX - 1, y1 + filterY - 1].R;
                            g1 += kernel1[filterX, filterY] * result[x1 + filterX - 1, y1 + filterY - 1].G;
                            b1 += kernel1[filterX, filterY] * result[x1 + filterX - 1, y1 + filterY - 1].B;
                            r2 += kernel2[filterX, filterY] * result[x1 + filterX - 1, y1 + filterY - 1].R;
                            g2 += kernel2[filterX, filterY] * result[x1 + filterX - 1, y1 + filterY - 1].G;
                            b2 += kernel2[filterX, filterY] * result[x1 + filterX - 1, y1 + filterY - 1].B;
                        }
                    }
                    r1 = (int)Math.Sqrt((r1 * r1) + (r2 * r2));
                    g1 = (int)Math.Sqrt((g1 * g1) + (g2 * g2));
                    b1 = (int)Math.Sqrt((b1 * b1) + (b2 * b2));

                    if (r1 > 100 || g1 > 100 || b1 > 100)
                    {
                        copy.SetPixel(i, j, Color.Black); //clip out of domain
                    }
                    else
                    {
                        copy.SetPixel(i, j, Color.Transparent); //clip out of domain
                    }
                }
            }

            return copy;
        }


        public static Bitmap histogram(Bitmap bmp)
        {
            Bitmap copy = new Bitmap(bmp.Width, bmp.Height);

            Color[,] source = new Color[bmp.Width, bmp.Height];
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    source[i, j] = bmp.GetPixel(i, j); //get pixel
                }
            }

            //count probability of source picture
            double[,] oriProb = new double[3, 256];

            for (int i = 0; i < bmp.Width; i++) //calculate pr (rk) table 3.1 pg. 126
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    int r = source[i,j].R;
                    int g =source[i, j].G;
                    int b = source[i, j].B;
                    oriProb[0, r]++;
                    oriProb[1, g]++;
                    oriProb[2, b]++;
                }
            }

            int MN = bmp.Width * bmp.Height;

            for (int i = 0; i < 256; i++)
            {
                oriProb[0, i] /= (double)MN;
                oriProb[1, i] /= (double)MN;
                oriProb[2, i] /= (double)MN;
            }
            //end 

            //transformation pg.127 figure 3.19b
            double[,] staircaseProb = new double[3, 256];

            for (int i = 0; i < 256; i++)   //pg.126 formula (eq 3.3-8)
            {
                for (int j = 0; j <= i; j++)
                {
                    staircaseProb[0, i] += oriProb[0, j];
                    staircaseProb[1, i] += oriProb[1, j];
                    staircaseProb[2, i] += oriProb[2, j];

                }
                staircaseProb[0, i] *= 255;
                staircaseProb[1, i] *= 255;
                staircaseProb[2, i] *= 255;
            }

            for (int i = 0; i < 256; i++)   //rounding to nearest integer (pg.127)
            {
                staircaseProb[0, i] = Math.Round(staircaseProb[0, i]);
                staircaseProb[1, i] = Math.Round(staircaseProb[1, i]);
                staircaseProb[2, i] = Math.Round(staircaseProb[2, i]);
            }
            //end


            for (int i = 0; i < bmp.Width; i++) 
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int r, g, b;
                    Color pixelColor = source[i, j];
                    r = (int)staircaseProb[0, pixelColor.R];
                    g = (int)staircaseProb[1, pixelColor.G];
                    b = (int)staircaseProb[2, pixelColor.B];
                    copy.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return copy;
        }

        public static Bitmap rotation(Bitmap bmp, int trackbar)
        {
            int tbValue = trackbar;
            Bitmap copy = new Bitmap(bmp.Width, bmp.Height);

            Graphics gfx = Graphics.FromImage(copy);
            gfx.TranslateTransform(bmp.Width / 2, bmp.Height / 2); //the (0,0) move to center
            gfx.RotateTransform(tbValue);
            gfx.TranslateTransform(-bmp.Height / 2, -bmp.Height / 2); //the pictures in the center
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(bmp, 0, 0, bmp.Height, bmp.Height);

            return copy;
        }

    }
}