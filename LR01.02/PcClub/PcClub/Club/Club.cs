using PcClub.ClientBase;
using PcClub.Computer;
using PcClub.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PcClub.Club
{
    public class Club
    {
        private readonly List<Pc> computers = new List<Pc>();
        private readonly List<Client> clients = new List<Client>();
        private readonly List<Reservation> reservations = new List<Reservation>();

        private int nextComputerId = 1;
        private int nextClientId = 1;
        private int nextReservationId = 1; // Можно оставить для будущего использования

        public void AddComputer(string name, string specs, decimal price)
        {
            Pc computer = new Pc(nextComputerId++, name, specs, price);
            computers.Add(computer);
            Console.WriteLine($"Компьютер {name} добавлен!");
        }

        public void ShowAllComputers()
        {
            Console.WriteLine("\n====== ВСЕ КОМПЬЮТЕРЫ ======");
            if (computers.Count == 0)
            {
                Console.WriteLine("Нет компьютеров");
            }
            else
            {
                foreach (var computer in computers)
                {
                    Console.WriteLine($"Компьютер {computer.Name}: {computer.Specs} - {computer.Price} руб.");
                }
            }
        }

        public int GetComputersCount()
        {
            return computers.Count;
        }
            public int GetClientsCount()
            {
                return clients.Count;
            }
            public bool AddClient(string name, string phone)
            {
                // Проверка на дубликаты
                if (clients.Any(c => c.Name == name))
                {
                    return false;
                }

                Client client = new Client(nextClientId++, name, phone);
                clients.Add(client);
                return true;
            }
        
    }
}