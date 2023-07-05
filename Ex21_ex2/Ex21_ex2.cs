namespace Ex21_ex2;
internal class Ex21_ex2
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            Praise(
                InputString("名前："),
                InputInt("ほめ指数", 1, 6)
                )
            );
    }
    static string Praise(string s, int praiseIndex)
    {
        //ここに処理を追加
        string answer = string.Empty;
        string[] message = { "かっこいい", "ゲームがうまい", "つよい", "もうどうにかして", "つきあってください" };
        for (var i = 1; i <= praiseIndex && praiseIndex <= message.Length; i++)
        {
            answer += $"{s}さん{message[i - 1]}!\n";
        }
        return answer;
    }

    // MethodSampleから移植 https://github.com/JunShimura/Csharp_2023/blob/master/MethodSample/MethodSample.cs
    private static string InputString(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
    private static int InputInt(string message)
    {
        int i;
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out i))
            {
                break;
            }
            Console.WriteLine("入力エラー");
        }
        return i;
    }
    private static int InputInt(string message, int min, int max)
    {
        int i;
        while (true)
        {
            i = InputInt($"{message} 値の範囲は{min}以上・{max}未満");
            if (i >= min && i < max)
            {
                break;
            }
            Console.WriteLine("入力範囲エラー");
        }
        return i;
    }
}