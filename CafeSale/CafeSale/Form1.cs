using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafeSale.Models;

namespace CafeSale
{
    public partial class Form1 : Form
    {
        private List<DrinkSale> drinks = new List<DrinkSale>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            DrinkSale coffee = new DrinkSale();
            coffee.DrinkName = "Кофе";
            coffee.PricePerUnit = 2.5m;
            coffee.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-2), Quantity = 10 });
            coffee.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-1), Quantity = 15 });
            coffee.DailySales.Add(new DaySale { Date = DateTime.Now, Quantity = 12 });
            drinks.Add(coffee);

            DrinkSale tea = new DrinkSale();
            tea.DrinkName = "Чай";
            tea.PricePerUnit = 1.8m;
            tea.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-2), Quantity = 8 });
            tea.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-1), Quantity = 11 });
            tea.DailySales.Add(new DaySale { Date = DateTime.Now, Quantity = 9 });
            drinks.Add(tea);

            DrinkSale juice = new DrinkSale();
            juice.DrinkName = "Сок";
            juice.PricePerUnit = 3.0m;
            juice.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-2), Quantity = 5 });
            juice.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-1), Quantity = 7 });
            juice.DailySales.Add(new DaySale { Date = DateTime.Now, Quantity = 6 });
            drinks.Add(juice);

            DrinkSale lemonade = new DrinkSale();
            lemonade.DrinkName = "Лимонад";
            lemonade.PricePerUnit = 2.2m;
            lemonade.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-2), Quantity = 12 });
            lemonade.DailySales.Add(new DaySale { Date = DateTime.Now.AddDays(-1), Quantity = 9 });
            lemonade.DailySales.Add(new DaySale { Date = DateTime.Now, Quantity = 14 });
            drinks.Add(lemonade);

            foreach (var drink in drinks)
            {
                listBoxDrinks.Items.Add(drink.DrinkName);
            }
        }
        private void listBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrinks.SelectedIndex >= 0)
            {
                ShowDrinkInfo(listBoxDrinks.SelectedIndex);
            }
        }
        private void ShowDrinkInfo(int index)
        {
            panelCharts.Controls.Clear();

            DrinkSale selectedDrink = drinks[index];

            Label lblDrinkName = new Label();
            lblDrinkName.Text = selectedDrink.DrinkName;
            lblDrinkName.Font = new Font("Arial", 14, FontStyle.Bold);
            lblDrinkName.Location = new Point(10, 10);
            lblDrinkName.Size = new Size(200, 25);
            panelCharts.Controls.Add(lblDrinkName);

            Label lblPrice = new Label();
            lblPrice.Text = $"Цена: {selectedDrink.PricePerUnit} руб.";
            lblPrice.Location = new Point(10, 35);
            lblPrice.Size = new Size(150, 20);
            panelCharts.Controls.Add(lblPrice);

            Label lblSales = new Label();
            lblSales.Text = "Продажи по дням:";
            lblSales.Font = new Font("Arial", 10, FontStyle.Bold);
            lblSales.Location = new Point(10, 60);
            lblSales.Size = new Size(150, 20);
            panelCharts.Controls.Add(lblSales);

            int maxQuantity = selectedDrink.DailySales.Max(s => s.Quantity);    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
