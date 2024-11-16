using System.Collections.Generic;
using System.IO;
using System;

namespace Discounts
{
    public class ProductCSVFile
    {
        private string fileName_;
        public ProductCSVFile(string fileName)
        {
            fileName_ = fileName;
        }

        public string GetFullPathToFile()
        {
            return Directory.GetCurrentDirectory() + "\\" + fileName_;
        }

        public bool SaveToCSV(List<Product> p)
        {
            if (File.Exists(fileName_))
            {
                File.Delete(fileName_);
            }

            /// создали объект типа StreamWriter, позволяющий сохранять текст в файл с названием fileName_
            StreamWriter outputFile = new StreamWriter(fileName_);

            foreach (Product product in p)
            {
                string csvLine = product.GetName() + ";"
                                  + product.GetPrice() + ";"
                                  + product.GetQuantity() + ";"
                                  + product.GetType().Name;

                outputFile.WriteLine(csvLine);
            }


            outputFile.Dispose(); /// перенести накопленный текст в файл

            return File.Exists(fileName_);
        }

        public List<Product> LoadProductsFromCSVFile()
        {
            List<Product> result = new List<Product>();

            string contents = File.ReadAllText(GetFullPathToFile());
            string[] rows = contents.Split('\n');

            foreach (string row in rows)
            {
                string[] data = row.Split(';');
                if (data.Length != 4)
                {
                    continue;
                }

                string type = data[3];
                type = type.Remove(type.Length - 1);
                Console.WriteLine(type);
                string nameProduct = data[0];
                double price = Convert.ToDouble(data[1]);
                int quantity = Convert.ToInt32(data[2]);

                if (type == "Milk")
                {
                    result.Add(new Milk(nameProduct, price, quantity));
                }
                else if (type == "Water")
                {
                    result.Add(new Water(nameProduct, price, quantity));
                }
                else
                {
                    result.Add(new Product(nameProduct, price, quantity));
                }
            }

            return result;
        }
    }
}
