// 153

namespace Bai03;

public delegate void FunctionToCall(ref int x);
public delegate void MethodDelegateToCall(ref int x);

public class AddValue
{
    public static void Add2(ref int x)
    {
        x += 2;
    }

    public static void Add3(ref int x)
    {
        x += 3;
    }
    public static void Result(ref int x)
    {
        Console.WriteLine("Hello Delegate");
        Console.WriteLine($"Gia tri cua x thay doi boi delegate: {x}");
    }
}

public class Program
{

    static void Main()
    {
        {
            Console.Write("Nhap gia tri cua x: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int x))
            {
                // Khai báo đồng thời gán delegate bằng Add2 từ lớp AddValue
                FunctionToCall functionDelegate = AddValue.Add2;
                functionDelegate += AddValue.Add3;
                functionDelegate += AddValue.Add2;
                functionDelegate += AddValue.Add2;
                functionDelegate(ref x); // Gọi delegate 
                MethodDelegateToCall CallResultByDelegate = (ref int num) => AddValue.Result(ref num);
                CallResultByDelegate(ref x); // Gọi method từ lớp khác thông qua delegate;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

