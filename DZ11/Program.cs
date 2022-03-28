using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.");
            Console.Write("k= ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());

            LinUrovnenie linUrovnenie = new LinUrovnenie(k, b);
            Console.WriteLine(linUrovnenie.Root());
            Console.ReadKey();
        }
    }
}
