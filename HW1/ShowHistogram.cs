using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class ShowHistogram : Form
    {
        public int[] times = new int[101];

        public ShowHistogram(String formName, int[] RV)
        {
            InitializeComponent();
            this.Text = formName;
            Bitmap histomap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for(int i = 0; i < 10000; i++)
            {
              //  if (RV[i] >= 0 && RV[i] < 100)
                    times[RV[i]]++;
            }

            int maxbound = 0;

            for(int i = 0; i <= 100; i++)
            {
                if (times[i] > maxbound)
                    maxbound = times[i];
            }

            Ymax.Text = Convert.ToString(maxbound);
            Ysec.Text = Convert.ToString((int)(maxbound * 0.75));
            Ythird.Text = Convert.ToString((int)(maxbound * 0.5));
            Yforth.Text = Convert.ToString((int)(maxbound * 0.25));

            for (int w = 0; w < pictureBox1.Width; w++)
            {
                int ToTimes = w / 3;
                int threshold = (maxbound - times[ToTimes]) * 200 / maxbound;
                for(int h = 0; h < pictureBox1.Height; h++)
                {
                    if (h > threshold)
                        histomap.SetPixel(w, h, Color.FromArgb(0, 0, 0));
                }
            }

            pictureBox1.Image = histomap;
            
        }
    }
}
