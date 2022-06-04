using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shar 
{
    class Program 
    {
        static void Main(string[]args) 
        {
            try
            {
                Шар sh1 = new Шар(2);
                Шар sh2 = new Шар(2, 3, 5, 7);
                sh1.Print();
                sh2.Print();
                Console.WriteLine(sh1.Объём());
                sh1.X = 3;
                sh1.Y = 3;
                sh1.Z = 3;
                Console.WriteLine(sh1.X);
                Console.WriteLine(sh1.Y);
                Console.WriteLine(sh1.Z);
                sh1.xyz = new Точка(2, 3, 5);
                Console.WriteLine(sh1.xyz.Координаты());
                Console.WriteLine(sh2.Площадь);
                try
                {
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("{0}", sh2[i]);
                }
                catch { Console.WriteLine("ne ok"); }
                sh2++;
                sh2.Print();
                if (sh1) Console.WriteLine("ok");
                else Console.WriteLine("ne ok");
            }
            catch 
            {
                Console.WriteLine("Ошибка:");
            }
        }
    }
}
