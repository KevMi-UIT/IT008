namespace Bai03;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static int[,] InputMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Nhap cac phan tu cua ma tran:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhap phan tu [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }
        return matrix;
    }

    static void OutputMatrix(int[,] matrix, int rows, int cols)
    {
        Console.WriteLine("Ma tran:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static bool FindElement(int[,] matrix, int rows, int cols, int target)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == target)
                    return true;
            }
        }
        return false;
    }

    static void OutputPrimes(int[,] matrix, int rows, int cols)
    {
        Console.WriteLine("Cac so nguyen to trong ma tran:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (IsPrime(matrix[i, j]))
                    Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }

    static int FindRowWithMostPrimes(int[,] matrix, int rows, int cols)
    {
        int maxPrimes = 0;
        int rowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int primeCount = 0;
            for (int j = 0; j < cols; j++)
            {
                if (IsPrime(matrix[i, j]))
                    primeCount++;
            }
            if (primeCount > maxPrimes)
            {
                maxPrimes = primeCount;
                rowIndex = i;
            }
        }

        return rowIndex;
    }

    static void Main()
    {
        Console.Write("Nhap so dong: ");
        int rows = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhap so cot: ");
        int cols = int.Parse(Console.ReadLine() ?? "0");

        // Nhập ma trận
        int[,] matrix = InputMatrix(rows, cols);

        // Xuất ma trận
        OutputMatrix(matrix, rows, cols);

        // Tìm kiếm phần tử trong ma trận
        Console.Write("Nhap phan tu can tim: ");
        int target = int.Parse(Console.ReadLine() ?? "0");
        bool found = FindElement(matrix, rows, cols, target);
        Console.WriteLine(found ? "Tim thay phan tu" : "Khong tim thay phan tu");

        // Xuất các số nguyên tố trong ma trận
        OutputPrimes(matrix, rows, cols);

        // Tìm dòng có nhiều số nguyên tố nhất
        int rowWithMostPrimes = FindRowWithMostPrimes(matrix, rows, cols);
        if (rowWithMostPrimes != -1)
        {
            Console.WriteLine($"Dong co nhieu so nguyen to nhat: {rowWithMostPrimes + 1}");
        }
        else
        {
            Console.WriteLine("Khong co so nguyen to nao trong ma tran");
        }
    }
}
