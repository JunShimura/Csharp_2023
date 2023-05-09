namespace Ex04_3
{
    internal class Ex04_3
    {
        static void Main(string[] args)
        {
            var s = string.Empty;
            Console.WriteLine("金額を入力：");
            var money = uint.Parse(Console.ReadLine());
            s += $"1万円札:{money / 10000}枚\n";
            money %= 10000;
            s += $"五千円札:{money / 5000}枚\n";
            money %= 5000;
            s += $"千円札:{money / 1000}枚\n";
            money %= 1000;
            s += $"五百円玉:{money / 500}枚\n";
            money %= 500;
            s += $"百円玉:{money / 100}枚\n";
            money %= 100;
            s += $"五十円玉:{money / 50}枚\n";
            money %= 50;
            s += $"十円玉:{money / 10}枚\n";
            money %= 10;
            s += $"五円玉:{money / 5}枚\n";
            money %= 5;
            s += $"一円玉:{money / 1}枚\n";
            Console.WriteLine(s);

        }
    }
}