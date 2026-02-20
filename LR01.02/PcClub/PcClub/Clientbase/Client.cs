using System;

namespace PcClub.ClientBase
{
    public class Client
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        public string Phone { get; set; }
        public Client(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
        public string GetInfo()
        {
            return $"Клиент: {Name} | Телефон: {Phone}";
        }
    }
}