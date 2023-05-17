namespace Ex10
{
    internal class Ex10
    {
        static void Main(string[] args)
        {
            uint n;
            while (true)
            {
                Console.Write("1～9の整数を入力して下さい：");
                if (uint.TryParse(Console.ReadLine(), out n))
                {
                    if (n >= 1 && n <= 9)
                    {
                        break;
                    }
                }
                Console.WriteLine("入力エラーです");
            }
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{n}*{i}={n * i}");
            }
        }
    }
}