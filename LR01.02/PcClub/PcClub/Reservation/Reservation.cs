using System;
using PcClub.Computer;
using PcClub.ClientBase;

namespace PcClub.Reservations
{
    public class Reservation
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Pc Computer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalPrice { get; set; }
        public Reservation(int id, Client client, Pc computer, DateTime startTime, int hours)
        {
            Id = id;
            Client = client;
            Computer = computer;
            StartTime = startTime;
            EndTime = startTime.AddHours(hours);
            TotalPrice = computer.PricePerHour * hours;
            computer.IsAvailable = false;
        }
        public string GetInfo()
        {
            return $"Бронь #{Id}: {Client.Name} - {Computer.Name} с {StartTime:HH:mm} до {EndTime:HH:mm}, Сумма: {TotalPrice} руб.";
        }
    }
}