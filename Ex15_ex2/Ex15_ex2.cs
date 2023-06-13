namespace Ex15_ex2
{
    internal class Ex15_ex2
    {
        static void Main(string[] args)
        {
            string[] words0to19 =
                {
                    "zero", "one",  "two",  "three",    "four", "five", "six",  "seven",    "eight",    "nine",
                    "ten",  "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
                };

            string[] words20to90 =
              { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string answer = string.Empty;
            string[] answers = new string[100];
            for(int i=0; i<answers.Length; i++)
            {
                if (i < 20)
                {
                    answers[i] = words0to19[i];
                }
                else
                {   //20以上90未満
                    int ten = i / 10; //10の位
                    int one = i % 10; //１の位
                    answers[i] = words20to90[ten - 2];//10の位
                    if (one != 0)
                    {   // 1の位の単語をつける
                        answers[i] = answers[i] + "-" + words0to19[one];
                    }
                }
            }

            uint inputNumber;
            Console.Write("数を入力（0～99）：");
            if (!uint.TryParse(Console.ReadLine(), out inputNumber) || inputNumber > 99)
            {
                Console.WriteLine("入力エラー");
                return;
            }
            Console.WriteLine(answers[inputNumber]);

        }
    }
}