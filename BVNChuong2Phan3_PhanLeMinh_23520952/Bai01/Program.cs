// 138

namespace Bai01;

public class Test
{
    static void Main(string[] args)
    {
        Test t = new Test();
        t.TestFunc();
    }
    public double DoDivide(double a, double b)
    {
        if (b == 0)
            throw new System.DivideByZeroException();
        if (a == 0)
            throw new System.ArithmeticException();
        return a / b;
    }


    public void TestFunc()
    {
        try
        {
            double a = 5;
            double b = 0;
            Console.WriteLine("{0} / {1} = {2}", a, b,
            DoDivide(a, b));
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException caught!");
        }
        catch (System.ArithmeticException)
        {
            Console.WriteLine("ArithmeticException caught!");
        }
        catch
        {
            Console.WriteLine("Unknown exception caught");
        }
    }
}

