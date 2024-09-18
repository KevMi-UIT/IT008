using System;

namespace Bai01
{
    public class NumArray
    {
        public NumArray() { }
        public int Nums { get; set; }
        public List<int> NumArr { get; set; }

        public NumArray(int _nums, List<int> _numArr)
        {
            Nums = _nums;
            NumArr = _numArr;
        }

        public void CreateArray()
        {
            Console.Write("Nhap kich thuoc mang: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                Nums = result;
            }
            else
            {
                throw new ArgumentException("Invalid input for number of integers.");
            }
            NumArr = new List<int>(Nums);
            var rand = new Random();
            for (int i = 0; i < Nums; i++)
            {
                NumArr.Add(rand.Next(0, 100));
            }
            foreach (int num in NumArr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        public void PrintOddSum()
        {
            int OddSum = 0;
            foreach (int num in NumArr)
            {
                if (num % 2 != 0)
                    OddSum += num;
            }
            Console.WriteLine($"Tong so le trong mang: {OddSum}");
        }
        private static bool IsPrime(int _num)
        {
            if (_num < 2) return false;
            for (int i = 2; i * i <= _num; i++)
                if (_num % i == 0) return false;
            return true;
        }
        public int PrimeCounter()
        {
            int count = 0;
            foreach (int num in NumArr)
            {
                if (IsPrime(num)) count++;
            }
            return count;
        }
        private static bool IsSquare(int num)
        {
            for (int i = 1; i * i < num; i++)
            {
                if (i * i == num) return true;
            }
            return false;
        }
        public int FindMinimumSquare()
        {
            if (NumArr.Count == 0)
            {
                return -1; // Return -1 if the list is empty
            }

            int temp = NumArr[NumArr.Count - 1];
            bool foundSquare = false;

            foreach (int num in NumArr)
            {
                if (IsSquare(num) && (!foundSquare || num < temp))
                {
                    temp = num;
                    foundSquare = true;
                }
            }
            return foundSquare ? temp : -1;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            NumArray IntergerArray = new NumArray();
            IntergerArray.CreateArray();
            IntergerArray.PrintOddSum();
            Console.WriteLine($"So luong so nguyen to: {IntergerArray.PrimeCounter()}");
            Console.WriteLine($"So nguyen to nho nhat: {IntergerArray.FindMinimumSquare()}");
        }
    }
}
