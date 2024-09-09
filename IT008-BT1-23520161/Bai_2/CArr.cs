namespace Bai_2
{
    public class CArr
    {
        private int[] Arr = [];

        public void Input()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine()!);
            Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                Arr[i] = int.Parse(Console.ReadLine()!);
            }
        }

        public void Print()
        {
            Console.WriteLine("Gia tri trong mang: ");
            foreach (int x in Arr)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        private int SumEven()
        {
            int sum = 0;
            foreach (int x in Arr)
                if (x % 2 == 0)
                    sum += x;
            return sum;
        }

        public void SumEvenAndPrint()
        {
            Console.WriteLine($"Tong cac so chan trong mang: {SumEven()}");
        }

        private int FindMax()
        {
            return Arr.Max();
        }

        public void FindMaxAndPrint()
        {
            Console.WriteLine($"Gia tri lon nhat trong mang: {FindMax()}");
        }

        private void Sort()
        {
            Array.Sort(Arr);
        }

        public void SortAndPrint()
        {
            Sort();
            Console.WriteLine("Mang sau khi sap xep: ");
            Print();
        }
    }
}
