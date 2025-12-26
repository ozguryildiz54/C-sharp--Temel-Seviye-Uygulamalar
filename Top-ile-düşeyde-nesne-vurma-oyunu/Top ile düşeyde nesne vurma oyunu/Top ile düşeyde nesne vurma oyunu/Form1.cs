using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_ile_düşeyde_nesne_vurma_oyunu
{
    public partial class Form1 : Form
    {
        public static int nesneSayisi;
        public static int nesneKordinatX;
        public static int nesneKordinatY;
        Random rastgele = new Random();
        Button[] button = new Button[10];

        int[] puan = new int[10];

        int skor = 0, atisSayisi = 1;

        int topX, topY = 0;

        int butonSayisi = 0;

        public Form1()
        {
            InitializeComponent();

          
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

            Bitmap bm = new Bitmap(100, 300);
            pictureBox1.Image = bm;
            topX = 310;
            topY = 0;
            Point a = new Point(topX, topY);
            pictureBox1.Location = a;
            nesneSayisi = rastgele.Next(1, 11);
            butonSayisi = nesneSayisi;
            label1.Text = nesneSayisi.ToString();
            int nesneKordinatY = 620;
            for (int i = 0; i < nesneSayisi; i++)
            {
                puan[i] = new int();
                puan[i] = rastgele.Next(100);
                button[i] = new Button();
                button[i].Height = 60;
                button[i].Width = 60;
                nesneKordinatX = rastgele.Next(0, 30);
                button[i].BackColor = Color.DeepSkyBlue;
                button[i].Left = nesneKordinatX + 100 * i;
                button[i].Top = nesneKordinatY;
                button[i].Name = "buton" + i;
                button[i].Text = "Puan: " + puan[i].ToString();
                this.Controls.Add(button[i]);

            }
            topX = rastgele.Next(0, 720);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            label5.Text = (atisSayisi-1).ToString();

            Point a = new Point(topX, topY);
            pictureBox1.Location = a;
            topY += 50;

         
            if (topY == 650)
            {
               
                topX = rastgele.Next(0, 720);
                pictureBox1.Location = a;
                topY += 50;
               
                topY %= 650;
                atisSayisi++;
            }

            //Çarpışma olayının gerçekleştiği blok

            for (int i = 0; i < nesneSayisi; i++)
            {

                foreach (Control item in this.Controls.OfType<Control>())
                {

                    float mutlakX = Math.Abs((pictureBox1.Left + (pictureBox1.Width / 2)) - (button[i].Left + (button[i].Width / 2)));
                    float mutlakY = Math.Abs((pictureBox1.Top + (pictureBox1.Height / 2)) - (button[i].Top + (button[i].Height / 2)));
                    float farkGenislik = (pictureBox1.Width / 2) + (button[i].Width / 2);
                    float farkYukselik = (pictureBox1.Height / 2) + (button[i].Height / 2);

                    if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY))
                    {
                        if (item.Name == "buton" + i)
                        {
                            skor += puan[i] * atisSayisi;
                           
                            this.Controls.Remove(item);
                            butonSayisi--;

                         
                        }

                    }
                }
                //Çarpışma araması burda bitiyor.
                label3.Text = skor.ToString();
                if (butonSayisi==0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti.\nPuan: "+ skor.ToString());
                    Application.Exit();
                }
            }
        }
    }
}

