using System.Collections;
using System.Text;

namespace Bai06;

public class Program
{
    public class Matrix : IEnumerable<int>
    {
        private static readonly Random rand = new();
        private readonly List<List<int>> matrix;

        public Matrix(int row, int col)
        {
            matrix = new(row);
            for (int i = 0; i < row; ++i)
            {
                matrix.Add(new(col));
                for (int j = 0; j < col; ++j)
                {
                    matrix[i].Add(rand.Next(0, 100));
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (List<int> subList in matrix)
            {
                foreach (int num in subList)
                {
                    yield return num;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (List<int> subList in matrix)
            {
                foreach (int num in subList)
                {
                    sb.AppendFormat("{0,-4} ", num);
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public int FindMax()
        {
            int max = int.MinValue;
            foreach (int num in this)
            {
                max = Math.Max(max, num);
            }
            return max;
        }

        public int FindMin()
        {
            int min = int.MaxValue;
            foreach (int num in this)
            {
                min = Math.Min(min, num);
            }
            return min;
        }

        public int FindRowIndexHasMaxTotal()
        {
            int max = int.MinValue;
            int maxRowIndex = default;
            for (int i = 0; i < matrix.Count; ++i)
            {
                int total = matrix[i].Sum();
                if (total > max)
                {
                    maxRowIndex = i;
                    max = total;
                }
            }
            return maxRowIndex;
        }

        private static bool CheckPrime(int num)
        {
            int lim = (int)Math.Sqrt(num);
            for (int i = 2; i <= lim; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int SumAllNonePrime()
        {
            int res = 0;
            foreach (int num in this)
            {
                if (CheckPrime(num))
                {
                    res += num;
                }

            }
            return res;
        }

        public void RemoveKthRow(int k)
        {
            matrix.RemoveAt(k - 1);
        }

        private int FindMaxElementColIndex()
        {
            int max = int.MinValue;
            int colIndex = 0;
            foreach (List<int> subList in matrix)
            {
                for (int i = 0; i < subList.Count; ++i)
                {
                    if (subList[i] > max)
                    {
                        max = subList[i];
                        colIndex = i;
                    }
                }
            }
            return colIndex;
        }

        public void RemoveColOfMaxVal()
        {
            int colIndex = FindMaxElementColIndex();
            foreach (List<int> subList in matrix)
            {
                subList.RemoveAt(colIndex);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so dong cho matrix: ");
        int row = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Nhap so cot cho matrix: ");
        int col = int.Parse(Console.ReadLine() ?? "");
        Matrix matrix = new(row, col);
        Console.WriteLine("Matrix vua duoc tao:");
        Console.WriteLine(matrix);

        Console.WriteLine($"Phan tu lon nhat: {matrix.FindMax()}");
        Console.WriteLine($"Phan tu nho nhat: {matrix.FindMin()}");

        Console.WriteLine($"Dong (index) co phan tu lon nhat: {matrix.FindRowIndexHasMaxTotal()}");

        Console.WriteLine($"Tong cac so khong la so nguyen to: {matrix.SumAllNonePrime()}");

        Console.Write("Nhap dong thu k de xoa: ");
        int k = int.Parse(Console.ReadLine() ?? "");
        matrix.RemoveKthRow(k);
        Console.WriteLine($"Matrix sau khi xoa dong {k}:");
        Console.WriteLine(matrix);

        matrix.RemoveColOfMaxVal();
        Console.WriteLine("Matrix sau khi xoa cot co gia tri lon nhat:");
        Console.WriteLine(matrix);
    }

}
