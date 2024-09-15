// fraction overloading


namespace Bai07;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Mau so phai khac 0.");
        }
        this._numerator = numerator;
        this._denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNumerator = a._numerator * b._denominator + b._numerator * a._denominator;
        int newDenomitor = a._denominator * b._denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int newNumerator = a._numerator * b._numerator;
        int newDenomitor = a._denominator * b._denominator;
        return new Fraction(newNumerator, newDenomitor);
    }
    public static Fraction operator -(Fraction a)
    {
        return new Fraction(-a._numerator, a._denominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return a + (-b);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b._numerator == 0)
        {
            throw new ArgumentException("Mau so phai khac 0.");
        }
        int newNumerator = a._numerator * b._denominator;
        int newDenomitor = b._numerator * a._denominator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public Fraction Add(Fraction b)
    {
        int newNumerator = this._numerator * b._denominator + b._numerator * this._denominator;
        int newDenomitor = this._denominator * b._denominator;
        return new Fraction(newNumerator, newDenomitor);

    }
    public Fraction Sub(Fraction b)
    {
        int newNumerator = this._numerator * b._denominator - b._numerator * this._denominator;
        int newDenomitor = this._denominator * b._denominator;
        return new Fraction(newNumerator, newDenomitor);
    }
    public Fraction Multiply(Fraction b)
    {
        int newNumerator = this._numerator * b._numerator;
        int newDenomitor = this._denominator * b._denominator;
        return new Fraction(newNumerator, newDenomitor);
    }
    public Fraction Divide(Fraction b)
    {
        int newNumerator = this._numerator * b._denominator;
        int newDenomitor = this._denominator * b._numerator;
        return new Fraction(newNumerator, newDenomitor);
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        return a._numerator * b._denominator == b._numerator * a._denominator;
    }
    public bool EqualFraction(Fraction b)
    {
        return this._numerator * b._denominator == b._numerator * this._denominator;
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }

    public bool NotEqualFraction(Fraction b)
    {
        return this._numerator * b._denominator != b._numerator * this._denominator;
    }

    public static bool operator >(Fraction a, Fraction b)
    {
        return a._numerator * b._denominator > b._numerator * a._denominator;
    }
    public bool GreaterThan(Fraction b)
    {
        return this._numerator * b._denominator > b._numerator * this._denominator;
    }

    public static bool operator <(Fraction a, Fraction b)
    {
        return a._numerator * b._denominator < b._numerator * a._denominator;
    }

    public bool LessThan(Fraction b)
    {
        return this._numerator * b._denominator < b._numerator * this._denominator;
    }

    public static bool operator >=(Fraction a, Fraction b)
    {
        return !(a < b);
    }

    public bool GreaterThanEqual(Fraction b)
    {
        return this._numerator * b._denominator >= b._numerator * this._denominator;
    }
    public static bool operator <=(Fraction a, Fraction b)
    {
        return !(a > b);
    }

    public bool LessThanEqual(Fraction b)
    {
        return this._numerator * b._denominator <= b._numerator * this._denominator;
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
        return _numerator.GetHashCode() ^ _denominator.GetHashCode();

    }
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}

class Program
{
    static void Main()
    {
        Fraction A = new Fraction(3, 4);
        Fraction B = new Fraction(2, 5);

        Fraction sum = A + B;
        Console.WriteLine($"{A} + {B} = {sum}");

        Fraction diff = A - B;
        Console.WriteLine($"{A} - {B} = {diff}");

        Fraction product = A * B;
        Console.WriteLine($"{A} * {B} = {product}");

        Fraction quotient = A / B;
        Console.WriteLine($"{A} / {B} = {quotient}");

        Console.WriteLine($"{A} == {B}: {A == B}");
        Console.WriteLine($"{A} != {B}: {A != B}");
        Console.WriteLine($"{A} > {B}: {A > B}");
        Console.WriteLine($"{A} < {B}: {A < B}");
        Console.WriteLine($"{A} >= {B}: {A >= B}");
        Console.WriteLine($"{A} <= {B}: {A <= B}");

        // Thực hiện các phương thức Add, Sub, Multiply, Divide tương tự như đã nạp chồng 
        Fraction addResult = A.Add(B);
        Console.WriteLine($"{A} Add {B} = {addResult}");

        Fraction subResult = A.Sub(B);
        Console.WriteLine($"{A} Sub {B} = {subResult}");

        Fraction multiplyResult = A.Multiply(B);
        Console.WriteLine($"{A} Multiply {B} = {multiplyResult}");

        Fraction divideResult = A.Divide(B);
        Console.WriteLine($"{A} Divide {B} = {divideResult}");

        //throw exception với mẫu số = 0
        Fraction C = new Fraction(3, 0);
    }
}
