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
            matrix.SetColumnCount(4);
            Console.WriteLine("init matrix");
            Console.WriteLine(matrix.ToFormattedString());
            matrix.AddRow(new List<int> { 1, 2 });
            matrix.AddRow(new List<int> { 1, 2, 3 });
            matrix.AddRow(new List<int> { 2, 3, 4 });
            matrix.AddRow(new List<int> { 2, 3, 4, 5, 6, 7});

            Console.WriteLine("after AddRow matrix");
            Console.WriteLine(matrix.ToFormattedString());

            Console.WriteLine("cell value (0, 3) = " + matrix.CellValue(0, 3));
            Console.WriteLine("cell value (1, 3) = " + matrix.CellValue(1, 3));
            Console.WriteLine("cell value (2, 5) = " + matrix.CellValue(2, 5));
            Console.WriteLine("cell value (-2, 5) = " + matrix.CellValue(-2, 5));

            Console.WriteLine("sum main diagonal: " + matrix.SumMainDiagonal());

            Console.ReadKey();
        }
    }
}
