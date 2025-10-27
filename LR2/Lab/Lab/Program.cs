using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var clients = new List<Client>
        {
            new Client { Name = "Иванов", Services = new List<string> { "стрижка", "укладка" } },
            new Client { Name = "Петрова", Services = new List<string> { "маникюр" } }
        };

        Console.Write("Введите услугу: ");
        string service = Console.ReadLine();

        var results = clients
            .Select(c => new { c.Name, Count = c.Services.Count(s => s == service) })
            .Where(x => x.Count > 0)
            .OrderByDescending(x => x.Count)
            .ToList();

        Console.WriteLine("\nРезультаты:");
        foreach (var client in results)
        {
            Console.WriteLine($"{client.Name} - {client.Count} раз");
        }

        Console.ReadKey();
    }
}