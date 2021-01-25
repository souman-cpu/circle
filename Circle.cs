using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_inhertence_app
{       // we inherted from figure the first point to draw it and now we need the second point 
    class Circle : Figure 
    {
        // and those are the second poitnt
        int x2, y2;
        int radius;
        public Circle(int x, int y) :
            base(x,y) // we need to pass the argumernt from the base class in this case it's figure
        {
            x2 = y2 = 0;
        }
        public Circle(int x, int y, int r ):
            base(x,y)
        {
            this.radius = r;
        }
        public Circle(int x, int y, int x2 , int y2 ) :  // this one to draw all the point in the design
           base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
            int dx = x2 - x;
            int dy = y2 - y;
            double r = Math.Sqrt(dx * dx + dy * dy);
        }
        internal override void Draw(Graphics g)
        {
            Pen pen;
            if (selected)
                pen = new Pen(color, 3);
            else
                pen = new Pen(color);
            g.DrawEllipse(Pens.Black, x, y, x2, y2);
        }
       
    }

}
