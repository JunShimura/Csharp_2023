namespace Ex13_Katsumata
{
    public class Test
    {
        static void Main()
        {
            Random rand = new Random();
            int number = rand.Next(1, 10);
            int currentNumber = 0;
            int oldNumber = 0;


            for (int i = 1; i < 4; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int playerNumber))
                {
                    Console.WriteLine("入力エラー");
                    return;
                }
                else if (playerNumber != number)
                {
                    if (playerNumber < 1 || playerNumber > 9) return;
                    Console.WriteLine($"はずれ！ あと{4 - i}回まで入力可能");
                    currentNumber += Math.Abs(number - playerNumber);
                }
                else
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"\n答えは{number}でした！\n得点 : 一発正解！");
                    }
                    Console.WriteLine($"あたり！\n答えは{number}でした！");

                    float score = 0;
                    if (number > 4)
                    {
                        score = (float)number - 1 * 2 / currentNumber;
                    }
                    else
                    {
                        score = ((float)9 - number) * 2 / currentNumber;
                    }


                    Console.WriteLine($"得点 : {(100 - 1 / score * 100).ToString("F2")}点");
                    return;
                }

                if (i != 1)
                {
                    int abs = Math.Abs(number - playerNumber);

                    if (abs > oldNumber)
                    {
                        Console.WriteLine("遠のいた\n");
                    }
                    else if (abs < oldNumber)
                    {
                        Console.WriteLine("近付いた\n");
                    }
                    else
                    {
                        Console.WriteLine("変わらない\n");
                    }
                }
                else
                {
                    if (playerNumber < number)
                    {
                        Console.WriteLine("もっと大きい\n");
                    }
                    else
                    {
                        Console.WriteLine("もっと小さい\n");
                    }
                }

                oldNumber = currentNumber;
            }
            Console.WriteLine($"回数制限 : 答えは{number}でした。\n得点 : 不正解");
        }
    }
}