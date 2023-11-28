using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp153
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Color c1 = Color.FromArgb(0, 0, 0);
            Color c2 = Color.FromArgb(255, 255, 255);
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0), new Point(300, 300),c1,c2);
            g.FillEllipse(lb, new Rectangle(new Point(100, 100), new Size(200, 300)));


            Bitmap b = new Bitmap(500, 500);
            Graphics g2 = Graphics.FromImage(b);
            g2.FillEllipse(lb, new Rectangle(new Point(100, 100), new Size(300, 100)));
            System.IO.MemoryStream m = new System.IO.MemoryStream();
            b.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bmemory = m.GetBuffer();
            System.IO.FileStream fsave = new System.IO.FileStream(@"G:\mahan.jpg", System.IO.FileMode.Create);
            fsave.Write(bmemory, 0, bmemory.Length);
            fsave.Flush();
            fsave.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
