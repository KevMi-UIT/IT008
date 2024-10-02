// Fraction Overloading

using System.Runtime.CompilerServices;

namespace Bai07;

public class Fraction(int _numerator = 0, int _denominator = 0)
{
    private int Numerator { get; set; } = _numerator;
    private int Denominator
    {
        get => _denominator;
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Mau so phai khac 0.");
            }
            _denominator = value;
        }
    }

    public void Input()
    {
        Console.Write("Nhap tu so: ");
        Numerator = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Nhap mau so: ");
        Denominator = int.Parse(Console.ReadLine() ?? "");
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int newDenomitor = a.Denominator * b.Denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Numerator;
        int newDenomitor = a.Denominator * b.Denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public static Fraction operator -(Fraction a)
    {
        return new Fraction(-a.Numerator, a.Denominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return a + (-b);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.Numerator == 0)
        {
            throw new ArgumentException("Mau so phai khac 0.");
        }
        int newNumerator = a.Numerator * b.Denominator;
        int newDenomitor = b.Numerator * a.Denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public Fraction Add(Fraction b)
    {
        int newNumerator = Numerator * b.Denominator + b.Numerator * Denominator;
        int newDenomitor = Denominator * b.Denominator;
        return new Fraction(newNumerator, newDenomitor);

    }

    public Fraction Sub(Fraction b)
    {
        int newNumerator = Numerator * b.Denominator - b.Numerator * Denominator;
        int newDenomitor = Denominator * b.Denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public Fraction Multiply(Fraction b)
    {
        int newNumerator = Numerator * b.Numerator;
        int newDenomitor = Denominator * b.Denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public Fraction Divide(Fraction b)
    {
        int newNumerator = Numerator * b.Denominator;
        int newDenomitor = Denominator * b.Numerator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        return a.Numerator * b.Denominator == b.Numerator * a.Denominator;
    }
    public bool EqualFraction(Fraction b)
    {
        return Numerator * b.Denominator == b.Numerator * Denominator;
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }

    public bool NotEqualFraction(Fraction b)
    {
        return Numerator * b.Denominator != b.Numerator * Denominator;
    }

    public static bool operator >(Fraction a, Fraction b)
    {
        return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
    }
    public bool GreaterThan(Fraction b)
    {
        return Numerator * b.Denominator > b.Numerator * Denominator;
    }

    public static bool operator <(Fraction a, Fraction b)
    {
        return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
    }

    public bool LessThan(Fraction b)
    {
        return Numerator * b.Denominator < b.Numerator * Denominator;
    }

    public static bool operator >=(Fraction a, Fraction b)
    {
        return !(a < b);
    }

    public bool GreaterThanEqual(Fraction b)
    {
        return Numerator * b.Denominator >= b.Numerator * Denominator;
    }

    public static bool operator <=(Fraction a, Fraction b)
    {
        return !(a > b);
    }

    public bool LessThanEqual(Fraction b)
    {
        return Numerator * b.Denominator <= b.Numerator * Denominator;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Fraction f)
        {
            return this == f;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Numerator.GetHashCode() ^ Denominator.GetHashCode();

    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

public class FractionArr
{
    int size = int.Parse(Console.ReadLine() ?? "");
    List<Fraction> FracArr = new List<Fraction>();
    public void Input()
    {
        for (int i = 0; i < size; i++)
        {
            FracArr.Add(new Fraction());
            FracArr[i].Input();
        }
    }
    public void Print()
    {
        Console.WriteLine("Day phan so da nhap: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{FracArr[i]}    ");
        }
        Console.WriteLine();
    }
    public static int CompareTo(Fraction A, Fraction B)
    {
        if (A > B) return 1;
        if (A < B) return -1;
        return 0;
    }
    public void Sort()
    {
        FracArr.Sort(CompareTo);
    }

    public Fraction FindMaxFraction()
    {
        FracArr.Sort(CompareTo);
        return FracArr[FracArr.Count - 1];
    }
}

class Program
{
    static void Main()
    {
        Fraction A = new Fraction();
        A.Input();
        Fraction B = new Fraction();
        B.Input();

        Console.WriteLine($"{A} + {B} = {A + B}");
        Console.WriteLine($"{A} - {B} = {A - B}");
        Console.WriteLine($"{A} * {B} = {A * B}");
        Console.WriteLine($"{A} / {B} = {A / B}");

        Console.WriteLine("Nhap day so phan so: ");
        Console.WriteLine("Nhap kich thuoc: ");
        FractionArr Array = new FractionArr();
        Array.Input();
        Array.Print();

        Console.WriteLine("Phan so lon nhat la: ");
        Console.WriteLine(Array.FindMaxFraction());

        Console.WriteLine("Sap xep day phan so tang dan: ");
        Array.Sort();
        Array.Print();
    }
}

