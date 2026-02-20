namespace PcClub.ClientBase
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        // Конструктор
        public Client(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        // Дополнительный конструктор для тестов (если нужен)
        public Client(string name, string surname, int age, bool isActive)
        {
            Name = $"{name} {surname}";
            // Другие свойства...
        }

        // Метод Add() - если он действительно нужен
        public bool Add()
        {
            try
            {
                // Логика добавления в базу данных
                // Возвращаем true при успехе
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}