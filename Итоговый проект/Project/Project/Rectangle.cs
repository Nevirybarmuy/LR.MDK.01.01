using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Rectangle : Shape
    {
         private double length;
        private double width;

        public override void InputParameters()
        {
            Console.WriteLine("Введите длину прямоугольника");
            length = GetPositiveDouble();
            Console.WriteLine("Введите ширину прямоугольника");
            width = GetPositiveDouble();
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
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
