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
    public partial class Form1 : Form
    {
        double CoinA_Probability;
        double CoinB_Probability;
        public int[] RV_X = new int[10000];
        public int[] RV_Y = new int[10000];
        public int[] RV_Z = new int[10000];
        public int[] RV_D = new int[10000];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

        //限制textbox只能輸入數字
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {    
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        //限制textbox不能輸入
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                CoinA_Probability = 0;
            else
                CoinA_Probability = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text == "")
                CoinB_Probability = 0;
            else
                CoinB_Probability = Convert.ToDouble(textBox2.Text);


            if(CoinA_Probability < 0 || CoinB_Probability < 0 || CoinA_Probability > 1 || CoinB_Probability > 1)
            {
                textBox3.AppendText("[error] 0 ≤ Probability ≤ 1 \r\n");
                return;
            }

            Random flip = new Random(Guid.NewGuid().GetHashCode());
            double result;

            //Flip Coin A 1,000,000 times and save head appear times
            for(int i = 1, j = 0; i <= 1000000; i++)
            {
                result = flip.NextDouble();
                if (result <= CoinA_Probability)
                    RV_X[j]++;
                if (i % 100 == 0)
                    j++;
            }

            //Flip Coin B 1,000,000 times and save head appear times
            for (int i = 1, j = 0; i <= 1000000; i++)
            {
                result = flip.NextDouble();
                if (result <= CoinB_Probability)
                    RV_Y[j]++;
                if (i % 100 == 0)
                    j++;
            }

            //Draw the histogram for RV_X and RV_Y
            ShowHistogram CoinAHisto = new ShowHistogram("Coin A Histogram", RV_X);
            ShowHistogram CoinBHisto = new ShowHistogram("Coin B Histogram", RV_Y);
            CoinAHisto.Show();
            CoinBHisto.Show();
            textBox3.AppendText("Draw histogram ! \r\n");

            //Compute E(X) and E(Y)
            double E_X = 0, E_Y = 0;
            for (int i = 0; i <= 100; i++) {
                E_X += CoinAHisto.times[i] / 10000d * i;
                E_Y += CoinBHisto.times[i] / 10000d * i;
            }
            textBox3.AppendText("E(X) = " + Convert.ToString(E_X) + "\r\n");
            textBox3.AppendText("E(Y) = " + Convert.ToString(E_Y) + "\r\n");

            //Compute Var(X) and Var(Y)
            double Var_X = 0, Var_Y = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (CoinAHisto.times[i] > 0)
                    Var_X += (CoinAHisto.times[i] / 10000d) * Math.Pow(i - E_X, 2);
                if (CoinBHisto.times[i] > 0)
                    Var_Y += (CoinBHisto.times[i] / 10000d) * Math.Pow(i - E_Y, 2);
            }
            textBox3.AppendText("Var(X) = " + Convert.ToString(Var_X) + "\r\n");
            textBox3.AppendText("Var(Y) = " + Convert.ToString(Var_Y) + "\r\n");

            //Calculate Accurrancy
            int Error = 0;
            for(int i = 0; i < 10000; i++)
            {
                if (CoinAHisto.times[RV_X[i]] <= CoinBHisto.times[RV_X[i]])
                    Error++;
                if (CoinAHisto.times[RV_Y[i]] > CoinBHisto.times[RV_Y[i]])
                    Error++;
            }
            textBox3.AppendText("Accurrancy = " + Convert.ToString((20000-Error)/20000d) + "\r\n");


        }




    }
}
