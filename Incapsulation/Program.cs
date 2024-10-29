using System;
using System.Collections.Generic;

namespace Incapsulation
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Product> allProducts = FetchProductsInfo();
            SalesHistory history = new SalesHistory();
            history.AddSale(
                new Sale(167)
                .SetFactSale(allProducts["Колбаса копченая"], 0.1));

            history.AddSale(
                new Sale(167)
                .SetFactSale(allProducts["Творог воздушный"], 0.5));

            history.AddSale(
                new Sale(7)
                .SetFactSale(allProducts["Колбаса копченая"], 0.7));

            Console.WriteLine("cost = " + history.CalcCost());

            /// ДЗ: вывести на экран чеки (товар, дата, количество, стоимость)
            /// + разобраться с тем, почему стало 1135. Должно быть 770

            Console.ReadKey();
        }


        private static Dictionary<string, Product> FetchProductsInfo()
        {
            Dictionary<string, Product> result = new Dictionary<string, Product> ();
            result.Add("Колбаса копченая", new Product("Колбаса копченая", 1100.0));
            result.Add("Творог воздушный", new Product("Творог воздушный", 550.0));

            return result;
        }
    }
}
