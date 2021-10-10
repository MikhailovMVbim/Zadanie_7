using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные первого треугольника:");
            double s1 = CalcTriangleSquare();
            Console.WriteLine("Введите данные второго треугольника:");
            double s2 = CalcTriangleSquare();
            Console.WriteLine();
            if (s1>s2)
            {
                Console.WriteLine("Площадь первого треугольника {0:f2} больше площади второго треугольника {1:f2}.",s1,s2);
            }
            else if (s1==s2)
            {
                Console.WriteLine("Площади треугольников равны {0}.",s1);
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника {0:f2} больше площади первого треугольника {1:f2}.", s2, s1);
            }
            Console.ReadKey();
        }

        static double CalcTriangleSquare ()
        {
            Console.Write("Длина стороны а:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Длина стороны b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Длина стороны c:");
            int c = Convert.ToInt32(Console.ReadLine());
            double P = a + b + c;
            double p2 = P / 2;
            double S=Math.Sqrt(p2*(p2-a)*(p2-b)*(p2-c));
            return S;
        }
    }
}
