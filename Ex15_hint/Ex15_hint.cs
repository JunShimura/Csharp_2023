namespace Ex15_hint
{
    internal class Ex15_hint
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
            string answer=string.Empty;
            if (inputNumber < 20)
            {
                answer = words0to19[inputNumber];
            }
            else
            {   //20以上90未満
                //int ten = inputNumber / 10; //10の位
                //int one = inputNumber % 10; //１の位
                                            //ここで変換する
            }
            Console.WriteLine(answer);

        }
    }
}