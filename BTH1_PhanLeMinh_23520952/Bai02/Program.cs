namespace Bai02;

public class Program
{
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

    public static void Main()
    {
        Console.WriteLine("Nhap vao n: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Loi input!");
            return;
        }

        int res = 0;
        for (int i = 1; i <= n; ++i)
        {
            if (CheckPrime(i))
            {
                Console.WriteLine(i);
                res += i;
            }
        }

        Console.WriteLine($"Tong so nguyen to < {n}: {res}");
    }
}
