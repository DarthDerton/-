using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar
{
    class Точка
    {
        double x, y, z;
        public Точка() { }
        public Точка(double x, double y, double z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double X 
        {
            get { return x; }
            set { x = value; }
        }
        public double Y 
        {
            get { return y; }
            set { y = value; }
        }
        public double Z 
        {
            get { return z; }
            set { z = value; }
        }
        public string Координаты() 
        {
            return "(" + x + "," + y + "," + z + ")";
        }
    }
}
