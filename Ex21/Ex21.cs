namespace Ex21
{
    class Ex21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前：");
            string s1 = Console.ReadLine();
            int no;
            while (true)
            {
                Console.WriteLine("ほめ指数を1～5で入力：");
                if (int.TryParse(Console.ReadLine(), out no))
                {
                    if (no >= 1 && no <= 5)
                    {
                        break;
                    }

                }
                Console.WriteLine("入力エラー");
            }

            Console.WriteLine(Praise(s1, no));
        }
        static string Praise(string s, int praiseIndex)
        {
            //ここに処理を追加
            string answer = string.Empty;
            string[] message = { "かっこいい", "ゲームがうまい", "つよい", "もうどうにかして", "つきあってください" };
            for (var i = 1; (i <= praiseIndex) && praiseIndex <= message.Length; i++)
            {
                answer += $"{s}さん{message[i - 1]}!\n";
            }
            return answer;
        }

    }
}
