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

            const char char1 = '■';
            const char char2 = '□';

            // 長方形
            Console.WriteLine("長方形");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                var s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    s += char1;
                }
                Console.WriteLine(s);
            }
            // 横縞
            Console.WriteLine("横縞");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                var s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    if (j % 2 == 0) //描く行は偶数番目か
                    {
                        s += char1;
                    }
                    else
                    {
                        s += char2;
                    }
                }
                Console.WriteLine(s);
            }
            // 縦縞
            Console.WriteLine("縦縞");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                var s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    if (i % 2 == 0) //描く列は偶数番目か
                    {
                        s += char1;
                    }
                    else
                    {
                        s += char2;
                    }
                }
                Console.WriteLine(s);
            }
            // チェック
            Console.WriteLine("チェック柄");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                var s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    if ((i + j) % 2 == 0) //チェックか
                    {
                        s += char1;
                    }
                    else
                    {
                        s += char2;
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}