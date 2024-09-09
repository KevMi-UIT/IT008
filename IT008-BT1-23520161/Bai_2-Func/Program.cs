static void Input(out int[] Arr)
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

static void Print(in int[] Arr)
{
    Console.WriteLine("Gia tri trong mang: ");
    foreach (int x in Arr)
        Console.Write($"{x} ");
    Console.WriteLine();
}

static int SumEven(in int[] Arr)
{
    int sum = 0;
    foreach (int x in Arr)
        if (x % 2 == 0)
            sum += x;
    return sum;
}

static int FindMax(in int[] Arr)
{
    return Arr.Max();
}

static void Sort(ref int[] Arr)
{
    Array.Sort(Arr);
}

int[] Arr = [];
Input(out Arr);
Print(Arr);
Console.WriteLine($"Tong cac so chan trong mang: {SumEven(Arr)}");
Console.WriteLine($"Gia tri lon nhat trong mang: {FindMax(Arr)}");
Console.WriteLine("Mang sau khi sap xep: ");
Sort(ref Arr);
Print(Arr);
