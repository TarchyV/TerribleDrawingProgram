using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace funtime
{
    public partial class Form1 : Form
    {
        public int mouseX;
        public int mouseY;
        public int size;
        public bool square;
        public bool MouseIsDown = false;
        SolidBrush myBrush; 
        Bitmap DrawArea;
        Graphics g;
        Rectangle myRectangle;
        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPicker.BackColor = colorDialog.Color;
            }

        }

        private void draw()
        {
        myBrush = new SolidBrush(ColorPicker.BackColor);
        myRectangle = new Rectangle(Cursor.Position.X - 45, Cursor.Position.Y - 78, size, size);
           if (square == true) { g.FillRectangle(myBrush, myRectangle); }
            else { g.FillEllipse(myBrush, myRectangle); }
        pictureBox1.Image = DrawArea;     
         }

        public void drawTmr_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(DrawArea);
            size = (int)sizeBar.Value;
            draw();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            drawTmr.Start();
        }

          
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawTmr.Stop();
        }
        private void circleRadio_CheckedChanged(object sender, EventArgs e)
        {
            square = false;
        }
        private void squareRadio_CheckedChanged(object sender, EventArgs e)
        {
            square = true;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            Graphics graphic = Graphics.FromImage(DrawArea);
            graphic.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

