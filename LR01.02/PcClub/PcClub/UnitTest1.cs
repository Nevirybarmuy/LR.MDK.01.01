using Microsoft.VisualStudio.TestTools.UnitTesting;
using PcClub.Computer;
using PcClub.ClientBase;
using System;
using System.Linq;

namespace PcClub.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private PcClub.Club.Club club; // Указываем полный путь

        [TestInitialize]
        public void Setup()
        {
            club = new PcClub.Club.Club(); // Полное имя
        }

        [TestMethod]
        public void AddComputer_ShouldIncreaseComputerCount()
        {
            int initialCount = club.GetComputersCount();
            club.AddComputer("Test PC", "Test Specs", 100);
            int newCount = club.GetComputersCount();
            Assert.IsTrue(newCount > initialCount, "Количество компьютеров должно увеличиваться");
        }

        [TestMethod]
        public void AddClient_ShouldAddNewClient()
        {
            string name = "Иван Петров";
            string phone = "+7-999-111-22-33";
            bool result = club.AddClient(name, phone);
            Assert.IsTrue(result, "Клиент должен быть добавлен");
        }
    }
}