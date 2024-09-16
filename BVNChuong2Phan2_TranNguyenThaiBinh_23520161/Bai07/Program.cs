// Fraction Overloading

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

class Program
{
    static void Main()
    {
        Fraction A = new(4, 3);
        Fraction B = new(5, 9);

        Console.WriteLine($"{A} + {B} = {A + B}");
        Console.WriteLine($"{A} - {B} = {A - B}");
        Console.WriteLine($"{A} * {B} = {A * B}");
        Console.WriteLine($"{A} / {B} = {A / B}");
        Console.WriteLine($"{A} == {B}: {A == B}");
        Console.WriteLine($"{A} != {B}: {A != B}");
        Console.WriteLine($"{A} > {B}: {A > B}");
        Console.WriteLine($"{A} < {B}: {A < B}");
        Console.WriteLine($"{A} >= {B}: {A >= B}");
        Console.WriteLine($"{A} <= {B}: {A <= B}");

        // Thực hiện các phương thức Add, Sub, Multiply, Divide tương tự như đã nạp chồng 
        Console.WriteLine($"{A} Add {B} = {A.Add(B)}");
        Console.WriteLine($"{A} Sub {B} = {A.Sub(B)}");
        Console.WriteLine($"{A} Multiply {B} = {A.Multiply(B)}");
        Console.WriteLine($"{A} Divide {B} = {A.Divide(B)}");

        //throw exception with denominator = 0
        Fraction C = new(3, 0);
    }
}
