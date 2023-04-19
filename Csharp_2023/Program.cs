using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your height in cm: ");
        var height = double.Parse(Console.ReadLine());
        Console.Write("Enter your weight in kg: ");
        var weight = double.Parse(Console.ReadLine());

        var bmi = weight / ((height / 100) * (height / 100));
        Console.WriteLine($"Your BMI is {bmi:F2}");
    }
}