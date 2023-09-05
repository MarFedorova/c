using System;

public class Plant
{
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Width { get; set; }

    public Plant(double height, double weight)
    {
        Height = height;
        Weight = weight;
    }

    public Plant(double height, double weight, double width)
    {
        Height = height;
        Weight = weight;
        Width = width;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Plant plant1 = new Plant(10.8, 3.0);
        Console.WriteLine($"Рост: {plant1.Height}, Вес: {plant1.Weight}");

        Plant plant2 = new Plant(20.0, 6.0, 1.5);
        Console.WriteLine($"Рост: {plant2.Height}, Вес: {plant2.Weight}, Ширина: {plant2.Width}");
    }
}
