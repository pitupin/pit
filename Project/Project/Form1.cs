using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        int xStart, yStart ;
        

        Graphics graphics;
        Bitmap currentBitmap;
        Bitmap saveBitmap;
       
        SolidBrush brush;
       
        int size;

        private void buttonUp_Click(object sender, EventArgs e)
        {
            
           yStart  = yStart - size;
            if (yStart <= 0)
            {
                yStart = 0;
            }

            currentBitmap = (Bitmap)saveBitmap.Clone();
            graphics = Graphics.FromImage(currentBitmap);

            graphics.FillRectangle(brush, xStart, yStart, size, size);
            pictureBox.Image = currentBitmap;

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            xStart = xStart - size;
            if (xStart <= 0)
            {
                xStart = 0 ;
            }

            currentBitmap = (Bitmap)saveBitmap.Clone();
            graphics = Graphics.FromImage(currentBitmap);

            graphics.FillRectangle(brush, xStart, yStart, size, size);
            pictureBox.Image = currentBitmap;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            xStart = xStart + size;
            if (xStart + size >= pictureBox.Width)
            {
                xStart = pictureBox.Width - size;
            }
            currentBitmap = (Bitmap)saveBitmap.Clone();
            graphics = Graphics.FromImage(currentBitmap);

            graphics.FillRectangle (brush,  xStart, yStart, size, size);
            pictureBox.Image = currentBitmap; 
            
        } 


        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK);
            {
                 brush.Color = colorDialog.Color;
                изменитьЦветToolStripMenuItem.BackColor = colorDialog.Color;
                currentBitmap = (Bitmap)saveBitmap.Clone();
                graphics = Graphics.FromImage(currentBitmap);

                graphics.FillRectangle(brush, xStart, yStart, size, size);
                pictureBox.Image = currentBitmap;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            saveBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(currentBitmap);
           
            brush = new SolidBrush(Color.Red);

           
            yStart = 1;
            xStart = 1;
            size = 100;
            graphics.FillRectangle(brush, xStart, yStart, size, size);
            pictureBox.Image = currentBitmap;
            brush = new SolidBrush(colorDialog.Color);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            yStart = yStart + size;
            if (yStart + size  >= pictureBox.Height)
            {
                yStart =  pictureBox.Height - size;
            }

            currentBitmap = (Bitmap)saveBitmap.Clone();
            graphics = Graphics.FromImage(currentBitmap);

            graphics.FillRectangle(brush, xStart, yStart, size, size);
            pictureBox.Image = currentBitmap;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}