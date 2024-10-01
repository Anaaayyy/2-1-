using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_
{
    class Car
    {
        // Публичные поля для хранения информации о машине
        public string Make;
        public string Model;
        public int Year;
        public double Price;

        // Конструктор для инициализации объекта класса Car
        public Car(string make, string model, int year, double price)
        {
            Make = make;// Устанавливается марку автомобиля
            Model = model;
            Year = year;
            Price = price;
        }

        // Метод для расчета цены с учётом скидки
        public double GetPriceWithDiscount(double discountPercentage) => Price * (1 - discountPercentage / 100);

        // Метод для расчета цены с учётом НДС
        public double GetPriceWithTax(double taxPercentage) => Price * (1 + taxPercentage / 100);
    }

    class Program
    {
        static void Main()
        {
            var car = new Car("Chevrolet Camaro", "Convertible", 1968, 50000);

            Console.WriteLine($"Марка: {car.Make}, Модель: {car.Model}, Год: {car.Year}, Цена: {car.Price} USD");
            Console.WriteLine($"Цена с 10% скидкой: {car.GetPriceWithDiscount(10)} USD");
            Console.WriteLine($"Цена с 20% НДС: {car.GetPriceWithTax(20)} USD");
            Console.ReadLine();
        }
    }
}
