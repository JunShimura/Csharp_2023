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
            var s = string.Empty;

            // 長方形
            Console.WriteLine("長方形");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                s = string.Empty;
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
                s = string.Empty;
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
                s = string.Empty;
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
            // 中抜け
            Console.WriteLine("中抜け");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    if (i == 0 || i == width - 1 || j == 0 || j == height - 1) //描く位置が周辺か
                    {
                        s += char1;
                    }
                    else
                    {
                        s += "　";   //スペース
                    }
                }
                Console.WriteLine(s);
            }
            /*            Console.WriteLine("中抜け別解");
                        s = string.Empty;
                        for (var i = 0; i < width; i++) //1行目の処理
                        {
                            s += char1;
                        }
                        s += "\n";

                        if (height > 1)
                        {
                            for (var j = 0; j < height - 2; j++)
                            {
                                s += char1;
                                for (var i = 0; i + 2 < width; i++) //中抜け
                                {
                                    s += "　";
                                }
                                if (width > 1)
                                {
                                    s += char1;
                                }
                                s += "\n";
                            }
                            for (var i = 0; i < width; i++) //最下段の処理
                            {
                                s += char1;
                            }
                        }
                        Console.WriteLine(s);*/

            // 長方形
            Console.WriteLine("直角三角形");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                s = string.Empty;
                var currentWidth = (float)width * (j+1) / height;
                for (var i = 0; i < currentWidth; i++)
                {
                    s += char1;
                }
                Console.WriteLine(s);
            }

            // チェック
            Console.WriteLine("チェック柄");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                s = string.Empty;
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

            // チェック
            Console.WriteLine("チェック柄の直角三角形");
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                s = string.Empty;
                var currentWidth = (float)width * (j + 1) / height;
                for (var i = 0; i < currentWidth; i++)
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