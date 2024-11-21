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

            var checks = GroupInfoByNumberCheck(history);
            foreach (KeyValuePair<int,SalesHistory> check in checks) 
            {
                Console.WriteLine("Номер чека " +  check.Key);
                List<Sale> sales = check.Value.GetSales();
                foreach (Sale s in sales)
                {
                    Console.WriteLine(s.ConvertToString());
                }

                Console.WriteLine("------------------------------------");
            }

            Console.ReadKey();
        }

        private static Dictionary<int, SalesHistory> GroupInfoByNumberCheck(SalesHistory allSales)
        {
            Dictionary<int, SalesHistory> result = new Dictionary<int, SalesHistory>();

            /// 1. Перебор всех продаж, которые есть
            /// 2. Рассматриваем конкретную продажу, интересовать будет номер чека
            /// 3. Под соответствующим ключом (собстенно, номером чека), сохраняем продажу в словарь
            

            List<Sale> sales = allSales.GetSales();
            foreach (Sale sale in sales)
            {
                int check = sale.Check();
                if (result.ContainsKey(check))
                {
                    result[check].AddSale(sale);
                }
                else
                {
                    SalesHistory s = new SalesHistory();
                    s.AddSale(sale);
                    result.Add(check, s);
                }
            }

            return result;
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
