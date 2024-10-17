using System;
using System.Collections.Generic;

namespace MyMatrix
{
    public class Matrix
    {
        private List<int> row_ = new List<int>();
        private int columnCount_;

        public Matrix(int columnCount)
        {
            row_ = new List<int>();
            columnCount_ = columnCount;
        }

        public Matrix(List<int> rowZZZZZZZZZZZZZZZZ, int columnCount)
        {
            columnCount_ = columnCount;
            row_ = rowZZZZZZZZZZZZZZZZ;
        }

        public void SetColumnCount(int c)
        {
            columnCount_ = c;
        }

        public void AddRow(List<int> r)
        {
            if(r.Count == columnCount_)
            {
                row_.AddRange(r);
                return;
            }

            if(r.Count < columnCount_)
            {
                row_.AddRange(r);
                int s = columnCount_ - r.Count;
                for(int i = 0; i < s; i++) 
                {
                    row_.Add(0);
                }

                return;
            }

            for(int i = 0; i < columnCount_; i++) 
            {
                row_.Add(r[i]);
            }
        }

        public string ToFormattedString()
        {
            string result = string.Empty;

            for(int rowIndex = 0; rowIndex < row_.Count; rowIndex = rowIndex + columnCount_)
            {
                List<string> row = new List<string>();
                for (int column = 0; column < columnCount_; ++column)
                {
                    int elementIndex = rowIndex + column;
                    int element = row_[elementIndex];
                    row.Add(Convert.ToString(element));
                }

                result += String.Join(" ", row) + "\n";
            }

            return result;
        }

        public void AddDefaultColumn()
        {
            /// ДЗ: реализовать добавление столбца со всеми нулями
        }

        public string CellValue(int indexRow, int indexColumn)
        {
            int indexElement = indexRow * columnCount_ + indexColumn;
            if (indexElement < 0 || indexElement >= row_.Count)
            {
                return "Значения нет";
            }

            return Convert.ToString(row_[indexElement]);
        }

        public int RowCount()
        {
            return row_.Count / columnCount_;
        }

        public List<int> Row(int indexRow)
        {
            int indexStartRow = indexRow * columnCount_;
            List<int> result = new List<int>();
            for (int i = indexRow; i < indexStartRow + columnCount_; ++i)
            {
                result.Add(row_[i]);
            }

            return result;
        }

        public int ColumnCount()
        {
            return columnCount_;
        }

        public string SumMainDiagonal()
        {
            if(RowCount() != columnCount_)
            {
                return "Матрица не квадратная";
            }

            int result = 0;
            for(int indexColumn = 0; indexColumn < columnCount_; indexColumn++) 
            {
                int indexRow = indexColumn;
                int element = Convert.ToInt32(CellValue(indexRow, indexColumn)); 
                result += element;
            }

            return Convert.ToString(result);
        }


    }
}
