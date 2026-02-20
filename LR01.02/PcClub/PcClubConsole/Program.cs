using System;
using PcClub.Club;
using PcClub; 

namespace PcClubConsole
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ДОБРО ПОЖАЛОВАТЬ В ПК КЛУБ ===\n");

            Club club = new Club();

            club.AddComputer("Gaming Ultra", "i7, RTX 3070, 32GB RAM", 200);
            club.AddComputer("Gaming Pro", "i5, RTX 2060, 16GB RAM", 150);
            club.AddComputer("Standart", "i3, GTX 1050, 8GB RAM", 100);
            club.AddComputer("VIP", "i9, RTX 4090, 64GB RAM", 350);

            club.AddClient("Иван Петров", "+7(999)123-45-67");
            club.AddClient("Мария Сидорова", "+7(999)765-43-21");

            club.ShowAllComputers();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}