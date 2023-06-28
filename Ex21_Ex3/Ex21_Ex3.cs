namespace Ex21_Ex3;
using InputUtility;
public class Ex21_Ex3
{

    static void Main(string[] args)
    {
        Console.WriteLine(
            Praise(
                InputValue.InputString("名前："),
                InputValue.InputInt("ほめ指数", 1, 6)
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
}