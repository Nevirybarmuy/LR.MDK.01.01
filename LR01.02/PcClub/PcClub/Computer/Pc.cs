using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcClub.Computer
{
    public class Pc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public decimal PricePerHour { get; set; }
        public bool IsAvailable { get; set; }

        public Pc(int id, string name, string specs, decimal price)
        {
            Id = id;
            Name = name;
            Specifications = specs;
            PricePerHour = price;
            IsAvailable = true;
        }

        public string GetInfo()
        {
            string status = IsAvailable ? "Свободен" : "Занят";
            return $"Компьютер {Name} (ID: {Id}) | {Specifications} | {PricePerHour} руб/час | {status}";
        }
    }

}

