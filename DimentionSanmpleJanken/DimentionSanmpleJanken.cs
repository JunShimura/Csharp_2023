using System.Numerics;

namespace DimentionSanmpleJanken
{
    internal class DimentionSanmpleJanken
    {
        static void Main(string[] args)
        {
            string[] message = { "あいこ", "あなたの負け", "あなたの勝ち" };
            int[,] judge =
                {
                    {0,1,2 },  //コンピュータがぐう
                    {2,0,1 },  //コンピュータがちょき
                    {1,2,0 },  //コンピュータがぱあ
                };
            Random rand = new Random();
            var com = rand.Next(0, 3);  // 最小値以上、最大値未満の数がランダムで得られる
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=ぐう、1=ちょき、2=ぱあ)");
            int player;
            if (!int.TryParse(Console.ReadLine(), out player))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            Console.WriteLine($"{message[judge[com, player]]}");
        }
    }
}