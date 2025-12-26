using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String islemler;
        double sayi1 = 0.0;
        double sayi2 = 0.0;
        int a = 0;
        
        Button sayiButonlari = new Button();
        Button cButonu = new Button();
        Button CEbutonu= new Button();
        Button artiButonu = new Button();
        Button eksiButonu = new Button();
        Button carpiButonu = new Button();
        Button bolmeButonu = new Button();
        Button sifirSayisi = new Button();
        Button virgulIsareti = new Button();
        Button esittirOperatoru= new Button();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Textbox' ın oluşturulmasi-----------------
                TextBox text = new TextBox();
                text.Location = new Point(25, 30);
                text.Size = new System.Drawing.Size(480, 40);
                text.Multiline = true;
                text.TextAlign = HorizontalAlignment.Right;
                text.Text = "0";
                this.Controls.Add(text);
                //-------------------------------------------

                //Butonlarin olusturulmasi-------------------

                //Sayi butonlarimizin olusturulmasi
                for (int i = 1; i <= 3; i++)
                {
                    if (i == 2)
                        a = 1;
                    if (i == 3)
                        a = 2;
                    for (int j = 1; j <= 3; j++)
                    {
                        Button sayiButonlari = new Button();
                        sayiButonlari.Location = new Point(80 * i, 90 * j);
                        sayiButonlari.Size = new System.Drawing.Size(50, 50);
                        sayiButonlari.BackColor = Color.Lime;
                        sayiButonlari.ForeColor=Color.Blue;
                        if (i == 1)
                        {
                            sayiButonlari.Text = (a + 1).ToString();
                            sayiButonlari.Click += (s, EventArgs) =>
                            {
                                if (text.Text == "0")
                                    text.Clear();
                                text.Text += sayiButonlari.Text;
                            };
                            this.Controls.Add(sayiButonlari);
                            a += 3;
                        }
                        if (i == 2)
                        {
                            sayiButonlari.Text = (a + 1).ToString();
                            sayiButonlari.Click += (s, EventArgs) =>
                            {
                                if (text.Text == "0")
                                    text.Clear();
                                text.Text += sayiButonlari.Text;
                            };
                            this.Controls.Add(sayiButonlari);
                            a += 3;
                        }
                        if (i == 3)
                        {
                            sayiButonlari.Text = (a + 1).ToString();
                            sayiButonlari.Click += (s, EventArgs) =>
                            {
                                if (text.Text == "0")
                                    text.Clear();
                                text.Text += sayiButonlari.Text;
                            };
                            this.Controls.Add(sayiButonlari);
                            a += 3;
                        }
                    }
                }
                
                //Sayi butonlarimizin olusturulmasi bitti-----------

                //Operator ve islem butonlari--------------------------------

                // C islemi------------------------------------
                cButonu.Location = new Point(350, 90);
                cButonu.BackColor = Color.Lime;
                cButonu.ForeColor = Color.Blue;
                cButonu.Size = new System.Drawing.Size(50, 50);
                cButonu.Text = "C";
                cButonu.Click += (s, EventArgs) =>
                {
                    text.Text = text.Text.Substring(0, text.Text.Length - 1);
                };
                this.Controls.Add(cButonu);

                // CE islemi----------------------------------
                CEbutonu.Location = new Point(420, 90);
                CEbutonu.BackColor = Color.Lime;
                CEbutonu.ForeColor = Color.Blue;
                CEbutonu.Size = new System.Drawing.Size(50, 50);
                CEbutonu.Text = "CE";
                CEbutonu.Click += (s, EventArgs) =>
                {
                    text.Text = "0";
                };
                this.Controls.Add(CEbutonu);

                // + operatörü--------------------------------
                artiButonu.Location = new Point(350, 158);
                artiButonu.BackColor = Color.Lime;
                artiButonu.ForeColor = Color.Blue;
                artiButonu.Size = new System.Drawing.Size(50, 30);
                artiButonu.Text = "+";
                artiButonu.Click += (s, EventArgs) =>
                {
                    sayi1=Convert.ToDouble(text.Text);
                    islemler = "+";
                    text.Clear();
                };
                this.Controls.Add(artiButonu);

                // - operatörü--------------------------------
                eksiButonu.Location = new Point(420, 158);
                eksiButonu.BackColor = Color.Lime;
                eksiButonu.ForeColor = Color.Blue;
                eksiButonu.Size = new System.Drawing.Size(50, 30);
                eksiButonu.Text = "-";
                eksiButonu.Click += (s, EventArgs) =>
                {
                    sayi1 = Convert.ToDouble(text.Text);
                    islemler = "-";
                    text.Clear();
                };
                this.Controls.Add(eksiButonu);

                // * operatörü--------------------------------
                carpiButonu.Location = new Point(350, 218);
                carpiButonu.BackColor = Color.Lime;
                carpiButonu.ForeColor = Color.Blue;
                carpiButonu.Size = new System.Drawing.Size(50, 30);
                carpiButonu.Text = "*";
                carpiButonu.Click += (s, EventArgs) =>
                {
                    sayi1 = Convert.ToDouble(text.Text);
                    islemler = "*";
                    text.Clear();
                };
                this.Controls.Add(carpiButonu);

                // / operatörü--------------------------------
                bolmeButonu.Location = new Point(420, 218);
                bolmeButonu.BackColor = Color.Lime;
                bolmeButonu.ForeColor = Color.Blue;
                bolmeButonu.Size = new System.Drawing.Size(50, 30);
                bolmeButonu.Text = "/";
                bolmeButonu.Click += (s, EventArgs) =>
                {
                    sayi1 = Convert.ToDouble(text.Text);

                    islemler = "/";
                    text.Clear();
                };
                this.Controls.Add(bolmeButonu);

                // 0 sayisi----------------------------------
                sifirSayisi.Location = new Point(80, 350);
                sifirSayisi.BackColor = Color.Lime;
                sifirSayisi.ForeColor = Color.Blue;
                sifirSayisi.Size = new System.Drawing.Size(130, 50);
                sifirSayisi.Text = "0";
                sifirSayisi.Click += (s, EventArgs) =>
                {
                    text.Text += "0";
                };
                this.Controls.Add(sifirSayisi);

                // , ----------------------------------------
                virgulIsareti.Location = new Point(240, 350);
                virgulIsareti.BackColor = Color.Lime;
                virgulIsareti.ForeColor = Color.Blue;
                virgulIsareti.Size = new System.Drawing.Size(50, 50);
                virgulIsareti.Text = ",";
                virgulIsareti.Click += (s, EventArgs) =>
                {
                    text.Text += ",";
                };
                this.Controls.Add(virgulIsareti);

                // = islemi----------------------------------
                esittirOperatoru.Location = new Point(350, 270);
                esittirOperatoru.BackColor = Color.Lime;
                esittirOperatoru.ForeColor = Color.Blue;
                esittirOperatoru.Size = new System.Drawing.Size(120, 50);
                esittirOperatoru.Text = "=";
                esittirOperatoru.Click += (s, EventArgs) =>
                {
                    sayi2 = Convert.ToDouble(text.Text);
                    text.Clear();
                    if (islemler == "+")
                        sayi1 += sayi2;
                    if (islemler == "-")
                        sayi1 -= sayi2;
                    if (islemler == "*")
                        sayi1 *= sayi2;
                    if (islemler == "/")
                        sayi1 /= sayi2;
                    text.Text = sayi1.ToString();
                    sayi1 = 0.0;
                };
                this.Controls.Add(esittirOperatoru);

                //------------------------------------------

            }
            catch(Exception)
            {
                MessageBox.Show("Beklenmeyen Bir Durum Oldu Programi Tekrar Açiniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
