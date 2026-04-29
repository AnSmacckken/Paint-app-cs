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

namespace paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp;       
        Graphics g;        
        int x=0, y=0;
        bool isdraw = false;
        string currentTool = "Pen";
        Color chosenColor = Color.Black;
        float penWidth = 2.0f;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White); 
            pictureBox1.Image = bmp;

            
            numWidth.Minimum = 1;
            numWidth.Maximum = 50;
            numWidth.Value = 2;
      }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdraw)
            {
                penWidth = (float)numWidth.Value;
                if (currentTool == "Pen" || currentTool == "Brush" || currentTool == "Eraser")
                {
                    Color drawColor;

                    if (currentTool == "Eraser")
                    {
                        drawColor = Color.White; 
                    }
                    else
                    {
                        drawColor = chosenColor;
                    }

                    if (x > 0 && y > 0)
                    {
                        Pen p = new Pen(drawColor, penWidth);
                        g.DrawLine(p, x, y, e.X, e.Y);
                    }
                    x = e.X;
                    y = e.Y;

                    pictureBox1.Refresh(); 
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentTool == "FloodFill")
            {
                Color target = bmp.GetPixel(e.X, e.Y);

                FloodFill(bmp, e.Location, target, chosenColor);

                pictureBox1.Refresh();
            }
            isdraw = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isdraw)
            {
                penWidth = (float)numWidth.Value;
                int width = Math.Abs(e.X - x);
                int height = Math.Abs(e.Y - y);
                int startX = Math.Min(x, e.X);
                int startY = Math.Min(y, e.Y);

                if (Fill.Checked && (currentTool != "Pen" && currentTool != "Brush" && currentTool != "Eraser"))
                {

                    SolidBrush brsh = new SolidBrush(chosenColor);
                    
                        if (currentTool == "Rectangle")
                        {
                            g.FillRectangle(brsh, startX, startY, width, height);
                        }
                        else if (currentTool == "Ellipse")
                        {
                            g.FillEllipse(brsh, startX, startY, width, height);
                        }
                        else if (currentTool == "Circle") 
                    {
                        int d = Math.Max(width, height);
                        g.FillEllipse(brsh, startX, startY, d, d);
                    }
                        else if (currentTool == "Square")
                        {
                            int side = Math.Max(width, height);
                            g.FillRectangle(brsh, startX, startY, side, side);
                        }
                        else if (currentTool == "Triangle")
                        {
                            Point[] points = new Point[3];
                            points[0] = new Point(startX + (width / 2), startY);
                            points[1] = new Point(startX, startY + height);
                            points[2] = new Point(startX + width, startY + height);
                            g.FillPolygon(brsh, points);
                        }
                    
                }
                else
                {

                    Pen p = new Pen(chosenColor, penWidth);
                    
                    if (currentTool == "Rectangle")
                        {
                            g.DrawRectangle(p, startX, startY, width, height);
                        }
                        else if (currentTool == "Ellipse")
                        {
                            g.DrawEllipse(p, startX, startY, width, height);
                        }
                        else if (currentTool == "Circle") 
                    {
                        int d = Math.Max(width, height);
                        g.DrawEllipse(p, startX, startY, d, d);
                    }
                        else if (currentTool == "Square")
                        {
                            int side = Math.Max(width, height);
                            g.DrawRectangle(p, startX, startY, side, side);
                        }

                        else if (currentTool == "Line") 
                    {
                            g.DrawLine(p, x, y, e.X, e.Y);
                    }
                        else if (currentTool == "Triangle")
                        {
                            Point[] points = new Point[3];
                            points[0] = new Point(startX + (width / 2), startY);
                            points[1] = new Point(startX, startY + height);
                            points[2] = new Point(startX + width, startY + height);
                            g.DrawPolygon(p, points);
                        
                        }
                    }
                

                pictureBox1.Refresh();
            }
            isdraw = false;
        }

        
        private void FloodFill(Bitmap bmp, Point pt, Color target, Color replacement)
        {
            if (target.ToArgb() == replacement.ToArgb()) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(pt);

            int targetRGB = target.ToArgb();
            int replacementRGB = replacement.ToArgb();

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X >= 0 && a.X < bmp.Width && a.Y >= 0 && a.Y < bmp.Height)
                {
                    if (bmp.GetPixel(a.X, a.Y).ToArgb() == targetRGB)
                    {
                        bmp.SetPixel(a.X, a.Y, replacement);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
            }
        }
        private void colors_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                chosenColor = cd.Color;
                colors.BackColor = chosenColor;
                if (currentTool == "Eraser") currentTool = "Pen";
            }
        }
        private void shapes_Click(object sender, EventArgs e)    { panelShapes.Visible = !panelShapes.Visible; }
        private void clear_Click(object sender, EventArgs e)     { g.Clear(Color.White); pictureBox1.Refresh(); }
        private void rectangle_Click(object sender, EventArgs e) { currentTool = "Rectangle"; panelShapes.Visible = false; }
        private void triangle_Click(object sender, EventArgs e)  { currentTool = "Triangle"; panelShapes.Visible = false; }
        private void ellipse_Click(object sender, EventArgs e)   { currentTool = "Ellipse"; panelShapes.Visible = false; }
        private void square_Click(object sender, EventArgs e)    { currentTool = "Square"; panelShapes.Visible = false; }
        private void circle_Click(object sender, EventArgs e)    { currentTool = "Circle"; panelShapes.Visible = false; }
        private void brush_Click(object sender, EventArgs e)     { currentTool = "Brush"; numWidth.Value = 30; }
        private void pencil_Click(object sender, EventArgs e)    { currentTool = "Pen"; numWidth.Value = 2; }
        private void flood_Click(object sender, EventArgs e)     { currentTool = "FloodFill" ; }
        private void eraser_Click(object sender, EventArgs e)    { currentTool = "Eraser"; }
        private void line_Click(object sender, EventArgs e)      { currentTool = "Line"; }


    }
}
