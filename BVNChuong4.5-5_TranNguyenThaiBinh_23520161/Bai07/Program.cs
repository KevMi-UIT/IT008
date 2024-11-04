// 162
namespace Bai07;
using System;
using System.Linq.Expressions;

public delegate int MyDelegate(int n);
class LambdaExpresion
{
    static void Main()
    {
        // Anonymous method that returns the argument multiplied by 10:
        MyDelegate Obj1 = new MyDelegate(delegate (int n)
        { return n * 10; });
        // Display the result:
        Console.WriteLine($"The value using ananonymous method is: {Obj1(5)}");
        // Using lambda expression to do the same job:
        MyDelegate Obj2 = (int n) => n * 10;
        // Display the result:
        Console.WriteLine($"The value using a lambda expression is: {Obj2(5)}");
    }
}