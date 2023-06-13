namespace Ex15
{
    internal class Ex15
    {
        static void Main(string[] args)
        {
            uint inputNumber;
            Console.Write("数を入力（0～99）：");
            if (!uint.TryParse(Console.ReadLine(), out inputNumber) || inputNumber > 99)
            {
                Console.WriteLine("入力エラー");
                return;
            }
            string[] words0to19 =
                {
                    "zero", "one",  "two",  "three",    "four", "five", "six",  "seven",    "eight",    "nine",
                    "ten",  "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
                };

            string[] words20to90 =
              { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string answer = string.Empty;
            if (inputNumber < 20)
            {
                answer = words0to19[inputNumber];
            }
            else
            {   //20以上90未満
                uint ten = inputNumber / 10; //10の位
                uint one = inputNumber % 10; //１の位
                //ここで変換する
                answer = words20to90[ten - 2];//10の位
                if (one != 0)
                {   // 1の位の単語をつける
                    answer = answer + "-" + words0to19[one];
                }
            }
            Console.WriteLine(answer);

        }
    }

}