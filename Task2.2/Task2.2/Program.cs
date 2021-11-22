using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввод исходных данных
            Console.WriteLine("Введите координаты двух противоположных вершин прямоугольника.");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Вычисления
            double length_A = Math.Abs(x2 - x1);
            double length_B = Math.Abs(y2 - y1);
            double perimeter = 2 * (length_A + length_B);
            double square = length_A * length_B;
            #endregion

            #region Вывод результатов
            Console.WriteLine("Периметр прямоугольника = {0}", perimeter);
            Console.WriteLine("Площадь прямоугольника = {0}", square);
            #endregion

            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
