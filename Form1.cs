using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_inhertence_app
{
    public partial class Form1 : Form
    {
        List<Figure> thelist;
        Circle C1;
        int x1, y1;
        int x2, y2;

        public Form1()
        {
            InitializeComponent();
            thelist = new List<Figure>();
            //C1 = new Circle(150, 150, 250, 250);
            x1 = y1 = 0;
            //x2 = y2 = 0;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (C1 != null)
                C1.Draw(g);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(x1==0 && y1==0) // first click mouse 
            {
                x1 = e.X; y1 = e.Y;
            }
            else  // second click mouse 
            {
                // creat a figure 
                C1 = new Circle(x1 , y1, e.X, e.Y);    // i think here we should add the redius to make this a proper circle
                this.Invalidate();
                x1 = y1 = 0;

            }
        }
    }
}
