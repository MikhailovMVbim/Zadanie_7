using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            CalcCube(a,out V, out S);
            Console.WriteLine();
            Console.WriteLine("Объем куба равен {0}, а площадь поверхности куба равна: {1}",V,S);
            Console.ReadKey();
        }
        static void CalcCube (int a, out double V, out double S)
        {
            V = Math.Pow(a,3);
            S = 6 * a * a;
        }
    }
}
