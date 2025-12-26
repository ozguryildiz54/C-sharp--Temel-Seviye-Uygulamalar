using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiral_Çizdirme
{
    public partial class Form1 : Form
    {
        int angle = 0;
        int radius = 150;
        int angleChange = 10;
        int centerX, centerY;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Width = 800;
            this.Height = 800;
            Bitmap bm = new Bitmap(100,300);
            using(Graphics gr =Graphics.FromImage(bm))
            {
                gr.Clear(Color.Green);
            }

            pictureBox1.Image = bm;
            centerX = this.Width / 2;
            centerY = this.Height / 2;
            Point a = new Point(centerX, centerY);
            pictureBox1.Location =a;
            timer1.Start();
        }

        private double deg2rad(double deger)
        {
            return deger *Math.PI / 180;
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            double radion = deg2rad(angle);
            Point yer = new Point(Convert.ToInt32(centerX + radius * Math.Cos(radion)),Convert.ToInt32(centerY+radius*Math.Sin(radion)));
            pictureBox1.Location = yer;
            angle += angleChange;
            angle %= 360;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            angleChange = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            radius = Convert.ToInt32(numericUpDown2.Value);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
