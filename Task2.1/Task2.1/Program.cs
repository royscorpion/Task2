using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        // Вычисление радиуса и площади круга, ограниченного окружностью введенной длины
        static void Main(string[] args)
        {
            Console.Write("Введите длину окружности: ");
            double circleLen = Convert.ToDouble(Console.ReadLine());
            double circleRad = circleLen / (2 * Math.PI);
            double circleSquare = Math.PI * Math.Pow(circleRad, 2);
            Console.WriteLine("Радиус окружности R = {0}", circleRad);
            Console.WriteLine("Площадь окружности R = {0}", circleSquare);
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
