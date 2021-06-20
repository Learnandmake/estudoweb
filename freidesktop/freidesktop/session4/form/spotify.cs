using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session4.form
{
    public partial class spotify : Form
    {
        public spotify()
        {
            InitializeComponent();
            //designentrar
            Rectangle r = new Rectangle(0, 0, picbtn.Width, picbtn.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            picbtn.Region = new Region(gp);
            //designfb
            Rectangle r1 = new Rectangle(0, 0, picfb.Width, picfb.Height);
            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            int d1 = 50;
            gp1.AddArc(r1.X, r1.Y, d1, d1, 180, 90);
            gp1.AddArc(r1.X + r1.Width - d1, r1.Y, d1, d1, 270, 90);
            gp1.AddArc(r1.X + r1.Width - d1, r1.Y + r1.Height - d1, d1, d1, 0, 90);
            gp1.AddArc(r1.X, r1.Y + r1.Height - d1, d1, d1, 90, 90);
            picfb.Region = new Region(gp1);
            picbtn.Region = new Region(gp);
            //designap
            Rectangle r2 = new Rectangle(0, 0, picap.Width, picap.Height);
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            int d2 = 50;
            gp2.AddArc(r2.X, r2.Y, d2, d2, 180, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y, d2, d2, 270, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y + r2.Height - d2, d2, d2, 0, 90);
            gp2.AddArc(r2.X, r2.Y + r2.Height - d2, d2, d2, 90, 90);
            picap.Region = new Region(gp2);
            //designg1
            Rectangle r3 = new Rectangle(0, 0, picg1.Width, picg1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp3 = new System.Drawing.Drawing2D.GraphicsPath();
            int d3 = 50;
            gp3.AddArc(r3.X, r3.Y, d3, d3, 180, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y, d3, d3, 270, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y + r3.Height - d3, d3, d3, 0, 90);
            gp3.AddArc(r3.X, r3.Y + r3.Height - d3, d3, d3, 90, 90);
            picg1.Region = new Region(gp3);
            //designg2
            Rectangle r4 = new Rectangle(0, 0, picg2.Width, picg2.Height);
            System.Drawing.Drawing2D.GraphicsPath gp4 = new System.Drawing.Drawing2D.GraphicsPath();
            int d4 = 50;
            gp4.AddArc(r4.X, r4.Y, d4, d4, 180, 90);
            gp4.AddArc(r4.X + r4.Width - d4, r4.Y, d4, d4, 270, 90);
            gp4.AddArc(r4.X + r4.Width - d4, r4.Y + r4.Height - d4, d4, d4, 0, 90);
            gp4.AddArc(r4.X, r4.Y + r4.Height - d4, d4, d4, 90, 90);
            picg2.Region = new Region(gp4);
            //designi1
            Rectangle r5 = new Rectangle(0, 0, pici1.Width, pici1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp5 = new System.Drawing.Drawing2D.GraphicsPath();
            int d5 = 50;
            gp5.AddArc(r5.X, r5.Y, d5, d5, 180, 90);
            gp5.AddArc(r5.X + r5.Width - d5, r5.Y, d5, d5, 270, 90);
            gp5.AddArc(r5.X + r5.Width - d5, r5.Y + r5.Height - d5, d5, d5, 0, 90);
            gp5.AddArc(r5.X, r5.Y + r5.Height - d5, d5, d5, 90, 90);
            pici1.Region = new Region(gp5);
            //designi2
            Rectangle r6 = new Rectangle(0, 0, pici2.Width, pici2.Height);
            System.Drawing.Drawing2D.GraphicsPath gp6 = new System.Drawing.Drawing2D.GraphicsPath();
            int d6 = 50;
            gp6.AddArc(r6.X, r6.Y, d6, d6, 180, 90);
            gp6.AddArc(r6.X + r6.Width - d6, r6.Y, d6, d6, 270, 90);
            gp6.AddArc(r6.X + r6.Width - d6, r6.Y + r6.Height - d6, d6, d6, 0, 90);
            gp6.AddArc(r6.X, r6.Y + r6.Height - d6, d6, d6, 90, 90);
            pici2.Region = new Region(gp6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
