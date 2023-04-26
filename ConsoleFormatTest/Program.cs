namespace ConsoleFormatTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = 123.54;
            int i1 = (int)(d * 100) % 10;
            int i2 = i1 / 5;
            d = d - (double)i1 / 100 + (double)i2 * 0.1;
            Console.WriteLine($"{d}");
        }
    }
}