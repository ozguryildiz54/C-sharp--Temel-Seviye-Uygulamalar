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

namespace Adımızın_İlk_Harfini_Yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, PaintEventArgs e)
        {}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Grafik Nesnelerimiz---------------------------------------------
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            GraphicsPath gp2 = new GraphicsPath();
            GraphicsPath gp3 = new GraphicsPath();
            GraphicsPath gp4 = new GraphicsPath();
            GraphicsPath gp5 = new GraphicsPath();
            //-----------------------------------------------------------------

            // Harflerin Kalıplarını Çizmek İçin Kullandığımız Koordinatlar
            Pen pen = new Pen(Color.Gold, 5);

            Point[] pts ={
                            new Point(100,100),
                            new Point(100,450),
                            new Point(450,450),
                            new Point (450,100)
                        };

            Point[] pts7 ={
                            new Point(140,140),
                            new Point(140,410),
                            new Point(410,410),
                            new Point (410,140)
                       };
            Point[] pts3 ={
                            new Point(200,30),
                            new Point(200,80),
                            new Point(240,80),
                            new Point (240,30)
                       };
            Point[] pts4 ={
                            new Point(350,30),
                            new Point(350,80),
                            new Point(310,80),
                            new Point (310,30)
             
                          };

            g.DrawPolygon(pen, pts);
            g.DrawPolygon(pen, pts7);
            //g.DrawPolygon(pen,pts2);
            g.DrawPolygon(pen, pts3);
            g.DrawPolygon(pen, pts4);

            // SoyAdım



            Point[] pts5 ={
                            new Point(600,100),
                            new Point(700,250),
                            new Point(700,450),
                            new Point(800,450),
                            new Point(800,250),
                            new Point(900,100),
                            new Point(800,100),
                            new Point(750,175),
                            new Point (700,100)
                        };
            g.DrawPolygon(pen, pts5);

            // Harflerin İçini Boyamak için Kullandığımız Kordinatlar

            //O Harfinin Kordinatları ---------------------
            Point[] points ={ new Point(100,100),
                            new Point(100,450),
                            new Point(450,450),
                            new Point (450,100)};
            //---------------------------------------------

           //Y Harfinin Kordinatları-----------------------
            Point[] pts2 ={
                            new Point(600,100),
                            new Point(700,250),
                            new Point(700,450),
                            new Point(800,450),
                            new Point(800,250),
                            new Point(900,100),
                            new Point(800,100),
                            new Point(750,175),
                            new Point (700,100)
                       };
            //---------------------------------------------

            //O Harfi içindeki Küçük O nun Kordinatları----
            Point[] pts10 ={
                              new Point(140,140),
                            new Point(140,410),
                            new Point(410,410),
                            new Point (410,140)
                          };
            //---------------------------------------------

            //Ö Hafrinin Noktalarının Kordinatları---------
            Point[] pts11 ={
                           new Point(200,30),
                            new Point(200,80),
                            new Point(240,80),
                            new Point (240,30)
                       };
            
            Point[] pts12 ={
                            new Point(350,30),
                            new Point(350,80),
                            new Point(310,80),
                            new Point (310,30)
                          };
            //---------------------------------------------

            gp4.AddPolygon(pts11);
            PathGradientBrush pg4 = new PathGradientBrush(gp4);
            pg4.CenterColor = Color.BlueViolet;
            pg4.SurroundColors = new Color[] { Color.Orange };
            g.FillPolygon(pg4, pts11);

            gp5.AddPolygon(pts12);
            PathGradientBrush pg5 = new PathGradientBrush(gp5);
            pg5.CenterColor = Color.BlueViolet;
            pg5.SurroundColors = new Color[] { Color.Orange };
            g.FillPolygon(pg5, pts12);



            gp.AddPolygon(points);



            PathGradientBrush pg = new PathGradientBrush(gp);
            pg.CenterColor = Color.White;
            pg.SurroundColors = new Color[] { Color.White};

            g.FillPolygon(pg, points);



            gp3.AddPolygon(pts10);
            PathGradientBrush pg3 = new PathGradientBrush(gp3);
            pg3.CenterColor = Color.BlueViolet;
            pg3.SurroundColors = new Color[] { Color.Orange };
            g.FillPolygon(pg3, pts10);



            

            gp2.AddPolygon(pts2);
            PathGradientBrush pg2 = new PathGradientBrush(gp2);
            pg2.CenterColor = Color.BlueViolet;
            pg2.SurroundColors = new Color[] { Color.Orange};
            g.FillPolygon(pg2, pts2);

            
            using (HatchBrush br = new HatchBrush(HatchStyle.DiagonalBrick,
                Color.Red, Color.Pink))
            {
                e.Graphics.FillRectangle(br,100, 100, 350, 40);
                e.Graphics.FillRectangle(br, 100, 410, 350, 40);
                e.Graphics.FillRectangle(br, 100, 100, 40,350);
                e.Graphics.FillRectangle(br, 410,140 , 40, 310);
               // e.Graphics.FillRectangle(br, 200, 30, 20, 30);
                //e.Graphics.FillRectangle(br, 330, 30, 20, 30);
               // e.Graphics.FillRectangle(br, 900, 450, 300, 150);
                //e.Graphics.DrawRectangle(Pens.Red, 10, 10, 200, 150);
            }
            

            
        }
    }
}
   