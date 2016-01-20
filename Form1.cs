using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance2016.CSharp;
using LivePerformance2016.CSharp.Data;

namespace LivePerformance2016
{
    public partial class Form1 : Form
    {
        private Administratie admin;

        public Form1()
        {
            
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            Database data = new Database();
            admin = new Administratie(data);
        }

        private void bttnOpslaan_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, p.Height);
            points[2] = new Point(p.Width, p.Height);
            points[3] = new Point(p.Width, 0);

            Brush brush = new SolidBrush(Color.DarkGreen);

            g.FillPolygon(brush, points);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }
    }
}
