namespace Ex04_4
{
    internal class Ex04_4
    {
        static void Main(string[] args)
        {
            var s = string.Empty;
            Console.WriteLine("金額を入力：");
            var money = uint.Parse(Console.ReadLine());
            s += $"1万円札:{money / 10000}枚\n";
            s += $"五千円札:{money % 10000 / 5000}枚\n";
            s += $"千円札:{money % 5000 / 1000}枚\n";
            s += $"五百円玉:{money % 1000 / 500}枚\n";
            s += $"百円玉:{money % 500 / 100}枚\n";
            s += $"五十円玉:{money % 100 / 50}枚\n";
            s += $"十円玉:{money % 50 / 10}枚\n";
            s += $"五円玉:{money % 10 / 5}枚\n";
            s += $"一円玉:{money % 5}枚\n";
            Console.WriteLine(s);
        }
    }
}