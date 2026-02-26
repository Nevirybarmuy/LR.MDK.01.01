using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Square : Shape
    {
        
        private double side;

        public override void InputParameters()
        {
            Console.WriteLine("Введите сторону квадрата");
            side = GetPositiveDouble();
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * side;
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
