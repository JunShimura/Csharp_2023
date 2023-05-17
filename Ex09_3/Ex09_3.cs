using System.Diagnostics;

namespace Ex09_3
{
    internal class Ex09_3
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
            switch (player)
            {
                case 0:
                    switch (com)
                    {
                        case 0:
                            Console.WriteLine("あいこです");
                            break;
                        case 1:
                            Console.WriteLine("あなたの勝ち");
                            break;
                        case 2:
                            Console.WriteLine("あなたの負け");
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (com)
                    {
                        case 0:
                            Console.WriteLine("あなたの負け");
                            break;
                        case 1:
                            Console.WriteLine("あいこです");
                            break;
                        case 2:
                            Console.WriteLine("あなたの勝ち");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (com)
                    {
                        case 0:
                            Console.WriteLine("あなたの勝ち");
                            break;
                        case 1:
                            Console.WriteLine("あなたの負け");
                            break;
                        case 2:
                            Console.WriteLine("あいこです");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}