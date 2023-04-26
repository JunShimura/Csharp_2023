namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("金額を入力：");
            var money = uint.Parse(Console.ReadLine());
            var k10000 = money/ 10000;
            Console.WriteLine($"1万円札:{k10000}枚");
            money -= k10000*10000;
            var k5000 = money / 5000;
            Console.WriteLine($"五千円札:{k5000}枚");

        }
    }
}