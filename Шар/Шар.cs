using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar
{
    class Шар
    {
        double x, y, z;//Координаты центра Шара;
        double r;//Радиус Шара;
        public Шар(double r)
        {
            this.r = r;

            x = 0; y = 0; z = 0;
        }
        public Шар(double x, double y, double z, double r)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.r = r;
        }
        public void Print()
        {
            Console.WriteLine("Коордыинты: {0}{1}{2}", x, y, z);
        }
        public double Объём()
        {
            int stepen = 3;
            double rrr = Math.Pow(r, stepen);
            return ((3 / 4) * Math.PI * rrr);
        }
        public Точка xyz
        {
            get { return new Точка(x, y, z); }
            set
            {
                x = value.X;
                y = value.Y;
                z = value.Z;
            }
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
        public double Площадь
        {
            get
            {
                int stepen = 2;
                double rr = Math.Pow(r, stepen);
                return (4 * Math.PI * rr);
            }
        }
        public double this[int i]
        {
            get
            {
                if (i == 0) return x;
                if (i == 1) return y;
                if (i == 2) return z;
                else throw new Exception("Ошибка: ");
            }
        }
        public static Шар operator ++(Шар r)
        {
            r.x++;
            r.y++;
            r.z++;
            r.r++;
            return r;
        }
        public static Шар operator --(Шар t)
        {
            t.x--;
            t.y--;
            t.z--;
            t.r--;
            return t;
        }
        public static bool operator true(Шар e) 
        {
            if (e.z >= 0) return true;
            else return false;
        }
        public static bool operator false(Шар e) 
        {
            if (e.z < 0) return false;
            else return true;
        }
    }
}
