using System;

namespace PolynomialLibrary
{
    public class Polynomial
{
    private int _a;
    private int _b;
    private int _c;

    // Конструкторы
    public Polynomial(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public Polynomial() : this(0, 0, 0) { }

    // Свойства
    public int A { get => _a; set => _a = value; }
    public int B { get => _b; set => _b = value; }
    public int C { get => _c; set => _c = value; }

    // Индексатор
    public int this[int index]
    {
        get => index switch
        {
            0 => _a,
            1 => _b,
            2 => _c,
            _ => throw new IndexOutOfRangeException("Invalid index")
        };
        set
        {
            switch (index)
            {
                case 0: _a = value; break;
                case 1: _b = value; break;
                case 2: _c = value; break;
                default: throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }

    // Перегрузка ToString
    public override string ToString()
    {
        return $"{_a}x + {_b}y + {_c}z";
    }

    // Перегрузка операторов
    public static Polynomial operator +(Polynomial p1, Polynomial p2)
    {
        return new Polynomial(p1.A + p2.A, p1.B + p2.B, p1.C + p2.C);
    }

    public static Polynomial operator -(Polynomial p1, Polynomial p2)
    {
        return new Polynomial(p1.A - p2.A, p1.B - p2.B, p1.C - p2.C);
    }

    public static Polynomial operator *(Polynomial p, int scalar)
    {
        return new Polynomial(p.A * scalar, p.B * scalar, p.C * scalar);
    }

    public static Polynomial operator /(Polynomial p, int scalar)
    {
        if (scalar == 0)
            throw new DivideByZeroException("Cannot divide by zero");
        return new Polynomial(p.A / scalar, p.B / scalar, p.C / scalar);
    }

    public static Polynomial operator ++(Polynomial p)
    {
        return new Polynomial(p.A + 1, p.B + 1, p.C + 1);
    }

    public static Polynomial operator --(Polynomial p)
    {
        return new Polynomial(p.A - 1, p.B - 1, p.C - 1);
    }

    // Сравнение
    public static bool operator ==(Polynomial p1, Polynomial p2)
    {
        return p1.A == p2.A && p1.B == p2.B && p1.C == p2.C;
    }

    public static bool operator !=(Polynomial p1, Polynomial p2)
    {
        return !(p1 == p2);
    }

    public static bool operator <(Polynomial p1, Polynomial p2)
    {
        return (p1.A + p1.B + p1.C) < (p2.A + p2.B + p2.C);
    }

    public static bool operator >(Polynomial p1, Polynomial p2)
    {
        return (p1.A + p1.B + p1.C) > (p2.A + p2.B + p2.C);
    }

    // True/False
    public static bool operator true(Polynomial p)
    {
        return !(p.A == 0 && p.B == 0 && p.C == 0);
    }

    public static bool operator false(Polynomial p)
    {
        return p.A == 0 && p.B == 0 && p.C == 0;
    }

    // Перегрузка оператора '!'
    public static bool operator !(Polynomial p)
    {
        return !(p ? true : false);
    }

    // Преобразование типа
    public static explicit operator int(Polynomial p)
    {
        return p.A;
    }

    public static explicit operator Polynomial(int a)
    {
        return new Polynomial(a, 0, 0);
    }

    // Переопределение методов для сравнения
    public override bool Equals(object obj)
    {
        if (obj is Polynomial p)
            return this == p;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_a, _b, _c);
    }
}
}
