namespace If_sample;
internal class If_sample
{
    static void Main(string[] args)
    {
        Console.Write("体重を入力してください:");
        var weight = double.Parse(Console.ReadLine());
        if (weight >= 30 && weight < 80)
        {
            Console.WriteLine("ちょうどいいじゃあないですか！");
        }
        if (weight < 30 || weight >= 80)
        {
            Console.WriteLine("ちょうどよくないですねえ！");
        }

        if (weight < 30.0)
        {
            Console.WriteLine("ガリガリ");
        }
        else if (weight < 80.0)
        {
            Console.WriteLine("ちょうどいい");
        }
        else if (weight < 120)
        {
            Console.WriteLine("デブかも");
        }
        else
        {
            Console.WriteLine("おすもうさん");
        }
        /*        switch (weight)
                {
                    case < 30.0:
                        Console.WriteLine($"ガリガリ\n{30 - weight}kg足りません");
                        break;
                    case < 80.0:
                        Console.WriteLine("ちょうどいい");
                        break;
                    case < 120:
                        Console.WriteLine($"デブかも\n{weight - 80}kg減らしましょう");
                        break;
                    default:
                        Console.WriteLine("おすもうさん\n危険です");
                        break;
                }*/

    }
}
