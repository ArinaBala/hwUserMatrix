using System;
using System.Collections.Generic;
using System.Text;

namespace hwUserMatrix
{
    internal class Matrix
    {
        private int[,] data;
        public int Rows
        {
            get 
            {
                return data.GetLength(0); 
            }
        }

        public int Cols
        {
            get 
            {
                return data.GetLength(1);
            }
        }
        public Matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }
        public int this[int row, int col]
        {
            get
            {
                return data[row, col];
            }
            set
            {
                data[row, col] = value;
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                Console.WriteLine("помилка: додавати можна лише матриці однакового розміру");
                return null;
            }

            Matrix result = new Matrix(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j]; 
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                Console.WriteLine("помилка: віднімати можна лише матриці однакового розміру");
                return null;
            }

            Matrix result = new Matrix(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix m, int number)
        {
            Matrix result = new Matrix(m.Rows, m.Cols);
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    result[i, j] = m[i, j] * number;
                }
            }
            return result;
        }
        public static Matrix operator *(int number, Matrix m)
        {
            return m * number;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Cols != m2.Rows)
            {
                Console.WriteLine("помилка: кількість стовпчиків 1 матриці має дорівнювати кількості рядків 2");
                return null;
            }

            Matrix result = new Matrix(m1.Rows, m2.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m1.Cols; k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (ReferenceEquals(m1, m2))
            {
                return true;
            }
            if (m1 is null || m2 is null)
            {
                return false;
            }

            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                return false;
            }
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    if (m1[i, j] != m2[i, j]) return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Matrix other)
            {
                return this == other;
            }
            return false;
        }
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"{data[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    }
}
