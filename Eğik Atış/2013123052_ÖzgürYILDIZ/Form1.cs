using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Drawing;

namespace _2013123052_ÖzgürYILDIZ
{
    public partial class Form1 : Form
    {
        int pictureBox_Y_kordinat = 0;
        int aci;
        int x = 5;
        int vo = 0;
        int vx=5;//sabit
        int vy = 5;
        int ax =0;//sabit
        int ay = 1;
        int rastgelePictureBox;
        int puan=0;
        Random rastgele = new Random();
         PictureBox[] CokgenNesne = new PictureBox[5];
       
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   pictureBox1.Location = new Point(5,5);
           
            rastgelePictureBox = rastgele.Next(1,6);
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Buyuk O ve onun içinde ki o harfini yazdırmak için----
            Pen p = new Pen(Color.Blue, 5);
            //------------------------------------------------------

            //Buyuk o hafinin dışında yani üstünde ki o harfini ö harfi yapan noktalar için------
            Pen p2 = new Pen(Color.Blue, 1);
            //-----------------------------------------------------------------------------------


            Point[] buyuk_O_Harfi = {
                            //O hafrinin çizimi-----
                            new Point(20,20), 
                            new Point(20,80),
                            new Point(80,80), 
                            new Point(80,20), 
                           //-----------------------
                        };

            Point[] kucuk_O_Harfi =
            {
                 //O harfi için de ki küçük o harfinin çizimi iç içe çizdiriyorum çünkü 3 boyutlu olması için
                            new Point(30,30), 
                            new Point(30,70),
                            new Point(70,70), 
                            new Point(70,30), 
                //-------------------------------------------------------------------------------------------
            };

            //O harfinin soldaki noktasi yani o harfini ö yapan noktalar
            Point[] O_harfinin_noktalari=
            {
                            new Point(35,5), 
                            new Point(35,15),
                            new Point(40,15), 
                            new Point(40,5),
            };
            //----------------------------------------------------------

            //O harfinin sağdaki noktasi yani o harfini ö yapan noktalar bu ikincisi
            Point[] O_harfinin_noktalari2 =
            {
                            new Point(65,5), 
                            new Point(65,15),
                            new Point(70,15), 
                            new Point(70,5),
            };
            g.DrawPolygon(p, buyuk_O_Harfi);
            g.DrawPolygon(p, kucuk_O_Harfi);
            g.DrawPolygon(p2, O_harfinin_noktalari);
            g.DrawPolygon(p2, O_harfinin_noktalari2);

            //Şimdi de harflerin içini gradient ile boyuyoruz------------
            using (HatchBrush br = new HatchBrush(HatchStyle.DiagonalBrick, Color.Green, Color.Turquoise))
            {
                //buyuk_O_harfi_boya---------------------------------------------------------------
                PathGradientBrush buyuk_O_harfi_boya = new PathGradientBrush(buyuk_O_Harfi);
                buyuk_O_harfi_boya.CenterColor = Color.OrangeRed;
                buyuk_O_harfi_boya.SurroundColors = new Color[] { Color.Lime };
                g.FillPolygon(buyuk_O_harfi_boya, buyuk_O_Harfi);
                //---------------------------------------------------------------------------------

                //kucuk_O_harfi_boya---------------------------------------------------------------
                PathGradientBrush kucuk_O_harfi_boya = new PathGradientBrush(kucuk_O_Harfi);
                kucuk_O_harfi_boya.CenterColor = Color.Purple;
                kucuk_O_harfi_boya.SurroundColors = new Color[] { Color.Yellow };
                g.FillPolygon(kucuk_O_harfi_boya, kucuk_O_Harfi);
                //---------------------------------------------------------------------------------

                //O_harfinin_Noktalari_boya--------------------------------------------------------
                PathGradientBrush O_harfinin_Noktalari_boya = new PathGradientBrush(O_harfinin_noktalari);
                O_harfinin_Noktalari_boya.CenterColor = Color.Red;
                O_harfinin_Noktalari_boya.SurroundColors = new Color[] { Color.SteelBlue };
                g.FillPolygon(O_harfinin_Noktalari_boya, O_harfinin_noktalari);
                //---------------------------------------------------------------------------------

                //O_harfinin_noktalari2_boya-------------------------------------------------------
                PathGradientBrush O_harfinin_noktalari2_boya = new PathGradientBrush(O_harfinin_noktalari2);
                O_harfinin_noktalari2_boya.CenterColor = Color.Red;
                O_harfinin_noktalari2_boya.SurroundColors = new Color[] { Color.SteelBlue };
                g.FillPolygon(O_harfinin_noktalari2_boya, O_harfinin_noktalari2);
                //---------------------------------------------------------------------------------

                //boyamamız bitti şimdi textbox dan picture box'ın y konumunu alalım------------------------------------------------------------------------------
            }
           
        }

       
           private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //Burada kullanıcı deger girmeden butona tıkladığında program akışının bozulmaması için istisnai durumlar için try catch bloğu kullanacağız----------
            try
            {
                pictureBox_Y_kordinat = Convert.ToInt32(textBox1.Text);
                //vo = Convert.ToInt32(textBox2.Text);
               // aci = Convert.ToInt32(textBox3.Text);

                pictureBox1.Location = new Point(5, pictureBox_Y_kordinat);
                
                rastgelePictureBox = rastgele.Next(1, 6);
                for (int i = 0; i < rastgelePictureBox; i++)
                {
                    int kordinatX = rastgele.Next(50, 550);
                    int kordinatY = rastgele.Next(50, 450);
                    Point p = new Point(kordinatX, kordinatY);
                    CokgenNesne[i] = new PictureBox();
                    CokgenNesne[i].Top = kordinatX + 50 * i;
                    CokgenNesne[i].BackColor = Color.Red;
                    CokgenNesne[i].Left = kordinatY + 50 * i;
                    CokgenNesne[i].Size = new Size(50, 50);
                    CokgenNesne[i].Name="pictureBox"+i;//  çarpışma kontrolünü yapmak için böyle bir isim veriyoruz
                    this.Controls.Add(CokgenNesne[i]);
                    CokgenNesne[i].BringToFront();
                    timer1.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir deger giriniz!");
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            vx += ax;

            vy += ay;
            x += vx;
            pictureBox_Y_kordinat += Convert.ToInt32(vy);
            if (pictureBox_Y_kordinat > 500)
            {
                pictureBox_Y_kordinat -= Convert.ToInt32(vy);
                vy = -vy;
            }
            if (x > 800)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitti.");
            }
            pictureBox1.Location = new Point((int)x, (int)pictureBox_Y_kordinat);




            Graphics cizim = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 1);
            Point m = new Point(pictureBox1.Left - 1, pictureBox1.Top + pictureBox1.Height / 2);
            Point n = new Point(pictureBox1.Left - 2, pictureBox1.Top + pictureBox1.Height / 2); //nokta
            cizim.DrawLine(kalem, m, n);

            cizim.Dispose();

            for (var j = 0; j < rastgelePictureBox; j++)
            {


                float mutlakX = Math.Abs((pictureBox1.Left + (pictureBox1.Width / 2)) - (CokgenNesne[j].Left + (CokgenNesne[j].Width / 2)));/* X koordinatları arası farkın mutlak değeri. */
                float mutlakY = Math.Abs((pictureBox1.Top + (pictureBox1.Height / 2)) - (CokgenNesne[j].Top + (CokgenNesne[j].Height / 2)));/* Y koordinatları arası farkın mutlak değeri . */

                float farkGenislik = (pictureBox1.Width / 2) + (CokgenNesne[j].Width / 2); /*Genişliklerin yarılarının toplamı.*/
                float farkYukselik = (pictureBox1.Height / 2) + (CokgenNesne[j].Height / 2); /* Yüksekliklerin yarılarının toplamı. */
                if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY))
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        ;
                        if (item.Name == "pictureBox" + j)
                        {

                            puan += 10;
                            this.Controls.Remove(item);
                            label2.Text = puan.ToString();
                        }

                    }
                    
                }
            }
        }


            
        

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

      

    }
}
