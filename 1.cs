using System;

public class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Sum(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int sum1 = calculator.Sum(1, 2);
        Console.WriteLine("Сумма двух чисел = " + sum1);

        int sum2 = calculator.Sum(1, 2, 3);
        Console.WriteLine("Сумма трех чисел = " + sum2);

        int sum3 = calculator.Sum(1, 2, 3, 4);
        Console.WriteLine("Сумма четырех чисел = " + sum3);
    }
}
