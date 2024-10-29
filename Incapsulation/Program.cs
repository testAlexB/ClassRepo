using System;

namespace Incapsulation
{
    internal class Program
    {
        static void Main()
        {
            SalesHistory history = new SalesHistory();
            history.AddSale(
                new Sale(167)
                .SetFactSale(new Product("Колбаса копченая", 1100), 0.1));

            history.AddSale(
                new Sale(167)
                .SetFactSale(new Product("Творог воздушный", 550), 0.5));

            history.AddSale(
                new Sale(7)
                .SetFactSale(new Product("Колбаса копченая", 550), 0.7));

            Console.WriteLine("cost = " + history.CalcCost());

            /// ДЗ: вывести на экран чеки (товар, дата, количество, стоимость)

            Console.ReadKey();
        }
    }
}
