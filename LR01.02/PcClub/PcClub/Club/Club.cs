using PcClub.Computer;
using PcClub.Reservations;
using System.Collections.Generic;
using System.Linq;
using System;
using PcClub.ClientBase;

namespace PcClub.Club
{
    public class Club
    {
        private readonly List<Pc> computers = new List<Pc>();
        private readonly List<Client> clients = new List<Client>();
        private readonly List<Reservation> reservations = new List<Reservation>();
        private int nextComputerId = 1;
        private int nextClientId = 1;
        private int nextReservationId = 1;

        public void AddComputer(string name, string specs, decimal price)
        {
            Pc computer = new Pc(nextComputerId++, name, specs, price);
            computers.Add(computer);
            Console.WriteLine($"Компьютер {name} добавлен!");
        }
        public void AddClient(string name, string phone)
        {
            Client client = new Client(nextClientId++, name, phone);
            clients.Add(client);
            Console.WriteLine($"Клиент {name} добавлен!");
        }

        public void ShowAllComputers()
        {
            Console.WriteLine("\n=== ВСЕ КОМПЬЮТЕРЫ ===");
            if (computers.Count == 0)
            {
                Console.WriteLine("Компьютеров нет");
                return;
            }

            foreach (var pc in computers)
            {
                Console.WriteLine(pc.GetInfo());
            }
        }

        // Показать свободные компьютеры
        public void ShowAvailableComputers()
        {
            Console.WriteLine("\n=== СВОБОДНЫЕ КОМПЬЮТЕРЫ ===");
            var available = computers.Where(c => c.IsAvailable).ToList();

            if (available.Count == 0)
            {
                Console.WriteLine("Свободных компьютеров нет");
                return;
            }

            foreach (var pc in available)
            {
                Console.WriteLine(pc.GetInfo());
            }
        }

        // Показать всех клиентов
        public void ShowAllClients()
        {
            Console.WriteLine("\n=== КЛИЕНТЫ ===");
            if (clients.Count == 0)
            {
                Console.WriteLine("Клиентов нет");
                return;
            }

            foreach (var client in clients)
            {
                Console.WriteLine(client.GetInfo());
            }
        }

        // Забронировать компьютер
        public void MakeReservation(int clientId, int computerId, int hours)
        {
            // Ищем клиента
            Client client = clients.FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                Console.WriteLine("Клиент не найден!");
                return;
            }

            // Ищем компьютер
            Pc computer = computers.FirstOrDefault(c => c.Id == computerId);
            if (computer == null)
            {
                Console.WriteLine("Компьютер не найден!");
                return;
            }

            // Проверяем, свободен ли компьютер
            if (!computer.IsAvailable)
            {
                Console.WriteLine("Компьютер уже занят!");
                return;
            }

            // Создаем бронь
            Reservation reservation = new Reservation(nextReservationId++, client, computer, DateTime.Now, hours);
            reservations.Add(reservation);
            Console.WriteLine($"\nБронь создана! {reservation.GetInfo()}");
        }

        // Показать все бронирования
        public void ShowAllReservations()
        {
            Console.WriteLine("\n=== ТЕКУЩИЕ БРОНИРОВАНИЯ ===");
            if (reservations.Count == 0)
            {
                Console.WriteLine("Бронирований нет");
                return;
            }

            foreach (var res in reservations)
            {
                Console.WriteLine(res.GetInfo());
            }
        }

        // Освободить компьютер
        public void ReleaseComputer(int computerId)
        {
            Pc computer = computers.FirstOrDefault(c => c.Id == computerId);
            if (computer == null)
            {
                Console.WriteLine("Компьютер не найден!");
                return;
            }

            if (computer.IsAvailable)
            {
                Console.WriteLine("Компьютер и так свободен!");
                return;
            }

            computer.IsAvailable = true;
            Console.WriteLine($"Компьютер {computer.Name} освобожден!");
        }
    }
}