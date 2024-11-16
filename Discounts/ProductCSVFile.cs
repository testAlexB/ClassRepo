using System.Collections.Generic;
using System.IO;
using System;
using System.Runtime.Remoting.Messaging;

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
                result.Add(ProcessCSVLine(row));
            }

            return result;
        }

        public List<Product> StreamReadFile()
        {
            StreamReader stream = new StreamReader(fileName_);

            string line;
            List<Product> result = new List<Product>();
            while ((line = stream.ReadLine()) != null)
            {
                result.Add(ProcessCSVLine((line)));
            }

            return result;
        }

        static private Product ProcessCSVLine(string row)
        {
            string[] data = row.Split(';');
            if (data.Length != 4)
            {
                return new Product();
            }

            string type = data[3];
            if (type.Contains("\\r"))
            {
                type = type.Remove(type.Length - 1);
            }

            string nameProduct = data[0];
            double price = Convert.ToDouble(data[1]);
            int quantity = Convert.ToInt32(data[2]);

            if (type == "Milk")
            {
                return new Milk(nameProduct, price, quantity);
            }
            else if (type == "Water")
            {
                return new Water(nameProduct, price, quantity);
            }

             return new Product(nameProduct, price, quantity);
        }
    }
}
