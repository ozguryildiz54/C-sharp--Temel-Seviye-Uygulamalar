using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Boolean acik = true;
        double tamsayi, sonuc = 0;
        float ondalik = 0;
        bool sifirla = true;
        string islem = "yok";
        public Form1()
        {
            InitializeComponent();

        }

        private void dortislem()
        {
            if (!sifirla)
            {
                switch (islem)
                {
                    case "esittir":
                        sonuc = Convert.ToDouble(txtAlan.Text);
                        break;
                    case "carpma":
                        sonuc *= Convert.ToSingle(txtAlan.Text);
                        break;
                    case "toplama":
                        sonuc += Convert.ToSingle(txtAlan.Text);
                        break;
                    case "cikarma":
                        sonuc -= Convert.ToSingle(txtAlan.Text);
                        break;
                    case "bolme":
                        sonuc /= Convert.ToSingle(txtAlan.Text);
                        break;
                    case "yok":
                        sonuc = Convert.ToSingle(txtAlan.Text);
                        break;
                }

                txtAlan.Text = Convert.ToString(sonuc);
                sifirla = true;
            }

        }
        private void tekislem()
        {
            if (!sifirla)
            {
                switch (islem)
                {
                        
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "8";
            }
            else
            {
                txtAlan.Text = "8";
            }
            sifirla = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "5";
            }
            else
            {
                txtAlan.Text = "5";
            }
            sifirla = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                if (txtAlan.Text != "0")
                {
                    txtAlan.Text += "0";
                    sifirla = false;
                }
                else
                {
                    txtAlan.Text = "0";
                    sifirla = true;
                }
            }
            else { txtAlan.Text = "0"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            { 
                txtAlan.Text += "1"; 
            } 
            else 
            { 
                txtAlan.Text = "1"; 
            }
            sifirla = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!sifirla)
            {
                txtAlan.Text += "2";
            }
            else
            {
                txtAlan.Text = "2";
            }
            sifirla = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "3";
            }
            else
            {
                txtAlan.Text = "3";
            }
            sifirla = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "4";
            }
            else
            {
                txtAlan.Text = "4";
            }
            sifirla = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "6";
            }
            else
            {
                txtAlan.Text = "6";
            }
            sifirla = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "7";
            }
            else
            {
                txtAlan.Text = "7";
            }
            sifirla = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += "9";
            }
            else
            {
                txtAlan.Text = "9";
            }
            sifirla = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dortislem();
            islem = "toplama";
        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dortislem();
            islem = "cikarma"; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dortislem();
            islem = "carpma";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dortislem();
            islem = "bolme";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtAlan.Clear();
            txtAlan.Text = "0";
            sonuc = 0; 
            islem="yok";
            sifirla= true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dortislem();
            islem = "esittir";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a;
            dortislem();
            sonuc = Convert.ToInt32(txtAlan.Text);
            a = Math.Sqrt(sonuc);
            txtAlan.Text = Convert.ToString(a); 

        }

        private void button18_Click(object sender, EventArgs e)
        {
            dortislem();
            sonuc = 1 / sonuc;
            txtAlan.Text = Convert.ToString(sonuc);
            islem = "1bolux";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!sifirla)
            {
                txtAlan.Text += ",";
            }
            else
            {
                txtAlan.Text = ",";
            }
            sifirla = false;
        }
    }
}