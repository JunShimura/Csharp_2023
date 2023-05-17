namespace Ex11
{
    internal class Ex11
    {
        static void Main(string[] args)
        {
            const uint MAX_VALUE = 20;
            uint width;
            while (true)
            {
                Console.Write($"幅を1～{MAX_VALUE}の整数を入力して下さい：");
                if (uint.TryParse(Console.ReadLine(), out width))
                {
                    if (width >= 1 && width <= MAX_VALUE)
                    {
                        break;
                    }
                }
                Console.WriteLine("入力エラーです");
            }
            uint height;
            while (true)
            {
                Console.Write($"高さを1～{MAX_VALUE}の整数を入力して下さい：");
                if (uint.TryParse(Console.ReadLine(), out height))
                {
                    if (width >= 1 && width <= MAX_VALUE)
                    {
                        break;
                    }
                }
                Console.WriteLine("入力エラーです");
            }

            for (var j=0;j<height;j++ )
            {
                //1行分の処理
                var s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    s+="□";
                }
                Console.WriteLine(s);
            }


        }
    }
}