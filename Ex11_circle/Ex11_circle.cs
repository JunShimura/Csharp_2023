namespace Ex11_circle
{
    internal class Ex11_circle
    {
        static void Main(string[] args)
        {
            const uint MAX_VALUE = 40;
            const float EDGE_WIDTH =1.0f;
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

            uint centerX= width/2-2;
            uint centerY= height/2;
            for (var j = 0; j < height; j++)
            {
                //1行分の処理
                var s = string.Empty;
                for (var i = 0; i < width; i++)
                {
                    var d= Math.Sqrt(Math.Pow(centerX-i, 2) + Math.Pow(centerY-j, 2));
                    if (d < centerX/*+EDGE_WIDTH && d> centerX - EDGE_WIDTH*/ )
                    {
                        if ((i + j) % 2 == 0) //チェックか
                        {
                            s += "□";
                        }
                        else
                        {
                            s += "■";
                        }
                        
                    }
                    else
                    {
                        s += "  ";
                    }
                }
                Console.WriteLine(s);
            }


        }
    }
}