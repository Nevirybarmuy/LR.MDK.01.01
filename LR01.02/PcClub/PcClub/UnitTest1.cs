using Microsoft.VisualStudio.TestTools.UnitTesting;
using PcClub.Club;
using PcClub;
using PcClub.Computer;
using PcClub.ClientBase;
using PcClub.Reservations;
using System;
using System.Linq;

namespace PcClub.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Club club;

        // Этот метод выполняется перед каждым тестом - используем TestInitialize, а не TestMethod
        [TestInitialize]
        public void Setup()
        {
            club = new Club();
        }

        // Тест 1: Добавление компьютера
        [TestMethod]
        public void AddComputer_ShouldIncreaseComputerCount()
        {
            // Arrange (подготовка)
            int initialCount = club.GetComputersCount();

            // Act (действие)
            club.AddComputer("Test PC", "Test Specs", 100);

            // Assert (проверка)
            int newCount = club.GetComputersCount();
            Assert.IsTrue(newCount > initialCount, "Количество компьютеров должно увеличиться");
        }

        // Тест 2: Добавление клиента
        [TestMethod]
        public void AddClient_ShouldIncreaseClientCount()
        {
            // Arrange
            int initialCount = club.GetClientsCount();

            // Act
            club.AddClient("Тест Клиент", "+7(999)111-22-33");

            // Assert
            int newCount = club.GetClientsCount();
            Assert.IsTrue(newCount > initialCount, "Количество клиентов должно увеличиться");
        }

        // Тест 3: Бронирование компьютера
        [TestMethod]
        public void MakeReservation_ShouldChangeComputerAvailability()
        {
            // Arrange
            club.AddComputer("Test PC", "Test Specs", 100);
            club.AddClient("Тест Клиент", "+7(999)111-22-33");

            // Act
            club.MakeReservation(1, 1, 2);

            // Assert
            bool isAvailable = club.IsComputerAvailable(1);
            Assert.IsFalse(isAvailable, "Компьютер должен быть занят после бронирования");
        }

        // Тест 4: Освобождение компьютера
        [TestMethod]
        public void ReleaseComputer_ShouldMakeComputerAvailable()
        {
            // Arrange
            club.AddComputer("Test PC", "Test Specs", 100);
            club.AddClient("Тест Клиент", "+7(999)111-22-33");
            club.MakeReservation(1, 1, 2);

            // Act
            club.ReleaseComputer(1);

            // Assert
            bool isAvailable = club.IsComputerAvailable(1);
            Assert.IsTrue(isAvailable, "Компьютер должен быть свободен после освобождения");
        }

        // Тест 5: Проверка создания компьютера
        [TestMethod]
        public void Computer_Creation_ShouldSetCorrectProperties()
        {
            // Arrange & Act
            Pc computer = new Pc(1, "Test PC", "i5, 16GB RAM", 150);

            // Assert
            Assert.AreEqual(1, computer.Id);
            Assert.AreEqual("Test PC", computer.Name);
            Assert.AreEqual("i5, 16GB RAM", computer.Specifications);
            Assert.AreEqual(150, computer.PricePerHour);
            Assert.IsTrue(computer.IsAvailable);
        }

        // Тест 6: Проверка создания клиента
        [TestMethod]
        public void Client_Creation_ShouldSetCorrectProperties()
        {
            // Arrange & Act
            Client client = new Client(1, "Иван Иванов", "+7(999)123-45-67");

            // Assert
            Assert.AreEqual(1, client.Id);
            Assert.AreEqual("Иван Иванов", client.Name);
            Assert.AreEqual("+7(999)123-45-67", client.Phone);
        }

        // Тест 7: Проверка создания бронирования
        [TestMethod]
        public void Reservation_Creation_ShouldCalculateCorrectPrice()
        {
            // Arrange
            Pc computer = new Pc(1, "Test PC", "Specs", 200);
            Client client = new Client(1, "Test Client", "123456");
            DateTime startTime = DateTime.Now;
            int hours = 3;

            // Act
            Reservation reservation = new Reservation(1, client, computer, startTime, hours);

            // Assert
            Assert.AreEqual(1, reservation.Id);
            Assert.AreEqual(client, reservation.Client);
            Assert.AreEqual(computer, reservation.Computer);
            Assert.AreEqual(startTime, reservation.StartTime);
            Assert.AreEqual(startTime.AddHours(hours), reservation.EndTime);
            Assert.AreEqual(600, reservation.TotalPrice); // 200 * 3 = 600
            Assert.IsFalse(computer.IsAvailable); // Компьютер должен стать занятым
        }
    }
}