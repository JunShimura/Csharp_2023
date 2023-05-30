using static System.Formats.Asn1.AsnWriter;

namespace Ex12
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            //　難易度の設定
            const int MAX_VALUE = 10;   //乱数の最大値
            const int MAX_TIME = 3; //解答できる回数

            //  乱数で正解を設定
            Random rand = new Random();    // 乱数生成オブジェクトを生成
            int answer = rand.Next(1, MAX_VALUE+1); //　乱数が入る
            //回答を入力
            int i;
            for (i = 0; i < MAX_TIME; i++)
            {
                uint inputNumber;
                while (true)
                {
                    Console.Write($"\"あと{(MAX_TIME - i)}回答えられます、数字を1～{MAX_VALUE}の整数を入力して下さい：");
                    if (uint.TryParse(Console.ReadLine(), out inputNumber))
                    {
                        if (inputNumber >= 1 && inputNumber <= MAX_VALUE)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("入力エラーです");
                }
                if (inputNumber == answer)
                {
                    Console.WriteLine($"当たり！");
                    break;
                }
                else if (inputNumber > answer)
                {
                    Console.WriteLine("はずれ,もっと小さい");
                }
                else
                {
                    Console.WriteLine("はずれ,もっと大きい");
                }
            }
            Console.WriteLine($"答えは{answer}でした\n得点は{(int)Math.Pow(100, (MAX_TIME - i))}点です");
        }
    }
}