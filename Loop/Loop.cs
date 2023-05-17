namespace Loop
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            uint n;
            while(true)
            {
                Console.Write("正の整数を入力して下さい：");
                if (uint.TryParse(Console.ReadLine(), out n))
                {
                    break;
                }
                Console.WriteLine("入力エラーです");
            }
            var answer = n;
            for (uint i = 2; i < n; i++)
            {
                answer *= i;
            }
/*
            while (n > 1)
            {
                n--;
                answer *= n;
            }
*/
            Console.WriteLine($"答えは{answer}");


            for(var  i = 1; i <= 9; i++)
            {
                var s = string.Empty;
                for(var j = 1; j <= 9; j++)
                {
                    s+=$"{(i*j).ToString("D2")} ";
                }
                Console.WriteLine(s);
            }
        }
    }
}