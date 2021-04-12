using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._04._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.17 a


            Console.WriteLine("1.17 a");
            Console.WriteLine(" Введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double xp = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2,2));


            Console.WriteLine("Ответ:" + x1 + x2);
            


            //1.17 b


            Console.WriteLine("1.17 b");
            Console.WriteLine(" Введите число x1");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите число x3");
            double c3 = Convert.ToDouble(Console.ReadLine());
            double c4 = c1 * c2 + c1 * c3 + c2 * c3;
            Console.WriteLine("Ответ:" + c4);
            Console.ReadKey();


            //1.17 c
            Console.WriteLine("1.17 c");
            Console.WriteLine(" Введите число v0");
            double v0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число t");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double a1 =v0 * t +(a * t / 2);
            Console.WriteLine("Ответ:" + a1);
            Console.ReadKey();


            //1.17 d
            Console.WriteLine("1.17 d");
            Console.WriteLine(" Введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число n");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число h");
            double h = Convert.ToDouble(Console.ReadLine());
            double h1 = m * v0 + (m * n + g * h / 2);
            Console.WriteLine("Ответ:" + h1);
            Console.ReadKey();

            //1.17 e
            Console.WriteLine("1.17 e");
            Console.WriteLine(" Введите число R1");
            double R1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число R2");
            double R2 = Convert.ToDouble(Console.ReadLine());
            double R = 1 / R1 + 1 / R2;
            Console.WriteLine("Ответ:" + R);
            Console.ReadKey();

            //1.17 f
            Console.WriteLine("1.17 f");
            Console.WriteLine(" Введите число s1");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число w");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число cosa");
            double cosa = Convert.ToDouble(Console.ReadLine());
            double q2 = s * w * cosa;
            Console.WriteLine("Ответ:" + 1234);
            Console.ReadKey();















        }






    }
}
