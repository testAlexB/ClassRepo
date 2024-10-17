using System.Collections.Generic;

namespace MyMatrix
{
    public class MatrixOperations
    {
        //ДЗ: доработать, чтобы складывадись все строчки
        // + сложение матриц с разныи числом строк
        public static Matrix Steplers(Matrix m1, Matrix m2)
        {
           Matrix result = new Matrix(m1.ColumnCount() + m2.ColumnCount());
           if(m1.RowCount() == m2.RowCount())
           {
                List<int> rowM1 = m1.Row(0);
                List<int> rowM2 = m2.Row(0);
                rowM1.AddRange(rowM2);

                result.AddRow(rowM1);
            }

           return result;
        }
    }
}
