using System;
using System.Collections.Generic;
using MyMatrix;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Matrix matrix = new Matrix();
            matrix.SetColumnCount(10);
            Console.WriteLine("init matrix");
            Console.WriteLine(matrix.ToFormattedString());
            matrix.AddRow(new List<int> { 1, 2 });
            matrix.AddRow(new List<int> { 1, 2, 3, 4, 5 });
            matrix.AddRow(new List<int> { 2, 3, 4, 5, 6, 7, 8});

            Console.WriteLine("after AddRow matrix");
            Console.WriteLine(matrix.ToFormattedString());

            Console.ReadKey();
        }
    }
}
