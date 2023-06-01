namespace Ex13
{
    internal class Ex13
    {
        static void Main(string[] args)
        {
            //　難易度の設定
            const int MAX_VALUE = 10;   //乱数の最大値
            const int MAX_TIME = 3; //解答できる回数

            //  乱数で正解を設定
            Random rand = new Random();    // 乱数生成オブジェクトを生成
            var answer = rand.Next(1, MAX_VALUE + 1); //　乱数が入る
            //回答を入力
            int i;
            var lastDiff = 0; //前回の差

            for (i = 0; i < MAX_TIME; i++)
            {
                int inputNumber;
                while (true)
                {
                    Console.Write($"あと{(MAX_TIME - i)}回答えられます、数字を1～{MAX_VALUE}の整数を入力して下さい：");
                    if (int.TryParse(Console.ReadLine(), out inputNumber))
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
                else
                {   // はずれ
                    Console.WriteLine($"はずれです。");
                    /*
                     var diff = inputNumber - answer;
                     if (diff < 0)
                     { //負数なのでー1をかけて絶対値にする
                        diff *= (-1);
                     }
                    */
                    var diff = Math.Abs(inputNumber - answer);
                    if (i > 0)
                    {   // ２回目以降
                        if (lastDiff > diff)
                        {
                            Console.WriteLine("近づきました");
                        }
                        else if (lastDiff < diff)
                        {
                            Console.WriteLine("遠ざかりました");
                        }
                        else
                        {
                            Console.WriteLine("変わりません");
                        }
                    }
                    lastDiff = diff;    // 差を次回のために保存する
                }

            }
            Console.WriteLine($"答えは{answer}でした\n得点は{(int)Math.Pow(100, (MAX_TIME - i))}点です");
        }
    }
}