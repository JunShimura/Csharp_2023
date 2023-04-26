namespace Ex03
{
    internal class Ex03
    {
        class Ex03
        {
            static void Main(string[] args)
            {
                Console.WriteLine("頭の数を入力してください"); // 文字列を出す
                var heads = int.Parse(Console.ReadLine());   // 文字列を入力しheadsに変換し代入
                Console.WriteLine("脚の数を入力してください"); // 文字列を出す
                var legs = int.Parse(Console.ReadLine());   // 文字列を入力しlegsに変換し代入
                var turtle = legs / 2 - heads;
                var crane = heads - turtle;
                //var crane = heads * 2 - legs / 2;
                //var turtle = heads - crane;
                Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
                //Console.WriteLine($"鶴の数{heads * 2 - legs / 2}.亀の数{legs / 2 - heads}");
            }
        }

    }
}