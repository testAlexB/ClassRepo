using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;

namespace Discounts
{
    internal class Program
    {
        static void Main()
        {

            List<Product> products = new List<Product>();
            products.Add(new Milk("Дубрава, 100 мл.", 100.0, 10));
            products.Add(new Milk("Простоквашино.", 500.0, 2));
            products.Add(new Water("Сенежская", 42, 2));
            products.Add(new Water("Святой источник", 5, 10));
            products.Add(new Product("Просто товар", 1, 1));

            //Print(products);


            string fileName = "products.csv";
            string fullPathToFile = Directory.GetCurrentDirectory() + "\\" + fileName;
            if (SaveToCSV(fileName, products))
            {
                Console.WriteLine($"Информация в файл {fullPathToFile} сохранена");
            }
            else
            {
                Console.WriteLine($"Сохранение в файл {fullPathToFile} выполнить не удалось");
            }

            List<Product> productsFromFile = LoadProductsFromCSVFile(fullPathToFile);
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

        static bool SaveToCSV(string fileName, List<Product> p)
        {
            if(File.Exists(fileName)) 
            {
                File.Delete(fileName);
            }

            /// создали объект типа StreamWriter, позволяющий сохранять текст в файл с названием fileName
            StreamWriter outputFile = new StreamWriter(fileName);

            foreach (Product product in p) 
            {
                string csvLine =  product.GetName() + ";" 
                                  + product.GetPrice() + ";" 
                                  + product.GetQuantity();

                outputFile.WriteLine(csvLine);
            }


            outputFile.Dispose(); /// перенести накопленный текст в файл

            return File.Exists(fileName);
        }

        static List<Product> LoadProductsFromCSVFile(string fileName)
        {
            List<Product> result = new List<Product>();

            string contents = File.ReadAllText(fileName);
            string[] rows = contents.Split('\n');

            foreach (string row in rows) 
            {
                string[] data = row.Split(';');
                if(data.Length != 3)
                {
                    continue;
                }

                Product product = new Product(data[0], Convert.ToDouble(data[1]), Convert.ToInt32(data[2]));
                result.Add(product);
            }

            return result;
        }
    }
}
