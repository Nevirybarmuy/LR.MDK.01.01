using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool exit = false;

                while (!exit)
                {
                    Console.Clear();
                    Console.WriteLine(" ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА ФИГУР ");
                    Console.WriteLine("Выберите фигуру:");
                    Console.WriteLine("1 - Круг");
                    Console.WriteLine("2 - Квадрат");
                    Console.WriteLine("3 - Прямоугольник");
                    Console.WriteLine("4 - Треугольник");
                    Console.WriteLine("5 - Выход");
                    Console.Write("Ваш выбор: ");

                    string choice = Console.ReadLine();
                    Shape shape = null;

                    switch (choice)
                    {
                        case "1":
                            shape = new Circle();
                            break;
                        case "2":
                            shape = new Square();
                            break;
                        case "3":
                            shape = new Rectangle();
                            break;
                        case "4":
                            shape = new Triangle();
                            break;
                        case "5":
                            exit = true;
                            continue;
                        default:
                            Console.WriteLine("Неверный выбор! Нажмите любую клавишу...");
                            Console.ReadKey();
                            continue;
                    }

                    // Ввод параметров для выбранной фигуры
                    shape.InputParameters();

                    // Расчёт и вывод результатов
                    Console.WriteLine("\n РЕЗУЛЬТАТЫ РАСЧЁТА ");
                    Console.WriteLine($"Площадь: {shape.CalculateArea():F2}");
                    Console.WriteLine($"Периметр: {shape.CalculatePerimeter():F2}");

                    Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                    Console.ReadKey();
                }
            }
        }
    }
}