using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Birime_göre_doğru_çizdirme
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            

            /*
             
             Aynı işlemleri yapar
             
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 0, 50, 50);
            myPen.Dispose();
            formGraphics.Dispose();
             * */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(comboBox1.Text=="-Inch")
            {
                g.PageUnit = GraphicsUnit.Inch;
            }
            if (comboBox1.Text == "-Mm") 
            {
                g.PageUnit = GraphicsUnit.Millimeter;
            }
            if (comboBox1.Text == "-Pixel")
            {
                g.PageUnit = GraphicsUnit.Pixel;
            }

            Pen blackPen = new Pen(Color.Black,1);
            g.DrawLine(blackPen, 0, 0, 45, 45);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            Pen blackPen = new Pen(Color.Silver,1000);
            g.DrawLine(blackPen, 0, 0, 720, 640);
        }

    }
}
