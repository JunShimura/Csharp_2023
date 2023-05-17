namespace Ex09
{
    internal class Ex09
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            var com = rand.Next(0, 3);  // 最小値以上、最大値未満の数がランダムで得られる
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=ぐう、1=ちょき、2=ぱあ)");
            int player;
            if (!int.TryParse(Console.ReadLine(), out player))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            Console.WriteLine($"私は{com}、あなたは{player}");
            //ここで勝ち負けの判定を行いメッセージを出力
            if (com == player)
            {
                Console.WriteLine("あいこです");
            }
            else if (player == 0 && com == 1 || player == 1 && com == 2 || player == 2 && com == 0)
            {
                Console.WriteLine("あなたの勝ち！");
            }
            else
            {
                Console.WriteLine("あなたの負け");
            }
        }
    }
}