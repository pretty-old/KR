using System;
using PolynomialLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов
        Polynomial p1 = new Polynomial(1, 2, 3);
        Polynomial p2 = new Polynomial(4, 5, 6);
        Polynomial p3 = new Polynomial();

        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");
        Console.WriteLine($"p3 (default): {p3}");

        // Демонстрация арифметических операций
        Console.WriteLine($"p1 + p2: {p1 + p2}");
        Console.WriteLine($"p1 - p2: {p1 - p2}");
        Console.WriteLine($"p1 * 2: {p1 * 2}");
        Console.WriteLine($"p2 / 2: {p2 / 2}");

        // Инкремент и декремент
        Console.WriteLine($"++p1: {++p1}");
        Console.WriteLine($"--p2: {--p2}");

        // Сравнение
        Console.WriteLine($"p1 == p2: {p1 == p2}");
        Console.WriteLine($"p1 != p3: {p1 != p3}");
        Console.WriteLine($"p1 > p3: {p1 > p3}");
        Console.WriteLine($"p1 < p2: {p1 < p2}");

        // True/False
        Console.WriteLine($"Is p1 true? {(p1 ? "True" : "False")}");
        Console.WriteLine($"Is p3 false? {(!p3 ? "True" : "False")}");


        // Преобразования типа
        int a = (int)p1;
        Polynomial p4 = (Polynomial)a;

        Console.WriteLine($"p1 as int: {a}");
        Console.WriteLine($"int to Polynomial: {p4}");
    }
}