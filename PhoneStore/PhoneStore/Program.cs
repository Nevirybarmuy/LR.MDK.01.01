using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void MostSaled(int[] price, int[] AmountSaled, string[] Phone) //Определяю функицю 
        {
            int MaxSaledPhone = 0;
            int MinSaledPhone = 0;
            int MaxSaled = price[MaxSaledPhone] * AmountSaled[MaxSaledPhone];
            int MinSaled = price[MinSaledPhone] * AmountSaled[MinSaledPhone];
            for (int index = 0; index < AmountSaled.Length; index++)
            {
                int Sale = price[index] * AmountSaled[index];
                if (MaxSaled < Sale)
                {
                    MaxSaled = Sale;
                    MaxSaledPhone = index;
                }
            }
            for (int index = 0; index < AmountSaled.Length; index++)
            {

                int Sale = price[index] * AmountSaled[index];
                if (MinSaled > Sale & MinSaled != 0)
                {
                    MinSaled = Sale;
                    MinSaledPhone = index;
                }
            }
            // Вывод результата
            Console.WriteLine($"Самый продаваемый телефон - {Phone[MaxSaledPhone]}");
            Console.WriteLine("Сумма продаж - " + MaxSaled);
            Console.WriteLine();
            Console.WriteLine($"Телефон с наименьшим фактором продаж - {Phone[MinSaledPhone]}");
            Console.WriteLine("Сумма продаж - " + MinSaled);
        }
        static int AllSales(int[] price, int[] AmountSaled, DateTime[] Time) // Определение функции
        {
            int AllSale = 0;
            Console.WriteLine("Введите номер интересущего вас временного отрывка");
            for (int index = 0; index < price.Length; index++)
            {
                Console.WriteLine($"Временной отрывок {index} - " + Time[index]);
            }
            int UserTime = Convert.ToInt32(Console.ReadLine());
            AllSale = price[UserTime] * AmountSaled[UserTime];
            return AllSale; //Вывод результата
        }
        static void Main()
        {
            string[] Phone = new string[] { "Iphone 15", "Iphone 11", "Iphone 12 mini", "Iphone 13", "Iphone 16 PRO MAX" };
            int[] Price = new int[] { 110000, 15000, 20000, 35000, 155499 };
            int[] CountSaled = new int[] { 3, 10, 2, 80, 1 };
            DateTime date1 = new DateTime(2025, 3, 11, 12, 35, 0);
            DateTime date2 = new DateTime(2025, 3, 11, 15, 0, 0);
            DateTime date3 = new DateTime(2025, 3, 12, 10, 25, 0);
            DateTime date4 = new DateTime(2025, 3, 11, 13, 45, 0);
            DateTime date5 = new DateTime(2025, 3, 11, 16, 5, 0);
            DateTime[] Time = new DateTime[] { date1, date2, date3, date4, date5 };
            int AllSaled = AllSales(Price, CountSaled, Time);
            Console.WriteLine("Общая сумма продаж за выбранный период = " + AllSaled);
            Console.WriteLine();
            MostSaled(Price, CountSaled, Phone);
        }
    }
}