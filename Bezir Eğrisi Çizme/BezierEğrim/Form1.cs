using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierEğrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics grafik = this.CreateGraphics();
            
            grafik = this.CreateGraphics();
            Pen firca = new Pen(Color.Black, 2);

            PointF x1 = new PointF(300, 20);
            PointF x2 = new PointF(300, 350);
            PointF y1 = new PointF(20, 200);
            PointF y2 = new PointF(570, 200);

            grafik.DrawLine(firca, x1, x2);
            grafik.DrawLine(firca, y1, y2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics grafik = this.CreateGraphics();
            grafik = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 2);
            grafik.DrawEllipse(firca, 296, 196, 8, 8);
            grafik.DrawEllipse(firca, 356, 61, 8, 8);
            grafik.DrawEllipse(firca, 461, 196, 8, 8);
            grafik.DrawEllipse(firca, 506, 151, 8, 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics grafik = this.CreateGraphics();

            grafik = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Orange, 2);
            PointF P0 = new PointF(300, 200);
            PointF P1 = new PointF(360, 65);
            PointF P3 = new PointF(465, 200);
            PointF P2 = new PointF(510, 155);

            for (double u = 0; u <= 1; u += 0.01)
            {
                float x = (float)(Math.Pow((1 - u), 3) * P0.X + 3 * u * Math.Pow((1 - u), 2) * P1.X + 3 * Math.Pow(u, 2) * (1 - u) * P2.X + Math.Pow(u, 3) * P3.X);
                float y = (float)(Math.Pow((1 - u), 3) * P0.Y + 3 * u * Math.Pow((1 - u), 2) * P1.Y + 3 * Math.Pow(u, 2) * (1 - u) * P2.Y + Math.Pow(u, 3) * P3.Y);
                grafik.DrawEllipse(firca, x, y, 2, 2);
            }
                
            




        }
    }
}

