using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Triangle : Shape
    {
        private double sideA, sideB, sideC;

        public override void InputParameters()
        {
            Console.WriteLine("Введите стороны треугольника");
            Console.WriteLine("Сторона a: ");
            sideA = GetPositiveDouble();
            Console.WriteLine("Сторона b: ");
            sideB = GetPositiveDouble();
            Console.WriteLine("Сторона c: ");
            sideC = GetPositiveDouble();

            // Проверка неравенства треугольника
            if (!IsValidTriangle())
            {
                Console.WriteLine("Ошибка! Треугольник с такими сторонами не существует.");
                Console.WriteLine("Нажмите любую клавишу для повторного ввода...");
                Console.ReadKey();
                Console.Clear();
                InputParameters(); // Рекурсивный повтор ввода
            }
        }

        private bool IsValidTriangle()
        {
            return sideA + sideB > sideC &&
                   sideA + sideC > sideB &&
                   sideB + sideC > sideA;
        }

        public override double CalculateArea()
        {
            // Формула Герона
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        private double GetPositiveDouble()
        {
            double value;
            Console.Write("Введите положительное число: ");

            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Ошибка! Введите положительное число: ");
            }

            return value;
        }
    }
}
