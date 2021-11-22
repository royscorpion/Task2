using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввод исходных данных
            Console.WriteLine("Введите координаты трех вершин треугольника");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Вычисления
            double side_a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double side_b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double side_c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double perimeter = side_a + side_b + side_c;
            double semiperimeter = perimeter / 2;
            double square = Math.Sqrt(semiperimeter * (semiperimeter - side_a) * (semiperimeter - side_b) * (semiperimeter - side_c));
            #endregion

            #region Вывод результатов
             Console.WriteLine("Периметр треугольника = {0}", perimeter);
             Console.WriteLine("Площадь треугольника = {0}", square);
             #endregion
            
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
