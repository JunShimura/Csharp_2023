namespace Ex04_2
{
    internal class Ex04_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("金額を入力：");
            var money = uint.Parse(Console.ReadLine());
            Console.WriteLine($"1万円札:{money / 10000}枚");
            money %= 10000;
            Console.WriteLine($"五千円札:{money / 5000}枚");
            money %= 5000;
            Console.WriteLine($"千円札:{money / 1000}枚");
            money %= 1000;
            Console.WriteLine($"五百円玉:{money / 500}枚");
            money %= 500;
            Console.WriteLine($"百円玉:{money / 100}枚");
            money %= 100;
            Console.WriteLine($"五十円玉:{money / 50}枚");
            money %= 50;
            Console.WriteLine($"十円玉:{money / 10}枚");
            money %= 10;
            Console.WriteLine($"五円玉:{money / 5}枚");
            money %= 5;
            Console.WriteLine($"一円玉:{money / 1}枚");

        }
    }
}