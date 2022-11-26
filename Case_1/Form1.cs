using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Case_1
{
   


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        abstract class ChooseBrush
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            abstract public void NewColor();

        }
        class Red: ChooseBrush
        {
            public override void NewColor()
            {
                Brush brush = new SolidBrush(Color.Red);
            }
        }
        abstract class Shapes
        {
            
            
            abstract public void Area();

            
        }

        class myRectangle : Shapes
        {
            
            public double edgeOfShort;
            public double edgeOfLong;
            public double areaOfRectangle;
            public Point firtsPoint;
            public Point secondPoint;
            public Point thirdPoint;
            public Point endPoint;
            public override void Area()
            {
                areaOfRectangle = edgeOfShort * edgeOfLong;
              
            }
          
        }
        Red mybrush = new Red();
        
        
        Point startMouseXY;
        Point endMouseXY;
        Boolean mouseClicked;
        Boolean deleteCliked = false;
        Boolean draw_Rectangle = false;
        Boolean draw_Circle = false;
        Boolean draw_Triangle = false;
        Boolean draw_Hexagon = false;
        Boolean penClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void drawSquare_Click(object sender, EventArgs e)
        {
            draw_Rectangle = true;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked == true)
            {
                endMouseXY = e.Location;
                pictureBox1.Refresh();
               
            }   

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endMouseXY = e.Location;
            
            mouseClicked = false;
            draw_Rectangle=false;
            draw_Triangle=false;
            draw_Circle=false;
            draw_Hexagon = false;
           
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startMouseXY = e.Location;
            mouseClicked = true;


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            myRectangle rectangle = new myRectangle();

            if (penClicked == true)
            {
                
                

                if (draw_Rectangle == true)
                {
                   e.Graphics.FillRectangle(Brushes.Yellow, Math.Min(startMouseXY.X, endMouseXY.X), Math.Min(startMouseXY.Y, endMouseXY.Y), Math.Abs(endMouseXY.X - startMouseXY.X), Math.Abs(endMouseXY.Y - startMouseXY.Y));
                    
                    
                }
                if (draw_Triangle == true)
                {
                    //  endMouseXY.X; endMouseXY.Y;
                    Point[] trianglePoint = new Point[3];
                    trianglePoint[0].X = startMouseXY.X;
                    trianglePoint[0].Y = startMouseXY.Y;
                    trianglePoint[1].X = Math.Abs((endMouseXY.X- 2 * (endMouseXY.X)));
                    trianglePoint[1].Y = Math.Min(endMouseXY.Y,endMouseXY.X);
                    trianglePoint[2].X = endMouseXY.X;
                    trianglePoint[2].X = endMouseXY.Y;
                    e.Graphics.FillPolygon(Brushes.Blue, trianglePoint);

                }
                if (draw_Circle == true)
                {
                    e.Graphics.FillEllipse(Brushes.Purple, Math.Min(startMouseXY.X, endMouseXY.X), Math.Min(startMouseXY.Y, endMouseXY.Y), Math.Abs(endMouseXY.X - startMouseXY.X), Math.Abs(endMouseXY.Y - startMouseXY.Y));
                }
                if (draw_Hexagon == true)
                {
                    Point[] hexagonPoint = new Point[6];
                    hexagonPoint[0].X = startMouseXY.X;
                    hexagonPoint[0].Y = startMouseXY.Y;
                    hexagonPoint[1].X = ((startMouseXY.X) / 2);
                    hexagonPoint[1].Y = ((startMouseXY.Y) / 2);
                    hexagonPoint[2].X = startMouseXY.X;
                    hexagonPoint[2].Y = ((startMouseXY.Y) / 4);
                    hexagonPoint[3].X = ((endMouseXY.X) * 2);
                    hexagonPoint[3].Y = endMouseXY.Y;
                    hexagonPoint[4].X = ((startMouseXY.X) * 4);
                    hexagonPoint[4].Y = ((startMouseXY.Y) / 2);
                    hexagonPoint[5].X = endMouseXY.X;
                    hexagonPoint[5].Y = endMouseXY.Y;
                    e.Graphics.FillPolygon(Brushes.Green, hexagonPoint);



                }

               /* Bitmap myBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                for (int x = 0; x < pictureBox1.Width; x++)
                    for (int y = 0; y < pictureBox1.Height; y++)
                    {
                        myBmp.SetPixel(pictureBox1.Width, pictureBox1.Height,Color.White);
                    }
                for (int x=0; x<pictureBox1.Width; x++)
                    for(int y=0; y<pictureBox1.Height; y++)
                    {
                        myBmp.SetPixel(pictureBox1.Width, pictureBox1.Height, myBmp.GetPixel(pictureBox1.Width, pictureBox1.Height));
                    }
               
                    try
                    {

                        int i = 1;
                        myBmp.Save(@"C:\Users\klcbe\Desktop\new_image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);


                    }
                    catch (Exception ex)
                    {
                        string str = ex.Message;

                    }
                    pictureBox1.Visible = true; */

                
            }

            
        }

        private void drawTriangle_Click(object sender, EventArgs e)
        {
            draw_Triangle = true;
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            draw_Circle = true;
        }

        private void drawHexagon_Click(object sender, EventArgs e)
        {
            draw_Hexagon = true;
        }

        public void colorRed_Click(object sender, EventArgs e)
        {
            Red myBrush = new Red();
            myBrush.NewColor();
            

        }

        private void penBttn_Click(object sender, EventArgs e)
        {
            penClicked = true;
        }

        private void mouseHandBttn_Click(object sender, EventArgs e)
        {
            penClicked = false;
            
        }
    }
}
