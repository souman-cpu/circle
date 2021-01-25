using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       //                           the base class
namespace the_inhertence_app
{
    abstract class Figure
    {
        protected int x, y; // these are the first point of the circle (Center)
        protected Color color;
        protected bool selected;    
        public Figure(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
        public Figure (int x,int y,Color co)
        {
            this.x = x;
            this.y = y;
            this.color = co;
            selected = false;
        }
        abstract internal void Draw(Graphics g);
      
        internal void Select(bool value)
        {
            selected = value;
        }
    }

}
