using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Circle : Shape
    {
        private double radius;

        public override void InputParameters()
        {
            Console.WriteLine("Введите радиус круга ");
            radius = GetPositiveDouble();
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
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
