using System;
using System.Collections.Generic;

namespace Discounts
{
    internal class Program
    {
        static void Main()
        {

            List<Product> products = new List<Product>();
            products.Add(new Milk("Дубрава, 100 мл.", 100.0, 10));
            products.Add(new Milk("Простоквашино.", 500.0, 2));
            products.Add(new Water("Сенежская", 42, 6));
            products.Add(new Water("Святой источник", 5, 10));
            products.Add(new Product("Просто товар", 1, 1));


            ProductCSVFile csvFile = new ProductCSVFile("products.csv");
            string fullPathToFile = csvFile.GetFullPathToFile();

            if (csvFile.SaveToCSV(products))
            {
                Console.WriteLine($"Информация в файл {fullPathToFile} сохранена");
            }
            else
            {
                Console.WriteLine($"Сохранение в файл {fullPathToFile} выполнить не удалось");
            }

            //List<Product> productsFromFile = csvFile.LoadProductsFromCSVFile();
            List<Product> productsFromFile = csvFile.StreamReadFile();
            Print(productsFromFile);

            Console.ReadKey();
        }

        static void Print(List<Product> products) 
        {
            foreach (Product product in products) 
            {
                string result = product.GetName() 
                    + ", количество: " + product.GetQuantity()
                    + ", скидка: " + product.GetDiscount() * 100.0 + "%"
                    + ", цена за единицу: " + product.GetPrice()
                    + ", стоимость со скидкой: " + product.GetCost();

                Console.WriteLine(result);
            }
        }
    }
}
