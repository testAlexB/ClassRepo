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
            products.Add(new Water("Сенежская", 42, 2));
            products.Add(new Water("Святой источник", 5, 10));

            Print(products);

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
